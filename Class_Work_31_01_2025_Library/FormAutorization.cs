using Home_and_Class_Work_31_01_2025_Library.Clases;
using Home_and_Class_Work_31_01_2025_Library.Data;
using System.Diagnostics;
using System.Windows.Forms;
namespace Home_and_Class_Work_31_01_2025_Library
{
    public partial class FormAutorization : Form
    {
        private ToolTip toolTipAutorization;
        public FormAutorization()
        {
            InitializeComponent();
            toolTipAutorization = new ToolTip();
            toolTipAutorization.AutoPopDelay = 2000;
            toolTipAutorization.InitialDelay = 500;
            toolTipAutorization.ReshowDelay = 500;
            toolTipAutorization.ShowAlways = true;
            toolTipAutorization.SetToolTip(textBoxLogin, "������� ����������� �����");
            toolTipAutorization.SetToolTip(textBoxPassword, "������� ���� ������");
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            if(textBoxLogin.Text == null || textBoxPassword.Text == null || 
                textBoxLogin.Text == string.Empty || textBoxPassword.Text == string.Empty)
            {
                MessageBox.Show("������� ����� � ������!",
                    "������",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            else
            {
                bool notSearchAccount = false;
                var AccountArray = UserResurs.GetListUsers();
                for (int i = 0; i < AccountArray.Count; i++)
                {
                    if(AccountArray[i].Email == textBoxLogin.Text && AccountArray[i].Password == textBoxPassword.Text)
                    {
                        switch (AccountArray[i].Role)
                        {
                            case UserRol.Admin:
                                AdminMainWindows win = new AdminMainWindows();
                                this.Visible = false;
                                if(win.ShowDialog() == DialogResult.Cancel)
                                {
                                    win.Close();
                                }
                                textBoxLogin.Text = string.Empty;
                                textBoxPassword.Text = string.Empty;
                                this.Visible = true;
                                break;
                            case UserRol.Employee:
                                LibraryStaffWorkerForm libStaf = new LibraryStaffWorkerForm();
                                this.Visible = false;
                                if (libStaf.ShowDialog() == DialogResult.Cancel)
                                {
                                    libStaf.Close();
                                }
                                textBoxLogin.Text = string.Empty;
                                textBoxPassword.Text = string.Empty;
                                this.Visible = true;
                                break;
                            case UserRol.Visitor: 
                                LibraryUserForm libraryUser = new LibraryUserForm();
                                this.Visible = false;
                                if(libraryUser.ShowDialog() == DialogResult.Cancel)
                                {
                                    libraryUser.Close();
                                }
                                textBoxLogin.Text = string.Empty;
                                textBoxPassword.Text = string.Empty;
                                this.Visible = true;
                                break;
                        }
                        notSearchAccount = true;
                    }
                    else if(AccountArray[i].Email == textBoxLogin.Text && AccountArray[i].Password != textBoxPassword.Text)
                    {
                        MessageBox.Show("�� ����� ������ ������, ��������� �������",
                            "�� ������ ������",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                        notSearchAccount = true;
                    }
                }
                if (!notSearchAccount)
                {
                    MessageBox.Show("������������ �� ���������������! ����������� � ���������� ���������� ��� �����������",
                        "������������ �� ���������������", 
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }
            }
            
        }
    }
}
