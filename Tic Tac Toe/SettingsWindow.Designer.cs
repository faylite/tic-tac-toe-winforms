namespace Tic_Tac_Toe
{
	partial class SettingsWindow
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SettingsWindow));
			this.label1 = new System.Windows.Forms.Label();
			this.nmtagPlayer1 = new System.Windows.Forms.TextBox();
			this.nmtagPlayer2 = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.radioEasy = new System.Windows.Forms.RadioButton();
			this.radioNormal = new System.Windows.Forms.RadioButton();
			this.btnSave = new System.Windows.Forms.Button();
			this.btnCancel = new System.Windows.Forms.Button();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.radioMultiplayer = new System.Windows.Forms.RadioButton();
			this.radioSingleplayer = new System.Windows.Forms.RadioButton();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(19, 19);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(114, 16);
			this.label1.TabIndex = 0;
			this.label1.Text = "Player 1 Name:";
			// 
			// nmtagPlayer1
			// 
			this.nmtagPlayer1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.nmtagPlayer1.Location = new System.Drawing.Point(139, 13);
			this.nmtagPlayer1.MaxLength = 8;
			this.nmtagPlayer1.Name = "nmtagPlayer1";
			this.nmtagPlayer1.Size = new System.Drawing.Size(127, 26);
			this.nmtagPlayer1.TabIndex = 1;
			this.nmtagPlayer1.Text = "Player";
			// 
			// nmtagPlayer2
			// 
			this.nmtagPlayer2.Enabled = false;
			this.nmtagPlayer2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.nmtagPlayer2.Location = new System.Drawing.Point(139, 50);
			this.nmtagPlayer2.MaxLength = 8;
			this.nmtagPlayer2.Name = "nmtagPlayer2";
			this.nmtagPlayer2.Size = new System.Drawing.Size(127, 26);
			this.nmtagPlayer2.TabIndex = 3;
			this.nmtagPlayer2.Text = "Computer";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(19, 55);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(114, 16);
			this.label2.TabIndex = 2;
			this.label2.Text = "Player 2 Name:";
			// 
			// radioEasy
			// 
			this.radioEasy.AutoSize = true;
			this.radioEasy.Enabled = false;
			this.radioEasy.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Strikeout, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.radioEasy.Location = new System.Drawing.Point(6, 22);
			this.radioEasy.Name = "radioEasy";
			this.radioEasy.Size = new System.Drawing.Size(51, 19);
			this.radioEasy.TabIndex = 4;
			this.radioEasy.Text = "Easy";
			this.radioEasy.UseVisualStyleBackColor = true;
			// 
			// radioNormal
			// 
			this.radioNormal.AutoSize = true;
			this.radioNormal.Checked = true;
			this.radioNormal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.radioNormal.Location = new System.Drawing.Point(6, 48);
			this.radioNormal.Name = "radioNormal";
			this.radioNormal.Size = new System.Drawing.Size(66, 19);
			this.radioNormal.TabIndex = 6;
			this.radioNormal.TabStop = true;
			this.radioNormal.Text = "Normal";
			this.radioNormal.UseVisualStyleBackColor = true;
			// 
			// btnSave
			// 
			this.btnSave.Location = new System.Drawing.Point(195, 171);
			this.btnSave.Name = "btnSave";
			this.btnSave.Size = new System.Drawing.Size(74, 27);
			this.btnSave.TabIndex = 10;
			this.btnSave.Text = "Save";
			this.btnSave.UseVisualStyleBackColor = true;
			this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
			// 
			// btnCancel
			// 
			this.btnCancel.Location = new System.Drawing.Point(112, 171);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.Size = new System.Drawing.Size(74, 27);
			this.btnCancel.TabIndex = 11;
			this.btnCancel.Text = "Cancel";
			this.btnCancel.UseVisualStyleBackColor = true;
			this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.radioEasy);
			this.groupBox1.Controls.Add(this.radioNormal);
			this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBox1.Location = new System.Drawing.Point(22, 85);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(88, 74);
			this.groupBox1.TabIndex = 12;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Difficulty";
			// 
			// radioMultiplayer
			// 
			this.radioMultiplayer.AutoSize = true;
			this.radioMultiplayer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.radioMultiplayer.Location = new System.Drawing.Point(8, 48);
			this.radioMultiplayer.Name = "radioMultiplayer";
			this.radioMultiplayer.Size = new System.Drawing.Size(85, 19);
			this.radioMultiplayer.TabIndex = 9;
			this.radioMultiplayer.Text = "Multiplayer";
			this.radioMultiplayer.UseVisualStyleBackColor = true;
			this.radioMultiplayer.CheckedChanged += new System.EventHandler(this.radioMultiplayer_CheckedChanged);
			// 
			// radioSingleplayer
			// 
			this.radioSingleplayer.AutoSize = true;
			this.radioSingleplayer.Checked = true;
			this.radioSingleplayer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.radioSingleplayer.Location = new System.Drawing.Point(8, 22);
			this.radioSingleplayer.Name = "radioSingleplayer";
			this.radioSingleplayer.Size = new System.Drawing.Size(93, 19);
			this.radioSingleplayer.TabIndex = 7;
			this.radioSingleplayer.TabStop = true;
			this.radioSingleplayer.Text = "Singleplayer";
			this.radioSingleplayer.UseVisualStyleBackColor = true;
			this.radioSingleplayer.CheckedChanged += new System.EventHandler(this.radioSingleplayer_CheckedChanged);
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.radioSingleplayer);
			this.groupBox2.Controls.Add(this.radioMultiplayer);
			this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBox2.Location = new System.Drawing.Point(139, 85);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(104, 74);
			this.groupBox2.TabIndex = 13;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Mode";
			// 
			// Form2
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(288, 212);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.btnCancel);
			this.Controls.Add(this.btnSave);
			this.Controls.Add(this.nmtagPlayer2);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.nmtagPlayer1);
			this.Controls.Add(this.label1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "Form2";
			this.ShowIcon = false;
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Settings";
			this.TopMost = true;
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox nmtagPlayer1;
		private System.Windows.Forms.TextBox nmtagPlayer2;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.RadioButton radioEasy;
		private System.Windows.Forms.RadioButton radioNormal;
		private System.Windows.Forms.Button btnSave;
		private System.Windows.Forms.Button btnCancel;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.RadioButton radioMultiplayer;
		private System.Windows.Forms.RadioButton radioSingleplayer;
		private System.Windows.Forms.GroupBox groupBox2;
	}
}