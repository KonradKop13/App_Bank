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
using System.Text.RegularExpressions;

namespace APPbank.Forms
{
    public partial class ModifyMoneyOnAccountWindow : Form
    {
        public ModifyMoneyOnAccountWindow()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            AdminWindow adminWindow = new AdminWindow();
            adminWindow.Show();
            Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string accountNumber = textBox1.Text;
            string money = textBox2.Text;

            AccountsRepository accountsRepository = AccountsRepository.GetInstance();
            if(!accountsRepository.Exists(accountNumber))
            {
                MessageBox.Show("Nie znaleziono konta");
            }
            else
            {
                Account account = accountsRepository.GetAccountByNumber(accountNumber);
                var validateMoneyValue = new Regex(@"^(\d+)((\.)|(\,)\d{1,2})?$");
                if (validateMoneyValue.IsMatch(money))
                {
                    account.SubtractMoney(Convert.ToDecimal(money));
                    MessageBox.Show("Odjęti środki");
                }
                else
                {
                    MessageBox.Show("Niepoprawna wartość");
                }
            }
            AdminWindow adminWindow = new AdminWindow();
            adminWindow.Show();
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string accountNumber = textBox1.Text;
            string money = textBox2.Text;

            AccountsRepository accountsRepository = AccountsRepository.GetInstance();
            if(!accountsRepository.Exists(accountNumber))
            {
                MessageBox.Show("Nie znaleziono konta");
            }else
            {
                Account account = accountsRepository.GetAccountByNumber(accountNumber);
                var validateMoneyValue = new Regex(@"^(\d+)((\.)|(\,)\d{1,2})?$");
                if (validateMoneyValue.IsMatch(money))
                {
                    account.AddMoney(Convert.ToDecimal(money));
                    MessageBox.Show("Dodano środki");
                }
                else
                {
                    MessageBox.Show("Niepoprawna wartość");
                }
            }
            AdminWindow adminWindow = new AdminWindow();
            adminWindow.Show();
            Close();

        }
    }
}
