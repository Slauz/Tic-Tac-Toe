using System.Collections.Specialized;
using System.Runtime.CompilerServices;
using System.Runtime.Intrinsics.Arm;
using System.Runtime.Intrinsics.X86;
using System.Security.Cryptography;

namespace Tic_Tac_Toe
{
    public partial class Form1 : Form
    {
        private bool Turn = true; // false - X, true - O
        private int TurnCount = 0;
        private Button[] clickableButtons = new Button[9];

        public Form1()
        {
            InitializeComponent();
        }

        private void StartGame_Click(object sender, EventArgs e)
        {
            A1.Enabled = true;
            A2.Enabled = true;
            A3.Enabled = true;
            C1.Enabled = true;
            C2.Enabled = true;
            C3.Enabled = true;
            B1.Enabled = true;
            B2.Enabled = true;
            B3.Enabled = true;

            clickableButtons[0] = A1;
            clickableButtons[1] = A2;
            clickableButtons[2] = A3;
            clickableButtons[3] = B1;
            clickableButtons[4] = B2;
            clickableButtons[5] = B3;
            clickableButtons[6] = C1;
            clickableButtons[7] = C2;
            clickableButtons[8] = C3;

            StartGame.Enabled = false;
            StartGame.Visible = false;

            NewGame.Visible = true;
            NewGame.Enabled = true;

            TurnInfo.Text = "O turn";

        }

        private void buttonClick(object sender, EventArgs e)
        {
            Button button = (Button)sender;

            if (!clickableButtons.Contains(button))
            {
                return;
            }

            if (Turn == false)
            {
                button.Text = "X";
                button.Enabled = false;
            }
            else if (Turn == true)
            {
                button.Text = "0";
                button.Enabled = false;
            }
            else
            {
                button.Text = "/";
                button.Enabled = false;
            }

            CheckWinner();
            Turn = !Turn;
            TurnCount++;


            if (Turn == true)
            {
                TurnInfo.Text = "O turn";
            }
            else if (Turn == false)
            {
                TurnInfo.Text = "X turn";
            }
        }

        private void CheckWinner()
        {
            bool SomeoneIsWon = false;
            // - - -
            if (A1.Text == A2.Text & A2.Text == A3.Text & (!A2.Enabled))
            {
                SomeoneIsWon = true;
            }
            else if (C1.Text == C2.Text & C2.Text == C3.Text & (!C2.Enabled))
            {
                SomeoneIsWon = true;
            }
            else if (B1.Text == B2.Text & B2.Text == B3.Text & (!B2.Enabled))
            {
                SomeoneIsWon = true;
            }

            // |||

            if (A1.Text == B1.Text & B1.Text == C1.Text & (!B1.Enabled))
            {
                SomeoneIsWon = true;
            }
            else if (A2.Text == B2.Text & B2.Text == C2.Text & (!B2.Enabled))
            {
                SomeoneIsWon = true;
            }
            else if (A3.Text == B3.Text & B3.Text == C3.Text & (!B3.Enabled))
            {
                SomeoneIsWon = true;
            }

            if (A1.Text == B2.Text & B2.Text == C3.Text & (!B2.Enabled))
            {
                SomeoneIsWon = true;
            }
            else if (C1.Text == B2.Text & B2.Text == A3.Text & (!B2.Enabled))
            {
                SomeoneIsWon = true;
            }

            if (SomeoneIsWon)
            {
                string str = "";

                if (Turn)
                {
                    str = "O";
                }
                else if (!Turn)
                {
                    str = "X";
                }

                MessageBox.Show($"{str} is Won!");
                AutoNewGame();

            }
            else if (TurnCount == 9)
            {
                MessageBox.Show("Draw!");
                AutoNewGame();
            }

        }

        private void AutoNewGame()
        {
            Turn = true;
            TurnCount = 0;

            try
            {
                foreach (Button b in clickableButtons)
                {
                    b.Text = "";
                    b.Enabled = true;
                }
            }
            catch { }

            TurnInfo.Text = "O turn";
        }

        private void NewGame_Click(object sender, EventArgs e)
        {
            Turn = true;
            TurnCount = 0;

            try
            {
                foreach (Button b in clickableButtons)
                {
                    b.Text = "";
                    b.Enabled = true;
                }
            }
            catch(Exception){ Console.WriteLine("WTF???"); }

            TurnInfo.Text = "O turn";
        }
    }
}