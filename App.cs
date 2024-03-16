using APPbank.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APPbank
{
    internal class App
    {
        public static void Oppen()
        {
            UsersRepository usersRepository = UsersRepository.GetInstance();
            AccountsRepository accountsRepository = AccountsRepository.GetInstance();
        }
    }
}
