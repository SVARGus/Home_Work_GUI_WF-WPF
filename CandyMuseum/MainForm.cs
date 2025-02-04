namespace CandyMuseum
{
    public partial class MainForm : Form
    {
        private List<OrderItem> dailyReceipt = new List<OrderItem>();
        private ToolTip toolTip;
        public MainForm()
        {
            InitializeComponent();
            UpdateProductList();
            toolTip = new ToolTip();
            toolTip.AutoPopDelay = 2000;
            toolTip.InitialDelay = 500;
            toolTip.ReshowDelay = 500;
            toolTip.ShowAlways = true;
            toolTip.SetToolTip(comboBoxProductList, "�������� �����");
            toolTip.SetToolTip(numericUpDownVolumeProducts, "���������� ������");
            toolTip.SetToolTip(buttonEnterReceipt, "����������� � �����������");
            toolTip.SetToolTip(buttonEnterStorage, "���� ������ ��� ������");
            toolTip.SetToolTip(buttonEndShiftCash, "��������� ������� ����?");
        }
        private void UpdateProductList()
        {
            comboBoxProductList.DataSource = null;
            comboBoxProductList.DataSource = Storage.GetListProducts();
            checkedListBoxProductsCash.Items.Clear();
            labelSumCash.Text = "0,00";
            numericUpDownVolumeProducts.Value = numericUpDownVolumeProducts.Minimum;
        }
        private void buttonAddProductCash_Click(object sender, EventArgs e)
        {
            if (comboBoxProductList.SelectedItem is Product selectedProduct)
            {
                int quantity = (int)numericUpDownVolumeProducts.Value;
                if (quantity < 1)
                {
                    MessageBox.Show("���������� ������ �� ����� ���� ������ 1",
                        "������",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                    return;
                }
                if (quantity > selectedProduct.Volume)
                {
                    MessageBox.Show($"�� ������ ������ {selectedProduct.Volume} ����. ������� �� ������ ������� ����������",
                        "������",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                    return;
                }
                checkedListBoxProductsCash.Items.Add(new OrderItem(selectedProduct, quantity), false);
            }
        }
        private void buttonEnterReceipt_Click(object sender, EventArgs e)
        {
            List<OrderItem> itemToRemove = new List<OrderItem>();
            foreach (var item in checkedListBoxProductsCash.CheckedItems) // ��������� � �������� ��� ��� ��������� ������ ����� ���������
            {
                if (item is OrderItem orderItem)
                {
                    var existingItem = itemToRemove.FirstOrDefault(x => x.Product == orderItem.Product);
                    if (existingItem != null)
                        existingItem.Quantity += orderItem.Quantity;
                    else
                        itemToRemove.Add(new OrderItem(orderItem.Product, orderItem.Quantity));
                }
            }
            foreach (var item in itemToRemove) // ��������� ����� ������ ������� � ������� ���������� ������ ��� ������� �� ������
            {
                if (item.Quantity > item.Product.Volume)
                {
                    MessageBox.Show("������������ ������ �� ������",
                        "������",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                    return;
                }
            }
            string cashReceip = "�������� ���\n";
            double sum = 0;
            foreach (var item in itemToRemove)
            {
                sum += item.Quantity * item.PriceAtPurchase;
                cashReceip += $"{item.Product.Name} - {item.PriceAtPurchase.ToString("F2")} ���. * " +
                    $"{item.Quantity} = {(item.PriceAtPurchase * item.Quantity).ToString("F2")} ���.\n";
                item.Product.Volume -= item.Quantity;
                dailyReceipt.Add(item);
            }
            cashReceip += $"�����: {sum.ToString("F2")} ���.";
            UpdateProductList();
            MessageBox.Show(cashReceip,
                "�������� ���",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }
        private void buttonEnterStorage_Click(object sender, EventArgs e)
        {
            LogInForm logInForm = new LogInForm();
            this.Visible = false;
            if (logInForm.ShowDialog() == DialogResult.Cancel)
            {
                this.Visible = true;
                UpdateProductList();
            }
        }

        private void checkedListBoxProductsCash_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            double sum = 0;
            if (checkedListBoxProductsCash.Items[e.Index] is OrderItem changedItem)
            {
                if (e.NewValue == CheckState.Checked)
                    sum += changedItem.Quantity * changedItem.PriceAtPurchase;
                else
                    sum -= changedItem.Quantity * changedItem.PriceAtPurchase;
            }
            foreach (var item in checkedListBoxProductsCash.CheckedItems)
            {
                if (item is OrderItem orderItem)
                {
                    sum += orderItem.Quantity * orderItem.PriceAtPurchase;
                }
            }
            labelSumCash.Text = sum.ToString("F2");
        }

        private void buttonEndShiftCash_Click(object sender, EventArgs e)
        {
            string closeCashierShift = "������� ��� �����\n\n";
            var groupedOrder = dailyReceipt // ����������� ������ �� ����� ������, ������������� � ���� �������
                .GroupBy(o => new { o.Product.Name, o.Product.Producer, o.PriceAtPurchase })
                .Select(g => new
                {
                    Name = g.Key.Name,
                    Producer = g.Key.Producer,
                    PriceAtPurchase = g.Key.PriceAtPurchase,
                    Quantity = g.Sum(o => o.Quantity),
                    TotalSumPrice = g.Sum(o => o.Quantity * o.PriceAtPurchase)
                })
                .ToList();
            double totalSum = 0;
            foreach (var item in groupedOrder)
            {
                closeCashierShift += $"{item.Name} - ���� �������: {item.PriceAtPurchase.ToString("F2")} ���., " +
                    $"���������� - {item.Quantity} ��., ����� {item.TotalSumPrice.ToString("F2")} ���.\n";
                totalSum += item.TotalSumPrice;
            }
            closeCashierShift += $"\n�������� ������� �� �����: {totalSum.ToString("F2")} ���.";
            MessageBox.Show(closeCashierShift,
                "����� �����",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
            this.Close();
            //UpdateProductList();
        }
    }
}
