using APPbank.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using APPbank.Accounts;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using APPbank.Users;

namespace APPbank.Forms
{
    public partial class DeleteAccountByNumberWindow : Form
    {
        private Session _session = Session.GetInstance();
        private readonly AccountsRepository _accountsRepository = AccountsRepository.GetInstance();
        public DeleteAccountByNumberWindow()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(_session.SessionMaster is Admin)
            {
                CheckAndDeletingAdmin();
            }
            else
            {
                CheckAndDeleting();
            }
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AdminWindow adminWindow = new AdminWindow();
            adminWindow.Show();
            Close();
        }

        public void CheckAndDeleting()
        {
            
            string accountNumber = textBox1.Text;
            

            foreach (Account account in _accountsRepository.Accounts)
            {
                if (account.Owner.Login == _session.SessionMaster.Login)
                {
                    if (account.AccountNumber == accountNumber)
                    {

                        _accountsRepository.DeleteAccountByNumber(accountNumber);
                        break;

                    }
                    else
                    {
                        MessageBox.Show("Niepoprawna wartość");
                        break;
                    }
                 }
            }


            Form6 form6 = new Form6();
            form6.Show();
            Close();

        }

        public void CheckAndDeletingAdmin()
        {
            AccountsRepository accountsRepository = AccountsRepository.GetInstance();
            string accountNumber = textBox1.Text;

            if (AccountNumberValidation.ValidateNumber(accountNumber))
            {
                accountsRepository.DeleteAccountByNumber(accountNumber);
            }
            else
            {
                MessageBox.Show("Niepoprawna wartość");
            }
            AdminWindow adminWindow = new AdminWindow();
            adminWindow.Show();
            Close();


        }

    }
}
