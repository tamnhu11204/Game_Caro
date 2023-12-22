namespace Game_Caro
{
    partial class SignUp
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
            this.pcb_SignUp = new System.Windows.Forms.PictureBox();
            this.lb_Title = new System.Windows.Forms.Label();
            this.lb_Username = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txb_Password = new System.Windows.Forms.TextBox();
            this.txb_Username = new System.Windows.Forms.TextBox();
            this.btn_SignUp = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pcb_SignUp)).BeginInit();
            this.SuspendLayout();
            // 
            // pcb_SignUp
            // 
            this.pcb_SignUp.Image = global::Game_Caro.Properties.Resources.background_SignUp;
            this.pcb_SignUp.Location = new System.Drawing.Point(-2, 0);
            this.pcb_SignUp.Name = "pcb_SignUp";
            this.pcb_SignUp.Size = new System.Drawing.Size(803, 448);
            this.pcb_SignUp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcb_SignUp.TabIndex = 0;
            this.pcb_SignUp.TabStop = false;
            // 
            // lb_Title
            // 
            this.lb_Title.AutoSize = true;
            this.lb_Title.BackColor = System.Drawing.Color.White;
            this.lb_Title.Font = new System.Drawing.Font("MS Reference Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Title.Location = new System.Drawing.Point(277, 18);
            this.lb_Title.Name = "lb_Title";
            this.lb_Title.Size = new System.Drawing.Size(186, 49);
            this.lb_Title.TabIndex = 1;
            this.lb_Title.Text = "Sign Up";
            // 
            // lb_Username
            // 
            this.lb_Username.AutoSize = true;
            this.lb_Username.BackColor = System.Drawing.Color.White;
            this.lb_Username.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Username.Location = new System.Drawing.Point(135, 92);
            this.lb_Username.Name = "lb_Username";
            this.lb_Username.Size = new System.Drawing.Size(102, 25);
            this.lb_Username.TabIndex = 2;
            this.lb_Username.Text = "Username";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(135, 139);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 25);
            this.label3.TabIndex = 3;
            this.label3.Text = "Password";
            // 
            // txb_Password
            // 
            this.txb_Password.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txb_Password.Location = new System.Drawing.Point(286, 138);
            this.txb_Password.Name = "txb_Password";
            this.txb_Password.Size = new System.Drawing.Size(268, 26);
            this.txb_Password.TabIndex = 4;
            // 
            // txb_Username
            // 
            this.txb_Username.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txb_Username.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txb_Username.Location = new System.Drawing.Point(286, 91);
            this.txb_Username.Name = "txb_Username";
            this.txb_Username.Size = new System.Drawing.Size(268, 26);
            this.txb_Username.TabIndex = 5;
            // 
            // btn_SignUp
            // 
            this.btn_SignUp.BackColor = System.Drawing.Color.LightBlue;
            this.btn_SignUp.Location = new System.Drawing.Point(333, 191);
            this.btn_SignUp.Name = "btn_SignUp";
            this.btn_SignUp.Size = new System.Drawing.Size(88, 44);
            this.btn_SignUp.TabIndex = 6;
            this.btn_SignUp.Text = "Sign Up";
            this.btn_SignUp.UseVisualStyleBackColor = false;
            this.btn_SignUp.Click += new System.EventHandler(this.btn_SignUp_Click);
            // 
            // SignUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_SignUp);
            this.Controls.Add(this.txb_Username);
            this.Controls.Add(this.txb_Password);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lb_Username);
            this.Controls.Add(this.lb_Title);
            this.Controls.Add(this.pcb_SignUp);
            this.Name = "SignUp";
            this.Text = "SignUp";
            ((System.ComponentModel.ISupportInitialize)(this.pcb_SignUp)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pcb_SignUp;
        private System.Windows.Forms.Label lb_Title;
        private System.Windows.Forms.Label lb_Username;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txb_Password;
        private System.Windows.Forms.TextBox txb_Username;
        private System.Windows.Forms.Button btn_SignUp;
    }
}