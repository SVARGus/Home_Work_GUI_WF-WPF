using Home_and_Class_Work_31_01_2025_Library.Clases;
using Home_and_Class_Work_31_01_2025_Library.Data;
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
        string textFont;
        int textSize;
        Color textColor;
        Color backgroundColor;

        public LibraryStaffWorkerForm()
        {
            InitializeComponent();
            UpdateWorkerForm();
        }

        private void UpdateWorkerForm()
        {
            var ListBooks = BookResurs.GetListBooks();
            bookListBox.DataSource = null;
            bookListBox.DataSource = ListBooks;
            bookListBox.ClearSelected();
            textBoxAuthor.Text = string.Empty;
            textBoxGenre.Text = string.Empty;
            textBoxTitle.Text = string.Empty;
            textBoxPublisher.Text = string.Empty;
            textBoxDescription.Text = string.Empty;
            textBoxDescription.ForeColor = SystemColors.WindowText;
            textBoxDescription.BackColor = SystemColors.Window;
            textBoxDescription.Font = SystemFonts.DefaultFont;
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
            textBoxDescription.ReadOnly = !Enabled;
            btSave.Enabled = Enabled;
            fornStileToolStripMenuItem.Enabled = Enabled;
            btEdeteCreate.Enabled = !Enabled;
            if (Enabled)
            {
                btSave.BackColor = Color.Chartreuse;
                btEdeteCreate.BackColor = Color.Gray;
            }
            else
            {
                btSave.BackColor = Color.Gray;
                btEdeteCreate.BackColor = Color.Chartreuse;
            }
            bookListBox.Enabled = !Enabled;
        }

        private void btSave_Click(object sender, EventArgs e)
        {
            var saveBook = MessageBox.Show("Сохранить книгу?",
                "Сохранение",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);
            if (saveBook == DialogResult.Yes)
            {
                if (bookListBox.SelectedItem is Book selectBook)
                {
                    selectBook.Author = textBoxAuthor.Text;
                    selectBook.Genre = textBoxGenre.Text;
                    selectBook.Title = textBoxTitle.Text;
                    selectBook.Publisher = textBoxPublisher.Text;
                    selectBook.Description = textBoxDescription.Text;
                    selectBook.TextColor = textBoxDescription.ForeColor.Name;
                    selectBook.TextBackGroundColor = textBoxDescription.BackColor.Name;
                    selectBook.TextFont = textBoxDescription.Font.Name;
                    selectBook.TextSize = (int)textBoxDescription.Font.Size;
                }
                else
                {
                    var listBooks = BookResurs.GetListBooks();
                    var newBook = new Book(listBooks.Last().Id + 1,
                        textBoxTitle.Text,
                        textBoxAuthor.Text,
                        textBoxGenre.Text,
                        textBoxPublisher.Text,
                        textBoxDescription.Text,
                        textBoxDescription.Font.Name,
                        (int)textBoxDescription.Font.Size,
                        textBoxDescription.ForeColor.Name,
                        textBoxDescription.BackColor.Name);
                    listBooks.Add(newBook);
                }
            }
            
            IsEnable(false);
            UpdateWorkerForm();
        }

        private void bookListBox_Click(object sender, EventArgs e)
        {
            if (bookListBox.SelectedItem is Book selectBook)
            {
                textBoxAuthor.Text = selectBook.Author;
                textBoxGenre.Text = selectBook.Genre;
                textBoxTitle.Text = selectBook.Title;
                textBoxPublisher.Text = selectBook.Publisher;
                textBoxDescription.Text = selectBook.Description;
                textBoxDescription.ForeColor = textColor = Color.FromName(selectBook.TextColor);
                textBoxDescription.BackColor = backgroundColor = Color.FromName(selectBook.TextBackGroundColor);
                textFont = selectBook.TextFont;
                textSize = selectBook.TextSize;
                textBoxDescription.Font = new Font(textFont, textSize);
            }
        }

        private void arialFontToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBoxDescription.Font = new Font(textFont = "Arial", textSize);
        }

        private void timeNewRomanFontToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBoxDescription.Font = new Font(textFont = "Times New Roman", textSize);
        }

        private void calibriFontToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBoxDescription.Font = new Font(textFont = "Calibri", textSize);
        }

        private void brushScriptMTFontToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBoxDescription.Font = new Font(textFont = "Brush Script MT", textSize);
        }

        private void segoeUIFontToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBoxDescription.Font = new Font(textFont = "Segoe UI", textSize);
        }

        private void textSize8toolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBoxDescription.Font = new Font(textFont, textSize = 8);
        }

        private void textSize9toolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBoxDescription.Font = new Font(textFont, textSize = 9);
        }

        private void textSize10ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBoxDescription.Font = new Font(textFont, textSize = 10);
        }

        private void textSize12ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBoxDescription.Font = new Font(textFont, textSize = 12);
        }

        private void textSize14ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBoxDescription.Font = new Font(textFont, textSize = 14);
        }

        private void textSize16ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBoxDescription.Font = new Font(textFont, textSize = 16);
        }

        private void textSize18ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBoxDescription.Font = new Font(textFont, textSize = 18);
        }

        private void textSize20ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBoxDescription.Font = new Font(textFont, textSize = 20);
        }

        private void redTextToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBoxDescription.ForeColor = Color.Red;
        }

        private void orangeTextToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBoxDescription.ForeColor = Color.Orange;
        }

        private void yellowTextToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBoxDescription.ForeColor = Color.Yellow;
        }

        private void greenTextToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBoxDescription.ForeColor = Color.Green;
        }

        private void blueTextToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBoxDescription.ForeColor = Color.Blue;
        }

        private void purpleTextToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBoxDescription.ForeColor = Color.Purple;
        }

        private void blackTextToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBoxDescription.ForeColor = Color.Black;
        }

        private void whiteTextToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBoxDescription.ForeColor = Color.White;
        }

        private void redBackgtoundToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBoxDescription.BackColor = Color.Red;
        }

        private void orangeBackgtoundToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBoxDescription.BackColor = Color.Orange;
        }

        private void yellowBackgtoundToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBoxDescription.BackColor = Color.Yellow;
        }

        private void greenBackgtoundToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBoxDescription.BackColor = Color.Green;
        }

        private void blueBackgtoundToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBoxDescription.BackColor = Color.Blue;
        }

        private void purpleBackgtoundToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBoxDescription.BackColor = Color.Purple;
        }

        private void blackBackgtoundToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBoxDescription.BackColor = Color.Black;
        }

        private void whiteBackgtoundToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBoxDescription.BackColor = Color.White;
        }

        private void vivaldiFontToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBoxDescription.Font = new Font(textFont = "Vivaldi", textSize);
        }

        private void saveBaseBooksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BookResurs.SaveListBooks();
        }

        private void deleteBookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(bookListBox.SelectedItem == null)
            {
                MessageBox.Show("Вы не выбрали книгу для удаления", 
                    "Ошибка",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }
            var listBooks = BookResurs.GetListBooks();
            var questionDel = MessageBox.Show("Удалить книгу из базы?",
                "Удаление книги",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);
            if(questionDel == DialogResult.Yes)
            {
                listBooks.RemoveAt(bookListBox.SelectedIndex);
                UpdateWorkerForm();
            }
        }

        private void createBookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UpdateWorkerForm();
            IsEnable(true);
        }

        private void saveTextBookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxDescription.Text))
            {
                MessageBox.Show("Нет текста для сохранения.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Текстовые файлы (*.txt)|*.txt";
            saveFileDialog.FilterIndex = 1;
            // Создание дефолтного названия текста
            string author = textBoxAuthor.Text;
            string genre = textBoxGenre.Text;
            string title = textBoxTitle.Text;
            string publisher = textBoxPublisher.Text;
            string fileName = $"{title}_{author}_{genre}_{publisher}.txt";
            fileName = string.Join("_", fileName.Split(Path.GetInvalidFileNameChars())); // убераем спец символы
            saveFileDialog.FileName = fileName;
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    File.WriteAllText(saveFileDialog.FileName, textBoxDescription.Text);
                    MessageBox.Show("Файл успешно сохранен.",
                        "Успех",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ошибка при сохранении файла: {ex.Message}",
                        "Ошибка", 
                        MessageBoxButtons.OK, 
                        MessageBoxIcon.Error);
                }
            }
        }

        private void loadTextInBookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string TextFile = ""; OpenFileDialog open = new OpenFileDialog();
            open.Filter = "All txt files (*.txt)|*.txt";
            open.FilterIndex = 1;// по умолчанию фильтруются // текстовые файлы
            if (open.ShowDialog() == DialogResult.OK)
            {
                StreamReader reader = File.OpenText(open.FileName); 
                TextFile = reader.ReadToEnd(); // считываем файл до конца
                reader.Close(); // закрываем reader}
                textBoxDescription.Text = TextFile;
            }
        }
    }
}
