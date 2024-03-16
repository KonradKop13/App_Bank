using APPbank.Accounts;
using APPbank.Forms;
using APPbank.Repository;
using APPbank.Users;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;

namespace APPbank
{
    public partial class Form6 : Form
    {
        private UsersRepository _usersRepository = UsersRepository.GetInstance();
        private AccountsRepository _accountsRepository = AccountsRepository.GetInstance();
        private Session _session = Session.GetInstance();


        public Form6()
        {
            InitializeComponent();
            label2.Text = $"{_session.Show()}";
            UpdateAccountsList();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Czy na pewno chcesz wyjść z naszego banku", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {

                Thread thread = new Thread(SaveDB);
                thread.Start();
                this.Close();
            }

        }

        private void button5_Click(object sender, EventArgs e)
        {
            PasswordChange passwordChange = new PasswordChange();
            passwordChange.Show();
            Close();
        }



        private void button2_Click(object sender, EventArgs e)
        {
            Form4 form4 = new Form4();
            form4.Show();

        }

        private void button7_Click(object sender, EventArgs e)
        {
            Form5 form5 = new Form5();
            form5.Show();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {


            if (_session.SessionMaster is not null)
            {
                this.textBox1.Text =
                    _session.SessionMaster.Login;
            }
            else
            {
                this.textBox1.Text = "Niezalogowany";
            }
        }



        private void button3_Click(object sender, EventArgs e)
        {
            CreateNewBankAccountWindow createNewUserAccount = new CreateNewBankAccountWindow();
            createNewUserAccount.Show();
            Close();
        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            var comboboxTappedItem = comboBox1.SelectedIndex;
            Account selectedAccount = _accounts[comboboxTappedItem];

            AccountInformationWindow accountInformationWindow = new AccountInformationWindow();
            accountInformationWindow.SetAccountCurrency(selectedAccount.Currency);
            accountInformationWindow.SetAccountName(selectedAccount.Name);
            accountInformationWindow.SetAccountNumber(selectedAccount.AccountNumber);
            accountInformationWindow.SetAccountValue(selectedAccount.Saldo.ToString());
            foreach (History history in selectedAccount.AccountHistory)
            {
                accountInformationWindow.UpdateHistoryList(history.HistoryText(history));
            }
            accountInformationWindow.Show();
        }
        private List<Account> _accounts;
        public void UpdateAccountsList()
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
        }


        private void button4_Click(object sender, EventArgs e)
        {
            TransferWindow transferWindow = new TransferWindow();
            transferWindow.Show();
            Close();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            DeleteAccountByNumberWindow deleteAccountByNumberWindow = new DeleteAccountByNumberWindow();
            deleteAccountByNumberWindow.Show();
            Close();
        }

        private void SaveDB()
        {
            FileHandler<AccountsRepository>.WriteToJsonFile("AccountBase.json", AccountsRepository.GetInstance());
            FileHandler<UsersRepository>.WriteToJsonFile("UserBase.json", UsersRepository.GetInstance());
        }
    }

}
