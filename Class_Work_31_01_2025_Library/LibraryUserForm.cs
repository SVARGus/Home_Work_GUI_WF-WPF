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
    public partial class LibraryUserForm : Form
    {
        public LibraryUserForm()
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
        private void bookListBox_Click(object sender, EventArgs e)
        {
            if (bookListBox.SelectedItem is Book selectBook)
            {
                textBoxAuthor.Text = selectBook.Author;
                textBoxGenre.Text = selectBook.Genre;
                textBoxTitle.Text = selectBook.Title;
                textBoxPublisher.Text = selectBook.Publisher;
                textBoxDescription.Text = selectBook.Description;
                textBoxDescription.ForeColor = Color.FromName(selectBook.TextColor);
                textBoxDescription.BackColor = Color.FromName(selectBook.TextBackGroundColor);
                textBoxDescription.Font = new Font(selectBook.TextFont, selectBook.TextSize);
            }
        }
    }
}
