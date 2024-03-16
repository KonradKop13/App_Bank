using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APPbank.Users
{
    internal class Admin : User
    {
        public Admin(string login, string password) : base(login, password)
        {
            Login = login;
            Password = password;
        }
    }
}
