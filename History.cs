using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APPbank
{
    internal class History
    {
        public decimal Amount { get; set; }
        public string AccountName { get; set; }
        


        public History(decimal amount, string accountName )
        {
            Amount = amount;
            AccountName = accountName;
           
        }

        public string HistoryText(History history)
        {
           string historyText = $"kwota :{history.Amount} na rzecz konta: {history.AccountName}";
            return historyText ;
        }

    }
}
