/*
Написать приложение – анкету, которую предлагается заполнить пользователю: имя, фамилия, e-mail, телефон. 
После нажатия на кнопку «Добавить» Информация о пользователе попадает в ListBox,
в котором храниться информация о всех пользователях. 
Также, в ListBox, по клику на строку с информацией о пользователе следует предусмотреть 
возможность удаления пользователя из коллекции элементов ListBox, а также редактирования. 
Редактирование информации о пользователе производиться путем подстановки данных из ListBox, 
в соответствующие поля для ввода новой информации.

Предусмотреть:
• экспорт / импорт всей информации о пользователях в текстовый файл;
*/

using Microsoft.VisualBasic.ApplicationServices;

namespace Home_Work_20_01_2025_part_1
{
    public partial class MainForm : Form
    {
        private UserManager userManager;
        public MainForm()
        {
            InitializeComponent();
            userManager = new UserManager
            {
                FilePath = "users.json",
                Users = new List<User>
                {
                    //new User("Иван", "Иванов", "ivanov@gmail.com", "+79261112233"),
                    //new User("Мария", "Петрова", "petrova@gmail.com", "+79262223344"),
                    //new User("Алексей", "Сидоров", "sidorov@gmail.com", "+79263334455")
                }
            };
            UpdateListBox();
        }
        private void UpdateListBox() // Метод обновления данных в ListBox после любых изменений
        {
            listBoxUsers.Items.Clear();
            foreach (var user in userManager.GetUsers())
            {
                listBoxUsers.Items.Add(user);
            }
        }

        private void buttonAddUser_Click(object sender, EventArgs e)
        {
            UserForm userForm = new UserForm();
            if (userForm.ShowDialog() == DialogResult.OK)
            {
                userManager.AddUser(userForm.UserData);
                UpdateListBox();
            }
        }

        private void buttonEditUser_Click(object sender, EventArgs e)
        {
            if (listBoxUsers.SelectedItem == null)
            {
                MessageBox.Show("Выберите пользователя для редактирования.",
                    "Ошибка",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }
            else if (listBoxUsers.SelectedIndex != -1)
            {
                User selectedUser = (User)listBoxUsers.SelectedItem;
                UserForm userForm = new UserForm(selectedUser);
                if (userForm.ShowDialog() == DialogResult.OK)
                {
                    int index = listBoxUsers.SelectedIndex;
                    userManager.Users[index] = userForm.UserData;
                    //userManager.UpdateUser(userManager.Users[index], userForm.UserData);
                    UpdateListBox();
                }
            }
        }

        private void buttonDeleteUser_Click(object sender, EventArgs e)
        {
            if (listBoxUsers.SelectedItem == null)
            {
                MessageBox.Show("Выберите пользователя для удаления.",
                    "Ошибка",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }
            else if (listBoxUsers.SelectedIndex != -1)
            {
                int index = listBoxUsers.SelectedIndex;
                userManager.Users.RemoveAt(index);
                UpdateListBox();
            }
        }

        private void buttonExportUser_Click(object sender, EventArgs e)
        {
            userManager.ImportFromTxt();
        }

        private void buttonImportUser_Click(object sender, EventArgs e)
        {
            userManager.Users.Clear();
            userManager.ExportToTxt();
            UpdateListBox();
        }
    }
}
