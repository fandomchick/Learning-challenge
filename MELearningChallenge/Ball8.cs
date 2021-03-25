using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace MELearningChallenge
{
    public partial class ball8 : Form
    {
        public ball8()
        {
            InitializeComponent();
            lbl_ball.Text = "Type your question:";
        }

        private void btn_ball_Click(object sender, EventArgs e)
        {
            txt_ball.Hide();
            lbl_ball.Hide();
            lbl_result.Show();
            int rannum = 0;
            Random r = new Random();

            rannum = r.Next(1, 20);

            switch (rannum)
            {
                case 1:
                    lbl_result.Text = "Answer: " + "YES";
                    break;
                case 2:
                    lbl_result.Text = "Answer: " + "It is certain";
                    break;
                case 3:
                    lbl_result.Text = "Answer: " + "It is decidedly so";
                    break;
                case 4:
                    lbl_result.Text = "Answer: " + "Without a doubt";
                    break;
                case 5:
                    lbl_result.Text = "Answer: " + "Reply hazy, try again";
                    break;
                case 6:
                    lbl_result.Text = "Answer: " + "Ask again later";
                    break;
                case 7:
                    lbl_result.Text = "Answer: " + "Better not tell you now";
                    break;
                case 8:
                    lbl_result.Text = "Answer: " + "Cannot predict now";
                    break;
                case 9:
                    lbl_result.Text = "Answer: " + "Don't count on it";
                    break;
                case 10:
                    lbl_result.Text = "Answer: " + "My reply is no";
                    break;
                case 11:
                    lbl_result.Text = "Answer: " + "My sources say no";
                    break;
                case 12:
                    lbl_result.Text = "Answer: " + "Outlook not so good";
                    break;
                case 13:
                    lbl_result.Text = "Answer: " + "Very doubtful";
                    break;
                case 14:
                    lbl_result.Text = "Answer: " + "Concentrate and ask again";
                    break;
                case 15:
                    lbl_result.Text = "Answer: " + "Yes – definitely";
                    break;
                case 16:
                    lbl_result.Text = "Answer: " + "You may rely on it";
                    break;
                case 17:
                    lbl_result.Text = "Answer: " + "Outlook good";
                    break;
                case 18:
                    lbl_result.Text = "Answer: " + "Most likely";
                    break;
                case 19:
                    lbl_result.Text = "Answer: " + "As I see it, yes";
                    break;
                default:
                    lbl_result.Text = "Answer: " + "Signs point to yes";
                    break;
            }
        }
    }
}
