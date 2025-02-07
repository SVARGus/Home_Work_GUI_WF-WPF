using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Home_and_Class_Work_31_01_2025_Library.Clases;
using Home_and_Class_Work_31_01_2025_Library.Data;

namespace Home_and_Class_Work_31_01_2025_Library
{
    public partial class LibraryStaffForm : Form
    {
        public LibraryStaffForm()
        {
            InitializeComponent();
            BookResurs.GetListBooks();
            UpdateAllListBox();
        }
        public void UpdateAllListBox()
        {
            var AllBooksListBox = UserResurs.GetListUsers();
            allBooksListBox.DataSource = null;
            allBooksListBox.DataSource = AllBooksListBox;
            // Релазиция обновления bookRequestsFromUsersListBox, после того как будет спроектирована логика и функционал формирования запроса книг

        }
    }
}
