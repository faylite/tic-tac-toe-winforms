namespace Tic_Tac_Toe
{
    partial class GameWindow
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GameWindow));
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.newGameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.resetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.A1 = new System.Windows.Forms.Button();
			this.A2 = new System.Windows.Forms.Button();
			this.A3 = new System.Windows.Forms.Button();
			this.B3 = new System.Windows.Forms.Button();
			this.B2 = new System.Windows.Forms.Button();
			this.B1 = new System.Windows.Forms.Button();
			this.C3 = new System.Windows.Forms.Button();
			this.C2 = new System.Windows.Forms.Button();
			this.C1 = new System.Windows.Forms.Button();
			this.nmtag1 = new System.Windows.Forms.Label();
			this.nmtag2 = new System.Windows.Forms.Label();
			this.lblDraw = new System.Windows.Forms.Label();
			this.x_wins = new System.Windows.Forms.Label();
			this.o_wins = new System.Windows.Forms.Label();
			this.draws = new System.Windows.Forms.Label();
			this.button1 = new System.Windows.Forms.Button();
			this.win_msg = new System.Windows.Forms.Label();
			this.panel1 = new System.Windows.Forms.Panel();
			this.menuStrip1.SuspendLayout();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// menuStrip1
			// 
			this.menuStrip1.BackColor = System.Drawing.SystemColors.Control;
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.settingsToolStripMenuItem,
            this.helpToolStripMenuItem});
			this.menuStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(400, 24);
			this.menuStrip1.TabIndex = 0;
			this.menuStrip1.Text = "fileMenu";
			// 
			// fileToolStripMenuItem
			// 
			this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newGameToolStripMenuItem,
            this.resetToolStripMenuItem,
            this.exitToolStripMenuItem});
			this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
			this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
			this.fileToolStripMenuItem.Text = "File";
			// 
			// newGameToolStripMenuItem
			// 
			this.newGameToolStripMenuItem.Name = "newGameToolStripMenuItem";
			this.newGameToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
			this.newGameToolStripMenuItem.Text = "New Game";
			this.newGameToolStripMenuItem.Click += new System.EventHandler(this.newGame);
			// 
			// resetToolStripMenuItem
			// 
			this.resetToolStripMenuItem.Name = "resetToolStripMenuItem";
			this.resetToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
			this.resetToolStripMenuItem.Text = "Reset Score";
			this.resetToolStripMenuItem.Click += new System.EventHandler(this.resetToolStripMenuItem_Click);
			// 
			// exitToolStripMenuItem
			// 
			this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
			this.exitToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
			this.exitToolStripMenuItem.Text = "Exit";
			this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
			// 
			// settingsToolStripMenuItem
			// 
			this.settingsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.optionsToolStripMenuItem});
			this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
			this.settingsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
			this.settingsToolStripMenuItem.Text = "Settings";
			// 
			// optionsToolStripMenuItem
			// 
			this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
			this.optionsToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
			this.optionsToolStripMenuItem.Text = "Options";
			this.optionsToolStripMenuItem.Click += new System.EventHandler(this.openOptionsMenu);
			// 
			// helpToolStripMenuItem
			// 
			this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
			this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
			this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
			this.helpToolStripMenuItem.Text = "Help";
			// 
			// aboutToolStripMenuItem
			// 
			this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
			this.aboutToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
			this.aboutToolStripMenuItem.Text = "About";
			this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
			// 
			// A1
			// 
			this.A1.BackColor = System.Drawing.SystemColors.Control;
			this.A1.Cursor = System.Windows.Forms.Cursors.Hand;
			this.A1.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
			this.A1.FlatAppearance.BorderSize = 0;
			this.A1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.A1.Font = new System.Drawing.Font("Comic Sans MS", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.A1.ForeColor = System.Drawing.SystemColors.Desktop;
			this.A1.Location = new System.Drawing.Point(12, 43);
			this.A1.Name = "A1";
			this.A1.Size = new System.Drawing.Size(75, 75);
			this.A1.TabIndex = 1;
			this.A1.TabStop = false;
			this.A1.UseVisualStyleBackColor = false;
			this.A1.Click += new System.EventHandler(this.button_click);
			this.A1.MouseEnter += new System.EventHandler(this.button_enter);
			this.A1.MouseLeave += new System.EventHandler(this.button_leave);
			// 
			// A2
			// 
			this.A2.BackColor = System.Drawing.SystemColors.Control;
			this.A2.Cursor = System.Windows.Forms.Cursors.Hand;
			this.A2.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
			this.A2.FlatAppearance.BorderSize = 0;
			this.A2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.A2.Font = new System.Drawing.Font("Comic Sans MS", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.A2.ForeColor = System.Drawing.SystemColors.Desktop;
			this.A2.Location = new System.Drawing.Point(93, 43);
			this.A2.Name = "A2";
			this.A2.Size = new System.Drawing.Size(75, 75);
			this.A2.TabIndex = 2;
			this.A2.TabStop = false;
			this.A2.UseVisualStyleBackColor = false;
			this.A2.Click += new System.EventHandler(this.button_click);
			this.A2.MouseEnter += new System.EventHandler(this.button_enter);
			this.A2.MouseLeave += new System.EventHandler(this.button_leave);
			// 
			// A3
			// 
			this.A3.BackColor = System.Drawing.SystemColors.Control;
			this.A3.Cursor = System.Windows.Forms.Cursors.Hand;
			this.A3.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
			this.A3.FlatAppearance.BorderSize = 0;
			this.A3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.A3.Font = new System.Drawing.Font("Comic Sans MS", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.A3.ForeColor = System.Drawing.SystemColors.Desktop;
			this.A3.Location = new System.Drawing.Point(174, 43);
			this.A3.Name = "A3";
			this.A3.Size = new System.Drawing.Size(75, 75);
			this.A3.TabIndex = 3;
			this.A3.TabStop = false;
			this.A3.UseVisualStyleBackColor = false;
			this.A3.Click += new System.EventHandler(this.button_click);
			this.A3.MouseEnter += new System.EventHandler(this.button_enter);
			this.A3.MouseLeave += new System.EventHandler(this.button_leave);
			// 
			// B3
			// 
			this.B3.BackColor = System.Drawing.SystemColors.Control;
			this.B3.Cursor = System.Windows.Forms.Cursors.Hand;
			this.B3.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
			this.B3.FlatAppearance.BorderSize = 0;
			this.B3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.B3.Font = new System.Drawing.Font("Comic Sans MS", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.B3.ForeColor = System.Drawing.SystemColors.Desktop;
			this.B3.Location = new System.Drawing.Point(174, 124);
			this.B3.Name = "B3";
			this.B3.Size = new System.Drawing.Size(75, 75);
			this.B3.TabIndex = 6;
			this.B3.TabStop = false;
			this.B3.UseVisualStyleBackColor = false;
			this.B3.Click += new System.EventHandler(this.button_click);
			this.B3.MouseEnter += new System.EventHandler(this.button_enter);
			this.B3.MouseLeave += new System.EventHandler(this.button_leave);
			// 
			// B2
			// 
			this.B2.BackColor = System.Drawing.SystemColors.Control;
			this.B2.Cursor = System.Windows.Forms.Cursors.Hand;
			this.B2.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
			this.B2.FlatAppearance.BorderSize = 0;
			this.B2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.B2.Font = new System.Drawing.Font("Comic Sans MS", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.B2.ForeColor = System.Drawing.SystemColors.Desktop;
			this.B2.Location = new System.Drawing.Point(93, 124);
			this.B2.Name = "B2";
			this.B2.Size = new System.Drawing.Size(75, 75);
			this.B2.TabIndex = 5;
			this.B2.TabStop = false;
			this.B2.UseVisualStyleBackColor = false;
			this.B2.Click += new System.EventHandler(this.button_click);
			this.B2.MouseEnter += new System.EventHandler(this.button_enter);
			this.B2.MouseLeave += new System.EventHandler(this.button_leave);
			// 
			// B1
			// 
			this.B1.BackColor = System.Drawing.SystemColors.Control;
			this.B1.Cursor = System.Windows.Forms.Cursors.Hand;
			this.B1.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
			this.B1.FlatAppearance.BorderSize = 0;
			this.B1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.B1.Font = new System.Drawing.Font("Comic Sans MS", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.B1.ForeColor = System.Drawing.SystemColors.Desktop;
			this.B1.Location = new System.Drawing.Point(12, 124);
			this.B1.Name = "B1";
			this.B1.Size = new System.Drawing.Size(75, 75);
			this.B1.TabIndex = 4;
			this.B1.TabStop = false;
			this.B1.UseVisualStyleBackColor = false;
			this.B1.Click += new System.EventHandler(this.button_click);
			this.B1.MouseEnter += new System.EventHandler(this.button_enter);
			this.B1.MouseLeave += new System.EventHandler(this.button_leave);
			// 
			// C3
			// 
			this.C3.BackColor = System.Drawing.SystemColors.Control;
			this.C3.Cursor = System.Windows.Forms.Cursors.Hand;
			this.C3.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
			this.C3.FlatAppearance.BorderSize = 0;
			this.C3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.C3.Font = new System.Drawing.Font("Comic Sans MS", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.C3.ForeColor = System.Drawing.SystemColors.Desktop;
			this.C3.Location = new System.Drawing.Point(174, 205);
			this.C3.Name = "C3";
			this.C3.Size = new System.Drawing.Size(75, 75);
			this.C3.TabIndex = 9;
			this.C3.TabStop = false;
			this.C3.UseVisualStyleBackColor = false;
			this.C3.Click += new System.EventHandler(this.button_click);
			this.C3.MouseEnter += new System.EventHandler(this.button_enter);
			this.C3.MouseLeave += new System.EventHandler(this.button_leave);
			// 
			// C2
			// 
			this.C2.BackColor = System.Drawing.SystemColors.Control;
			this.C2.Cursor = System.Windows.Forms.Cursors.Hand;
			this.C2.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
			this.C2.FlatAppearance.BorderSize = 0;
			this.C2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.C2.Font = new System.Drawing.Font("Comic Sans MS", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.C2.ForeColor = System.Drawing.SystemColors.Desktop;
			this.C2.Location = new System.Drawing.Point(93, 205);
			this.C2.Name = "C2";
			this.C2.Size = new System.Drawing.Size(75, 75);
			this.C2.TabIndex = 8;
			this.C2.TabStop = false;
			this.C2.UseVisualStyleBackColor = false;
			this.C2.Click += new System.EventHandler(this.button_click);
			this.C2.MouseEnter += new System.EventHandler(this.button_enter);
			this.C2.MouseLeave += new System.EventHandler(this.button_leave);
			// 
			// C1
			// 
			this.C1.BackColor = System.Drawing.SystemColors.Control;
			this.C1.Cursor = System.Windows.Forms.Cursors.Hand;
			this.C1.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
			this.C1.FlatAppearance.BorderSize = 0;
			this.C1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.C1.Font = new System.Drawing.Font("Comic Sans MS", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.C1.ForeColor = System.Drawing.SystemColors.Desktop;
			this.C1.Location = new System.Drawing.Point(12, 205);
			this.C1.Name = "C1";
			this.C1.Size = new System.Drawing.Size(75, 75);
			this.C1.TabIndex = 7;
			this.C1.TabStop = false;
			this.C1.UseVisualStyleBackColor = false;
			this.C1.Click += new System.EventHandler(this.button_click);
			this.C1.MouseEnter += new System.EventHandler(this.button_enter);
			this.C1.MouseLeave += new System.EventHandler(this.button_leave);
			// 
			// nmtag1
			// 
			this.nmtag1.AutoSize = true;
			this.nmtag1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.nmtag1.ForeColor = System.Drawing.SystemColors.InfoText;
			this.nmtag1.Location = new System.Drawing.Point(15, 10);
			this.nmtag1.Name = "nmtag1";
			this.nmtag1.Size = new System.Drawing.Size(53, 16);
			this.nmtag1.TabIndex = 10;
			this.nmtag1.Text = "Player";
			// 
			// nmtag2
			// 
			this.nmtag2.AutoSize = true;
			this.nmtag2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.nmtag2.ForeColor = System.Drawing.SystemColors.InfoText;
			this.nmtag2.Location = new System.Drawing.Point(15, 50);
			this.nmtag2.Name = "nmtag2";
			this.nmtag2.Size = new System.Drawing.Size(74, 16);
			this.nmtag2.TabIndex = 11;
			this.nmtag2.Text = "Computer";
			// 
			// lblDraw
			// 
			this.lblDraw.AutoSize = true;
			this.lblDraw.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblDraw.ForeColor = System.Drawing.SystemColors.InfoText;
			this.lblDraw.Location = new System.Drawing.Point(15, 90);
			this.lblDraw.Name = "lblDraw";
			this.lblDraw.Size = new System.Drawing.Size(51, 16);
			this.lblDraw.TabIndex = 12;
			this.lblDraw.Text = "Draws";
			// 
			// x_wins
			// 
			this.x_wins.AutoSize = true;
			this.x_wins.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.x_wins.ForeColor = System.Drawing.SystemColors.InfoText;
			this.x_wins.Location = new System.Drawing.Point(97, 11);
			this.x_wins.Name = "x_wins";
			this.x_wins.Size = new System.Drawing.Size(15, 15);
			this.x_wins.TabIndex = 13;
			this.x_wins.Text = "0";
			// 
			// o_wins
			// 
			this.o_wins.AutoSize = true;
			this.o_wins.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.o_wins.ForeColor = System.Drawing.SystemColors.InfoText;
			this.o_wins.Location = new System.Drawing.Point(97, 51);
			this.o_wins.Name = "o_wins";
			this.o_wins.Size = new System.Drawing.Size(15, 15);
			this.o_wins.TabIndex = 14;
			this.o_wins.Text = "0";
			// 
			// draws
			// 
			this.draws.AutoSize = true;
			this.draws.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.draws.ForeColor = System.Drawing.SystemColors.InfoText;
			this.draws.Location = new System.Drawing.Point(97, 91);
			this.draws.Name = "draws";
			this.draws.Size = new System.Drawing.Size(15, 15);
			this.draws.TabIndex = 15;
			this.draws.Text = "0";
			// 
			// button1
			// 
			this.button1.BackColor = System.Drawing.SystemColors.ButtonFace;
			this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
			this.button1.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveBorder;
			this.button1.FlatAppearance.BorderSize = 0;
			this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button1.ForeColor = System.Drawing.SystemColors.ControlText;
			this.button1.Location = new System.Drawing.Point(255, 205);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(131, 75);
			this.button1.TabIndex = 17;
			this.button1.Text = "New Game";
			this.button1.UseVisualStyleBackColor = false;
			this.button1.Click += new System.EventHandler(this.newGame);
			// 
			// win_msg
			// 
			this.win_msg.AutoSize = true;
			this.win_msg.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.win_msg.ForeColor = System.Drawing.SystemColors.InfoText;
			this.win_msg.Location = new System.Drawing.Point(15, 130);
			this.win_msg.Name = "win_msg";
			this.win_msg.Size = new System.Drawing.Size(92, 16);
			this.win_msg.TabIndex = 18;
			this.win_msg.Text = "Placeholder";
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.SystemColors.ButtonFace;
			this.panel1.Controls.Add(this.nmtag1);
			this.panel1.Controls.Add(this.win_msg);
			this.panel1.Controls.Add(this.o_wins);
			this.panel1.Controls.Add(this.x_wins);
			this.panel1.Controls.Add(this.nmtag2);
			this.panel1.Controls.Add(this.draws);
			this.panel1.Controls.Add(this.lblDraw);
			this.panel1.Location = new System.Drawing.Point(255, 43);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(131, 156);
			this.panel1.TabIndex = 19;
			// 
			// Form1
			// 
			this.AcceptButton = this.A3;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.GrayText;
			this.ClientSize = new System.Drawing.Size(400, 298);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.C3);
			this.Controls.Add(this.C2);
			this.Controls.Add(this.C1);
			this.Controls.Add(this.B3);
			this.Controls.Add(this.B2);
			this.Controls.Add(this.B1);
			this.Controls.Add(this.A3);
			this.Controls.Add(this.A2);
			this.Controls.Add(this.A1);
			this.Controls.Add(this.menuStrip1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MainMenuStrip = this.menuStrip1;
			this.MaximizeBox = false;
			this.Name = "Form1";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Tic Tac Toe";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newGameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.Button A1;
		private System.Windows.Forms.Button A2;
        private System.Windows.Forms.Button B3;
        private System.Windows.Forms.Button B2;
        private System.Windows.Forms.Button B1;
        private System.Windows.Forms.Button C3;
        private System.Windows.Forms.Button C2;
		private System.Windows.Forms.Button C1;
		private System.Windows.Forms.ToolStripMenuItem resetToolStripMenuItem;
		private System.Windows.Forms.Button A3;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
		public System.Windows.Forms.Label nmtag1;
		public System.Windows.Forms.Label nmtag2;
		private System.Windows.Forms.Label lblDraw;
		private System.Windows.Forms.Label x_wins;
		private System.Windows.Forms.Label o_wins;
		private System.Windows.Forms.Label draws;
		private System.Windows.Forms.Label win_msg;
		private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
    }
}

