using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace CandyMuseum
{
    public partial class ProductCardForm : Form
    {
        public Product productDate { get; private set; }
        public ProductCardForm(Product product = null)
        {
            InitializeComponent();
            if (product != null)
            {
                textBoxNameProduct.Text = product.Name;
                if (radioButtonProducer1.Text.ToString() == product.Producer)
                    radioButtonProducer1.Checked = true;
                if (radioButtonProducer2.Text.ToString() == product.Producer)
                    radioButtonProducer2.Checked = true;
                if (radioButtonProducer3.Text.ToString() == product.Producer)
                    radioButtonProducer3.Checked = true;
                if (radioButtonProducer4.Text.ToString() == product.Producer)
                    radioButtonProducer4.Checked = true;
                numericUpDownQuzntityProduct.Value = (decimal)product.Volume;
                numericUpDownPriceProduct.Value = (decimal)product.Price;
            }
            textBoxNameProduct.Focus();
            this.DialogResult = DialogResult.Cancel;
        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void buttonBackProduct_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void buttonSaveProduct_Click(object sender, EventArgs e)
        {
            string producer = null;
            if (radioButtonProducer1.Checked == true)
                producer = radioButtonProducer1.Text;
            if (radioButtonProducer2.Checked == true)
                producer = radioButtonProducer2.Text;
            if (radioButtonProducer3.Checked == true)
                producer = radioButtonProducer3.Text;
            if (radioButtonProducer4.Checked == true)
                producer = radioButtonProducer4.Text;
            if(producer == null)
            {
                MessageBox.Show("Выберите производителя",
                    "Ошибка",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }
            productDate = new Product(textBoxNameProduct.Text, producer, (int)numericUpDownQuzntityProduct.Value, (double)numericUpDownPriceProduct.Value);
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
