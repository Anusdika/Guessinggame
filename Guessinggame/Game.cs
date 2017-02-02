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
    public partial class Game : Form
    {
        public Game()
        {
            InitializeComponent();
        }
        Bitmap[] Image = new Bitmap[52];

        int guess = 0;
        int winamount = 0;
        int points;
        int generate;
        char[] totalcredit = new char[2];
        private void Game_Load(object sender, EventArgs e)
        {
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.Show();

            cards();

            comBox1();
            comBox2();

            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            label11.Hide();
            label10.Hide();
            label12.Hide();
            
        }
        public void cards()
        {
            Image[0] = new Bitmap(Properties.Resources.aceclubs);
            Image[1] = new Bitmap(Properties.Resources.aceheart);
            Image[2] = new Bitmap(Properties.Resources.acespades);
            Image[3] = new Bitmap(Properties.Resources.acediamonds);
            Image[4] = new Bitmap(Properties.Resources._2clubs);
            Image[5] = new Bitmap(Properties.Resources._2hearts);
            Image[6] = new Bitmap(Properties.Resources._2spades);
            Image[7] = new Bitmap(Properties.Resources._2diamonds);
            Image[8] = new Bitmap(Properties.Resources._3clubs);
            Image[9] = new Bitmap(Properties.Resources._3Hearts);
            Image[10] = new Bitmap(Properties.Resources._3spades);
            Image[11] = new Bitmap(Properties.Resources._3diamonds);
            Image[12] = new Bitmap(Properties.Resources._4clubs);
            Image[13] = new Bitmap(Properties.Resources._4hearts);
            Image[14] = new Bitmap(Properties.Resources._4spades);
            Image[15] = new Bitmap(Properties.Resources._4diamonds);
            Image[16] = new Bitmap(Properties.Resources._5clubs);
            Image[17] = new Bitmap(Properties.Resources._5hearts);
            Image[18] = new Bitmap(Properties.Resources._5spades);
            Image[19] = new Bitmap(Properties.Resources._5diamonds);
            Image[20] = new Bitmap(Properties.Resources._6clubs);
            Image[21] = new Bitmap(Properties.Resources._6hearts);
            Image[22] = new Bitmap(Properties.Resources._6spades);
            Image[23] = new Bitmap(Properties.Resources._6diamonds);
            Image[24] = new Bitmap(Properties.Resources._7clubs);
            Image[25] = new Bitmap(Properties.Resources._7hearts);
            Image[26] = new Bitmap(Properties.Resources._7spades);
            Image[27] = new Bitmap(Properties.Resources._7diamonds);
            Image[28] = new Bitmap(Properties.Resources._8clubs);
            Image[29] = new Bitmap(Properties.Resources._8hearts);
            Image[30] = new Bitmap(Properties.Resources._8spades);
            Image[31] = new Bitmap(Properties.Resources._8diamonds);
            Image[32] = new Bitmap(Properties.Resources._9clubs);
            Image[33] = new Bitmap(Properties.Resources._9hearts);
            Image[34] = new Bitmap(Properties.Resources._9spades);
            Image[35] = new Bitmap(Properties.Resources._9diamonds);
            Image[36] = new Bitmap(Properties.Resources._10Clubs);
            Image[37] = new Bitmap(Properties.Resources._10hearts);
            Image[38] = new Bitmap(Properties.Resources._10spades);
            Image[39] = new Bitmap(Properties.Resources._10diamonds);
            Image[40] = new Bitmap(Properties.Resources.jack_clubs);
            Image[41] = new Bitmap(Properties.Resources.jack_hearts);
            Image[42] = new Bitmap(Properties.Resources.jack_spades);
            Image[43] = new Bitmap(Properties.Resources.jack_diamonds);
            Image[44] = new Bitmap(Properties.Resources.king_clubs);
            Image[45] = new Bitmap(Properties.Resources.king_hearts);
            Image[46] = new Bitmap(Properties.Resources.king_spades);
            Image[47] = new Bitmap(Properties.Resources.king_diamonds);
            Image[48] = new Bitmap(Properties.Resources.queen_clubs);
            Image[49] = new Bitmap(Properties.Resources.queen_hearts);
            Image[50] = new Bitmap(Properties.Resources.queen_spades);
            Image[51] = new Bitmap(Properties.Resources.queen_diamonds);
        }
        public void comBox1()
        {
            for(int a=0;a<=25;a++)
            {
                comboBox1.Items.Add(a);
            }
            comboBox1.Focus();

        }
        public void comBox2()
        {
            for(int b=1;b<=50;b++)
            {
                comboBox2.Items.Add(b);
            }
            
            comboBox2.Focus();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int combonum = Convert.ToInt32(comboBox1.Text);
            int combonum2 = Convert.ToInt32(comboBox2.Text);
            textBox_bet.Text = Convert.ToString(combonum * combonum2);
            textBox3_gamount.Text = textBox_bet.Text;
            int gamblewin = Convert.ToInt32(textBox_bet.Text);
            textBox4_gamwin.Text = Convert.ToString(gamblewin * 2);

            if (Image.Count() == 0)
            {
                MessageBox.Show("Play");
            }
            else

            {
                for (int i = 0; i <= combonum; i++)
                {
                    if (guess == combonum)
                    {
                        DialogResult dialogResult = MessageBox.Show("Do you continue game?","Game Over", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                        if(dialogResult==DialogResult.Yes)
                        {
                            total_value();
                            break;
                        }
                        if(dialogResult==DialogResult.No)
                        {
                            button_red.Enabled = false;
                            button_black.Enabled = false;
                            //button3.Enabled = false;
                            MessageBox.Show("Game Stop","Get your score",MessageBoxButtons.OK,MessageBoxIcon.Stop);
                            break;
                        }

                    }
                    else
                    {
                        Random num = new Random();
                        generate = num.Next(Image.Count());
                        pictureBox2.Image = Image[generate];

                    }

                }
            }
            pictureBox1.Show();
            pictureBox2.Hide();

            comboBox1.Enabled = false;
            comboBox2.Enabled = false;
            label10.Show();
            label11.Hide();
            label12.Hide();
        }

        public void deck()
        {
            guess++;

            pictureBox1.Hide();
            pictureBox2.Show();
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;

            if (guess == 1)
            {
                pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
                pictureBox3.Image = pictureBox2.Image;
            }
            if (guess == 2)
            {
                pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
                pictureBox4.Image = pictureBox2.Image;
            }
            if (guess == 3)
            {
                pictureBox5.SizeMode = PictureBoxSizeMode.StretchImage;
                pictureBox5.Image = pictureBox2.Image;
            }
            if (guess == 4)
            {
                pictureBox7.SizeMode = PictureBoxSizeMode.StretchImage;
                pictureBox7.Image = pictureBox2.Image;
            }
            if (guess >= 5)
            {
                pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
                pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
                pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
                pictureBox5.SizeMode = PictureBoxSizeMode.StretchImage;
                pictureBox7.SizeMode = PictureBoxSizeMode.StretchImage;
                pictureBox3.Image = pictureBox4.Image;
                pictureBox4.Image = pictureBox5.Image;
                pictureBox5.Image = pictureBox7.Image;
                pictureBox7.Image = pictureBox2.Image;
            }
        }
        private void button_black_Click(object sender, EventArgs e)
        {
            points = 1;
            deck();
            calculate();
        }

        private void button_red_Click(object sender, EventArgs e)
        {
            points = 2;
            deck();
            calculate();
        }

        public void calculate()
        {
            if(generate %2==0 && points==1)
            {
                winamount = winamount + Convert.ToInt32(comboBox2.Text);
                label12.Show();
            }
            if(generate %2==1 && points==2)
            {
                winamount = winamount + Convert.ToInt32(comboBox2.Text);
                label12.Show();
            }
            if(generate %2==0 && points==2)
            {
                label11.Show();
            }
            else
            {
                label11.Show();
            }
            textBox2_win.Text = winamount.ToString();

        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Game Gam = new Game();
            Gam.Show();
            this.Hide();
            textBox1_credit.Text = winamount.ToString();
        }

        public void total_value()
        {
            
            int[] value = new int[3];
            value[0] = Convert.ToInt32(this.textBox1_credit.Text);
            value[1] = Convert.ToInt32(this.textBox2_win.Text);
            value[2] = Convert.ToInt32(textBox2_win.Text);
            int answer = value[0] + value[1];

            Game G1 = new Game();
            G1.Show();
            this.Close();
            G1.textBox1_credit.Text = answer.ToString();
            G1.textBox1_lawin.Text = value[2].ToString();
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void finalResult()
        {
            System.Diagnostics.Process.Start("Notepad.exe", "Score_details.txt");
            String[] Output = { "Name of Player", "How many time played", "Bet amount", "Loose amount", "Corrent winning amount", "Last time winning amount", "Total score" };
            String[] val = new string[7];
            val[1] = comboBox1.Text;
            val[2] = textBox4_gamwin.Text;
            int a = Convert.ToInt32(textBox4_gamwin.Text);
            int b = Convert.ToInt32(textBox2_win.Text);
            int loose = a - b;
            val[3] = Convert.ToString(loose);
            val[4] = textBox2_win.Text;
            val[5] = textBox1_lawin.Text;
            int y = Convert.ToInt32(textBox1_credit.Text);
            int total = b + y;
            val[6] = Convert.ToString(total);

            using (System.IO.StreamWriter Result = new System.IO.StreamWriter("Score_details.txt"))
            {
                Result.WriteLine("\t\t\t\tScore Details");

                for(int s=1;s<7;s++)
                {
                    if (s == 1 || s == 4 || s == 5)
                    {
                        Result.WriteLine(Output[s] + "\t\t" + val[s]);
                    }
                    if(s==2||s==3||s==6)
                    {
                        Result.WriteLine(Output[s] + "\t\t\t" + val[s]);
                    }

                }
                Result.WriteLine(" ");
                Result.WriteLine("\t\t\t\t\tThank you");
            }
        }

        private void button4_collect_Click(object sender, EventArgs e)
        {
            finalResult();
            
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}

