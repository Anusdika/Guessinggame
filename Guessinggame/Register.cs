using System;
using System.Windows.Forms;

namespace Guessinggame
{
    public partial class Register : Form
    {
        RegLink lgIn = new RegLink();
        public Register(RegLink llink)
        {
            InitializeComponent();
            lgIn = llink;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Register_Load(object sender, EventArgs e)
        {
            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox4.Text == textBox5.Text)
                if (!lgIn.RegisterUser(textBox1.Text, textBox3.Text,textBox5.Text))
                    MessageBox.Show("Login Existed Registration Failed","",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                else MessageBox.Show(" Login Registration Success","",MessageBoxButtons.OK,MessageBoxIcon.Asterisk);
            else MessageBox.Show("Confirmation Invalid Check the password","",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 First = new Form1();
            First.Show();
            this.Hide();
        }

        private void button_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
