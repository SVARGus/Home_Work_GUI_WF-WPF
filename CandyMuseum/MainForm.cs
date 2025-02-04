namespace CandyMuseum
{
    public partial class MainForm : Form
    {
        private List<OrderItem> dailyReceipt = new List<OrderItem>();
        public MainForm()
        {
            InitializeComponent();
            UpdateProductList();
        }
        private void UpdateProductList()
        {
            comboBoxProductList.DataSource = null;
            comboBoxProductList.DataSource = Storage.GetListProducts();
        }
        private void buttonAddProductCash_Click(object sender, EventArgs e)
        {
            if (comboBoxProductList.SelectedItem is Product selectedProduct)
            {
                int quantity = (int)numericUpDownVolumeProducts.Value;
                if (quantity < 1)
                {
                    MessageBox.Show("Количество товара не может быть меньше 1",
                        "Ошибка",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                    return;
                }
                if (quantity > selectedProduct.Volume)
                {
                    MessageBox.Show($"На складе только {selectedProduct.Volume} штук. Укажите не больше данного количества",
                        "Ошибка",
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
            foreach(var item in checkedListBoxProductsCash.CheckedItems) // Добавляем в итоговый чек все выбранные товары перед првоеркой
            {
                if(item is OrderItem orderItem)
                {
                    var existingItem = itemToRemove.FirstOrDefault(x => x.Product == orderItem.Product);
                    if (existingItem != null)
                        existingItem.Quantity += orderItem.Quantity;
                    else
                        itemToRemove.Add(new OrderItem(orderItem.Product, orderItem.Quantity));
                }
            }
            foreach (var item in itemToRemove) // Проверяем чтобы небыло выбрано к продаже количество больше чем имеется на складе
            {
                if(item.Quantity > item.Product.Volume)
                {
                    MessageBox.Show("Недостаточно товара на складе", 
                        "Ошибка",
                        MessageBoxButtons.OK, 
                        MessageBoxIcon.Error); 
                    return;
                }
            }
            string cashReceip = "Кассовый чек\n";
            double sum = 0;
            foreach (var item in itemToRemove)
            {
                sum += item.Quantity * item.PriceAtPurchase;
                cashReceip += $"{item.Product.Name} - {item.PriceAtPurchase.ToString("F2")} руб. * " +
                    $"{item.Quantity} = {(item.PriceAtPurchase * item.Quantity).ToString("F2")} руб.\n";
                item.Product.Volume -= item.Quantity;
                dailyReceipt.Add(item);
            }
            cashReceip += $"Итого: {sum.ToString("F2")} руб.";
            checkedListBoxProductsCash.Items.Clear();
            UpdateProductList();
            MessageBox.Show(cashReceip,
                "Итоговый чек",
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
    }
}
