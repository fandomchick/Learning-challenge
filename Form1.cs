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

                rannum = r.Next(1, 4);

                switch (rannum)
                {
                     case 1:
                        label2.Text = "Answer: " +  "YES";
                        break;
                    case 2:
                        label2.Text = "Answer: " +  "NO";
                        break;
                    case 3:
                        label2.Text = "Answer: " +  "Ask later again";
                        break;
                    default:
                        label2.Text = "Answer: " + "Not likely too";
                         break;

            }
            }

        private void label2_Click_1(object sender, EventArgs e)
        {
            
            
            

        }
    }
}

