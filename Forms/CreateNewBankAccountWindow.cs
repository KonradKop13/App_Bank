using APPbank.Accounts;
using APPbank.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace APPbank.Forms
{
    public partial class CreateNewBankAccountWindow : Form
    {
        public CreateNewBankAccountWindow()
        {
            InitializeComponent();
            comboBox1.Items.AddRange(new object[] { "Konto walutowe", "Konto oszczędnościowe", "Konto osobliste" });

        }

        private Session _session = Session.GetInstance();
        private bool _foreignCurrencyListVisibility;
        private Account _account;

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text is not null && comboBox1.SelectedItem! is not null)
            {
                string name = textBox1.Text;
                FinalizeCreatingAccount(comboBox1.SelectedItem!.ToString(), name);

            }
            else
            {
                MessageBox.Show("Proszę wprowadzić wymagane dane");
            }
        }

        void FinalizeCreatingAccount(string accountType, string accountName)
        {
            List<History> history = new List<History>();
            switch (accountType)
            {
                case "Konto oszczędnościowe":
                    {
                        _account = new SavingsAccount();
                        _account.Currency = "PL";
                        break;
                    }
                case "Konto walutowe":
                    {
                        _account = new ForeignCurrenceAccount();
                        _account.Currency = comboBox2.SelectedItem!.ToString();

                        break;
                    }
                case "Konto osobliste":
                    {
                        _account = new PersonalAccount();
                        _account.Currency = "PLN";
                        break;
                    }
            }
            _account.AccountHistory = history;
            _account.Owner = _session.SessionMaster;
            _account.Name = accountName;
            _account.AccountNumber = GenerateAccountNumber();
            _account.Saldo = 1000;
            AddAccountToRepository(_account);

            Form6 mainWindow = new();
            mainWindow.Show();
            Close();
        }

        void AddAccountToRepository(Account account)
        {
            AccountsRepository accountsRepository = AccountsRepository.GetInstance();
            accountsRepository.AddAccount(account);
        }

        private string GenerateAccountNumber()
        {
            var stringBuilder = new StringBuilder();
            Random random = new();

            for (int i = 0; i < 11; i++)
            {
                stringBuilder.Append(random.Next(0, 9));
            }

            return stringBuilder.ToString();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem!.ToString() == "Konto walutowe")
            {
                UpdateForeignCurrencyListVisibility();
            }

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void comboBox2_OnTapped(object sender, EventArgs e)
        {

        }

        private void UpdateForeignCurrencyListVisibility()
        {
            comboBox2.Visible = true;
            label4.Visible = true;
            comboBox2.Items.AddRange(new object[] { "PLN", "USD", "CHF", "EUR" });
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form6 form6 =new Form6();
            form6.Show();
            Close();
        }
    }
}
