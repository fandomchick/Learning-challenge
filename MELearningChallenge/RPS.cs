using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace MELearningChallenge
{
    public partial class RPS : Form
    {
        int gameCount = 0;
        int winCount = 0;
        int lostCount = 0;
        int drawCount = 0;

        
        public RPS()
        {
            InitializeComponent();
        }

        private void playRps(OptionsEnum userChoice)
        {
            OptionsEnum compChose = GameController.ComputerChoice();
            String result = GameController.Result(userChoice, compChose).ToString();
            //lbl_result.Text = "Result: " + result;
            if(result == "Lose")
            {
                lbl_result.Show();
                lbl_result.Font = new Font("Arial", 75, FontStyle.Bold);
                lbl_result.Text = "YOU LOSE";
                lbl_result.BringToFront();
            }
            else if(result == "Win")
            {
                lbl_result.Show();
                lbl_result.Font = new Font("Arial", 75, FontStyle.Bold);
                lbl_result.Text = "YOU WIN";
                lbl_result.BringToFront();
            }
            else
            {
                lbl_result.Show();
                lbl_result.Font = new Font("Arial", 75, FontStyle.Bold);
                lbl_result.Text = "It's a draw";
                lbl_result.BringToFront();
            }
            lbl_computer.Text = "Computer chose: " + compChose.ToString();
            switch (result)
            {
                case "Win":
                    winCount += 1;
                    break;
                case "Lose":
                    lostCount += 1;
                    break;
                default:
                    drawCount += 1;
                    break;
            }
            lbl_won.Text = "Won: " + winCount.ToString();
            lbl_lost.Text = "Lost: " + lostCount.ToString();
            lbl_draw.Text = "Draw: " + drawCount.ToString();
        }

        private void btn_rock_Click(object sender, EventArgs e)
        {
            playRps(OptionsEnum.Rock);
            gameCount += 1;
            lbl_total.Text = "Total: " + gameCount.ToString();
        }

        private void btn_paper_Click(object sender, EventArgs e)
        {
            playRps(OptionsEnum.Paper);
            gameCount += 1;
            lbl_total.Text = "Total: " + gameCount.ToString();
        }

        private void btn_scissors_Click(object sender, EventArgs e)
        {
            playRps(OptionsEnum.Scissor);
            gameCount += 1;
            lbl_total.Text = "Total: " + gameCount.ToString();
        }

        private void lbl_won_Click(object sender, EventArgs e)
        {

        }

        private void RPS_Load(object sender, EventArgs e)
        {

        }

        private void lbl_result_Click(object sender, EventArgs e)
        {
            lbl_result.Hide();
        }

        private void lbl_computer_Click(object sender, EventArgs e)
        {

        }
    }
}
