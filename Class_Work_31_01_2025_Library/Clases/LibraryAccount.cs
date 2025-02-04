using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_Work_31_01_2025_Library.Clases
{
    public class LibraryAccount
    {
        public string Email { get; set; }
        public string Password { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Phone { get; set; }
        public AccountRoles Role { get; set; }
        public LibraryAccount() { }
        public LibraryAccount(string email, string password, string firstname, string lastname, string phone, AccountRoles role)
        {
            Password = password;
            FirstName = firstname;
            LastName = lastname;
            Email = email;
            Phone = phone;
            Role = role;
        }
        public override string ToString()
        {
            return $"Login: {Email}, Password: {Password}, Name: {FirstName} {LastName}, Phone: {Phone}, role: {Role.ToString()}.";
        }
    }
}
