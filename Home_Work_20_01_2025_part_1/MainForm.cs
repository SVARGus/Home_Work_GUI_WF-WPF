/*
�������� ���������� � ������, ������� ������������ ��������� ������������: ���, �������, e-mail, �������. 
����� ������� �� ������ ���������� ���������� � ������������ �������� � ListBox,
� ������� ��������� ���������� � ���� �������������. 
�����, � ListBox, �� ����� �� ������ � ����������� � ������������ ������� ������������� 
����������� �������� ������������ �� ��������� ��������� ListBox, � ����� ��������������. 
�������������� ���������� � ������������ ������������� ����� ����������� ������ �� ListBox, 
� ��������������� ���� ��� ����� ����� ����������.

�������������:
� ������� / ������ ���� ���������� � ������������� � ��������� ����;
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
                    //new User("����", "������", "ivanov@gmail.com", "+79261112233"),
                    //new User("�����", "�������", "petrova@gmail.com", "+79262223344"),
                    //new User("�������", "�������", "sidorov@gmail.com", "+79263334455")
                }
            };
            UpdateListBox();
        }
        private void UpdateListBox() // ����� ���������� ������ � ListBox ����� ����� ���������
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
                MessageBox.Show("�������� ������������ ��� ��������������.",
                    "������",
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
                MessageBox.Show("�������� ������������ ��� ��������.",
                    "������",
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
