using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using APPbank.Accounts;

namespace APPbank.Users
{
    internal class Client : User
    {
        public List<Account> accountsList { get; set; }

        public Client(string login, string password) : base(login, password)
        {
            Login = login;
            Password = password;

        }
    }
}