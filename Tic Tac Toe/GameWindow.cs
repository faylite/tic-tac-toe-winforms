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
	public partial class GameWindow : Form
	{
		bool turn = true;// true = X turn; false = O turn;
		int turn_count = 0;
		internal bool singleplayer = true;
		int difficulty = 3; // 0:easy 3:extreme
		bool gameOver = false;

		internal string player1Name = "Player";
		internal string player2Name = "Computer";

		public GameWindow()
		{
			InitializeComponent();
			newGame(null, null);
		}

		private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
		{
			MessageBox.Show("A simple Tic Tac Toe game made in C#.\nPlay by clicking the empty squares when it's your turn.\n\n\u00a9 JeX 2014", "About");
		}

		private void exitToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}

		private void button_click(object sender, EventArgs e)
		{
			turn_count++;

			Button b = (Button)sender;
			if (turn){
				b.Text = "X";
				win_msg.Text = (player2Name + "'s turn");
			}
			else{
				b.Text = "O";
				win_msg.Text = (player1Name + "'s turn");
			}

			// Switch turns
			turn = !turn;
			// Disable occupied button
			b.Enabled = false;

			if (checkForWinner())
				gameOver = true;

			if (!turn && singleplayer && !gameOver)
				// Use ai according to difficulty.
				switch(difficulty)
				{
					case 0:
						Console.WriteLine("Log: Difficulty Easy!");
						bool valid = false;
						int x = 0;
						while (!valid)
						{
							x++;
							Button btn = null;
							btn = aiDumbRandom();
							Console.WriteLine("Log (Debug): AI switch: aiDumbRandom returned: " + btn);
							if (btn != null)
							{
								valid = true;
								Console.WriteLine("While loop looped " + x + " times");
							}
						}
						
						break;
					case 3:
						Console.WriteLine("Log: Difficulty Hard!");
						computerMakeMove();
						break;
					default:
						Console.WriteLine("Log (Error Warning): Ai difficulty switch defaulted!");
						computerMakeMove();
						break;
				}
			
			// Last
			if (!gameOver)
				checkForWinner();
		}
		// ------------------  AI Logic --------------------------- //
		// Call to make computer perform move.
		private void computerMakeMove()
		{
			win_msg.Text = "Computer is thinking...";

			Button move = null;

			// Get winning square if available
			move = aiGetWin();
			// If no move available try to block player winning move.
			if (move == null)
				move = aiBlockWin();
			// If no move choosen perform opening logic or get random available square.
			if (move == null)
				move = aiPerformLogic();

			// If move is available perform a click on selected square
			if(move != null)
				move.PerformClick();
		}

		// Opening move and random logic to select square.
		private Button aiPerformLogic()
		{
			// Take center if free
			if (B2.Text == "")
				return B2;

			Random rnd = new Random();
			int wildcard = rnd.Next(3);

			// Things become more interesting when they are random :D
			// Meant as an opening move.
			switch(wildcard)
			{
				case 0:
					if (A1.Text == "")
						return A1;
					break;
				case 1:
					if (A3.Text == "")
						return A3;
					break;
				case 2:
					if (C1.Text == "")
						return C1;
					break;
				case 3:
					if (C3.Text == "")
						return C3;
					break;
			}
			// If no possible moves take first available square.
			// A
			if (A1.Text == "")
				return A1;
			if (A2.Text == "")
				return A2;
			if (A3.Text == "")
				return A3;
			// B
			if (B1.Text == "")
				return B1;
			if (B2.Text == "")
				return B2;
			if (B3.Text == "")
				return B3;
			// C
			if (C1.Text == "")
				return C1;
			if (C2.Text == "")
				return C2;
			if (C3.Text == "")
				return C3;

			// Should never return null!
			win_msg.Text = "Error 100";
			return null;
		}

		// Method to perform winning move on opponent.
		private Button aiGetWin()
		{
			// Cock block opponent
			// Horizontal Row A
			if ((A1.Text == "") && (A2.Text == "O") && (A3.Text == "O"))
				return A1;
			else if ((A1.Text == "O") && (A2.Text == "") && (A3.Text == "O"))
				return A2;
			else if ((A1.Text == "O") && (A2.Text == "O") && (A3.Text == ""))
				return A3;

			// Horizontal Row B
			else if ((B1.Text == "") && (B2.Text == "O") && (B3.Text == "O"))
				return B1;
			else if ((B1.Text == "O") && (B2.Text == "") && (B3.Text == "O"))
				return B2;
			else if ((B1.Text == "O") && (B2.Text == "O") && (B3.Text == ""))
				return B3;

			// Horizontal Row C
			else if ((C1.Text == "") && (C2.Text == "O") && (C3.Text == "O"))
				return C1;
			else if ((C1.Text == "O") && (C2.Text == "") && (C3.Text == "O"))
				return C2;
			else if ((C1.Text == "O") && (C2.Text == "O") && (C3.Text == ""))
				return C3;

			// Vertical Row 1
			else if ((A1.Text == "") && (B1.Text == "O") && (C1.Text == "O"))
				return A1;
			else if ((A1.Text == "O") && (B1.Text == "") && (C1.Text == "O"))
				return B1;
			else if ((A1.Text == "O") && (B1.Text == "O") && (C1.Text == ""))
				return C1;

			// Vertical Row 2
			else if ((A2.Text == "") && (B2.Text == "O") && (C2.Text == "O"))
				return A2;
			else if ((A2.Text == "O") && (B2.Text == "") && (C2.Text == "O"))
				return B2;
			else if ((A2.Text == "O") && (B2.Text == "O") && (C2.Text == ""))
				return C2;

			// Vertical Row 3
			else if ((A3.Text == "") && (B3.Text == "O") && (C3.Text == "O"))
				return A3;
			else if ((A3.Text == "O") && (B3.Text == "") && (C3.Text == "O"))
				return B3;
			else if ((A3.Text == "O") && (B3.Text == "O") && (C3.Text == ""))
				return C3;

			// Diagonal 1
			else if ((A1.Text == "") && (B2.Text == "O") && (C3.Text == "O"))
				return A1;
			else if ((A1.Text == "O") && (B2.Text == "") && (C3.Text == "O"))
				return B2;
			else if ((A1.Text == "O") && (B2.Text == "O") && (C3.Text == ""))
				return C3;

			// Diagonal 2
			else if ((C1.Text == "") && (B2.Text == "O") && (A3.Text == "O"))
				return C1;
			else if ((C1.Text == "O") && (B2.Text == "") && (A3.Text == "O"))
				return B2;
			else if ((C1.Text == "O") && (B2.Text == "O") && (A3.Text == ""))
				return A3;

			// End
			else
				return null;
		}

		// Method to block a winning move by opponent.
		private Button aiBlockWin()
		{
			// Cock block opponent
			// Horizontal Row A
			if ((A1.Text == "") && (A2.Text == "X") && (A3.Text == "X"))
				return A1;
			else if ((A1.Text == "X") && (A2.Text == "") && (A3.Text == "X"))
				return A2;
			else if ((A1.Text == "X") && (A2.Text == "X") && (A3.Text == ""))
				return A3;

			// Horizontal Row B
			else if ((B1.Text == "") && (B2.Text == "X") && (B3.Text == "X"))
				return B1;
			else if ((B1.Text == "X") && (B2.Text == "") && (B3.Text == "X"))
				return B2;
			else if ((B1.Text == "X") && (B2.Text == "X") && (B3.Text == ""))
				return B3;

			// Horizontal Row C
			else if ((C1.Text == "") && (C2.Text == "X") && (C3.Text == "X"))
				return C1;
			else if ((C1.Text == "X") && (C2.Text == "") && (C3.Text == "X"))
				return C2;
			else if ((C1.Text == "X") && (C2.Text == "X") && (C3.Text == ""))
				return C3;

			// Vertical Row 1
			else if ((A1.Text == "") && (B1.Text == "X") && (C1.Text == "X"))
				return A1;
			else if ((A1.Text == "X") && (B1.Text == "") && (C1.Text == "X"))
				return B1;
			else if ((A1.Text == "X") && (B1.Text == "X") && (C1.Text == ""))
				return C1;

			// Vertical Row 2
			else if ((A2.Text == "") && (B2.Text == "X") && (C2.Text == "X"))
				return A2;
			else if ((A2.Text == "X") && (B2.Text == "") && (C2.Text == "X"))
				return B2;
			else if ((A2.Text == "X") && (B2.Text == "X") && (C2.Text == ""))
				return C2;

			// Vertical Row 3
			else if ((A3.Text == "") && (B3.Text == "X") && (C3.Text == "X"))
				return A3;
			else if ((A3.Text == "X") && (B3.Text == "") && (C3.Text == "X"))
				return B3;
			else if ((A3.Text == "X") && (B3.Text == "X") && (C3.Text == ""))
				return C3;

			// Diagonal 1
			else if ((A1.Text == "") && (B2.Text == "X") && (C3.Text == "X"))
				return A1;
			else if ((A1.Text == "X") && (B2.Text == "") && (C3.Text == "X"))
				return B2;
			else if ((A1.Text == "X") && (B2.Text == "X") && (C3.Text == ""))
				return C3;

			// Diagonal 2
			else if ((C1.Text == "") && (B2.Text == "X") && (A3.Text == "X"))
				return C1;
			else if ((C1.Text == "X") && (B2.Text == "") && (A3.Text == "X"))
				return B2;
			else if ((C1.Text == "X") && (B2.Text == "X") && (A3.Text == ""))
				return A3;

			// End
			else
				return null;
		}

		// Dumb ai, picks a random square. DOES NOT WORK!
		// TODO : Fix dumb ai
		private Button aiDumbRandom()
		{
			Random rnd = new Random();

			int wildcard = rnd.Next(8);

			switch (wildcard)
			{
				case 0:
					if (A1.Text == "")
						return A1;
					break;
				case 1:
					if (A2.Text == "")
						return A2;
					break;
				case 2:
					if (A3.Text == "")
						return A3;
					break;
				case 3:
					if (B1.Text == "")
						return B1;
					break;
				case 4:
					if (B2.Text == "")
						return B2;
					break;
				case 5:
					if (B3.Text == "")
						return B3;
					break;
				case 6:
					if (C1.Text == "")
						return C1;
					break;
				case 7:
					if (C2.Text == "")
						return C2;
					break;
				case 8:
					if (C3.Text == "")
						return C3;
					break;
				default:
					Console.WriteLine("Log (Logic Error): Dumb ai failed to pick a square!");
					return null;
			}// end Switch
			
			return null;
		}
		// ------------------  End AI Logic --------------------------- //


		// Method to check for a winner on both sides
		private bool checkForWinner()
		{
			bool there_is_a_winner = false;


			// Horizontal checks
			if ((A1.Text == A2.Text) && (A2.Text == A3.Text) && (!A1.Enabled))
				there_is_a_winner = true;
			else if ((B1.Text == B2.Text) && (B2.Text == B3.Text) && (!B1.Enabled))
				there_is_a_winner = true;
			else if ((C1.Text == C2.Text) && (C2.Text == C3.Text) && (!C1.Enabled))
				there_is_a_winner = true;

			// Vertical checks
			else if ((A1.Text == B1.Text) && (B1.Text == C1.Text) && (!A1.Enabled))
				there_is_a_winner = true;
			else if ((A2.Text == B2.Text) && (B2.Text == C2.Text) && (!A2.Enabled))
				there_is_a_winner = true;
			else if ((A3.Text == B3.Text) && (B3.Text == C3.Text) && (!A3.Enabled))
				there_is_a_winner = true;

			// Diagonal checks
			else if ((A3.Text == B2.Text) && (B2.Text == C1.Text) && (!A3.Enabled))
				there_is_a_winner = true;
			else if ((A1.Text == B2.Text) && (B2.Text == C3.Text) && (!A1.Enabled))
				there_is_a_winner = true;

			if (there_is_a_winner)
			{
				disableButtons();

				String winner = "";
				if (turn)
				{
					winner = player2Name;
					o_wins.Text = (Int32.Parse(o_wins.Text) + 1).ToString();
				}
				else
				{
					winner = player1Name;
					x_wins.Text = (Int32.Parse(x_wins.Text) + 1).ToString();
				}
				win_msg.Text = (winner + " Wins!");
			}
			else
			{
				if (turn_count >= 9)
				{
					draws.Text = (Int32.Parse(draws.Text) + 1).ToString();
					disableButtons();
					win_msg.Text = ("It's a draw!");
					return true;
				}
			}
			if (there_is_a_winner)
				return true;
			else
				return false;
		}// End checkForWinner

		// Method to disable all buttons with text lenght less than 1
		private void disableButtons()
		{
			foreach (Control c in Controls)
			{
				try
				{
					Button b = (Button)c;
					if((b.Text.Length <= 1))
						b.Enabled = false;
				}// end try
				catch {}
			}// end foreach
		}

		// Starts a new game
		private void newGame(object sender, EventArgs e)
		{
			turn = true;
			turn_count = 0;
			gameOver = false;
			win_msg.Text = (player1Name + "'s turn");

			foreach (Control c in Controls)
			{
				try
				{
					Button b = (Button)c;
					b.Enabled = true;
					if (b.Text.Length <= 1)
						b.Text = "";
				}// end try
				catch {}
			}// end foreach
		}

		private void button_enter(object sender, EventArgs e)
		{
			Button b = (Button)sender;
			if (turn)
				b.Text = "X";
			else
				b.Text = "O";
		}

		private void button_leave(object sender, EventArgs e)
		{
			Button b = (Button)sender;
			if (b.Enabled)
				b.Text = "";
		}

		private void resetToolStripMenuItem_Click(object sender, EventArgs e)
		{
			o_wins.Text = "0";
			x_wins.Text = "0";
			draws.Text = "0";
		}

		private void Form1_Load(object sender, EventArgs e)
		{

		}
		private void toolStripTextBox1_Click_1(object sender, EventArgs e)
		{

		}
		private void openOptionsMenu(object sender, EventArgs e)
		{
			SettingsWindow f2 = new SettingsWindow(this);
			f2.ShowDialog();
		}
		public void settingsPlayer1Name(string name)
		{
			player1Name = name;
			this.nmtag1.Text = name;
		}

		public void settingsPlayer2Name(string name)
		{
			player2Name = name;
			this.nmtag2.Text = name;
		}
	}
}
