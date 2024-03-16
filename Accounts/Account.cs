using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using APPbank.Repository;
using APPbank.Users;

namespace APPbank.Accounts
{
    internal  class Account
    {
        public string AccountNumber { get; set; }
        public DateTime CreationDate { get; set; }
        public decimal Saldo { get; set; }
        public List<Transaction> History { get; set; }
        public User Owner { get; set; }
        public string? Name { get; set; }
        public string Currency { get; set; }
        public List<History> AccountHistory { get; set; }
        
       
        // Funkcja dodająca określoną ilość środków do konta

        public void AddMoney(decimal moneyToAdd)
        {
            Saldo = decimal.Add(Saldo, moneyToAdd);
        }

       
         // Funkcja sprawdzająca, czy konto posiada wystarczającą ilość środków do wykonania transferu
         
        public bool HasEnoughMoney(decimal amount)
        {
            if(amount <= Saldo)
            {
                return true;
            }
            else
            {
                return false;
            }
        } 

    
        //Funkcja odejmująca określoną ilość środków z konta
        public void SubtractMoney(decimal moneyToSubtract)
        {
            Saldo = decimal.Subtract(Saldo, moneyToSubtract);
        }

        


        //Funkcja uzyskująca informacje o właścicielu konta
        public User GetOwner()
        {
            foreach (var user in UsersRepository.GetInstance().Users)
            {
                if (user.Login == Owner.Login)
                {
                    return user;
                }
            }

            return null;
        }
    }
}
