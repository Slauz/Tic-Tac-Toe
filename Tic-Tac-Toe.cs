using System.Collections.Specialized;
using System.Runtime.CompilerServices;
using System.Runtime.Intrinsics.Arm;
using System.Runtime.Intrinsics.X86;
using System.Security.Cryptography;

namespace Tic_Tac_Toe
{
    public partial class TTT : Form
    {
        private bool Turn = true; // false - X, true - O
        private int TurnCount = 0;
        private Button[,] clickableButtons = new Button[3, 3];
        private bool withBot = false;

        public TTT()
        {
            InitializeComponent();
            TurnInfo.Text = " ";
        }


        private void StartGame_Click(object sender, EventArgs e)
        {
            WithBotPlay.Enabled = true;
            SoloPlay.Enabled = true;

            WithBotPlay.Visible = true;
            SoloPlay.Visible = true;

            StartGame.Enabled = false;
            StartGame.Visible = false;

            clickableButtons[0, 0] = A1;
            clickableButtons[0, 1] = A2;
            clickableButtons[0, 2] = A3;
            clickableButtons[1, 0] = B1;
            clickableButtons[1, 1] = B2;
            clickableButtons[1, 2] = B3;
            clickableButtons[2, 0] = C1;
            clickableButtons[2, 1] = C2;
            clickableButtons[2, 2] = C3;

        }

        private void buttonClick(object sender, EventArgs e)
        {
            Button button = (Button)sender;

            bool found = false;

            for (int i = 0; i < clickableButtons.GetLength(0); i++)
            {
                for (int j = 0; j < clickableButtons.GetLength(1); j++)
                {
                    if (button == clickableButtons[i, j])
                    {
                        found = true;
                    }
                }
            }

            if (!found)
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
                button.Text = "O";
                button.Enabled = false;
            }
            else
            {
                button.Text = "/";
                button.Enabled = false;
            }

            Turn = !Turn;
            TurnCount++;


            if (CheckWinner())
            {
                AutoNewGame();
                return;
            }

            if (withBot)
            {
                BotTurn();
            }

            if (CheckWinner())
            {
                AutoNewGame();
                return;
            }

            if (Turn == true)
            {
                TurnInfo.Text = "O turn";
            }
            else if (Turn == false)
            {
                TurnInfo.Text = "X turn";
            }

        }

