using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using APPbank.Repository;

namespace APPbank.FunctionalModules
{
    internal class MDeleteUser
    {
        private UsersRepository _usersRepository = UsersRepository.UsersRepositoryInstance;
        private string _login;

        
        public MDeleteUser(string login)
        {
            _login = login;
        }


        
         // FUNKCJA USUWAJĄCA DANEGO URZYTKOWNIKA Z BAZY DANYCH NA PODASTAWIE INFORMACJI PRZEKAZANYCH W  KONSTRUKTORZE
        
        public void Execute()
        {
            _usersRepository.DeleteUserByLogin(_login);
        }
    }
}
