using Class_Work_31_01_2025_Library.Clases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_Work_31_01_2025_Library.Date
{
    public static class AccountResurses
    {
        private static List<LibraryAccount> listAccount;
        public static List<LibraryAccount> GetListAccount()
        {
            if (listAccount == null)
            {
                listAccount = new List<LibraryAccount>();
                listAccount.Add(new LibraryAccount("admin", "12345", "Admin", "admin", "+79219879635", AccountRoles.Admin));
            }
            return listAccount;
        }
        public static void AddAccount(LibraryAccount account, ListBox listBox)
        {
            listAccount.Add(account);
            listBox.Items.Add(account);
        }
        public static void DeleteAccount(LibraryAccount account, ListBox listBox)
        {
            listAccount.Remove(account);
            listBox.Items.Remove(account);
        }
        public static void EdeteAccount(LibraryAccount account, ListBox listBox)
        {
            listAccount.Remove(account);
            listBox.Items.Remove(account);
            listAccount.Add(account);
            listBox.Items.Add(account);
        }
    }
}
