using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Melearning
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();


        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label2.Hide();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnstart_Click(object sender, EventArgs e)
        {
                magic.Hide();
                label1.Hide();
                label2.Show();
                int rannum = 0;
                Random r = new Random();

                rannum = r.Next(1, 20);

                switch (rannum)
                {
                     case 1:
                        label2.Text = "Answer: " +  "YES";
                        break;
                    case 2:
                        label2.Text = "Answer: " +  "It is certain";
                        break;
                    case 3:
                        label2.Text = "Answer: " +  "It is decidedly so";
                        break;
                    case 4:
                        label2.Text = "Answer: " +  "Without a doubt";
                        break;
                     case 5:
                        label2.Text = "Answer: " +  "Reply hazy, try again";
                        break;
                     case 6:
                        label2.Text = "Answer: " +  "Ask again later";
                        break;
                     case 7:
                        label2.Text = "Answer: " +  "Better not tell you now";
                        break;
                     case 8:
                        label2.Text = "Answer: " +  "Cannot predict now";
                        break;
                     case 9:
                        label2.Text = "Answer: " +  "Don't count on it";
                        break;
                     case 10:
                        label2.Text = "Answer: " +  "My reply is no";
                        break;
                     case 11:
                        label2.Text = "Answer: " +  "My sources say no";
                        break;
                     case 12:
                        label2.Text = "Answer: " +  "Outlook not so good";
                        break;
                     case 13:
                        label2.Text = "Answer: " +  "Very doubtful";
                        break;
                     case 14:
                        label2.Text = "Answer: " +  "Concentrate and ask again";
                        break;
                     case 15:
                        label2.Text = "Answer: " +  "Yes – definitely";
                        break;
                      case 16:
                        label2.Text = "Answer: " +  "You may rely on it";
                        break;
                      case 17:
                        label2.Text = "Answer: " +  "Outlook good";
                        break;
                      case 18:
                        label2.Text = "Answer: " +  "Most likely";
                        break;
                      case 19:
                        label2.Text = "Answer: " +  "As I see it, yes";
                        break;
                     default:
                        label2.Text = "Answer: " + "Signs point to yes";
                         break;

            }
            }

        private void label2_Click_1(object sender, EventArgs e)
        {
            
            
            

        }
    }
}

