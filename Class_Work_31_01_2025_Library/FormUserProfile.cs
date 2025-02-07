using Home_and_Class_Work_31_01_2025_Library.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Home_and_Class_Work_31_01_2025_Library
{
    public partial class FormUserProfile : Form
    {
        public User UserData { get; private set; }
        public FormUserProfile(User accaunt = null)
        {
            InitializeComponent();
            RoleComboBox.DataSource = Enum.GetValues(typeof(UserRol));
            if (accaunt != null)
            {
                EmailTextBox.Text = accaunt.Email;
                passwordTextBox.Text = accaunt.Password;
                firstNameTextBox.Text = accaunt.FirstName;
                lastNameTextBox.Text = accaunt.LastName;
                phoneTextBox.Text = accaunt.Phone;
                RoleComboBox.SelectedIndex = ((int)accaunt.Role);
            }
        }

        private void btCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            Close();
        }

        private void btSaveAccount_Click(object sender, EventArgs e)
        {
            string roleUser = RoleComboBox.SelectedItem.ToString();
            if(Enum.TryParse(roleUser, out UserRol result)) 
            {
                UserData = new User(EmailTextBox.Text, passwordTextBox.Text, firstNameTextBox.Text,
                    lastNameTextBox.Text, phoneTextBox.Text, result);
                this.DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show("Не верно указана роль пользователя",
                    "Ошибка в данных",
                    MessageBoxButtons.OK, 
                    MessageBoxIcon.Error);
                this.DialogResult = DialogResult.Cancel;
            }
            Close();
        }
    }
}
