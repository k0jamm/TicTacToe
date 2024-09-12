using System.Drawing.Printing;

namespace JogoDaVelha
{
    public partial class Form1 : Form
    {
        bool turn = true;

        bool Easy = false;
        bool Medium = false;
        bool Hard = false;

        int TurnCount = 0;

        int PlayerWinCount = 0;
        int CPUWinCount = 0;
        int DrawCount = 0;

        List<Button> buttons;

        public Form1()
        {
            InitializeComponent();
            BackColor = Color.Gainsboro;
            MessageBox.Show("Selecione uma dificuldade antes de jogar!!");
            RestartGame();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        #region CPUMove
        private void CPUMove(object sender, EventArgs e)
        {
            Button move = null;

            if (Easy == true)
            {
                var rng = new Random();
                var no = rng.Next(1, 11);
                switch (no)
                {
                    case 1:
                    case 2:
                    case 3:
                    case 4:
                    case 5:
                        move = WinOrBlock("O");
                        if (move == null)
                        {
                            move = WinOrBlock("X");
                            if (move == null)
                            {
                                move = TryMiddle();
                                if (move == null)
                                {
                                    move = OpenSpace();
                                }
                            }
                        }

                        move.PerformClick();
                        break;

                    case 6:
                    case 7:
                    case 8:
                    case 9:
                    case 10:
                        move = OpenSpace();
                        move.PerformClick();
                        break;
                }

            }
            else if (Medium == true)
            {
                var rng = new Random();
                var no = rng.Next(1, 11);
                switch (no)
                {
                    case 1:
                    case 2:
                    case 3:
                    case 4:
                    case 5:
                    case 6:
                    case 7:
                        move = WinOrBlock("O");
                        if (move == null)
                        {
                            move = WinOrBlock("X");
                            if (move == null)
                            {
                                move = TryMiddle();
                                if (move == null)
                                {
                                    move = OpenSpace();
                                }
                            }
                        }

                        move.PerformClick();
                        break;

                    case 8:
                    case 9:
                    case 10:
                        move = OpenSpace();
                        move.PerformClick();
                        break;
                }
            }
            else if (Hard == true)
            {
                var rng = new Random();
                var no = rng.Next(1, 11);
                switch (no)
                {
                    case 1:
                    case 2:
                    case 3:
                    case 4:
                    case 5:
                    case 6:
                    case 7:
                    case 8:
                    case 9:
                        move = WinOrBlock("O");
                        if (move == null)
                        {
                            move = WinOrBlock("X");
                            if (move == null)
                            {
                                move = TryMiddle();
                                if (move == null)
                                {
                                    move = OpenSpace();
                                }
                            }
                        }

                        move.PerformClick();
                        break;

                    case 10:
                        move = OpenSpace();
                        move.PerformClick();
                        break;
                }
            }
        }
        #endregion

        #region WinOrBLock
        private Button WinOrBlock(string mark)
        {
            if ((B2.Text == "X") && (A3.Text == "X") && (C1.Text == "O") && (C3.Text == ""))
                return C3;
            if ((B2.Text == mark) && (C3.Text == mark) && (A1.Text == ""))
                return A1;
            if ((B2.Text == mark) && (C1.Text == mark) && (A3.Text == ""))
                return A3;

            if ((B2.Text == "O") && (A1.Text == "X") && (C3.Text == "X") && (C2.Text == ""))
                return C2;
            if ((B2.Text == mark) && (A3.Text == mark) && (C1.Text == ""))
                return C1;
            if ((A1.Text == mark) && (A2.Text == mark) && (A3.Text == ""))
                return A3;


            if ((A2.Text == mark) && (A3.Text == mark) && (A1.Text == ""))
                return A1;
            if ((A1.Text == mark) && (A3.Text == mark) && (A2.Text == ""))
                return A2;
            if ((B1.Text == mark) && (B2.Text == mark) && (B3.Text == ""))
                return B3;

            if ((B2.Text == mark) && (B3.Text == mark) && (B1.Text == ""))
                return B1;
            if ((B1.Text == mark) && (B3.Text == mark) && (B2.Text == ""))
                return B2;
            if ((C1.Text == mark) && (C2.Text == mark) && (C3.Text == ""))
                return C3;

            if ((C2.Text == mark) && (C3.Text == mark) && (C1.Text == ""))
                return C1;
            if ((C1.Text == mark) && (C3.Text == mark) && (C2.Text == ""))
                return C2;
            if ((A1.Text == mark) && (B1.Text == mark) && (C1.Text == ""))
                return C1;

            if ((B1.Text == mark) && (C1.Text == mark) && (A1.Text == ""))
                return A1;
            if ((A1.Text == mark) && (C1.Text == mark) && (B1.Text == ""))
                return B1;
            if ((A2.Text == mark) && (B2.Text == mark) && (C2.Text == ""))
                return C2;


            if ((B2.Text == mark) && (C2.Text == mark) && (A2.Text == ""))
                return A2;
            if ((A2.Text == mark) && (C2.Text == mark) && (B2.Text == ""))
                return B2;
            if ((A3.Text == mark) && (B3.Text == mark) && (C3.Text == ""))
                return C3;

            if ((B3.Text == mark) && (C3.Text == mark) && (A3.Text == ""))
                return A3;
            if ((A3.Text == mark) && (C3.Text == mark) && (B3.Text == ""))
                return B3;
            if ((A1.Text == mark) && (B2.Text == mark) && (C3.Text == ""))
                return C3;

            if ((B2.Text == mark) && (C3.Text == mark) && (A1.Text == ""))
                return A1;
            if ((A1.Text == mark) && (C3.Text == mark) && (B2.Text == ""))
                return B2;
            if ((A3.Text == mark) && (B2.Text == mark) && (C1.Text == ""))
                return C1;

            if ((B2.Text == mark) && (C1.Text == mark) && (A3.Text == ""))
                return A3;
            if ((A3.Text == mark) && (C1.Text == mark) && (B2.Text == ""))
                return B2;
            if ((A2.Text == "X") && (B2.Text == "O") && (C1.Text == "X") && (A1.Text == ""))
                return A1;
            if ((A2.Text == "X") && (B2.Text == "O") && (C3.Text == "X") && (A3.Text == ""))
                return A3;




            return null;
        }
        #endregion

        #region TryMiddle
        private Button TryMiddle()
        {

            if (B2.Text == "")
            {
                return B2;
            }

            return null;
        }
        #endregion

        #region OpenSpace
        private Button OpenSpace()
        {

            Button b = null;
            foreach (Control c in Controls)
            {
                b = c as Button;
                if (b != null)
                {
                    if (b.Text == "")
                        return b;
                }
            }

            return null;
        }
        #endregion

        #region PlayerClickButton
        private void PlayerClickButton(object sender, EventArgs e)
        {
            var button = (Button)sender;

            if (turn)
            {
                button.Text = "X";
            }
            else
            {
                button.Text = "O";
            }
            turn = !turn;
            button.Enabled = false;
            TurnCount++;
            CheckGame();

            if (!turn)
            {
                CPUMove(sender, e);
            }


        }
        #endregion

        #region RestartGameButton
        private void RestartGameButton(object sender, EventArgs e)
        {
            foreach (Button x in buttons)
            {
                RestartGame();
            }

        }
        #endregion

        #region CheckGame
        private void CheckGame()
        {
            bool GameWin = false;

           

            if ((A1.Text == "X" && A2.Text == "X" && A3.Text == "X")
                || (B1.Text == "X" && B2.Text == "X" && B3.Text == "X")
                || (C1.Text == "X" && C2.Text == "X" && C3.Text == "X")
                || (A1.Text == "X" && B1.Text == "X" && C1.Text == "X")
                || (A2.Text == "X" && B2.Text == "X" && C2.Text == "X")
                || (A3.Text == "X" && B3.Text == "X" && C3.Text == "X")
                || (A1.Text == "X" && B2.Text == "X" && C3.Text == "X")
                || (A3.Text == "X" && B2.Text == "X" && C1.Text == "X")
                )
            {
                GameWin = true;
                MessageBox.Show("Voce Ganhou!");
                PlayerWinCount++;
                label1.Text = "Vitorias Jogador: " + PlayerWinCount;
                RestartGame();
            }
            else if ((A1.Text == "O" && A2.Text == "O" && A3.Text == "O")
                || (A3.Text == "O" && B3.Text == "O" && C3.Text == "O")
                || (B1.Text == "O" && B2.Text == "O" && B3.Text == "O")
                || (C1.Text == "O" && C2.Text == "O" && C3.Text == "O")
                || (A1.Text == "O" && B1.Text == "O" && C1.Text == "O")
                || (A2.Text == "O" && B2.Text == "O" && C2.Text == "O")
                || (A1.Text == "O" && B2.Text == "O" && C3.Text == "O")
                || (A3.Text == "O" && B2.Text == "O" && C1.Text == "O")
                )
            {
                GameWin = true;
                MessageBox.Show("CPU Ganhou!");
                CPUWinCount++;
                label2.Text = "Vitorias CPU: " + CPUWinCount;
                RestartGame();
            }      
            else if (TurnCount == 9 && GameWin == false)
            {
                GameWin = true;
                MessageBox.Show("Empate!");
                DrawCount++;
                label3.Text = "Empates:" + DrawCount;
                RestartGame();
            }



        }
        #endregion

        #region RestartGame
        private void RestartGame()
        {
            buttons = new List<Button> { A1, A2, A3, B1, B2, B3, C1, C2, C3 };
            TurnCount = 0;
            turn = true;

            try
            {
                foreach (Button x in buttons)
                {
                    x.Enabled = true;
                    x.Text = "";
                    x.BackColor = DefaultBackColor;
                }
            }
            catch { }


        }
        #endregion

        private void label3_Click(object sender, EventArgs e)
        {

        }

        #region Difficulties
        private void DifficultiesEasy(object sender, EventArgs e)
        {
            Easy = true;
            Medium = false;
            Hard = false;
            menuStrip1.BackColor = Color.Green;
            aaToolStripMenuItem.Text = "Fácil";
            MessageBox.Show("Dificuldade Fácil Selecionada");
        }

        private void DifficultiesMedium(object sender, EventArgs e)
        {
            Easy = false;
            Medium = true;
            Hard = false;
            menuStrip1.BackColor = Color.Orange;
            aaToolStripMenuItem.Text = "Médio";
            MessageBox.Show("Dificuldade Média Selecionada");
        }

        private void DifficultiesHard(object sender, EventArgs e)
        {
            Easy = false;
            Medium = false;
            Hard = true;
            menuStrip1.BackColor = Color.Red;
            aaToolStripMenuItem.Text = "Difícil";
            MessageBox.Show("Dificuldade Difícil Selecionada");
        }
        #endregion
    }
}