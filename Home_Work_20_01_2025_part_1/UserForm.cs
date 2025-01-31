using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Home_Work_20_01_2025_part_1
{
    public partial class UserForm : Form
    {
        public User UserData { get; private set; }
        public UserForm(User user = null)
        {
            InitializeComponent();
            if (user != null)
            {
                textBoxFirstName.Text = user.FirstName;
                textBoxLastName.Text = user.LastName;
                textBoxEmail.Text = user.Email;
                textBoxPhone.Text = user.Phone;
            }
            textBoxFirstName.Focus();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            UserData = new User(textBoxFirstName.Text, textBoxLastName.Text, textBoxEmail.Text, textBoxPhone.Text);
            DialogResult = DialogResult.OK;
            Close();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
