using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CandyMuseum
{
    public partial class StorageForm : Form
    {
        public StorageForm()
        {
            InitializeComponent();
            UpdateListBox();
        }
        private void UpdateListBox() // Метод обновления данных в ListBox после любых изменений
        {
            listBoxStorage.Items.Clear();
            foreach (var item in Storage.GetListProducts())
            {
                listBoxStorage.Items.Add(item);
            }
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            DialogResult result = DialogResult.OK;
            this.Close();
        }

        private void buttonAddProduct_Click(object sender, EventArgs e)
        {
            ProductCardForm productCardForm = new ProductCardForm();
            productCardForm.ShowDialog(this);
            if (this.DialogResult == DialogResult.OK)
            {
                UpdateListBox();
            }
        }

        private void buttonModifyProduct_Click(object sender, EventArgs e)
        {
            ProductCardForm productCardForm = new ProductCardForm((Product)listBoxStorage.SelectedItem);
            productCardForm.ShowDialog(this);
            if (this.DialogResult == DialogResult.OK)
            {
                var product = Storage.GetListProducts();
                int index = listBoxStorage.SelectedIndex;
                product[index] = productCardForm.productDate;
                UpdateListBox();
            }
        }

        private void buttonRemoveProduct_Click(object sender, EventArgs e)
        {
            Storage.Delete(listBoxStorage.SelectedIndex);
            UpdateListBox();
        }
    }
}
