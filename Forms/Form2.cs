using APPbank.Forms;
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

namespace APPbank
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string login = textBox1.Text;
            string password = textBox2.Text;

            MLogin mLogin = new MLogin(login, password);

            if (mLogin.Execute())
            {

                if (mLogin.IsThisAnAdmin())
                {
                    AdminWindow mainWindow = new();
                    mainWindow.Show();
                    Visible = false;
                }
                else
                {
                    Form6 mainWindow = new();
                    mainWindow.Show();
                    Visible = false;
                }

            }

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form1 font1 = new();
            font1.Show();
            Visible = false;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
