
namespace MELearningChallenge
{
    partial class ball8
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
            this.btn_ball = new System.Windows.Forms.Button();
            this.txt_ball = new System.Windows.Forms.TextBox();
            this.lbl_ball = new System.Windows.Forms.Label();
            this.lbl_result = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_ball
            // 
            this.btn_ball.Location = new System.Drawing.Point(585, 352);
            this.btn_ball.Name = "btn_ball";
            this.btn_ball.Size = new System.Drawing.Size(94, 29);
            this.btn_ball.TabIndex = 0;
            this.btn_ball.Text = "OK";
            this.btn_ball.UseVisualStyleBackColor = true;
            this.btn_ball.Click += new System.EventHandler(this.btn_ball_Click);
            // 
            // txt_ball
            // 
            this.txt_ball.Location = new System.Drawing.Point(196, 225);
            this.txt_ball.Name = "txt_ball";
            this.txt_ball.Size = new System.Drawing.Size(399, 27);
            this.txt_ball.TabIndex = 1;
            // 
            // lbl_ball
            // 
            this.lbl_ball.AutoSize = true;
            this.lbl_ball.Location = new System.Drawing.Point(367, 124);
            this.lbl_ball.Name = "lbl_ball";
            this.lbl_ball.Size = new System.Drawing.Size(0, 20);
            this.lbl_ball.TabIndex = 2;
            // 
            // lbl_result
            // 
            this.lbl_result.AutoSize = true;
            this.lbl_result.Location = new System.Drawing.Point(367, 282);
            this.lbl_result.Name = "lbl_result";
            this.lbl_result.Size = new System.Drawing.Size(0, 20);
            this.lbl_result.TabIndex = 3;
            // 
            // ball8
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbl_result);
            this.Controls.Add(this.lbl_ball);
            this.Controls.Add(this.txt_ball);
            this.Controls.Add(this.btn_ball);
            this.Name = "ball8";
            this.Text = "Magic 8-Ball";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_ball;
        private System.Windows.Forms.TextBox txt_ball;
        private System.Windows.Forms.Label lbl_ball;
        private System.Windows.Forms.Label lbl_result;
    }
}