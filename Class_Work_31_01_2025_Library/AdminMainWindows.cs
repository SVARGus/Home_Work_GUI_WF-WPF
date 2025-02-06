using Class_Work_31_01_2025_Library.Clases;
using Class_Work_31_01_2025_Library.Date;
using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Class_Work_31_01_2025_Library
{
    public partial class AdminMainWindows : Form
    {
        public AdminMainWindows()
        {
            InitializeComponent();
            UpdateListBox();
        }
        private void UpdateListBox() // Метод обновления данных в ListBox после любых изменений
        {
            //accountListBox.Items.Clear();
            var AccountArray = UserResurs.GetListUsers();
            accountListBox.DataSource = AccountArray; // Лист бокс не обновляется после изменений в листе пользователей
        }

        private void btImportAccount_Click(object sender, EventArgs e)
        {

        }

        private void btExitAdmin_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            Close();
        }

        private void btCreateAccount_Click(object sender, EventArgs e)
        {
            var createAccount = new FormUserProfile();

        }

        private void btEdeteAccount_Click(object sender, EventArgs e)
        {
            if (accountListBox.SelectedItem == null)
            {
                MessageBox.Show("Выберите пользователя для редактирования.",
                    "Ошибка",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }
            else if (accountListBox.SelectedIndex != -1)
            {
                Clases.User selectAccount = (Clases.User)accountListBox.SelectedItem;
                FormUserProfile createAccount = new FormUserProfile(selectAccount);
                if (createAccount.ShowDialog() == DialogResult.OK)
                {
                    int index = accountListBox.SelectedIndex;
                    var AccountArray = UserResurs.GetListUsers();
                    AccountArray[index] = createAccount.UserData;
                    UpdateListBox();
                }
            }
        }
    }
}
