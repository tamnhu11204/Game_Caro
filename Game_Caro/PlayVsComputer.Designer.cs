namespace Game_Caro
{
    partial class PlayVsComputer
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
            this.components = new System.ComponentModel.Container();
            this.pnl_Logo = new System.Windows.Forms.Panel();
            this.pnl_ChessBoard = new System.Windows.Forms.Panel();
            this.menu = new System.Windows.Forms.MenuStrip();
            this.homeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newGameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.playWithFriendToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.playWithComputerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.undoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pnl_Control = new System.Windows.Forms.Panel();
            this.btn_Connect = new System.Windows.Forms.Button();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.txtb_Player = new System.Windows.Forms.TextBox();
            this.timerCountDown = new System.Windows.Forms.Timer(this.components);
            this.picb_Logo = new System.Windows.Forms.PictureBox();
            this.picb_IconXO = new System.Windows.Forms.PictureBox();
            this.pnl_Logo.SuspendLayout();
            this.menu.SuspendLayout();
            this.pnl_Control.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picb_Logo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picb_IconXO)).BeginInit();
            this.SuspendLayout();
            // 
            // pnl_Logo
            // 
            this.pnl_Logo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pnl_Logo.Controls.Add(this.picb_Logo);
            this.pnl_Logo.Location = new System.Drawing.Point(586, 62);
            this.pnl_Logo.Margin = new System.Windows.Forms.Padding(2);
            this.pnl_Logo.Name = "pnl_Logo";
            this.pnl_Logo.Size = new System.Drawing.Size(201, 182);
            this.pnl_Logo.TabIndex = 9;
            // 
            // pnl_ChessBoard
            // 
            this.pnl_ChessBoard.Location = new System.Drawing.Point(11, 26);
            this.pnl_ChessBoard.Margin = new System.Windows.Forms.Padding(2);
            this.pnl_ChessBoard.Name = "pnl_ChessBoard";
            this.pnl_ChessBoard.Size = new System.Drawing.Size(500, 523);
            this.pnl_ChessBoard.TabIndex = 4;
            this.pnl_ChessBoard.Click += new System.EventHandler(this.pnl_ChessBoard_Click);
            this.pnl_ChessBoard.MouseEnter += new System.EventHandler(this.pnl_ChessBoard_MouseEnter);
            this.pnl_ChessBoard.MouseLeave += new System.EventHandler(this.pnl_ChessBoard_MouseLeave);
            // 
            // menu
            // 
            this.menu.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.homeToolStripMenuItem,
            this.menuToolStripMenuItem});
            this.menu.Location = new System.Drawing.Point(0, 0);
            this.menu.Name = "menu";
            this.menu.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menu.Size = new System.Drawing.Size(856, 24);
            this.menu.TabIndex = 11;
            this.menu.Text = "menuStrip1";
            // 
            // homeToolStripMenuItem
            // 
            this.homeToolStripMenuItem.Name = "homeToolStripMenuItem";
            this.homeToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.homeToolStripMenuItem.Text = "Home";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newGameToolStripMenuItem,
            this.undoToolStripMenuItem,
            this.quitToolStripMenuItem});
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.menuToolStripMenuItem.Text = "Menu";
            // 
            // newGameToolStripMenuItem
            // 
            this.newGameToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.playWithFriendToolStripMenuItem,
            this.playWithComputerToolStripMenuItem});
            this.newGameToolStripMenuItem.Name = "newGameToolStripMenuItem";
            this.newGameToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.newGameToolStripMenuItem.Text = "New Game";
            // 
            // playWithFriendToolStripMenuItem
            // 
            this.playWithFriendToolStripMenuItem.Name = "playWithFriendToolStripMenuItem";
            this.playWithFriendToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.playWithFriendToolStripMenuItem.Size = new System.Drawing.Size(199, 22);
            this.playWithFriendToolStripMenuItem.Text = "Play with friend";
            // 
            // playWithComputerToolStripMenuItem
            // 
            this.playWithComputerToolStripMenuItem.Name = "playWithComputerToolStripMenuItem";
            this.playWithComputerToolStripMenuItem.Size = new System.Drawing.Size(199, 22);
            this.playWithComputerToolStripMenuItem.Text = "Play with Computer";
            this.playWithComputerToolStripMenuItem.Click += new System.EventHandler(this.PlayWithComputer);
            // 
            // undoToolStripMenuItem
            // 
            this.undoToolStripMenuItem.Name = "undoToolStripMenuItem";
            this.undoToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Z)));
            this.undoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.undoToolStripMenuItem.Text = "Undo";
            this.undoToolStripMenuItem.Click += new System.EventHandler(this.menuUndo_Click);
            // 
            // quitToolStripMenuItem
            // 
            this.quitToolStripMenuItem.Name = "quitToolStripMenuItem";
            this.quitToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.quitToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.quitToolStripMenuItem.Text = "Quit";
            this.quitToolStripMenuItem.Click += new System.EventHandler(this.menuQuit_Click_1);
            // 
            // pnl_Control
            // 
            this.pnl_Control.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pnl_Control.BackColor = System.Drawing.Color.LightCoral;
            this.pnl_Control.Controls.Add(this.btn_Connect);
            this.pnl_Control.Controls.Add(this.picb_IconXO);
            this.pnl_Control.Controls.Add(this.progressBar);
            this.pnl_Control.Controls.Add(this.txtb_Player);
            this.pnl_Control.Location = new System.Drawing.Point(583, 261);
            this.pnl_Control.Margin = new System.Windows.Forms.Padding(2);
            this.pnl_Control.Name = "pnl_Control";
            this.pnl_Control.Size = new System.Drawing.Size(202, 194);
            this.pnl_Control.TabIndex = 10;
            // 
            // btn_Connect
            // 
            this.btn_Connect.Location = new System.Drawing.Point(26, 80);
            this.btn_Connect.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Connect.Name = "btn_Connect";
            this.btn_Connect.Size = new System.Drawing.Size(81, 28);
            this.btn_Connect.TabIndex = 4;
            this.btn_Connect.Text = "Connect";
            this.btn_Connect.UseVisualStyleBackColor = true;
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(2, 32);
            this.progressBar.Margin = new System.Windows.Forms.Padding(2);
            this.progressBar.Maximum = 20000;
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(127, 17);
            this.progressBar.Step = 100;
            this.progressBar.TabIndex = 1;
            // 
            // txtb_Player
            // 
            this.txtb_Player.Location = new System.Drawing.Point(2, 11);
            this.txtb_Player.Margin = new System.Windows.Forms.Padding(2);
            this.txtb_Player.Name = "txtb_Player";
            this.txtb_Player.Size = new System.Drawing.Size(129, 20);
            this.txtb_Player.TabIndex = 0;
            // 
            // timerCountDown
            // 
            this.timerCountDown.Tick += new System.EventHandler(this.tmCooldown_Tick);
            // 
            // picb_Logo
            // 
            this.picb_Logo.Image = global::Game_Caro.Properties.Resources.LogoCaro;
            this.picb_Logo.Location = new System.Drawing.Point(0, -2);
            this.picb_Logo.Margin = new System.Windows.Forms.Padding(2);
            this.picb_Logo.Name = "picb_Logo";
            this.picb_Logo.Size = new System.Drawing.Size(202, 182);
            this.picb_Logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picb_Logo.TabIndex = 0;
            this.picb_Logo.TabStop = false;
            // 
            // picb_IconXO
            // 
            this.picb_IconXO.Location = new System.Drawing.Point(136, 11);
            this.picb_IconXO.Margin = new System.Windows.Forms.Padding(2);
            this.picb_IconXO.Name = "picb_IconXO";
            this.picb_IconXO.Size = new System.Drawing.Size(65, 58);
            this.picb_IconXO.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picb_IconXO.TabIndex = 3;
            this.picb_IconXO.TabStop = false;
            // 
            // PlayVsComputer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(856, 540);
            this.Controls.Add(this.pnl_Logo);
            this.Controls.Add(this.pnl_ChessBoard);
            this.Controls.Add(this.menu);
            this.Controls.Add(this.pnl_Control);
            this.Name = "PlayVsComputer";
            this.Text = "PlayVsComputer";
            this.pnl_Logo.ResumeLayout(false);
            this.menu.ResumeLayout(false);
            this.menu.PerformLayout();
            this.pnl_Control.ResumeLayout(false);
            this.pnl_Control.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picb_Logo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picb_IconXO)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnl_Logo;
        private System.Windows.Forms.PictureBox picb_Logo;
        private System.Windows.Forms.Panel pnl_ChessBoard;
        private System.Windows.Forms.MenuStrip menu;
        private System.Windows.Forms.ToolStripMenuItem homeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newGameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem playWithFriendToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem playWithComputerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem undoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quitToolStripMenuItem;
        private System.Windows.Forms.Panel pnl_Control;
        private System.Windows.Forms.Button btn_Connect;
        private System.Windows.Forms.PictureBox picb_IconXO;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.TextBox txtb_Player;
        private System.Windows.Forms.Timer timerCountDown;
    }
}