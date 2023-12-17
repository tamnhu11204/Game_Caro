namespace Game_Caro
{
    partial class Home
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_Play = new System.Windows.Forms.Button();
            this.lb_ID1 = new System.Windows.Forms.Label();
            this.lb_Username1 = new System.Windows.Forms.Label();
            this.lb_Win = new System.Windows.Forms.Label();
            this.txb_ID = new System.Windows.Forms.TextBox();
            this.txb_Username2 = new System.Windows.Forms.TextBox();
            this.txb_Win = new System.Windows.Forms.TextBox();
            this.lb_Lose = new System.Windows.Forms.Label();
            this.btn_LogOut = new System.Windows.Forms.Button();
            this.txb_Lose = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::Game_Caro.Properties.Resources.background_SignUp;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(928, 534);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btn_Play
            // 
            this.btn_Play.BackColor = System.Drawing.Color.Pink;
            this.btn_Play.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Play.Location = new System.Drawing.Point(394, 389);
            this.btn_Play.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_Play.Name = "btn_Play";
            this.btn_Play.Size = new System.Drawing.Size(147, 52);
            this.btn_Play.TabIndex = 1;
            this.btn_Play.Text = "Play game";
            this.btn_Play.UseVisualStyleBackColor = false;
            this.btn_Play.Click += new System.EventHandler(this.btn_Play_Click);
            // 
            // lb_ID1
            // 
            this.lb_ID1.AutoSize = true;
            this.lb_ID1.BackColor = System.Drawing.Color.White;
            this.lb_ID1.Location = new System.Drawing.Point(109, 64);
            this.lb_ID1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_ID1.Name = "lb_ID1";
            this.lb_ID1.Size = new System.Drawing.Size(26, 20);
            this.lb_ID1.TabIndex = 2;
            this.lb_ID1.Text = "ID";
            // 
            // lb_Username1
            // 
            this.lb_Username1.AutoSize = true;
            this.lb_Username1.BackColor = System.Drawing.Color.White;
            this.lb_Username1.Location = new System.Drawing.Point(109, 109);
            this.lb_Username1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_Username1.Name = "lb_Username1";
            this.lb_Username1.Size = new System.Drawing.Size(83, 20);
            this.lb_Username1.TabIndex = 3;
            this.lb_Username1.Text = "Username";
            // 
            // lb_Win
            // 
            this.lb_Win.AutoSize = true;
            this.lb_Win.BackColor = System.Drawing.Color.White;
            this.lb_Win.Location = new System.Drawing.Point(109, 162);
            this.lb_Win.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_Win.Name = "lb_Win";
            this.lb_Win.Size = new System.Drawing.Size(36, 20);
            this.lb_Win.TabIndex = 4;
            this.lb_Win.Text = "Win";
            // 
            // txb_ID
            // 
            this.txb_ID.Location = new System.Drawing.Point(272, 58);
            this.txb_ID.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txb_ID.Name = "txb_ID";
            this.txb_ID.Size = new System.Drawing.Size(140, 26);
            this.txb_ID.TabIndex = 5;
            // 
            // txb_Username2
            // 
            this.txb_Username2.Location = new System.Drawing.Point(272, 106);
            this.txb_Username2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txb_Username2.Name = "txb_Username2";
            this.txb_Username2.Size = new System.Drawing.Size(269, 26);
            this.txb_Username2.TabIndex = 6;
            // 
            // txb_Win
            // 
            this.txb_Win.Location = new System.Drawing.Point(272, 156);
            this.txb_Win.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txb_Win.Name = "txb_Win";
            this.txb_Win.Size = new System.Drawing.Size(140, 26);
            this.txb_Win.TabIndex = 7;
            // 
            // lb_Lose
            // 
            this.lb_Lose.AutoSize = true;
            this.lb_Lose.BackColor = System.Drawing.Color.White;
            this.lb_Lose.Location = new System.Drawing.Point(109, 212);
            this.lb_Lose.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_Lose.Name = "lb_Lose";
            this.lb_Lose.Size = new System.Drawing.Size(44, 20);
            this.lb_Lose.TabIndex = 8;
            this.lb_Lose.Text = "Lose";
            // 
            // btn_LogOut
            // 
            this.btn_LogOut.BackColor = System.Drawing.Color.Red;
            this.btn_LogOut.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_LogOut.Location = new System.Drawing.Point(412, 480);
            this.btn_LogOut.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_LogOut.Name = "btn_LogOut";
            this.btn_LogOut.Size = new System.Drawing.Size(112, 35);
            this.btn_LogOut.TabIndex = 9;
            this.btn_LogOut.Text = "Log out";
            this.btn_LogOut.UseVisualStyleBackColor = false;
            this.btn_LogOut.Click += new System.EventHandler(this.btn_LogOut_Click);
            // 
            // txb_Lose
            // 
            this.txb_Lose.Location = new System.Drawing.Point(272, 206);
            this.txb_Lose.Name = "txb_Lose";
            this.txb_Lose.Size = new System.Drawing.Size(140, 26);
            this.txb_Lose.TabIndex = 10;
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(928, 534);
            this.Controls.Add(this.txb_Lose);
            this.Controls.Add(this.btn_LogOut);
            this.Controls.Add(this.lb_Lose);
            this.Controls.Add(this.txb_Win);
            this.Controls.Add(this.txb_Username2);
            this.Controls.Add(this.txb_ID);
            this.Controls.Add(this.lb_Win);
            this.Controls.Add(this.lb_Username1);
            this.Controls.Add(this.lb_ID1);
            this.Controls.Add(this.btn_Play);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Home";
            this.Text = "Home";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btn_Play;
        private System.Windows.Forms.Label lb_ID1;
        private System.Windows.Forms.Label lb_Username1;
        private System.Windows.Forms.Label lb_Win;
        private System.Windows.Forms.TextBox txb_ID;
        private System.Windows.Forms.TextBox txb_Username2;
        private System.Windows.Forms.TextBox txb_Win;
        private System.Windows.Forms.Label lb_Lose;
        private System.Windows.Forms.Button btn_LogOut;
        private System.Windows.Forms.TextBox txb_Lose;
    }
}