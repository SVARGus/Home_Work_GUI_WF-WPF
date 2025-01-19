namespace Home_Work_15_01_2025_part_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void buttonUp_Click (object sender, EventArgs e)
        {
            string inputText = textBoxEnter.Text;
            string processedText = inputText.ToUpper();
            textBoxResult.Text = processedText;
        }
        private void buttonLower_Click (object sender, EventArgs e)
        {
            string inputText = textBoxEnter.Text;
            string processedText = inputText.ToLower();
            textBoxResult.Text = processedText;
        }
        private void buttonClear_Click (object sender, EventArgs e)
        {
            textBoxEnter.Text = string.Empty;
            textBoxResult.Text = string.Empty;
        }
    }
}
