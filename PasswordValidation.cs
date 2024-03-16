using APPbank.Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace APPbank
{
    internal class PasswordValidation
    {
        public static bool ValidatePassword(string password)
        {
            var input = password;
            string ErrorMessage = string.Empty;

            if (string.IsNullOrWhiteSpace(input))
            {
                ErrorMessage = "Hasło nie może być puste";
                MessageBox.Show(ErrorMessage);
                return false;
            }

            var hasNumber = new Regex(@"[0-9]+");
            var hasUpperChar = new Regex(@"[A-Z]+");
            var hasMiniMaxChars = new Regex(@".{8,15}");
            var hasLowerChar = new Regex(@"[a-z]+");
            var hasSymbols = new Regex(@"[!@#$%^&*()_+=\[{\]};:<>|./?,-]");

            if (!hasLowerChar.IsMatch(input))
            {
                ErrorMessage = "Hasło powinno posiadać co najmniej jedną małą literę";
                MessageBox.Show(ErrorMessage);
                return false;
            }

            if (!hasUpperChar.IsMatch(input))
            {
                ErrorMessage = "Hasło powinno posiadać co najmniej jedną dużą literę";
                MessageBox.Show(ErrorMessage);
                return false;
            }

            if (!hasMiniMaxChars.IsMatch(input))
            {
                ErrorMessage = "Hasło powinno posiadać 8 do 15 znaków";
                MessageBox.Show(ErrorMessage);
                return false;
            }

            if (!hasNumber.IsMatch(input))
            {
                ErrorMessage = "Hasło powinno posiadać co najmniej jedną cyfrę";
                MessageBox.Show(ErrorMessage);
                return false;
            }

            if (!hasSymbols.IsMatch(input))
            {
                ErrorMessage = "Hasło powinno posiadać co najmniej jeden symbol specjalny";
                MessageBox.Show(ErrorMessage);
                return false;
            }
            
                return true;
            
            
        }
    }
}
