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
            textBoxDescription.Enabled = Enabled;
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
        }

        private void btSave_Click(object sender, EventArgs e)
        {
            IsEnable(false);
        }

        private void bookListBox_Click(object sender, EventArgs e)
        {
            if (bookListBox.SelectedItem is Book selectBook)
            {
                textBoxAuthor.Text = selectBook.Author;
                textBoxGenre.Text = selectBook.Genre;
                textBoxTitle.Text = selectBook.Title;
                textBoxPublisher.Text = selectBook.Publisher;
                textBoxDescription.Text = "Тестовая заглушка, сюда должен подгружаться ранее выбранный текст из отдельного файла для каждой книги";
            }
        }

        private void redBackgtoundToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
