using System;
using System.Windows.Forms;

namespace ticTacToe
{
    public partial class Form1 : Form
    {
        private bool isXTurn = true;
        private int turnCount = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;

            if (btn.Text != "")
                return;

            btn.Text = isXTurn ? "X" : "O";
            turnCount++;
            isXTurn = !isXTurn;

            if (CheckWinner())
            {
                string winner = isXTurn ? "O" : "X";
                MessageBox.Show($"{winner} kazandı!", "Oyun Bitti");
                return;
            }

            if (turnCount == 9)
            {
                MessageBox.Show("Beraberlik!", "Oyun Bitti");
                ResetGame();
            }
        }

        private bool CheckWinner()
        {
            // Satırlar
            if (CheckButtons(button1, button2, button3)) return true;
            if (CheckButtons(button4, button5, button6)) return true;
            if (CheckButtons(button7, button8, button9)) return true;

            // Sütunlar
            if (CheckButtons(button1, button4, button7)) return true;
            if (CheckButtons(button2, button5, button8)) return true;
            if (CheckButtons(button3, button6, button9)) return true;

            // Çaprazlar
            if (CheckButtons(button1, button5, button9)) return true;
            if (CheckButtons(button3, button5, button7)) return true;

            return false;
        }

        private bool CheckButtons(Button b1, Button b2, Button b3)
        {
            if (b1.Text != "" && b1.Text == b2.Text && b2.Text == b3.Text)
            {
                b1.BackColor = System.Drawing.Color.LightGreen;
                b2.BackColor = System.Drawing.Color.LightGreen;
                b3.BackColor = System.Drawing.Color.LightGreen;
                return true;
            }
            return false;
        }

        private void ResetGame()
        {
            foreach (Control c in Controls)
            {
                if (c is Button btn && btn.Name.StartsWith("button"))
                {
                    btn.Text = "";
                    btn.BackColor = System.Drawing.SystemColors.Control;
                }
            }

            isXTurn = true;
            turnCount = 0;
        }
    }
}
