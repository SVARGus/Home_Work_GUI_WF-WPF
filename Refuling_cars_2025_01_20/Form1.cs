using System.Diagnostics;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Refuling_cars_2025_01_20
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            // Инициализация списка марок бензина и цен для каждой марки
            //productBindingSource.DataSource = Storage.GetProductOils(); // При закрытии окна выдает ошибку
            List<Product> products = Storage.GetProductOils();
            comboBoxPetrol.DataSource = products;
        }

        private void groupBoxRefueling_Enter(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBoxPriseOil_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBoxPetrol_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBoxPriseOil.Text = comboBoxPetrol.SelectedValue.ToString();
        }

        private void radioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonLitre.Checked)
            {
                textBoxEnterLiter.Enabled = true;
                textBoxEnterSum.Enabled = false;
                textBoxEnterSum.Text = ""; // очистка заблокированного поля
                labelRub3.Text = "руб.";
                labelSumRefueling.Text = "0,00";
                calculateLabelSum();
            }
            if (radioButtonSum.Checked)
            {
                textBoxEnterLiter.Enabled = false;
                textBoxEnterLiter.Text = ""; // очистка заблокированного поля
                textBoxEnterSum.Enabled = true;
                labelRub3.Text = "л.";
                labelSumRefueling.Text = "0,00";
                calculateLabelSum();
            }
        }
        private void textBoxEnter_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Проверка на корректность ввода, только цифры и плавающая точка (запятая)
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != ',')
            {
                e.Handled = true; // Блокируем ввод
            }
            // Проверка от повторного указания плавающей точки (запятой)
            if (e.KeyChar == ',' && textBoxEnterLiter.Text.Contains(','))
            {
                e.Handled = true; // Блокируем ввод повторной запятой или точки
            }
        }
        private void textBoxEnterLiter_UpdateLabelOnLeave(object sender, EventArgs e)
        {
            TextBox TextBoxVolumeOil = textBoxEnterLiter; // надо переделать?
            TextBox prise = textBoxPriseOil;
            if (double.TryParse(TextBoxVolumeOil.Text, out double inputVolumeOil)
                && double.TryParse(prise.Text, out double inputValuePrise))
            {
                // Вычисляем сумму
                labelSumRefueling.Text = (inputVolumeOil * inputValuePrise).ToString("F2");
            }
            else
            {
                // Если ошибка в преобразовании
                labelSumRefueling.Text = "error";
            }
            calculateLabelSum();
        }

        private void textBoxEnterSum_UpdateLabelOnLeave(object sender, EventArgs e)
        {
            TextBox TextBoxSum = textBoxEnterSum; // надо переделать?
            TextBox prise = textBoxPriseOil;
            if (double.TryParse(TextBoxSum.Text, out double inputSum)
                && double.TryParse(prise.Text, out double inputValuePrise))
            {
                // Вычисляем сумму
                labelSumRefueling.Text = (inputSum / inputValuePrise).ToString("F2");
            }
            else
            {
                // Если ошибка в преобразовании
                labelSumRefueling.Text = "error";
            }
            calculateLabelSum();
        }
        private void textBoxEnter_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.ActiveControl = null;
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }
        private void calculateLabelSum()
        {
            double SumOil = 0.00;
            if (string.IsNullOrWhiteSpace(textBoxEnterSum.Text) || !double.TryParse(textBoxEnterSum.Text, out SumOil))
                SumOil = 0.00;
            if (double.TryParse(labelSumRefueling.Text, out double sumRefueling)
                && double.TryParse(labelSumCafe.Text, out double sumCafe))
            {
                if(radioButtonLitre.Checked)
                    labelTotalSum.Text = (sumRefueling + sumCafe).ToString("F2");
                else if(radioButtonSum.Checked)
                    labelTotalSum.Text = (SumOil + sumCafe).ToString("F2");
            }
            else
            {
                labelTotalSum.Text = "error";
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (!checkBox1.Checked)
            {
                textBoxProductCount1.Enabled = false;
                textBoxProductCount1.Text = string.Empty;
                textBoxProductCount_Leave(sender, e);
            }
            else
            {
                textBoxProductCount1.Enabled = true;
                textBoxProductCount1.Text = "0";
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (!checkBox2.Checked)
            {
                textBoxProductCount2.Enabled = false;
                textBoxProductCount2.Text = string.Empty;
                textBoxProductCount_Leave(sender, e);
            }
            else
            {
                textBoxProductCount2.Enabled = true;
                textBoxProductCount2.Text = "0";
            }
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (!checkBox3.Checked)
            {
                textBoxProductCount3.Enabled = false;
                textBoxProductCount3.Text = string.Empty;
                textBoxProductCount_Leave(sender, e);
            }
            else
            {
                textBoxProductCount3.Enabled = true;
                textBoxProductCount3.Text = "0";
            }
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            if (!checkBox4.Checked)
            {
                textBoxProductCount4.Enabled = false;
                textBoxProductCount4.Text = string.Empty;
                textBoxProductCount_Leave(sender, e);
            }
            else
            {
                textBoxProductCount4.Enabled = true;
                textBoxProductCount4.Text = "0";
            }
        }

        private void textBoxProductCount_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // Блокируем ввод
            }
        }

        private void textBoxProductCount_Leave(object sender, EventArgs e)
        {
            List<double> listSumProduct = new List<double>() { 0, 0, 0, 0 };
            if(checkBox1.Checked)
            {
                if(double.TryParse(textBoxProductCount1.Text, out double inputSumProduct) 
                    && double.TryParse(textBoxPrise1.Text, out double prises))
                    listSumProduct[0] = inputSumProduct * prises;
                else
                    labelSumCafe.Text = "ERROR";
            }
            else
                listSumProduct[0] = 0;
            if (checkBox2.Checked)
            {
                if (double.TryParse(textBoxProductCount2.Text, out double inputSumProduct)
                    && double.TryParse(textBoxPrise2.Text, out double prises))
                    listSumProduct[1] = inputSumProduct * prises;
                else
                    labelSumCafe.Text = "ERROR";
            }
            else
                listSumProduct[1] = 0;
            if (checkBox3.Checked)
            {
                if (double.TryParse(textBoxProductCount3.Text, out double inputSumProduct)
                    && double.TryParse(textBoxPrise3.Text, out double prises))
                    listSumProduct[2] = inputSumProduct * prises;
                else
                    labelSumCafe.Text = "ERROR";
            }
            else
                listSumProduct[2] = 0;
            if (checkBox4.Checked)
            {
                if (double.TryParse(textBoxProductCount4.Text, out double inputSumProduct)
                    && double.TryParse(textBoxPrise4.Text, out double prises))
                    listSumProduct[3] = inputSumProduct * prises;
                else
                    labelSumCafe.Text = "ERROR";
            }
            else
                listSumProduct[3] = 0;
            labelSumCafe.Text = (listSumProduct.Sum()).ToString("F2");
            calculateLabelSum();
        }
    }
}
