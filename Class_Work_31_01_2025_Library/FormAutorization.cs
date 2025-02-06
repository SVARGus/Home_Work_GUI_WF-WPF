using Class_Work_31_01_2025_Library.Clases;
using Class_Work_31_01_2025_Library.Date;
using System.Diagnostics;
using System.Windows.Forms;
namespace Class_Work_31_01_2025_Library
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
            toolTipAutorization.SetToolTip(textBoxLogin, "Введите электронную почту");
            toolTipAutorization.SetToolTip(textBoxPassword, "Введите свой пароль");
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            if(textBoxLogin.Text == null || textBoxPassword.Text == null || 
                textBoxLogin.Text == string.Empty || textBoxPassword.Text == string.Empty)
            {
                MessageBox.Show("Введите логин и пароль!",
                    "Ошибка",
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

                                break;
                            case UserRol.Visitor: 
                                
                                break;
                        }
                        notSearchAccount = true;
                    }
                    else if(AccountArray[i].Email == textBoxLogin.Text && AccountArray[i].Password != textBoxPassword.Text)
                    {
                        MessageBox.Show("Не верно введен пароль, повторите попытку",
                            "Не верный пароль",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                        notSearchAccount = true;
                    }
                }
                if (!notSearchAccount)
                {
                    MessageBox.Show("Пользователь не зарегестрирован! Обарититесь к сотруднику библиотеки для регистрации",
                        "Пользователь не зарегестрирован", 
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }
            }
            
        }
    }
}
