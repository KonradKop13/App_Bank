using APPbank.Accounts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APPbank.Users
{
    [Serializable]
    internal  class User
    {
        public string Login { get; set; }
        public string Password { get; set; }
        public bool IsAdmin { get; set; }
        public List<Account> accountsList { get; set; }

        public User(string login, string password)
        {
            Login = login;
            Password = password;
        }

    }
}
