
namespace MELearningChallenge
{
    partial class Main
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
            this.lblMain = new System.Windows.Forms.Label();
            this.txt_first = new System.Windows.Forms.TextBox();
            this.txt_last = new System.Windows.Forms.TextBox();
            this.lbl_first = new System.Windows.Forms.Label();
            this.lbl_last = new System.Windows.Forms.Label();
            this.btn_Confirm = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblMain
            // 
            this.lblMain.AutoSize = true;
            this.lblMain.Location = new System.Drawing.Point(51, 33);
            this.lblMain.Name = "lblMain";
            this.lblMain.Size = new System.Drawing.Size(0, 20);
            this.lblMain.TabIndex = 0;
            // 
            // txt_first
            // 
            this.txt_first.Location = new System.Drawing.Point(292, 234);
            this.txt_first.Name = "txt_first";
            this.txt_first.Size = new System.Drawing.Size(225, 27);
            this.txt_first.TabIndex = 1;
            this.txt_first.Validating += new System.ComponentModel.CancelEventHandler(this.txt_validate);
            // 
            // txt_last
            // 
            this.txt_last.Location = new System.Drawing.Point(292, 315);
            this.txt_last.Name = "txt_last";
            this.txt_last.Size = new System.Drawing.Size(225, 27);
            this.txt_last.TabIndex = 2;
            // 
            // lbl_first
            // 
            this.lbl_first.AutoSize = true;
            this.lbl_first.Location = new System.Drawing.Point(51, 234);
            this.lbl_first.Name = "lbl_first";
            this.lbl_first.Size = new System.Drawing.Size(0, 20);
            this.lbl_first.TabIndex = 3;
            // 
            // lbl_last
            // 
            this.lbl_last.AutoSize = true;
            this.lbl_last.Location = new System.Drawing.Point(51, 315);
            this.lbl_last.Name = "lbl_last";
            this.lbl_last.Size = new System.Drawing.Size(0, 20);
            this.lbl_last.TabIndex = 4;
            // 
            // btn_Confirm
            // 
            this.btn_Confirm.Location = new System.Drawing.Point(583, 385);
            this.btn_Confirm.Name = "btn_Confirm";
            this.btn_Confirm.Size = new System.Drawing.Size(94, 29);
            this.btn_Confirm.TabIndex = 5;
            this.btn_Confirm.Text = "Confirm";
            this.btn_Confirm.UseVisualStyleBackColor = true;
            this.btn_Confirm.Click += new System.EventHandler(this.btn_Confirm_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_Confirm);
            this.Controls.Add(this.lbl_last);
            this.Controls.Add(this.lbl_first);
            this.Controls.Add(this.txt_last);
            this.Controls.Add(this.txt_first);
            this.Controls.Add(this.lblMain);
            this.Name = "Main";
            this.Text = "Main";
            this.Load += new System.EventHandler(this.Main_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMain;
        private System.Windows.Forms.Label lbl_first;
        private System.Windows.Forms.Label lbl_last;
        private System.Windows.Forms.Button btn_Confirm;
        public System.Windows.Forms.TextBox txt_first;
        public System.Windows.Forms.TextBox txt_last;
    }
}

