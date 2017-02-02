using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Guessinggame
{

    public partial class Login : Form
    {
       RegLink LgIn = new RegLink();
        public Login(RegLink llink)
        {
            InitializeComponent();
           LgIn = llink;
           
        }

        private void Login_Load(object sender, EventArgs e)
        {
            textBox2.Text = "";
            textBox2.PasswordChar = '*';
           

        }

        private void button_back_Click(object sender, EventArgs e)
        {
            Register R = new Register(LgIn);
            R.Show();
            this.Close();
        }

        private void button1_login_Click(object sender, EventArgs e)
        {
            if (LgIn.xml.FindInfo(textBox1.Text, textBox2.Text))
            {
                Gamestart G1 = new Gamestart();
                G1.Show();
                MessageBox.Show("Hi!"+ textBox1.Text + "Welcome");
                this.Hide();
            }
            else MessageBox.Show("Login/PassWord incorrect");
        }

        private void button_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
