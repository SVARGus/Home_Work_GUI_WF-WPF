/*
 Задание
Написать функцию, которая «угадывает» задуманное пользова-
телем число от 1 до 2000. Для запроса к пользователю использовать
MessageBox. После того, как число отгадано, необходимо вывести
количество запросов, потребовавшихся для этого, и предоставить
пользователю возможность сыграть еще раз, не выходя из программы
(MessageBox’ы оформляются кнопками и значками соответственно
ситуации).
 */

namespace Home_Work_15_01_2025_part_4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        private void textBoxEnterNum_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // Блокируем ввод
            }
        }

        private void buttonGame1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxEnterNum.Text) || !int.TryParse(textBoxEnterNum.Text, out int inputUpNumSearch) || inputUpNumSearch <= 1)
            {
                MessageBox.Show("Произошла ошибка при выборе диапазона загадывания!\nЗагадываемый диапазон должен быть больше чем 1", 
                    "Ошибка", 
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }
            if(inputUpNumSearch > 200)
            {
                MessageBox.Show("Диапазон слишком большой, очень долго будем угадывать!\nЗагадайте диапазон до 200",
                    "Ошибка",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }
            List<int> numbers = Enumerable.Range(1, inputUpNumSearch).ToList();
            bool exit= false;
            int count = 0;
            while(exit)
            {
                ++count;
                exit = FirstGame(numbers, count);
            }
        }
        private bool FirstGame(List<int> list, int count, int index = 0)
        {
            Random random = new Random();
            index = random.Next(0, list.Count);
            var result = MessageBox.Show($"Ваше загаданное число {list[index]}?", 
                $"попытка отгадать #{count}",
                MessageBoxButtons.YesNo, 
                MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                return true;
            }
            else if (result == DialogResult.No)
            {
                return false;
            }
            else
                return false;
        }
        private bool SecondGame()
        {

        }
    }
}
