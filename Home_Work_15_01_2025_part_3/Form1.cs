namespace Home_Work_15_01_2025_part_3
{
    /*
    ������� 
    ������� �� ����� ���� (�������!!!) ������ � ������� ������������������ MessageBox��� (������ �� ����� ����). 
    ������ �� ��������� ���������� ������ ������������ ������� ����� �������� �� �������� 
    (����� ���������� �������� � ������ / ���������� MessageBox���). 
    */
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string part1 = "�����������! ���� ����� ����� � � ���������� �����������!";
            string part2 = "���� �������: �++, ���, �������� ��������������, ����-������������, �#, SQL Server, Postgres, Git, .NET, ��������� HUI - WF, WPF, Qt.";
            string part3 = "� ���������� � ������� ���������� ��, � ����� ������� ����������� �������� ���������";
            string fullResume = part1 + part2 + part3;
            int numberCharacters = fullResume.Length;
            double averageNumberCharacters = numberCharacters / 3.0;
            MessageBox.Show(part1, "������ (����� 1)");
            MessageBox.Show(part2, "������ (����� 2)");
            MessageBox.Show(part3, $"������ (����� 3) - ������� ��������� {averageNumberCharacters}.");
        }
    }
}
