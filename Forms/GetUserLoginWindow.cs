using APPbank.FunctionalModules;
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
    public partial class GetUserLoginWindow : Form
    {
        public GetUserLoginWindow()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AdminWindow adminWindow = new AdminWindow();
            adminWindow.Show();
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string userLogin = textBox1.Text;

            MDeleteUser deleteUser = new MDeleteUser(userLogin);
            deleteUser.Execute();
            AdminWindow adminWindow = new AdminWindow();
            adminWindow.Show();
            Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
