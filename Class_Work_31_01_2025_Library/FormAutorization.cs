using Class_Work_31_01_2025_Library.Clases;
using Class_Work_31_01_2025_Library.Date;
using System.Diagnostics;
namespace Class_Work_31_01_2025_Library
{
    public partial class FormAutorization : Form
    {
        public FormAutorization()
        {
            InitializeComponent();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            if(textBoxLogin.Text == null || textBoxPassword.Text == null || 
                textBoxLogin.Text == string.Empty || textBoxPassword.Text == string.Empty)
            {
                MessageBox.Show("¬ведите логин и пароль!",
                    "ќшибка",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            else
            {
                var AccountArray = AccountResurses.GetListAccount().ToArray();
                for (int i = 0; i < AccountArray.Length; i++)
                {
                    if(AccountArray[i].Email == textBoxLogin.Text && AccountArray[i].Password == textBoxPassword.Text)
                    {
                        switch (AccountArray[i].Role)
                        {
                            case AccountRoles.Admin:
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
                            case AccountRoles.Employee:

                                break;
                            case AccountRoles.Visitor: 
                                
                                break;
                        }
                    }
                }
            }
            
        }
    }
}
