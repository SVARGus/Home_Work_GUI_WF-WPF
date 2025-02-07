using Home_and_Class_Work_31_01_2025_Library.Clases;
using Home_and_Class_Work_31_01_2025_Library.Data;
using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Home_and_Class_Work_31_01_2025_Library
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
            accountListBox.DataSource = null;
            accountListBox.DataSource = AccountArray; // Лист бокс не обновляется после изменений в листе пользователей
        }

        private void btImportAccount_Click(object sender, EventArgs e)
        {
            UserResurs.SaveListUsers();
        }

        private void btExitAdmin_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            Close();
        }

        private void btCreateAccount_Click(object sender, EventArgs e)
        {
            var createAccount = new FormUserProfile();
            if(createAccount.ShowDialog() == DialogResult.OK)
            {
                var AccountArray = UserResurs.GetListUsers();
                AccountArray.Add(createAccount.UserData);
                UpdateListBox();
            }
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
                FormUserProfile edeteAccount = new FormUserProfile(selectAccount);
                if (edeteAccount.ShowDialog() == DialogResult.OK)
                {
                    int index = accountListBox.SelectedIndex;
                    var AccountArray = UserResurs.GetListUsers();
                    AccountArray[index] = edeteAccount.UserData;
                    UpdateListBox();
                }
            }
        }

        private void btDeleteAccount_Click(object sender, EventArgs e)
        {
            if (accountListBox.SelectedItem == null)
            {
                MessageBox.Show("Выберите пользователя для удаления.",
                    "Ошибка",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }
            var listUsers = UserResurs.GetListUsers();
            listUsers.RemoveAt(accountListBox.SelectedIndex);
            UpdateListBox();
        }
    }
}
