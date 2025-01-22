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
                MessageBox.Show("Введите Фамилию", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (string.IsNullOrEmpty(textBoxFirstname.Text))
            {
                MessageBox.Show("Введите Имя", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (string.IsNullOrEmpty(textBoxMiddlename.Text))
            {
                MessageBox.Show("Введите Отчество", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (string.IsNullOrEmpty(textBoxCountry.Text))
            {
                MessageBox.Show("Введите Страну", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (string.IsNullOrEmpty(textBoxCity.Text))
            {
                MessageBox.Show("Введите Город", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (string.IsNullOrEmpty(textBoxPhone.Text))
            {
                MessageBox.Show("Введите телефон", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if(dateTimePickerBirth.Value > DateTime.Now)
            {
                MessageBox.Show("Дата рождения не может быть в будущем", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (dateTimePickerBirth.Value > DateTime.Now.AddYears(-18))
            {
                MessageBox.Show("Возраст должен быть не менее 18 лет.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!radioButtonGenderMale.Checked && !radioButtonGenderWoman.Checked)
            {
                MessageBox.Show("Выберите пол", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            string fullName = string.Concat(textBoxLastname.Text, " ", textBoxFirstname.Text, " ", textBoxMiddlename.Text);
            string dateOfBirthStr = dateTimePickerBirth.Value.ToString("dd.MM.yyyy");
            string genderStr = radioButtonGenderMale.Checked ? "Мужской" : radioButtonGenderWoman.Checked ? "Женский" : "Не указан";
            string message = string.Concat("ФИО: ", fullName, "\n", "Место проживания: ", textBoxCountry.Text, ", ",
                textBoxCity.Text, "\n", "Телефон: ", textBoxPhone.Text, "\n", "Дата рождения: ", dateOfBirthStr, "г. \n",
                "Пол: ", genderStr);
            MessageBox.Show(message);
        }
    }
}
