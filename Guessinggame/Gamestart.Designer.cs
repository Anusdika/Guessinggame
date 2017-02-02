namespace Guessinggame
{
    partial class Gamestart
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.button1_play = new System.Windows.Forms.Button();
            this.button1_login = new System.Windows.Forms.Button();
            this.button_home = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Ravie", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label1.Location = new System.Drawing.Point(20, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(379, 50);
            this.label1.TabIndex = 1;
            this.label1.Text = "Card Guessing\r\n";
            // 
            // button1_play
            // 
            this.button1_play.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button1_play.BackColor = System.Drawing.Color.Transparent;
            this.button1_play.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button1_play.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1_play.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1_play.Font = new System.Drawing.Font("Rockwell Extra Bold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1_play.ForeColor = System.Drawing.Color.White;
            this.button1_play.Image = global::Guessinggame.Properties.Resources.Button_Play_icon1;
            this.button1_play.Location = new System.Drawing.Point(54, 128);
            this.button1_play.Margin = new System.Windows.Forms.Padding(0);
            this.button1_play.Name = "button1_play";
            this.button1_play.Size = new System.Drawing.Size(87, 81);
            this.button1_play.TabIndex = 2;
            this.button1_play.TabStop = false;
            this.button1_play.UseVisualStyleBackColor = false;
            this.button1_play.Click += new System.EventHandler(this.button1_play_Click);
            // 
            // button1_login
            // 
            this.button1_login.BackColor = System.Drawing.Color.Transparent;
            this.button1_login.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1_login.Font = new System.Drawing.Font("Rockwell Extra Bold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1_login.ForeColor = System.Drawing.Color.Transparent;
            this.button1_login.Image = global::Guessinggame.Properties.Resources.V_Card_icon;
            this.button1_login.Location = new System.Drawing.Point(54, 209);
            this.button1_login.Margin = new System.Windows.Forms.Padding(0);
            this.button1_login.Name = "button1_login";
            this.button1_login.Size = new System.Drawing.Size(87, 66);
            this.button1_login.TabIndex = 3;
            this.button1_login.TabStop = false;
            this.button1_login.UseVisualStyleBackColor = false;
            this.button1_login.Click += new System.EventHandler(this.button1_login_Click);
            // 
            // button_home
            // 
            this.button_home.BackColor = System.Drawing.Color.Transparent;
            this.button_home.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_home.ForeColor = System.Drawing.Color.Transparent;
            this.button_home.Image = global::Guessinggame.Properties.Resources.home_button;
            this.button_home.Location = new System.Drawing.Point(54, 278);
            this.button_home.Name = "button_home";
            this.button_home.Size = new System.Drawing.Size(87, 55);
            this.button_home.TabIndex = 4;
            this.button_home.TabStop = false;
            this.button_home.UseVisualStyleBackColor = false;
            this.button_home.Click += new System.EventHandler(this.button_home_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Ravie", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label2.Location = new System.Drawing.Point(348, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(157, 50);
            this.label2.TabIndex = 5;
            this.label2.Text = "Game";
            // 
            // Gamestart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Guessinggame.Properties.Resources.score;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(562, 409);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button_home);
            this.Controls.Add(this.button1_login);
            this.Controls.Add(this.button1_play);
            this.Controls.Add(this.label1);
            this.Name = "Gamestart";
            this.Text = "Gamestart";
            this.Load += new System.EventHandler(this.Gamestart_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1_play;
        private System.Windows.Forms.Button button1_login;
        private System.Windows.Forms.Button button_home;
        private System.Windows.Forms.Label label2;
    }
}