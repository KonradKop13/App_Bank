using APPbank.Accounts;
using APPbank.Repository;


namespace APPbank
{
    public partial class Form1 : Form
    {
        private AccountsRepository _accountsRepository = AccountsRepository.GetInstance();
        public Form1()
        {
            InitializeComponent();
            monthCalendarSelsct();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.Show();
            Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
            Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form4 form4 = new Form4();
            form4.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {

            Form5 form5 = new Form5();
            form5.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Czy na pewno chcesz wyjœæ z naszego banku", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                Thread thread = new Thread(SaveDB);
                thread.Start();
                this.Close();
            }
                
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
           
            
        }

        public void monthCalendarSelsct()
        {
            if(monthCalendar1.TodayDate.Day == 1)
            {
                foreach (SavingsAccount account in _accountsRepository.Accounts)
                {
                    if (account is SavingsAccount)
                    {
                        account.BalanceCounting();
                    }

                }
            }
             

        }
        private void SaveDB()
        {
            FileHandler<AccountsRepository>.WriteToJsonFile("AccountBase.json", AccountsRepository.GetInstance());
            FileHandler<UsersRepository>.WriteToJsonFile("UserBase.json", UsersRepository.GetInstance());
        }
    }
}