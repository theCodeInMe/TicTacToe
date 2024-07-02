using System.Diagnostics;
using System.Security.Cryptography;

namespace TicTacToe2
{
    public partial class Form1 : Form
    {
        public int player = 0;
        public int turncount = 0;
        private Button[,] playField;

        public Form1()
        {
            InitializeComponent();
            playField = new Button[3, 3] { { a1, a2, a3 }, { b1, b2, b3 }, { c1, c2, c3 } };
            newGameButton.Hide();
        }

        private void chooseField(object sender, EventArgs e)
        {
            turncount++;
            Button a = (Button)sender;
            a.Enabled = false;
            if (player == 1)
            {
                a.Text = "O";
                player = 2;
            }
            else
            {
                a.Text = "X";
                player = 1;
            }
            if (checkWin() == true)
            {
                foreach (Button b in playField)
                {
                    b.Enabled = false;
                }
                newGameButton.Show();
            }
        }

        private void newPlayfield(object sender, EventArgs e)
        {
            foreach (Button b in playField)
            {
                b.Enabled = true;
                b.Text = "";
            }
            turncount = 0;
            player = 0;
            announceLabel.Text = "";
        }

        private bool checkWin()
        {
            bool hasWon = false;
            if (turncount == 9)
            {
                announceLabel.Text = "Game Over \n \n No One Wins!";
                hasWon = true;
            }
            else if (checkWindiagonal() == true || checkWinHorizontal() == true || checkWinVertical() == true)
            {
                announceLabel.Text = $"Player {player} is the winner !!";
                hasWon = true;
            }

            return hasWon;
        }

        private bool checkWinHorizontal()
        {
            bool haswon = false;
            for (int Spalte = 0; Spalte < playField.GetLength(0); Spalte++)
            {
                if (playField[0, Spalte].Text == playField[1, Spalte].Text && playField[1, Spalte].Text == playField[2, Spalte].Text && playField[0, Spalte].Text != "")
                {
                    haswon = true;
                }
            }

            return haswon;
        }

        private bool checkWinVertical()
        {
            bool haswon = false;

            for (int row = 0; row < playField.GetLength(0); row++)
            {
                if (playField[row, 0].Text == playField[row, 1].Text && playField[row, 1].Text == playField[row, 2].Text && playField[row, 0].Text != "")
                {
                    haswon = true;
                }
            }
            return haswon;
        }

        private bool checkWindiagonal()
        {
            bool haswon = false;

            if (playField[0, 0].Text != "" && playField[1, 1].Text != "" && playField[2, 2].Text != "")
            {
                if (playField[0, 0].Text == playField[1, 1].Text && playField[1, 1].Text == playField[2, 2].Text)
                {
                    haswon = true;
                }
            }

            if (playField[0, 2].Text != "" && playField[1, 1].Text != "" && playField[2, 0].Text != "")
            {
                if (playField[0, 0].Text == playField[1, 1].Text && playField[1, 1].Text == playField[2, 2].Text)
                {
                    haswon = true;
                }
            }

            return haswon;
        }
    }
}