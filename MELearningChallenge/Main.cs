using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MELearningChallenge
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            lblMain.Text = "Hello Stranger!";
            lbl_first.Text = "What is your first name?";
            lbl_last.Text = "And your last name?";

            





        }

        private void btn_Confirm_Click(object sender, EventArgs e)
        {
            string first_name = txt_first.Text;
            string last_name = txt_last.Text;
            string name = first_name + " " + last_name;

            this.Hide();
            GamesPage games = new GamesPage(txt_first.Text, txt_last.Text);
            games.ShowDialog();
        }

        private void txt_validate(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txt_first.Text))
            {
                
            }
        }
    }

        
    }

