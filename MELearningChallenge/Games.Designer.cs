
namespace MELearningChallenge
{
    partial class GamesPage
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GamesPage));
            this.btn_rps = new System.Windows.Forms.Button();
            this.btn_4 = new System.Windows.Forms.Button();
            this.btn_ttt = new System.Windows.Forms.Button();
            this.lbl_games = new System.Windows.Forms.Label();
            this.lbl_games2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_rps
            // 
            this.btn_rps.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_rps.BackgroundImage")));
            this.btn_rps.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_rps.Location = new System.Drawing.Point(158, 104);
            this.btn_rps.Name = "btn_rps";
            this.btn_rps.Size = new System.Drawing.Size(124, 103);
            this.btn_rps.TabIndex = 0;
            this.btn_rps.UseVisualStyleBackColor = true;
            this.btn_rps.Click += new System.EventHandler(this.btn_rps_Click);
            // 
            // btn_4
            // 
            this.btn_4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_4.BackgroundImage")));
            this.btn_4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_4.Location = new System.Drawing.Point(401, 104);
            this.btn_4.Name = "btn_4";
            this.btn_4.Size = new System.Drawing.Size(132, 103);
            this.btn_4.TabIndex = 1;
            this.btn_4.UseVisualStyleBackColor = true;
            this.btn_4.Click += new System.EventHandler(this.btn_4_Click);
            // 
            // btn_ttt
            // 
            this.btn_ttt.Location = new System.Drawing.Point(286, 243);
            this.btn_ttt.Name = "btn_ttt";
            this.btn_ttt.Size = new System.Drawing.Size(108, 122);
            this.btn_ttt.TabIndex = 2;
            this.btn_ttt.Text = "Tic Tac Toe";
            this.btn_ttt.UseVisualStyleBackColor = true;
            this.btn_ttt.Click += new System.EventHandler(this.btn_ttt_Click);
            // 
            // lbl_games
            // 
            this.lbl_games.AutoSize = true;
            this.lbl_games.Location = new System.Drawing.Point(83, 30);
            this.lbl_games.Name = "lbl_games";
            this.lbl_games.Size = new System.Drawing.Size(0, 20);
            this.lbl_games.TabIndex = 3;
            // 
            // lbl_games2
            // 
            this.lbl_games2.AutoSize = true;
            this.lbl_games2.Location = new System.Drawing.Point(229, 59);
            this.lbl_games2.Name = "lbl_games2";
            this.lbl_games2.Size = new System.Drawing.Size(0, 20);
            this.lbl_games2.TabIndex = 4;
            // 
            // GamesPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbl_games2);
            this.Controls.Add(this.lbl_games);
            this.Controls.Add(this.btn_ttt);
            this.Controls.Add(this.btn_4);
            this.Controls.Add(this.btn_rps);
            this.Name = "GamesPage";
            this.Text = "Games";
            this.Load += new System.EventHandler(this.GamesPage_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_rps;
        private System.Windows.Forms.Button btn_4;
        private System.Windows.Forms.Button btn_ttt;
        private System.Windows.Forms.Label lbl_games;
        private System.Windows.Forms.Label lbl_games2;
    }
}