namespace Game_Caro
{
    partial class LogIn
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LogIn));
            this.pnl_LogIn = new System.Windows.Forms.Panel();
            this.btn_LogIn = new System.Windows.Forms.Button();
            this.txb_Password = new System.Windows.Forms.TextBox();
            this.txb_Username = new System.Windows.Forms.TextBox();
            this.lb_Password = new System.Windows.Forms.Label();
            this.lb_LogIn = new System.Windows.Forms.Label();
            this.pcb_LogIn = new System.Windows.Forms.PictureBox();
            this.pnl_SignUp = new System.Windows.Forms.Panel();
            this.btn_SignUp = new System.Windows.Forms.Button();
            this.pcb_SignUp = new System.Windows.Forms.PictureBox();
            this.pnl_LogIn.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcb_LogIn)).BeginInit();
            this.pnl_SignUp.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcb_SignUp)).BeginInit();
            this.SuspendLayout();
            // 
            // pnl_LogIn
            // 
            this.pnl_LogIn.Controls.Add(this.btn_LogIn);
            this.pnl_LogIn.Controls.Add(this.txb_Password);
            this.pnl_LogIn.Controls.Add(this.txb_Username);
            this.pnl_LogIn.Controls.Add(this.lb_Password);
            this.pnl_LogIn.Controls.Add(this.lb_LogIn);
            this.pnl_LogIn.Controls.Add(this.pcb_LogIn);
            this.pnl_LogIn.Location = new System.Drawing.Point(225, 3);
            this.pnl_LogIn.Margin = new System.Windows.Forms.Padding(2);
            this.pnl_LogIn.Name = "pnl_LogIn";
            this.pnl_LogIn.Size = new System.Drawing.Size(317, 310);
            this.pnl_LogIn.TabIndex = 1;
            // 
            // btn_LogIn
            // 
            this.btn_LogIn.BackColor = System.Drawing.Color.Pink;
            this.btn_LogIn.Location = new System.Drawing.Point(119, 127);
            this.btn_LogIn.Margin = new System.Windows.Forms.Padding(2);
            this.btn_LogIn.Name = "btn_LogIn";
            this.btn_LogIn.Size = new System.Drawing.Size(68, 29);
            this.btn_LogIn.TabIndex = 5;
            this.btn_LogIn.Text = "Log In";
            this.btn_LogIn.UseVisualStyleBackColor = false;
            this.btn_LogIn.Click += new System.EventHandler(this.btn_LogIn_Click);
            // 
            // txb_Password
            // 
            this.txb_Password.Location = new System.Drawing.Point(110, 90);
            this.txb_Password.Margin = new System.Windows.Forms.Padding(2);
            this.txb_Password.Name = "txb_Password";
            this.txb_Password.Size = new System.Drawing.Size(147, 20);
            this.txb_Password.TabIndex = 4;
            // 
            // txb_Username
            // 
            this.txb_Username.Location = new System.Drawing.Point(110, 57);
            this.txb_Username.Margin = new System.Windows.Forms.Padding(2);
            this.txb_Username.Name = "txb_Username";
            this.txb_Username.Size = new System.Drawing.Size(147, 20);
            this.txb_Username.TabIndex = 3;
            // 
            // lb_Password
            // 
            this.lb_Password.AutoSize = true;
            this.lb_Password.BackColor = System.Drawing.Color.White;
            this.lb_Password.Location = new System.Drawing.Point(37, 94);
            this.lb_Password.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_Password.Name = "lb_Password";
            this.lb_Password.Size = new System.Drawing.Size(53, 13);
            this.lb_Password.TabIndex = 2;
            this.lb_Password.Text = "Password";
            // 
            // lb_LogIn
            // 
            this.lb_LogIn.AutoSize = true;
            this.lb_LogIn.BackColor = System.Drawing.Color.White;
            this.lb_LogIn.Location = new System.Drawing.Point(34, 61);
            this.lb_LogIn.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_LogIn.Name = "lb_LogIn";
            this.lb_LogIn.Size = new System.Drawing.Size(55, 13);
            this.lb_LogIn.TabIndex = 1;
            this.lb_LogIn.Text = "Username";
            // 
            // pcb_LogIn
            // 
            this.pcb_LogIn.Image = global::Game_Caro.Properties.Resources.background_SignUp;
            this.pcb_LogIn.Location = new System.Drawing.Point(2, -1);
            this.pcb_LogIn.Margin = new System.Windows.Forms.Padding(2);
            this.pcb_LogIn.Name = "pcb_LogIn";
            this.pcb_LogIn.Size = new System.Drawing.Size(315, 311);
            this.pcb_LogIn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcb_LogIn.TabIndex = 0;
            this.pcb_LogIn.TabStop = false;
            // 
            // pnl_SignUp
            // 
            this.pnl_SignUp.Controls.Add(this.btn_SignUp);
            this.pnl_SignUp.Controls.Add(this.pcb_SignUp);
            this.pnl_SignUp.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnl_SignUp.Location = new System.Drawing.Point(0, 0);
            this.pnl_SignUp.Margin = new System.Windows.Forms.Padding(2);
            this.pnl_SignUp.Name = "pnl_SignUp";
            this.pnl_SignUp.Size = new System.Drawing.Size(221, 315);
            this.pnl_SignUp.TabIndex = 0;
            // 
            // btn_SignUp
            // 
            this.btn_SignUp.BackColor = System.Drawing.Color.Pink;
            this.btn_SignUp.Location = new System.Drawing.Point(74, 131);
            this.btn_SignUp.Margin = new System.Windows.Forms.Padding(2);
            this.btn_SignUp.Name = "btn_SignUp";
            this.btn_SignUp.Size = new System.Drawing.Size(68, 29);
            this.btn_SignUp.TabIndex = 1;
            this.btn_SignUp.Text = "Sign Up";
            this.btn_SignUp.UseVisualStyleBackColor = false;
            this.btn_SignUp.Click += new System.EventHandler(this.btn_SignUp_Click);
            // 
            // pcb_SignUp
            // 
            this.pcb_SignUp.Image = global::Game_Caro.Properties.Resources.background_SignUp;
            this.pcb_SignUp.Location = new System.Drawing.Point(0, 2);
            this.pcb_SignUp.Margin = new System.Windows.Forms.Padding(2);
            this.pcb_SignUp.Name = "pcb_SignUp";
            this.pcb_SignUp.Size = new System.Drawing.Size(221, 311);
            this.pcb_SignUp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcb_SignUp.TabIndex = 0;
            this.pcb_SignUp.TabStop = false;
            // 
            // LogIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(547, 315);
            this.Controls.Add(this.pnl_LogIn);
            this.Controls.Add(this.pnl_SignUp);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "LogIn";
            this.Text = "LogIn";
            this.pnl_LogIn.ResumeLayout(false);
            this.pnl_LogIn.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcb_LogIn)).EndInit();
            this.pnl_SignUp.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pcb_SignUp)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_SignUp;
        private System.Windows.Forms.Panel pnl_LogIn;
        private System.Windows.Forms.PictureBox pcb_SignUp;
        private System.Windows.Forms.Button btn_SignUp;
        private System.Windows.Forms.PictureBox pcb_LogIn;
        private System.Windows.Forms.Label lb_Password;
        private System.Windows.Forms.Label lb_LogIn;
        private System.Windows.Forms.TextBox txb_Password;
        private System.Windows.Forms.TextBox txb_Username;
        private System.Windows.Forms.Button btn_LogIn;
    }
}