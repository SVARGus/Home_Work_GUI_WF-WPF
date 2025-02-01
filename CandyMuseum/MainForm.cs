namespace CandyMuseum
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }
        private void buttonAddProductCash_Click(object sender, EventArgs e)
        {

        }
        private void buttonEnterReceipt_Click(object sender, EventArgs e)
        {

        }
        private void buttonEnterStorage_Click(object sender, EventArgs e)
        {
            LogInForm logInForm = new LogInForm();
            this.Visible = false;
            if(logInForm.ShowDialog() == DialogResult.Cancel)
            {
                this.Visible = true;
            }
        }
    }
}
