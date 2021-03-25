using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace MELearningChallenge
{
    public partial class GamesPage : Form
    {
        Main main = new Main();
        public GamesPage(string first, string last)
        {
            InitializeComponent();

            string name = first + " " + last;
            //This will be a constructor (To copy the values from the MainPage to the Games page)
            lbl_games.Text = "Hello " + name;
            lbl_games2.Text = "What game do you want to play?";

        }

        private void GamesPage_Load(object sender, EventArgs e)
        {
            
        }

        private void btn_rps_Click(object sender, EventArgs e)
        {
            RPS rps = new RPS();
            rps.ShowDialog();
           
        }

        private void btn_4_Click(object sender, EventArgs e)
        {
            ball8 ball = new ball8();
            ball.ShowDialog();
            
        }

        private void btn_ttt_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
    }
}
