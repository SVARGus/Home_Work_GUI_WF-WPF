namespace Home_Work_15_01_2025_part_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }
        private void buttonShowResult_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(textBoxLastname.Text))
            {
                MessageBox.Show("������� �������", "������", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (string.IsNullOrEmpty(textBoxFirstname.Text))
            {
                MessageBox.Show("������� ���", "������", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (string.IsNullOrEmpty(textBoxMiddlename.Text))
            {
                MessageBox.Show("������� ��������", "������", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (string.IsNullOrEmpty(textBoxCountry.Text))
            {
                MessageBox.Show("������� ������", "������", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (string.IsNullOrEmpty(textBoxCity.Text))
            {
                MessageBox.Show("������� �����", "������", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (string.IsNullOrEmpty(textBoxPhone.Text))
            {
                MessageBox.Show("������� �������", "������", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if(dateTimePickerBirth.Value > DateTime.Now)
            {
                MessageBox.Show("���� �������� �� ����� ���� � �������", "������", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (dateTimePickerBirth.Value > DateTime.Now.AddYears(-18))
            {
                MessageBox.Show("������� ������ ���� �� ����� 18 ���.", "������", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!radioButtonGenderMale.Checked && !radioButtonGenderWoman.Checked)
            {
                MessageBox.Show("�������� ���", "������", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            string fullName = string.Concat(textBoxLastname.Text, " ", textBoxFirstname.Text, " ", textBoxMiddlename.Text);
            string dateOfBirthStr = dateTimePickerBirth.Value.ToString("dd.MM.yyyy");
            string genderStr = radioButtonGenderMale.Checked ? "�������" : radioButtonGenderWoman.Checked ? "�������" : "�� ������";
            string message = string.Concat("���: ", fullName, "\n", "����� ����������: ", textBoxCountry.Text, ", ",
                textBoxCity.Text, "\n", "�������: ", textBoxPhone.Text, "\n", "���� ��������: ", dateOfBirthStr, "�. \n",
                "���: ", genderStr);
            MessageBox.Show(message);
        }
    }
}
