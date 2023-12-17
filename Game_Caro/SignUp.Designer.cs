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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SignUp));
            this.pcb_SignUp1 = new System.Windows.Forms.PictureBox();
            this.lb_Username1 = new System.Windows.Forms.Label();
            this.lb_Password1 = new System.Windows.Forms.Label();
            this.txb_Username1 = new System.Windows.Forms.TextBox();
            this.txb_Password1 = new System.Windows.Forms.TextBox();
            this.btn_SignUp1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pcb_SignUp1)).BeginInit();
            this.SuspendLayout();
            // 
            // pcb_SignUp1
            // 
<<<<<<< HEAD
            this.pcb_SignUp1.Image = global::Game_Caro.Properties.Resources.background_SignUp;
            this.pcb_SignUp1.Location = new System.Drawing.Point(9, 5);
=======

            this.pcb_SignUp1.Image = global::Game_Caro.Properties.Resources.background_SignUp;
            this.pcb_SignUp1.Location = new System.Drawing.Point(9, 5);
            this.pcb_SignUp1.Location = new System.Drawing.Point(6, 3);
            this.pcb_SignUp1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);


            this.pcb_SignUp1.Image = global::Game_Caro.Properties.Resources.background_SignUp;
            this.pcb_SignUp1.Location = new System.Drawing.Point(9, 5);

            this.pcb_SignUp1.Location = new System.Drawing.Point(6, 3);
            this.pcb_SignUp1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);

>>>>>>> 7966dc77325cc4000dc0544e3509a91fd6b623ca
            this.pcb_SignUp1.Name = "pcb_SignUp1";
            this.pcb_SignUp1.Size = new System.Drawing.Size(783, 438);
            this.pcb_SignUp1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcb_SignUp1.TabIndex = 0;
            this.pcb_SignUp1.TabStop = false;
            // 
            // lb_Username1
            // 
            this.lb_Username1.AutoSize = true;
            this.lb_Username1.BackColor = System.Drawing.Color.White;
            this.lb_Username1.Location = new System.Drawing.Point(178, 109);
            this.lb_Username1.Name = "lb_Username1";
            this.lb_Username1.Size = new System.Drawing.Size(83, 20);
            this.lb_Username1.TabIndex = 2;
            this.lb_Username1.Text = "Username";
            // 
            // lb_Password1
            // 
            this.lb_Password1.AutoSize = true;
            this.lb_Password1.BackColor = System.Drawing.Color.White;
            this.lb_Password1.Location = new System.Drawing.Point(178, 145);
            this.lb_Password1.Name = "lb_Password1";
            this.lb_Password1.Size = new System.Drawing.Size(78, 20);
            this.lb_Password1.TabIndex = 3;
            this.lb_Password1.Text = "Password";
            // 
            // txb_Username1
            // 
            this.txb_Username1.Location = new System.Drawing.Point(303, 103);
            this.txb_Username1.Name = "txb_Username1";
            this.txb_Username1.Size = new System.Drawing.Size(288, 26);
            this.txb_Username1.TabIndex = 4;
            // 
            // txb_Password1
            // 
            this.txb_Password1.Location = new System.Drawing.Point(303, 138);
            this.txb_Password1.Name = "txb_Password1";
            this.txb_Password1.Size = new System.Drawing.Size(288, 26);
            this.txb_Password1.TabIndex = 5;
            // 
            // btn_SignUp1
            // 
            this.btn_SignUp1.BackColor = System.Drawing.Color.Pink;
            this.btn_SignUp1.Location = new System.Drawing.Point(336, 198);
            this.btn_SignUp1.Name = "btn_SignUp1";
            this.btn_SignUp1.Size = new System.Drawing.Size(86, 40);
            this.btn_SignUp1.TabIndex = 7;
            this.btn_SignUp1.Text = "Sign Up";
            this.btn_SignUp1.UseVisualStyleBackColor = false;
            this.btn_SignUp1.Click += new System.EventHandler(this.btn_SignUp1_Click);
            // 
            // SignUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 449);
            this.Controls.Add(this.btn_SignUp1);
            this.Controls.Add(this.txb_Password1);
            this.Controls.Add(this.txb_Username1);
            this.Controls.Add(this.lb_Password1);
            this.Controls.Add(this.lb_Username1);
            this.Controls.Add(this.pcb_SignUp1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SignUp";
            this.Text = "Sign Up";
            ((System.ComponentModel.ISupportInitialize)(this.pcb_SignUp1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pcb_SignUp1;
        private System.Windows.Forms.Label lb_Username1;
        private System.Windows.Forms.Label lb_Password1;
        private System.Windows.Forms.TextBox txb_Username1;
        private System.Windows.Forms.TextBox txb_Password1;
        private System.Windows.Forms.Button btn_SignUp1;
    }
}