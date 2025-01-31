/*
Задание 4
Разработать приложение, созданное на основе форме. 
■ Пользователь «щелкает» левой кнопкой мыши по форме и,
не отпуская кнопку, ведет по ней мышку, а в момент отпускания кнопки по полученным координатам прямоугольника (вам, конечно, известно, что двух точек на плоскости
достаточно для создания прямоугольника) необходимо создать «статик», который содержит свой порядковый номер
(имеется в виду порядок появления на форме).
■ Минимальный размер «статика» составляет 10х10, при попытке создания элемента меньших размеров пользователь
должен увидеть соответствующее предупреждение.
■ При щелчке правой кнопкой мыши над поверхностью
«статика» в заголовке окна должна появиться информация о его площади и координатах (относительно формы).
В случае, если в точке щелчка находится несколько «статиков», то предпочтение отдается «статику» с наибольшим
порядковым номером.
■ При двойном щелчке левой кнопки мыши над поверхностью «статика» он должен исчезнуть с формы. В случае,
если в точке щелчка находится несколько «статиков», то
предпочтение отдается «статику» с наименьшим порядковым номером
*/
namespace Home_Work_15_01_2025_part_5_StaticRectangle
{
    public partial class Form1 : Form
    {
        private Point startPoint;
        private Point endPoint;
        private Panel previewPanel;
        private bool isDrawing = false;
        public Form1()
        {
            InitializeComponent();
            this.MouseDown += Form1_MouseDown;
            this.MouseUp += Form1_MouseUp;
            this.MouseMove += Form1_MouseMove;
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                startPoint = e.Location;
                isDrawing = true;
                if(previewPanel == null)
                {
                    previewPanel = new Panel()
                    {
                        BorderStyle = BorderStyle.FixedSingle,
                        BackColor = Color.FromArgb(100, 59, 166, 241),
                        Visible = false
                    };
                    this.Controls.Add(previewPanel);
                }
            }
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            if (isDrawing)
            {
                isDrawing = false;
                previewPanel.Visible = false;
                Panel staticPanel = new Panel()
                {
                    Location = previewPanel.Location,
                    Size = previewPanel.Size,
                    BackColor = Color.FromArgb(59, 166, 241),
                    BorderStyle = BorderStyle.FixedSingle
                };
                this.Controls.Add(staticPanel);
            }
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (isDrawing)
            {
                endPoint = e.Location;
                int x = Math.Min(startPoint.X, endPoint.X);
                int y = Math.Min(startPoint.Y, endPoint.Y);
                int width = Math.Abs(startPoint.X - endPoint.X);
                int heigh = Math.Abs(startPoint.Y - endPoint.Y);
                previewPanel.SetBounds(x, y, width, heigh);
                previewPanel.Visible = true;
                this.Controls.Add(previewPanel);
            }
        }
    }
}
