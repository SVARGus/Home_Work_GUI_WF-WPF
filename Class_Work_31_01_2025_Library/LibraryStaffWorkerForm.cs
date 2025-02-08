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
    public partial class LibraryStaffWorkerForm : Form
    {
        public LibraryStaffWorkerForm()
        {
            InitializeComponent();
        }

        private void btEdeteCreate_Click(object sender, EventArgs e)
        {
            IsEnable(true);
        }
        private void IsEnable(bool Enabled)
        {
            textBoxTitle.Enabled = Enabled;
            textBoxAuthor.Enabled = Enabled;
            textBoxGenre.Enabled = Enabled;
            textBoxPublisher.Enabled = Enabled;
            textBoxDescription.Enabled = Enabled;
            btSave.Enabled = Enabled;
            btEdeteCreate.Enabled = !Enabled;
        }

        private void btSave_Click(object sender, EventArgs e)
        {
            IsEnable(false);
        }
    }
}