        private bool CheckWinner()
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
                    str = "X";
                }
                else if (!Turn)
                {
                    str = "O";
                }

                MessageBox.Show($"{str} is Won!");
                return true;

            }
            else if (TurnCount == 9)
            {
                MessageBox.Show("Draw!");
                return true;
            }

            return false;
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

        private void toolStripMenuItem1_Click_1(object sender, EventArgs e)
        {

            DialogResult result = MessageBox.Show("Do you want to play with bot?","Confirmation", MessageBoxButtons.YesNo);
            if(result == DialogResult.Yes)
            {
                withBot = true;
                foreach (Button b in clickableButtons)
                {
                    b.Enabled = true;
                    b.Visible = true;
                    b.Text = "";
                }

                SoloPlay.Visible = false;
                SoloPlay.Enabled = false;

                WithBotPlay.Enabled = false;
                WithBotPlay.Visible = false;

                TurnInfo.Text = "O turn";
                return;

            }
            else if(result == DialogResult.No)
            {
                withBot = false;

                foreach (Button b in clickableButtons)
                {
                    b.Enabled = true;
                    b.Visible = true;
                    b.Text = "";
                }

                SoloPlay.Visible = false;
                SoloPlay.Enabled = false;

                WithBotPlay.Enabled = false;
                WithBotPlay.Visible = false;
                TurnInfo.Text = "O turn";
                return;
            }
            else
            {
                return;
            }
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This is Tic-Tac-Toe game.");
        }

        private void SoloPlay_Click(object sender, EventArgs e)
        {
            withBot = false;

            foreach (Button b in clickableButtons)
            {
                b.Enabled = true;
                b.Visible = true;
                b.Text = "";
            }

            SoloPlay.Visible = false;
            SoloPlay.Enabled = false;

            WithBotPlay.Enabled = false;
            WithBotPlay.Visible = false;
            TurnInfo.Text = "O turn";
        }

        private void WithBotPlay_Click(object sender, EventArgs e)
        {
            withBot = true;
            foreach (Button b in clickableButtons)
            {
                b.Enabled = true;
                b.Visible = true;
                b.Text = "";
            }

            SoloPlay.Visible = false;
            SoloPlay.Enabled = false;

            WithBotPlay.Enabled = false;
            WithBotPlay.Visible = false;

            TurnInfo.Text = "O turn";
        }

        private void BotTurn()
        { 
            Button checkedButton = CheckCrate();

            if (checkedButton == null)
            {
                Console.WriteLine("NULL founded");

                List<Button> buttons = new List<Button>();

                foreach (Button b in clickableButtons)
                {
                    if (b.Enabled == true & b.Text == "")
                    {
                        buttons.Add(b);
                    }
                }

                Random r = new Random();

                int rb_index = r.Next(1, buttons.Count-1);

                buttons[rb_index].Enabled = false;
                buttons[rb_index].Text = "X";
            }
            else if (checkedButton != null)
            {
                Console.WriteLine("NULL is not founded, but trying to win");
                checkedButton.Text = "X";
                checkedButton.Enabled = false;
            }

            Turn = !Turn;
            TurnCount++;
        }

        private Button CheckCrate()
        {
            Button freeButtonToPick = null;
            // (clickableButtons[0,0].Text == clickableButtons[0,1].Text & !clickableButtons[0,0].Enabled) | (clickableButtons[0,0].Text == clickableButtons[0,2].Text & !clickableButtons[0, 0].Enabled) | (clickableButtons[0,1].Text == clickableButtons[0, 2].Text & !clickableButtons[0, 0].Enabled)
            for (int i = 0; i < clickableButtons.GetLength(0); i++)
            {
                int opp_marks = 0;
                int free_sections = 0;

                for (int j = 0; j < clickableButtons.GetLength(1); j++)
                {
                    if (clickableButtons[i, j].Text == "O")
                    {
                        opp_marks++;
                    }
                    else if (clickableButtons[j, i].Enabled)
                    {
                        free_sections++;
                    }
                }

                if (opp_marks == 2 & free_sections == 1)
                {
                    for (int j = 0; j < clickableButtons.GetLength(0); j++)
                    {
                        if (clickableButtons[i, j].Enabled)
                        {
                            freeButtonToPick = clickableButtons[j, i];
                        }
                    }

                    return freeButtonToPick;
                }
            }

            for (int i = 0; i < clickableButtons.GetLength(0); i++)
            {
                int opp_marks = 0;
                int free_sections = 0;

                for (int j = 0; j < clickableButtons.GetLength(0); j++)
                {
                    if (clickableButtons[j, i].Text == "O")
                    {
                        opp_marks++;
                    }
                    else if (clickableButtons[j, i].Enabled)
                    {
                        free_sections++;
                    }
                }

                if (opp_marks == 2 & free_sections == 1)
                {
                    for (int j = 0; j < clickableButtons.GetLength(0); j++)
                    {
                        if (clickableButtons[j, i].Enabled)
                        {
                            freeButtonToPick = clickableButtons[j, i];
                        }
                    }

                    return freeButtonToPick;
                }
            }

            Button[] fd_diagonal = new Button[3];

            fd_diagonal[0] = clickableButtons[0, 0];
            fd_diagonal[1] = clickableButtons[1, 1];
            fd_diagonal[2] = clickableButtons[2, 2];

            int fd_opp = 0;
            int fd_free = 0;

            for (int i = 0; i < fd_diagonal.Length; i++)
            {
                if (fd_diagonal[i].Text == "O")
                {
                    fd_opp++;
                }
                else if (fd_diagonal[i].Enabled)
                {
                    fd_free++;
                }

                if (fd_opp == 2 & fd_free == 1)
                {
                    for (int k = 0; k < fd_diagonal.Length; k++)
                    {
                        if (fd_diagonal[k].Enabled)
                        {
                            freeButtonToPick = fd_diagonal[k];
                        }
                    }
                    return freeButtonToPick;
                }
            }

            Button[] sd_diagonal = new Button[3];

            sd_diagonal[0] = clickableButtons[0, 2];
            sd_diagonal[1] = clickableButtons[1, 1];
            sd_diagonal[2] = clickableButtons[0, 2];

            int sd_opp = 0;
            int sd_free = 0;

            for(int i = 0; i < sd_diagonal.Length; i++)
            {
                if (sd_diagonal[i].Text == "O")
                {
                    sd_opp++;
                }
                else if (sd_diagonal[i].Enabled)
                {
                    sd_free++;
                }

                if (sd_opp == 2 & sd_free == 1)
                {
                    for(int k = 0; k < sd_diagonal.Length; k++)
                    {
                        if(sd_diagonal[k].Enabled)
                        {
                            freeButtonToPick = sd_diagonal[k];
                        }
                    }
                    return freeButtonToPick;
                }
            }

            return freeButtonToPick;
        }
    }
}