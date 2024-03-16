using APPbank.Accounts;
using APPbank.Repository;
using APPbank.Users;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using APPbank.Accounts;
using System.Security.Principal;
using System.Text.RegularExpressions;
using System.Numerics;
using Microsoft.VisualBasic.Devices;

namespace APPbank.Forms
{
    public partial class TransferWindow : Form
    {
        public TransferWindow()
        {
            InitializeComponent();
            GetAccountList();
        }

        private readonly AccountsRepository _accountsRepository = AccountsRepository.GetInstance();
        private readonly UsersRepository _usersRepository = UsersRepository.GetInstance();
        private readonly Session _session = Session.GetInstance();
        private List<Account> _accounts = new();

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox1.Text = "Konto źródłowe";
        }


        // Funkcja pobierająca listę kont i przypisująca ją do odpowiedniej zmiennej
        private void GetAccountList()
        {
            List<Account> accounts = new();
            foreach (Account account in _accountsRepository.Accounts)
            {
                if (account.Owner.Login == _session.SessionMaster.Login)
                {
                    accounts.Add(account);
                    comboBox1.Items.Add(account.Name);
                }
            }
            _accounts = accounts;
            comboBox1.Items.Add(_accounts);
        }



        //Funkcja wykonująca przelew na podstawie danych wprowadzonych w polach okna lub wyświetlająca informacje o wprowadzeniu błędnych danych

        private void button1_Click(object sender, EventArgs e)
        {
            var correctMoneyValue = new Regex(@"^(\d+)((\.)|(\,)\d{1,2})?$");
            var amount = textBox1;
            var target = textBox2;
            int selectedIndex = comboBox1.SelectedIndex;
            string souceAccountName = string.Empty;

            if (selectedIndex >= 0 && selectedIndex < _accounts.Count)
            {
                if (_accounts[selectedIndex].Name != string.Empty || correctMoneyValue.IsMatch(amount.Text))
                {
                    souceAccountName = _accounts[selectedIndex].Name;
                }

                if (souceAccountName is null || target is null)
                {
                    MessageBox.Show("Nie wybrano konta źródłowego");
                }
                else if (AccountNumberValidation.ValidateNumber(target.Text))
                {
                    if (amount.Text == string.Empty || amount.Text is null || correctMoneyValue.IsMatch(amount.Text))
                    {
                        if (_accountsRepository.Exists(target.Text))
                        {
                            Account targetAccount = _accountsRepository.GetAccountByNumber(target.Text);
                            if (targetAccount.Owner is null)
                            {
                                MessageBox.Show("Nie znaleziono konta docelowego");
                            }
                            else
                            {
                                Account sourceAccount = GetSourceAccountByName(souceAccountName);

                                if (sourceAccount.Owner is null)
                                {
                                    MessageBox.Show("Nie znaleziono konta źródłowego");
                                }
                                else
                                {
                                    Transaction transfer = new Transaction(sourceAccount, targetAccount);
                                    transfer.TransferMoney(decimal.Parse(amount.Text));
                                    Form6 form6 = new();
                                    form6.Show();
                                    Close();
                                }
                            }
                        }
                        else
                        {
                            MessageBox.Show("Nie znaleziono konta docelowego");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Niewłaściwa kwota");
                    }
                }

            }
            else
            {
                MessageBox.Show("Prosze wybrać konto");
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        //Funkcja pobierająca konto użytkownika na podstawie nazwy konta

        private Account GetSourceAccountByName(string name)
        {
            foreach (User user in _usersRepository.Users)
            {
                foreach (Account account in _accounts)
                {
                    if (account.Name == name)
                    {
                        return account;
                    }
                }
            }
            return null;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form6 form6 = new Form6();
            form6.Show();
            Close();
        }
    }
}
