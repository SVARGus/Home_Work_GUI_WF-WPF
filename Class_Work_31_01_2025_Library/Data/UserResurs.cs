using Class_Work_31_01_2025_Library.Clases;
using System;
using System.Collections.Generic;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Class_Work_31_01_2025_Library.Date
{
    public static class UserResurs
    {
        private static List<User> listUsers;
        private static string FilePath = "libraryUsers.json"; // Поле пока будет неизменным в проекте, позже добавить метод доступа к адрессу

        public static List<User> GetListUsers()
        {
            if (listUsers == null) // Если файл не загружен, то будет создан один единственный админ для тестирования программы
            {
                LoadListUsers(); // Загрузка базы пользователей из json файла
                if (listUsers == null)
                {
                    listUsers = new List<User>();
                    listUsers.Add(new User("admin", "12345", "Admin", "admin", "+79219879635", UserRol.Admin));
                }
            }
            return listUsers;
        }
        //public static void AddAccount(User account, ListBox listBox) // Удалить
        //{
        //    listUsers.Add(account);
        //    listBox.Items.Add(account);
        //}
        //public static void DeleteAccount(User account, ListBox listBox) // Удалить
        //{
        //    listUsers.Remove(account);
        //    listBox.Items.Remove(account);
        //}
        //public static void EdeteAccount(User account, ListBox listBox) // Удалить
        //{
        //    listUsers.Remove(account);
        //    listBox.Items.Remove(account);
        //    listUsers.Add(account);
        //    listBox.Items.Add(account);
        //}
        private static void LoadListUsers(string filePath = null)
        {
            if(filePath == null) 
                filePath = FilePath;
            // реализация загрузки файла
            if (File.Exists(filePath))
            {
                try
                {
                    string strJson = File.ReadAllText(filePath);
                    List<User> loadListUsers = JsonSerializer.Deserialize<List<User>>(strJson);
                    listUsers = loadListUsers;
                    //MessageBox.Show("Данные загружены", // Данный Мессандж бокс можно потом удалить, он для теста
                    //    "Load Users",
                    //    MessageBoxButtons.OK,
                    //    MessageBoxIcon.Information);
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
        public static void SaveListUsers(string filePath = null)
        {
            if (filePath == null)
                filePath = FilePath;
            string jsonStr = JsonSerializer.Serialize(listUsers, new JsonSerializerOptions
            {
                WriteIndented = true 
            });
            File.WriteAllText(filePath, jsonStr);
        }
    }
}
