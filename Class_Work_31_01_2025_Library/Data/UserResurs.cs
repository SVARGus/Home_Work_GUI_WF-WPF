using Class_Work_31_01_2025_Library.Clases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_Work_31_01_2025_Library.Date
{
    public static class UserResurs
    {
        private static List<User> listUsers;
        private static string FilePath = "libraryUsers.json"; // Поле пока будет неизменным в проекте, позже добавить метод доступа к адрессу

        public static List<User> GetListUsers()
        {
            if (listUsers == null)
            {
                listUsers = new List<User>();
                listUsers.Add(new User("admin", "12345", "Admin", "admin", "+79219879635", UserRol.Admin));
            }
            return listUsers;
        }
        public static void AddAccount(User account, ListBox listBox)
        {
            listUsers.Add(account);
            listBox.Items.Add(account);
        }
        public static void DeleteAccount(User account, ListBox listBox)
        {
            listUsers.Remove(account);
            listBox.Items.Remove(account);
        }
        public static void EdeteAccount(User account, ListBox listBox)
        {
            listUsers.Remove(account);
            listBox.Items.Remove(account);
            listUsers.Add(account);
            listBox.Items.Add(account);
        }
    }
}
