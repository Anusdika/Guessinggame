using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            textBox1.Text = "";
            textBox2.Text = "";
            // The password character is an asterisk.
            textBox2.PasswordChar = '*';
            // The control will allow no more than 10 characters.
            textBox2.MaxLength = 10;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
