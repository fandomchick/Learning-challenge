
namespace Melearning
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.question = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.magic = new System.Windows.Forms.Label();
            this.btnstart = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // question
            // 
            this.question.Location = new System.Drawing.Point(152, 255);
            this.question.Name = "question";
            this.question.Size = new System.Drawing.Size(531, 27);
            this.question.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(265, 207);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(258, 26);
            this.label1.TabIndex = 1;
            this.label1.Text = "write your question down.";
            // 
            // magic
            // 
            this.magic.AutoSize = true;
            this.magic.Font = new System.Drawing.Font("Times New Roman", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.magic.Location = new System.Drawing.Point(296, 97);
            this.magic.Name = "magic";
            this.magic.Size = new System.Drawing.Size(195, 42);
            this.magic.TabIndex = 2;
            this.magic.Text = "magic 8 ball";
            this.magic.Click += new System.EventHandler(this.label2_Click);
            // 
            // btnstart
            // 
            this.btnstart.Location = new System.Drawing.Point(515, 316);
            this.btnstart.Name = "btnstart";
            this.btnstart.Size = new System.Drawing.Size(183, 45);
            this.btnstart.TabIndex = 3;
            this.btnstart.Text = "start";
            this.btnstart.UseVisualStyleBackColor = true;
            this.btnstart.Click += new System.EventHandler(this.btnstart_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(378, 161);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(18, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "...";
            this.label2.Click += new System.EventHandler(this.label2_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnstart);
            this.Controls.Add(this.magic);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.question);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox question;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label magic;
        private System.Windows.Forms.Button btnstart;
        private System.Windows.Forms.Label label2;
    }
}

