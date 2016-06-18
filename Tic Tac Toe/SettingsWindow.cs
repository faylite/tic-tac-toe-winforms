using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tic_Tac_Toe
{
	public partial class SettingsWindow : Form
	{
		GameWindow f1 = null;
		public SettingsWindow(GameWindow f1)
		{
			this.f1 = f1;
			InitializeComponent();
			this.nmtagPlayer1.Text = f1.player1Name;
			this.nmtagPlayer2.Text = f1.player2Name;
			if (f1.singleplayer){
				this.radioSingleplayer.Checked = true;
			}
			else {
				this.radioMultiplayer.Checked = true;
			}
		}

		private void btnCancel_Click(object sender, EventArgs e)
		{
			this.Close();
		}
		private void btnSave_Click(object sender, EventArgs e)
		{
			if (!radioMultiplayer.Checked)
			{
				f1.settingsPlayer1Name(this.nmtagPlayer1.Text);
				f1.settingsPlayer2Name("Computer");
				f1.singleplayer = true;
			}
			else if (radioMultiplayer.Checked)
			{
				f1.settingsPlayer1Name(this.nmtagPlayer1.Text);
				f1.settingsPlayer2Name(this.nmtagPlayer2.Text);
				f1.singleplayer = false;
			}
			this.Close();
		}

		private void radioSingleplayer_CheckedChanged(object sender, EventArgs e)
		{
			if (this.radioSingleplayer.Checked)
			{
				this.nmtagPlayer2.Text = "Computer";
				this.nmtagPlayer2.Enabled = false;
			}
		}

		private void radioMultiplayer_CheckedChanged(object sender, EventArgs e)
		{
			if (this.radioMultiplayer.Checked)
			{
				this.nmtagPlayer2.Enabled = true;
			}
		}
	}
}
