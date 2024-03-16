using APPbank;
using APPbank.Accounts;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace APPbank.Forms
{
    public partial class AdminWindow : Form
    {


        private readonly AccountsRepository _accountsRepository = AccountsRepository.GetInstance();
        private readonly UsersRepository _usersRepository = UsersRepository.GetInstance();



        public AdminWindow()
        {
            InitializeComponent();
            UpdateAccountsList();
            UpdateUsersList();
        }

        private void AdminWindow_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            GetUserLoginWindow getUserLoginWindow = new();
            getUserLoginWindow.Show();
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ModifyMoneyOnAccountWindow modifyMoneyOnAccountWindow = new();
            modifyMoneyOnAccountWindow.Show();
            Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DeleteAccountByNumberWindow deleteAccountByNumberWindow = new();
            deleteAccountByNumberWindow.Show();
            Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            form.Show();
            Close();
        }
        private List<Account> _accounts;
        public void UpdateAccountsList()
        {
            List<Account> accounts = new();
            foreach (Account account in _accountsRepository.Accounts)
            {

                accounts.Add(account);
                comboBox1.Items.Add(account.Name);

            }
            _accounts = accounts;
        }

        private List<User> _users;
        public void UpdateUsersList()
        {
            List<User> users = new List<User>();
            foreach (User user in _usersRepository.Users)
            {
                users.Add(user);
                comboBox2.Items.Add(user.Login);

            }
            _users = users;
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
        

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            var comboboxTappedItem = comboBox2.SelectedIndex;
            User selectedUser = _users[comboboxTappedItem];
            
            UserData userData = new UserData();
            userData.SetUpLogin(selectedUser.Login); 
            if (selectedUser.accountsList != null)
            {
                foreach (Account account in selectedUser.accountsList)
                {
                    userData.UpdateAccountsList(account.Name);
                }
            }
            userData.Show();
        }
    }
}


