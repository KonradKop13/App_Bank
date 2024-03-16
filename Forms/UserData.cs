using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace APPbank.Forms
{
    public partial class UserData : Form
    {
        public UserData()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        public void SetUpLogin(string login)
        {
            label3.Text = login;
        }



        public void UpdateAccountsList(string account)
        {
            comboBox1.Items.Add(account);
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {
        }
    }
}
