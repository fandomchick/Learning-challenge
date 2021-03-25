
namespace MELearningChallenge
{
    partial class RPS
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RPS));
            this.btn_rock = new System.Windows.Forms.Button();
            this.btn_paper = new System.Windows.Forms.Button();
            this.btn_scissors = new System.Windows.Forms.Button();
            this.lbl_result = new System.Windows.Forms.Label();
            this.lbl_computer = new System.Windows.Forms.Label();
            this.lbl_won = new System.Windows.Forms.Label();
            this.lbl_lost = new System.Windows.Forms.Label();
            this.lbl_draw = new System.Windows.Forms.Label();
            this.lbl_total = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_rock
            // 
            this.btn_rock.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_rock.BackgroundImage")));
            this.btn_rock.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_rock.Location = new System.Drawing.Point(50, 50);
            this.btn_rock.Name = "btn_rock";
            this.btn_rock.Size = new System.Drawing.Size(143, 117);
            this.btn_rock.TabIndex = 0;
            this.btn_rock.Text = "ROCK";
            this.btn_rock.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_rock.UseVisualStyleBackColor = true;
            this.btn_rock.Click += new System.EventHandler(this.btn_rock_Click);
            // 
            // btn_paper
            // 
            this.btn_paper.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_paper.BackgroundImage")));
            this.btn_paper.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_paper.Location = new System.Drawing.Point(290, 50);
            this.btn_paper.Name = "btn_paper";
            this.btn_paper.Size = new System.Drawing.Size(146, 117);
            this.btn_paper.TabIndex = 1;
            this.btn_paper.Text = "PAPER";
            this.btn_paper.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_paper.UseVisualStyleBackColor = true;
            this.btn_paper.Click += new System.EventHandler(this.btn_paper_Click);
            // 
            // btn_scissors
            // 
            this.btn_scissors.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_scissors.BackgroundImage")));
            this.btn_scissors.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_scissors.Location = new System.Drawing.Point(530, 50);
            this.btn_scissors.Name = "btn_scissors";
            this.btn_scissors.Size = new System.Drawing.Size(128, 117);
            this.btn_scissors.TabIndex = 2;
            this.btn_scissors.Text = "SCISSORS";
            this.btn_scissors.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_scissors.UseVisualStyleBackColor = true;
            this.btn_scissors.Click += new System.EventHandler(this.btn_scissors_Click);
            // 
            // lbl_result
            // 
            this.lbl_result.AutoSize = true;
            this.lbl_result.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_result.Location = new System.Drawing.Point(50, 50);
            this.lbl_result.Name = "lbl_result";
            this.lbl_result.Size = new System.Drawing.Size(0, 20);
            this.lbl_result.TabIndex = 3;
            this.lbl_result.Click += new System.EventHandler(this.lbl_result_Click);
            // 
            // lbl_computer
            // 
            this.lbl_computer.AutoSize = true;
            this.lbl_computer.Location = new System.Drawing.Point(290, 305);
            this.lbl_computer.Name = "lbl_computer";
            this.lbl_computer.Size = new System.Drawing.Size(0, 20);
            this.lbl_computer.TabIndex = 4;
            this.lbl_computer.Click += new System.EventHandler(this.lbl_computer_Click);
            // 
            // lbl_won
            // 
            this.lbl_won.AutoSize = true;
            this.lbl_won.Location = new System.Drawing.Point(613, 255);
            this.lbl_won.Name = "lbl_won";
            this.lbl_won.Size = new System.Drawing.Size(0, 20);
            this.lbl_won.TabIndex = 5;
            this.lbl_won.Click += new System.EventHandler(this.lbl_won_Click);
            // 
            // lbl_lost
            // 
            this.lbl_lost.AutoSize = true;
            this.lbl_lost.Location = new System.Drawing.Point(613, 305);
            this.lbl_lost.Name = "lbl_lost";
            this.lbl_lost.Size = new System.Drawing.Size(0, 20);
            this.lbl_lost.TabIndex = 6;
            // 
            // lbl_draw
            // 
            this.lbl_draw.AutoSize = true;
            this.lbl_draw.Location = new System.Drawing.Point(613, 360);
            this.lbl_draw.Name = "lbl_draw";
            this.lbl_draw.Size = new System.Drawing.Size(0, 20);
            this.lbl_draw.TabIndex = 7;
            // 
            // lbl_total
            // 
            this.lbl_total.AutoSize = true;
            this.lbl_total.Location = new System.Drawing.Point(613, 413);
            this.lbl_total.Name = "lbl_total";
            this.lbl_total.Size = new System.Drawing.Size(0, 20);
            this.lbl_total.TabIndex = 8;
            // 
            // RPS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbl_total);
            this.Controls.Add(this.lbl_draw);
            this.Controls.Add(this.lbl_lost);
            this.Controls.Add(this.lbl_won);
            this.Controls.Add(this.lbl_computer);
            this.Controls.Add(this.lbl_result);
            this.Controls.Add(this.btn_scissors);
            this.Controls.Add(this.btn_paper);
            this.Controls.Add(this.btn_rock);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "RPS";
            this.Text = "RockPaperScissors";
            this.Load += new System.EventHandler(this.RPS_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_rock;
        private System.Windows.Forms.Button btn_paper;
        private System.Windows.Forms.Button btn_scissors;
        private System.Windows.Forms.Label lbl_result;
        private System.Windows.Forms.Label lbl_computer;
        private System.Windows.Forms.Label lbl_won;
        private System.Windows.Forms.Label lbl_lost;
        private System.Windows.Forms.Label lbl_draw;
        private System.Windows.Forms.Label lbl_total;
    }
}