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
            toolTip.SetToolTip(comboBoxProductList, "Выберите товар");
            toolTip.SetToolTip(numericUpDownVolumeProducts, "Количество товара");
            toolTip.SetToolTip(buttonEnterReceipt, "Расчитаться с покупателем");
            toolTip.SetToolTip(buttonEnterStorage, "Вход только для админа");
            toolTip.SetToolTip(buttonEndShiftCash, "Завершить рабочиф день?");
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
            foreach (var item in checkedListBoxProductsCash.CheckedItems) // Добавляем в итоговый чек все выбранные товары перед првоеркой
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
            foreach (var item in itemToRemove) // Проверяем чтобы небыло выбрано к продаже количество больше чем имеется на складе
            {
                if (item.Quantity > item.Product.Volume)
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
            string closeCashierShift = "Сводный чек смены\n\n";
            var groupedOrder = dailyReceipt // Группировка данных по Имени товара, производителю и цене продажи
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
                closeCashierShift += $"{item.Name} - цена продажи: {item.PriceAtPurchase.ToString("F2")} руб., " +
                    $"количество - {item.Quantity} шт., сумма {item.TotalSumPrice.ToString("F2")} руб.\n";
                totalSum += item.TotalSumPrice;
            }
            closeCashierShift += $"\nИтоговая выручка за смену: {totalSum.ToString("F2")} руб.";
            MessageBox.Show(closeCashierShift,
                "Конец смены",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
            this.Close();
            //UpdateProductList();
        }
    }
}
