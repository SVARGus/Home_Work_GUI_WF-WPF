using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home_Work_20_01_2025_part_1
{
    // класс для работы с пользователями (добавление, удаление, редактирование, импорт/экспорт)
    // При необходимости можно выделить импорт и экспорт данных в отдельный класс или интерфейс с возможностью выбора стратегии действий (ТХТ, JSON, XML и другие типы данных)
    public class UserManager
    {
        public List<User> Users = new List<User>();
        string FilePath {  get; set; }
        // Методы для работы с User
        public void AddUser(User user) {  Users.Add(user); }
        public void RemoveUser(User user) { Users.Remove(user); }
        public void UpdateUser(User oldUser, User newUser)
        {
            // Написать реализацию
        }
        public List<User> GetUsers() { return Users; }
        // Методы ипорта/экспорта
        public List<User> LoadUsersFromJson(string json) // обработка JSON формата в User
        {
            // Переделать / Доделать реализацию
            return Users;
        }
        public string SaveUsersToJson() // Обработка User в формат JSON
        {
            // Переделать / Доделать реализацию
            string str = nameof(SaveUsersToJson);
            return str;
        }
        public void ImportFromTxt(string FilePath)
        {
            string strJson = SaveUsersToJson();
            File.WriteAllText(FilePath, strJson);
        }
        public void ExportToTxt(string FilePath)
        {
            if (File.Exists(FilePath))
            {
                try
                {
                    string strJson = File.ReadAllText(FilePath);
                    Users = LoadUsersFromJson(strJson);
                }
                catch(Exception ex)
                {
                    MessageBox.Show($"Ошебка при чтении файла {ex.Message}",
                    "Ошибка",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show($"Файл не найден по пути {FilePath}",
                    "Ошибка",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }
    }
}
