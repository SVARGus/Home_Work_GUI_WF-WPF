/*
 �������
�������� �������, ������� ���������� ���������� ��������-
����� ����� �� 1 �� 2000. ��� ������� � ������������ ������������
MessageBox. ����� ����, ��� ����� ��������, ���������� �������
���������� ��������, ��������������� ��� �����, � ������������
������������ ����������� ������� ��� ���, �� ������ �� ���������
(MessageBox�� ����������� �������� � �������� ��������������
��������).
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
                e.Handled = true; // ��������� ����
            }
        }

        private void buttonGame1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxEnterNum.Text) || !int.TryParse(textBoxEnterNum.Text, out int inputUpNumSearch) || inputUpNumSearch <= 1)
            {
                MessageBox.Show("��������� ������ ��� ������ ��������� �����������!\n������������ �������� ������ ���� ������ ��� 1", 
                    "������", 
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }
            if(inputUpNumSearch > 200)
            {
                MessageBox.Show("�������� ������� �������, ����� ����� ����� ���������!\n��������� �������� �� 200",
                    "������",
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
            var result = MessageBox.Show($"���� ���������� ����� {list[index]}?", 
                $"������� �������� #{count}",
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
