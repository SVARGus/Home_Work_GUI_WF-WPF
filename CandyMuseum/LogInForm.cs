//using System;
//using System.Collections.Generic;
//using System.ComponentModel;
//using System.Data;
//using System.Drawing;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using System.Windows.Forms;
//using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace CandyMuseum
{
    public partial class LogInForm : Form
    {
        private ToolTip toolTip;
        public LogInForm()
        {
            InitializeComponent();
            toolTip = new ToolTip();
            toolTip.AutoPopDelay = 2000;
            toolTip.InitialDelay = 500;
            toolTip.ReshowDelay = 500;
            toolTip.ShowAlways = true;
            toolTip.SetToolTip(textBoxLogin, "Для удобства автоматически вставлен правильный логин");
            toolTip.SetToolTip(textBoxPassword, "Ну пароль и так понятно: 12345");
            toolTip.SetToolTip(buttonEnterStorage, "Кномпа всевластия");
        }

        private void buttonEnterStorage_Click(object sender, EventArgs e)
        {
            if(textBoxLogin.Text == null || textBoxPassword.Text == null ||
                textBoxLogin.Text == string.Empty || textBoxPassword.Text == string.Empty)
            {
                MessageBox.Show("Введите пароль и логин!", 
                    "Ошибка", 
                    MessageBoxButtons.OK, 
                    MessageBoxIcon.Error);
            }
            else if(textBoxLogin.Text == "admin" && textBoxPassword.Text == "12345")
            {
                StorageForm storageForm = new StorageForm();
                this.Visible = false;
                DialogResult result = storageForm.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("Введен не правильный пароль",
                    "Ошибка",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }
    }
}
