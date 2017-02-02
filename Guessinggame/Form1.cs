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
    public partial class Form1 : Form
    {
        public RegLink LgIn = new RegLink();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Login F1 = new Login(LgIn);
            F1.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_hwply_Click(object sender, EventArgs e)
        {
            Help H1 = new Help();
            H1.Show();
        }
    }
}
