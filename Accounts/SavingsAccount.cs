using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using APPbank.Accounts;

namespace APPbank
{
    internal class SavingsAccount : Account
    {
        public decimal interestValue { get; set; }
        public TimeSpan interestSpan { get; set; }

        

        public void BalanceCounting()
        {
            interestValue = 0.6M ;
            Saldo = Saldo * interestValue;
            
        }

       
    }
}
