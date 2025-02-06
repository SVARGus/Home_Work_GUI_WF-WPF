using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Class_Work_31_01_2025_Library.Clases;
using Home_and_Class_Work_31_01_2025_Library.Clases;

namespace Home_and_Class_Work_31_01_2025_Library.Data
{
    public static class BookResurs
    {
        private static List<Book> listBooks;
        private static string FilePath = "libraryBooks.json";
        public static List<Book> GetListBooks()
        {
            if (listBooks == null)
            {
                LoadListBooks();
                if (listBooks == null)
                {
                    listBooks = new List<Book>();
                }
            }
            return listBooks;
        }
        private static void LoadListBooks(string filePath = null)
        {
            if (filePath == null)
                filePath = FilePath;

        }
    }
}
