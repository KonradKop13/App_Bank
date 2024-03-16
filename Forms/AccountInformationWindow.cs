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

namespace APPbank.Forms
{
    public partial class AccountInformationWindow : Form
    {
        public AccountInformationWindow()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {
        }

        private void label7_Click(object sender, EventArgs e)
        {
        }

        private void label6_Click(object sender, EventArgs e)
        {
        }

        private void label5_Click(object sender, EventArgs e)
        {
        }

        private void label4_Click(object sender, EventArgs e)
        {
        }

        private void label3_Click(object sender, EventArgs e)
        {
        }

        private void label9_Click(object sender, EventArgs e)
        {
        }

        private void label2_Click(object sender, EventArgs e)
        {
        }

        public void SetAccountName(string name)
        {
            label2.Text = name;
        }

        public void SetAccountNumber(string accountNumber)
        {
            label4.Text = accountNumber;
        }

        public void SetAccountCurrency(string currency)
        {
            label6.Text = currency;
        }

        public void SetAccountValue(string value)
        {
            label8.Text = value;
        }

       

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        public void SetAccountHistory(string value)
        {
            label8.Text = value;
        }

        public void UpdateHistoryList(string historyText)
        {
            comboBox1.Items.Add(historyText);
        }

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }
    }


}

