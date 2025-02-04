using Class_Work_31_01_2025_Library.Clases;
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
    public partial class FormAccountProfile : Form
    {
        public LibraryAccount account {  get; set; }
        public FormAccountProfile(LibraryAccount accaunt = null)
        {
            InitializeComponent();
            foreach(var role in Enum.GetValues(typeof(AccountRoles)))
            {
                RoleComboBox.Items.Add(role.ToString());
            }
            if(accaunt != null)
            {
                EmailTextBox.Text = accaunt.Email;
                passwordTextBox.Text = accaunt.Password;
                firstNameTextBox.Text = accaunt.FirstName;
                lastNameTextBox.Text = accaunt.LastName;
                phoneTextBox.Text = accaunt.Phone;
                RoleComboBox.SelectedIndex = ((int)accaunt.Role);
            }
        }
    }
}
