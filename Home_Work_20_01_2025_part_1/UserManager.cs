using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Home_Work_20_01_2025_part_1
{
    // класс для работы с пользователями (добавление, удаление, редактирование, импорт/экспорт)
    // При необходимости можно выделить импорт и экспорт данных в отдельный класс или интерфейс с возможностью выбора стратегии действий (ТХТ, JSON, XML и другие типы данных)
    public class UserManager
    {
        public List<User> Users = new List<User>();
        public string FilePath {  get; set; }
        // Методы для работы с User
        public void AddUser(User user) {  Users.Add(user); }
        //public void RemoveUser(User user) { Users.Remove(user); }
        //public void UpdateUser(User oldUser, User newUser)
        //{
        //    int index = Users.IndexOf(oldUser);
        //    if (index != -1)
        //    {
        //        Users[index] = newUser;
        //    }
        //}
        public List<User> GetUsers() { return Users; }
        // Методы ипорта/экспорта
        public List<User> LoadUsersFromJson(string json) // обработка JSON формата в User
        {
            List<User> users = JsonSerializer.Deserialize<List<User>>(json);
            return users;
        }
        public string SaveUsersToJson() // Обработка User в формат JSON
        {
            string jsonStr = JsonSerializer.Serialize(Users);
            return jsonStr;
        }
        public void ImportFromTxt(string filePath = null)
        {
            if (filePath == null)
                filePath = FilePath;
            string strJson = SaveUsersToJson();
            File.WriteAllText(filePath, strJson);
            MessageBox.Show("Данные успешно сохранены",
                        "Save Users",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
        }
        public void ExportToTxt(string filePath = null)
        {
            if (filePath == null)
                filePath = FilePath;
            if (File.Exists(filePath))
            {
                try
                {
                    string strJson = File.ReadAllText(filePath);
                    Users = LoadUsersFromJson(strJson);
                    MessageBox.Show("Данные загружены",
                        "Load Users",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
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
                MessageBox.Show($"Файл не найден по пути {filePath}",
                    "Ошибка",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }
    }
}
