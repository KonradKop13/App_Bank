using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace APPbank
{
    internal class MoneyConverter
    {
       
     // Statyczna funkcja obliczająca przelicznik wymiany walut
    
        public static decimal Convert(string sourceCurrency, string destinationCurrency)
        {
            decimal source = GetExchangeRate(sourceCurrency);
            decimal destination = GetExchangeRate(destinationCurrency);
            return decimal.Divide(source, destination);
        }
        

        // Funkcja odczytująca kurs danej waluty

        private static decimal GetExchangeRate(string currencyName)
        {
            switch (currencyName)
            {
                case "PLN":
                    {
                        return System.Convert.ToDecimal(1);
                    }
                case "USD":
                    {
                        return System.Convert.ToDecimal(4.4);
                    }
                case "CHF":
                    {
                        return System.Convert.ToDecimal(4.55);
                    }
                case "EUR":
                    {
                        return System.Convert.ToDecimal(4.64);
                    }
            }

            return 1;
        }
       
    }
}
