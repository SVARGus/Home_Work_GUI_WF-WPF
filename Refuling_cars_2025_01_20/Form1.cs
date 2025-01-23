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

        private void radioButtonLitre_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonLitre.Checked == true)
            {
                textBoxEnterLiter.Enabled = true;
                textBoxEnterSum.Enabled = false;
                textBoxEnterSum.Text = ""; // очистка заблокированного поля
            }
            labelSumRefueling.Text = "00,00";
        }

        private void radioButtonSum_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonSum.Checked == true)
            {
                textBoxEnterLiter.Enabled = false;
                textBoxEnterLiter.Text = ""; // очистка заблокированного поля
                textBoxEnterSum.Enabled = true;
            }
            labelSumRefueling.Text = "00,00";
        }

        private void textBoxEnterLiter_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Проверка на корректность ввода, только цифры и плавающая точка (запятая)
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != ',' && e.KeyChar != '.')
            {
                e.Handled = true; // Блокируем ввод
            }
            // Проверка от повторного указания плавающей точки (запятой)
            if ((e.KeyChar == ',' || e.KeyChar == '.') && (textBoxEnterLiter.Text.Contains(',') || textBoxEnterLiter.Text.Contains('.')))
            {
                e.Handled = true; // Блокируем ввод повторной запятой или точки
            }
        }

        private void textBoxEnterSum_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Проверка на корректность ввода, только цифры и плавающая точка (запятая)
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != ',' && e.KeyChar != '.')
            {
                e.Handled = true; // Блокируем ввод
            }
            // Проверка от повторного указания плавающей точки (запятой)
            if ((e.KeyChar == ',' || e.KeyChar == '.') && (textBoxEnterSum.Text.Contains(',') || textBoxEnterSum.Text.Contains('.')))
            {
                e.Handled = true; // Блокируем ввод повторной запятой или точки
            }
        }

        private void textBoxEnterLiter_UpdateLabelOnLeave(object sender, EventArgs e)
        {
            TextBox TextBoxVolumeOil = sender as TextBox; // надо переделать?
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
            TextBox TextBoxSum = sender as TextBox; // надо переделать?
            TextBox prise = textBoxPriseOil;
            if (double.TryParse(TextBoxSum.Text, out double inputSum)
                && double.TryParse(prise.Text, out double inputValuePrise))
            {
                // Вычисляем сумму
                labelSumRefueling.Text = inputSum.ToString("F2");
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
            if (double.TryParse(labelSumRefueling.Text, out double sumRefueling)
                && double.TryParse(labelSumCafe.Text, out double sumCafe))
            {
                labelTotalSum.Text = (sumRefueling + sumCafe).ToString("F2");
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
            }
            else
            {
                textBoxProductCount1.Enabled = true;
                textBoxProductCount1.Text = "0";
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (!checkBox1.Checked)
            {
                textBoxProductCount2.Enabled = false;
                textBoxProductCount2.Text = string.Empty;
            }
            else
            {
                textBoxProductCount2.Enabled = true;
                textBoxProductCount2.Text = "0";
            }
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (!checkBox1.Checked)
            {
                textBoxProductCount3.Enabled = false;
                textBoxProductCount3.Text = string.Empty;
            }
            else
            {
                textBoxProductCount3.Enabled = true;
                textBoxProductCount3.Text = "0";
            }
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            if (!checkBox1.Checked)
            {
                textBoxProductCount4.Enabled = false;
                textBoxProductCount4.Text = string.Empty;
            }
            else
            {
                textBoxProductCount4.Enabled = true;
                textBoxProductCount4.Text = "0";
            }
        }
    }
}
