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
            }
        }
    }
}
