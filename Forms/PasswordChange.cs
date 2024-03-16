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
    public partial class PasswordChange : Form
    {
        public PasswordChange()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Visible = false;
            Form6 form6 = new();
            form6.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string password = textBox1.Text;
            Session session = Session.GetInstance();
            

            if (password is null || password == string.Empty)
            {
                MessageBox.Show("Proszę wpisać hasło");
            }
            else if (PasswordValidation.ValidatePassword(password))
            {
                MChangePassword changePassword = new(session.SessionMaster, password);
                changePassword.Execute();
                MessageBox.Show("Hasło zmienione");
                

                Form6 mainWindow = new();
                mainWindow.Show();
                Close();
            }




            string userInput = textBox1.Text;
            if (PasswordValidation.ValidatePassword(userInput))
            {

                Visible = false;
            }

        }

        
    }
}
