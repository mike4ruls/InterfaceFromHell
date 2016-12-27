namespace InterfaceFromHell
{
    partial class Form5
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
            this.label1 = new System.Windows.Forms.Label();
            this.AreYouRdyBox = new System.Windows.Forms.Label();
            this.YeahButton = new System.Windows.Forms.Button();
            this.BackButton = new System.Windows.Forms.Button();
            this.WtfButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.AnswerTextBox = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19F);
            this.label1.Location = new System.Drawing.Point(152, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(436, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "We are Gonna play a game right now";
            // 
            // AreYouRdyBox
            // 
            this.AreYouRdyBox.AutoSize = true;
            this.AreYouRdyBox.Font = new System.Drawing.Font("Old English Text MT", 20F);
            this.AreYouRdyBox.Location = new System.Drawing.Point(219, 102);
            this.AreYouRdyBox.Name = "AreYouRdyBox";
            this.AreYouRdyBox.Size = new System.Drawing.Size(294, 32);
            this.AreYouRdyBox.TabIndex = 1;
            this.AreYouRdyBox.Text = "ARE YOU READY???";
            // 
            // YeahButton
            // 
            this.YeahButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.YeahButton.Location = new System.Drawing.Point(86, 184);
            this.YeahButton.Name = "YeahButton";
            this.YeahButton.Size = new System.Drawing.Size(571, 36);
            this.YeahButton.TabIndex = 2;
            this.YeahButton.Text = "YEAH!!";
            this.YeahButton.UseVisualStyleBackColor = true;
            this.YeahButton.Click += new System.EventHandler(this.YeahButton_Click);
            // 
            // BackButton
            // 
            this.BackButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.BackButton.Location = new System.Drawing.Point(86, 276);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(571, 36);
            this.BackButton.TabIndex = 3;
            this.BackButton.Text = "BACK";
            this.BackButton.UseVisualStyleBackColor = true;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // WtfButton
            // 
            this.WtfButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.WtfButton.Location = new System.Drawing.Point(86, 361);
            this.WtfButton.Name = "WtfButton";
            this.WtfButton.Size = new System.Drawing.Size(571, 36);
            this.WtfButton.TabIndex = 4;
            this.WtfButton.Text = "WTF IS THAT FONT";
            this.WtfButton.UseVisualStyleBackColor = true;
            this.WtfButton.Click += new System.EventHandler(this.WtfButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 409);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Console:";
            // 
            // AnswerTextBox
            // 
            this.AnswerTextBox.AutoSize = true;
            this.AnswerTextBox.Location = new System.Drawing.Point(57, 409);
            this.AnswerTextBox.Name = "AnswerTextBox";
            this.AnswerTextBox.Size = new System.Drawing.Size(188, 13);
            this.AnswerTextBox.TabIndex = 6;
            this.AnswerTextBox.Text = "Hmm didn\'t know that this was in here.";
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SpringGreen;
            this.ClientSize = new System.Drawing.Size(706, 428);
            this.Controls.Add(this.AnswerTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.WtfButton);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.YeahButton);
            this.Controls.Add(this.AreYouRdyBox);
            this.Controls.Add(this.label1);
            this.Name = "Form5";
            this.Text = "Form5";
            this.Load += new System.EventHandler(this.Form5_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label AreYouRdyBox;
        private System.Windows.Forms.Button YeahButton;
        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.Button WtfButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label AnswerTextBox;

    }
}