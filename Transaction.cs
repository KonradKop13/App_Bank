using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using APPbank.Accounts;
using APPbank.Users;


namespace APPbank
{

    internal class Transaction
    {
        
     // Konstruktor klasy Transfer
   
        public Transaction(Account source, Account destination)
        {
            _source = source;
            _destination = destination;
        }

        private readonly Account _source;
        private readonly Account _destination;
        private readonly Session _session = Session.GetInstance();

      
        // Funkcja wyświetlająca informację o nieudanym przelewie środków
       
        void StopTransfer()
        {
           
            MessageBox.Show("Nie można sfinalizować transferu środków");
        }

        
        // Funkcja odpowiedzialna za transfer środków pomiędzy kontami
       
         
        public void TransferMoney(decimal amount)
        {
            decimal amount1 = amount;
            decimal amount2;
            if (_session.SessionMaster is Admin)
            {
                StopTransfer();
            }

            if (!_source.HasEnoughMoney(amount))
            {
                MessageBox.Show("Niewystarczająca liczba środków na koncje ");
                return;
            }
            
         
             if  (_destination.Currency == "PLN" || _source.Currency == "PLN")
            {
                _source.SubtractMoney(amount);
              
                
            }
            else
            {
                amount1 = decimal.Multiply(MoneyConverter.Convert(_destination.Currency, _source.Currency),amount);
                _source.SubtractMoney(amount1);
               
            }
                 amount2 = decimal.Multiply(MoneyConverter.Convert(_source.Currency, _destination.Currency), amount);
                 _destination.AddMoney(amount2);
                  

            AddToHistoru(amount1 , amount2);
            MessageBox.Show("Transfer przeprowadzony pomyślnie");

        }

        public void AddToHistoru(decimal amount , decimal amount2)
        {
            History historyDestination = new History(amount2, _source.Name);
            _destination.AccountHistory.Add(historyDestination);

            History historySource = new History(-amount, _destination.Name);
            _source.AccountHistory.Add(historySource);
        }
    }
}
