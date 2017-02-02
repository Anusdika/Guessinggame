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
    public partial class Gamestart : Form
    {
        public RegLink LgIn = new RegLink();
        public Gamestart()
        {
            InitializeComponent();
          
        }
        
        private void button1_play_Click(object sender, EventArgs e)
        {
            Game Ga = new Game();
            Ga.Show();
            this.Close();
            
            
        }

        private void button_home_Click(object sender, EventArgs e)
        {
            Form1 hm = new Form1();
            hm.Show();
            this.Hide();
        }

        private void Gamestart_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_login_Click(object sender, EventArgs e)
        {
            Login L = new Login(LgIn);
            L.Show();
            this.Hide();
        }
    }
}
