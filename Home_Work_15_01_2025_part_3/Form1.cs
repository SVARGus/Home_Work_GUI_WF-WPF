namespace Home_Work_15_01_2025_part_3
{
    /*
    Задание 
    Вывести на экран свое (краткое!!!) резюме с помощью последовательности MessageBox’ов (числом не менее трех). 
    Причем на заголовке последнего должно отобразиться среднее число символов на странице 
    (общее количество символов в резюме / количество MessageBox’ов). 
    */
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string part1 = "Здраствуйте! Меня звать Павел и я начинающий разработчик!";
            string part2 = "Стек навыков: С++, ООП, паттерны проектирования, юнит-тестирование, С#, SQL Server, Postgres, Git, .NET, различные HUI - WF, WPF, Qt.";
            string part3 = "Я развиваюсь в области разработки ОП, а также активно интересуюсь машинным обучением";
            string fullResume = part1 + part2 + part3;
            int numberCharacters = fullResume.Length;
            double averageNumberCharacters = numberCharacters / 3.0;
            MessageBox.Show(part1, "Резюме (часть 1)");
            MessageBox.Show(part2, "Резюме (часть 2)");
            MessageBox.Show(part3, $"Резюме (часть 3) - среднее симоволов {averageNumberCharacters}.");
        }
    }
}
