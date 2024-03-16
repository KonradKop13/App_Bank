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
using APPbank.Users;


namespace APPbank
{
    public partial class Form3 : Form
    {
        private bool checking;
        private string password = "1234";
        public Form3()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }


        private void CreateAccount_Click(object sender, EventArgs e)
        {
            string login = textBox1.Text;
            string password = textBox2.Text;
            if (PasswordValidation.ValidatePassword(password))
            {
                MCreateNewUser create = new MCreateNewUser(login, password, checkingAdmin());
                create.Execute();
                Form1 form1 = new Form1();
                form1.Show();
                Visible = false;
            }

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox1.Checked)
            {
                textBox3.Visible = true;
                label4.Visible = true;
            }
            else
            {
                textBox3.Visible = false;
                label4.Visible = false;
            }
        }

        

        private void button5_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            Visible = false;
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private bool checkingAdmin()
        {
            if (checkBox1.Checked && textBox3.Text == "1234") 
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
