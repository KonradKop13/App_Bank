using APPbank.Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace APPbank
{
    internal class AccountNumberValidation
    {

    // Stayczna funkcja sprawdzająca, czy przekazany numer konta spełnia wymagania

        public static bool ValidateNumber(string accountNumber)
        {
            var input = accountNumber;
            string ErrorMessage = string.Empty;

            if (string.IsNullOrWhiteSpace(input))
            {
                ErrorMessage = "Proszę wpisać numer konta";
                MessageBox.Show(ErrorMessage);
                return false;
            }

            var correctLenghtAndOnlyNumbers = new Regex(@"^[0-9]{11}$");

            if (!correctLenghtAndOnlyNumbers.IsMatch(input))
            {
                ErrorMessage = "Niewłaściwa składnia numeru konta";
                MessageBox.Show(ErrorMessage);
                return false;
            }


            return true;
        }
    }
}
