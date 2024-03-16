using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using APPbank.Accounts;
using APPbank.Forms;
using Newtonsoft.Json;

namespace APPbank.Repository { 


    [Serializable]
    internal class AccountsRepository
    {
       
        public List<Account> Accounts { get; set; }


        // Konstruktor klasy AccountsRepository
        
        public AccountsRepository()
        {
            Accounts = new List<Account>();
        }

        public static AccountsRepository? AccountsRepositoryInstance { get; set; }

        
         // Funkcja zwracająca istniejącą instancję AccountsRepository lub pobiera ją z pliku w przypadku braku istniejącej instancji 
       
        public static AccountsRepository GetInstance()
        {
            if (AccountsRepositoryInstance == null)
            {
                //AccountsRepositoryInstance = new AccountsRepository();

                AccountsRepositoryInstance = FileHandler<AccountsRepository>.ReadFromJsonFile<AccountsRepository>("AccountBase.json");
            }
            System.Diagnostics.Debug.WriteLine(AccountsRepositoryInstance.Accounts);
            return AccountsRepositoryInstance;
        }

        
        // Funkcja dodająca konto do repozytorium
         
        public void AddAccount(Account account)
        {
            Accounts.Add(account);
        }

        
         // Funkcja usuwająca dane konto z repozytorium
         
        public void DeleteAccountByNumber(string accountNumber)
        {
            foreach (Account acc in Accounts)
            {
                
                if (acc.AccountNumber == accountNumber)
                {
                    Accounts.Remove(acc);
                    
                    MessageBox.Show("Usunięto konto");
                    return;
                }

                MessageBox.Show("Nie znaleziono konta");
            }
        }
        
        // Funkcja sprawdzająca, czy dane konto istnieje w repozytorium
        

        public bool Exists(string accountNumber)
        {
            foreach (Account account in Accounts)
            {
                if (account.AccountNumber == accountNumber)
                {
                    return true;
                }
            }

            return false;
        }

        
         // Funkcja służąca do pobierania konto o danym numerze z repozytorium
         
        public Account GetAccountByNumber(string number)
        {
            foreach (Account account in Accounts)
            {
                if (account.AccountNumber == number)
                {
                    return account;
                }
            }

            return null;
        }
    }
}
