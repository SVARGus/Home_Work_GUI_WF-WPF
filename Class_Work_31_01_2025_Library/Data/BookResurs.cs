using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using Home_and_Class_Work_31_01_2025_Library.Clases;
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
        public static void LoadListBooks(string filePath = null)
        {
            if (filePath == null)
                filePath = FilePath;
            if (File.Exists(filePath))
            {
                try
                {
                    string strJson = File.ReadAllText(filePath);
                    List<Book> loadListBooks = JsonSerializer.Deserialize<List<Book>>(strJson);
                    listBooks = loadListBooks;
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ошибка при чтении файла {ex.Message}. Перезапустите программу!",
                    "Ошибка",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show($"Файл не найден по пути {filePath}. Закройте программу и обратитесь к администратору",
                    "Ошибка",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }
        public static void SaveListBooks(string filePath = null)
        {
            if (filePath == null)
                filePath = FilePath;
            string jsonStr = JsonSerializer.Serialize(listBooks, new JsonSerializerOptions
            {
                WriteIndented = true
            });
            File.WriteAllText(filePath, jsonStr);
        }
    }
}
