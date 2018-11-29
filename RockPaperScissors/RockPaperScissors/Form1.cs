using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RockPaperScissors
{
    public partial class frmRockPaperScissors : Form
    {
        public frmRockPaperScissors()
        {
            InitializeComponent();
        }

        int loss = 0;
        int win = 0;

        private void btnRock_Click(object sender, EventArgs e)
        {
            int rock = 1;
            DisplayDecision(rock);
        }
        private void DisplayDecision(int userGuess) 
        {
            Random ranNumberGenerator = new Random();
            int randomNumber;
            randomNumber = ranNumberGenerator.Next(1, 4);
            
            if( userGuess == 1 )
            {
                if (randomNumber == 1)
                {
                    lblWinLose.Text = "You tie";
                }
                else if (randomNumber == 2)
                {
                    lblWinLose.Text = "You lose";
                    loss++;
                }
                else if (randomNumber == 3)
                {
                    lblWinLose.Text = "You win";
                    win++;
                }
            }

            if (userGuess == 2)
            {
                if (randomNumber == 1)
                {
                    lblWinLose.Text = "You win";
                    win++;
                }
                else if (randomNumber == 2)
                {
                    lblWinLose.Text = "You tie";
                   
                }
                else if (randomNumber == 3)
                {
                    lblWinLose.Text = "You lose";
                    loss++;
                }
            }

            if (userGuess == 3)
            {
                if (randomNumber == 1)
                {
                    lblWinLose.Text = "You lose";
                    loss++;
                }
                else if (randomNumber == 2)
                {
                    lblWinLose.Text = "You win";
                    win++;
                }
                else if (randomNumber == 3)
                {
                    lblWinLose.Text = "You tie";
                }
            }
            finalCount();
        }

        private void finalCount()
        {
            lblWins.Text = "" + win;
            lblLosses.Text = "" + loss;   
        }

        private void btnPaper_Click(object sender, EventArgs e)
        {
            int paper = 2;
            DisplayDecision(paper);
        }

        private void btnScissors_Click(object sender, EventArgs e)
        {
            int scissors = 3;
            DisplayDecision(scissors);
        }
    }
}
