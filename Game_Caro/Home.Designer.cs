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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            this.pcb_home = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txb_Username = new System.Windows.Forms.TextBox();
            this.txb_Fullname = new System.Windows.Forms.TextBox();
            this.txb_Age = new System.Windows.Forms.TextBox();
            this.txb_Password = new System.Windows.Forms.TextBox();
            this.txb_Win = new System.Windows.Forms.TextBox();
            this.txb_Lose = new System.Windows.Forms.TextBox();
            this.btn_PlayGame = new System.Windows.Forms.Button();
            this.btn_LogOut = new System.Windows.Forms.Button();
            this.btn_Update = new System.Windows.Forms.Button();
            this.btn_Delete = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pcb_home)).BeginInit();
            this.SuspendLayout();
            // 
            // pcb_home
            // 
            this.pcb_home.Image = global::Game_Caro.Properties.Resources.background_pink;
            this.pcb_home.Location = new System.Drawing.Point(0, 1);
            this.pcb_home.Name = "pcb_home";
            this.pcb_home.Size = new System.Drawing.Size(801, 448);
            this.pcb_home.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcb_home.TabIndex = 0;
            this.pcb_home.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Image = global::Game_Caro.Properties.Resources.background_pink;
            this.label1.Location = new System.Drawing.Point(320, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(165, 50);
            this.label1.TabIndex = 1;
            this.label1.Text = "HOME";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Image = ((System.Drawing.Image)(resources.GetObject("label2.Image")));
            this.label2.Location = new System.Drawing.Point(66, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Username";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Image = ((System.Drawing.Image)(resources.GetObject("label3.Image")));
            this.label3.Location = new System.Drawing.Point(66, 172);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 25);
            this.label3.TabIndex = 3;
            this.label3.Text = "Password";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Image = ((System.Drawing.Image)(resources.GetObject("label4.Image")));
            this.label4.Location = new System.Drawing.Point(66, 226);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 25);
            this.label4.TabIndex = 4;
            this.label4.Text = "Fullname";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Image = ((System.Drawing.Image)(resources.GetObject("label5.Image")));
            this.label5.Location = new System.Drawing.Point(552, 170);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 25);
            this.label5.TabIndex = 5;
            this.label5.Text = "Win ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Image = ((System.Drawing.Image)(resources.GetObject("label6.Image")));
            this.label6.Location = new System.Drawing.Point(663, 170);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 25);
            this.label6.TabIndex = 6;
            this.label6.Text = "Lose";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Image = ((System.Drawing.Image)(resources.GetObject("label7.Image")));
            this.label7.Location = new System.Drawing.Point(66, 279);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 25);
            this.label7.TabIndex = 7;
            this.label7.Text = "Age";
            // 
            // txb_Username
            // 
            this.txb_Username.Location = new System.Drawing.Point(193, 115);
            this.txb_Username.Name = "txb_Username";
            this.txb_Username.ReadOnly = true;
            this.txb_Username.Size = new System.Drawing.Size(292, 26);
            this.txb_Username.TabIndex = 8;
            // 
            // txb_Fullname
            // 
            this.txb_Fullname.Location = new System.Drawing.Point(193, 225);
            this.txb_Fullname.Name = "txb_Fullname";
            this.txb_Fullname.Size = new System.Drawing.Size(292, 26);
            this.txb_Fullname.TabIndex = 9;
            // 
            // txb_Age
            // 
            this.txb_Age.Location = new System.Drawing.Point(193, 278);
            this.txb_Age.Name = "txb_Age";
            this.txb_Age.Size = new System.Drawing.Size(70, 26);
            this.txb_Age.TabIndex = 10;
            // 
            // txb_Password
            // 
            this.txb_Password.Location = new System.Drawing.Point(193, 171);
            this.txb_Password.Name = "txb_Password";
            this.txb_Password.Size = new System.Drawing.Size(292, 26);
            this.txb_Password.TabIndex = 11;
            // 
            // txb_Win
            // 
            this.txb_Win.Location = new System.Drawing.Point(557, 225);
            this.txb_Win.Name = "txb_Win";
            this.txb_Win.ReadOnly = true;
            this.txb_Win.Size = new System.Drawing.Size(42, 26);
            this.txb_Win.TabIndex = 12;
            // 
            // txb_Lose
            // 
            this.txb_Lose.Location = new System.Drawing.Point(668, 225);
            this.txb_Lose.Name = "txb_Lose";
            this.txb_Lose.ReadOnly = true;
            this.txb_Lose.Size = new System.Drawing.Size(42, 26);
            this.txb_Lose.TabIndex = 13;
            // 
            // btn_PlayGame
            // 
            this.btn_PlayGame.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_PlayGame.Location = new System.Drawing.Point(615, 375);
            this.btn_PlayGame.Name = "btn_PlayGame";
            this.btn_PlayGame.Size = new System.Drawing.Size(141, 42);
            this.btn_PlayGame.TabIndex = 14;
            this.btn_PlayGame.Text = "Play Game";
            this.btn_PlayGame.UseVisualStyleBackColor = true;
            this.btn_PlayGame.Click += new System.EventHandler(this.btn_PlayGame_Click);
            // 
            // btn_LogOut
            // 
            this.btn_LogOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_LogOut.Location = new System.Drawing.Point(71, 375);
            this.btn_LogOut.Name = "btn_LogOut";
            this.btn_LogOut.Size = new System.Drawing.Size(113, 42);
            this.btn_LogOut.TabIndex = 15;
            this.btn_LogOut.Text = "Log Out";
            this.btn_LogOut.UseVisualStyleBackColor = true;
            this.btn_LogOut.Click += new System.EventHandler(this.btn_LogOut_Click);
            // 
            // btn_Update
            // 
            this.btn_Update.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Update.Location = new System.Drawing.Point(258, 375);
            this.btn_Update.Name = "btn_Update";
            this.btn_Update.Size = new System.Drawing.Size(96, 42);
            this.btn_Update.TabIndex = 16;
            this.btn_Update.Text = "Update";
            this.btn_Update.UseVisualStyleBackColor = true;
            this.btn_Update.Click += new System.EventHandler(this.btn_Update_Click);
            // 
            // btn_Delete
            // 
            this.btn_Delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Delete.Location = new System.Drawing.Point(441, 375);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(89, 42);
            this.btn_Delete.TabIndex = 17;
            this.btn_Delete.Text = "Delete";
            this.btn_Delete.UseVisualStyleBackColor = true;
            this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Image = global::Game_Caro.Properties.Resources.background_pink;
            this.label8.Location = new System.Drawing.Point(554, 116);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(156, 29);
            this.label8.TabIndex = 18;
            this.label8.Text = "VS Computer";
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btn_Delete);
            this.Controls.Add(this.btn_Update);
            this.Controls.Add(this.btn_LogOut);
            this.Controls.Add(this.btn_PlayGame);
            this.Controls.Add(this.txb_Lose);
            this.Controls.Add(this.txb_Win);
            this.Controls.Add(this.txb_Password);
            this.Controls.Add(this.txb_Age);
            this.Controls.Add(this.txb_Fullname);
            this.Controls.Add(this.txb_Username);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pcb_home);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Home";
            this.Text = "Home";
            this.Load += new System.EventHandler(this.Home_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pcb_home)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pcb_home;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txb_Username;
        private System.Windows.Forms.TextBox txb_Fullname;
        private System.Windows.Forms.TextBox txb_Age;
        private System.Windows.Forms.TextBox txb_Password;
        private System.Windows.Forms.TextBox txb_Win;
        private System.Windows.Forms.TextBox txb_Lose;
        private System.Windows.Forms.Button btn_PlayGame;
        private System.Windows.Forms.Button btn_LogOut;
        private System.Windows.Forms.Button btn_Update;
        private System.Windows.Forms.Button btn_Delete;
        private System.Windows.Forms.Label label8;
    }
}