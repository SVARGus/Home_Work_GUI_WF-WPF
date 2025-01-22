using System.Diagnostics;

namespace Refuling_cars_2025_01_20
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
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
            switch (comboBoxPetrol.SelectedIndex)
            {
                case 0:
                    textBoxPriseOil.Text = "5,40";
                    break;
                case 1:
                    textBoxPriseOil.Text = "5,80";
                    break;
                case 2:
                    textBoxPriseOil.Text = "6,20";
                    break;
                case 3:
                    textBoxPriseOil.Text = "6,55";
                    break;
                case 4:
                    textBoxPriseOil.Text = "7,00";
                    break;
                default:
                    textBoxPriseOil.Text = string.Empty;
                    break;
            }
        }

        private void radioButtonLitre_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonLitre.Checked == true)
            {
                textBoxEnterLiter.Enabled = true;
                textBoxEnterSum.Enabled = false;
            }
        }

        private void radioButtonSum_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonSum.Checked == true)
            {
                textBoxEnterLiter.Enabled = false;
                textBoxEnterSum.Enabled = true;
            }
        }

        private void textBoxEnterLiter_KeyPress(object sender, KeyPressEventArgs e)
        {

        }
    }
}
