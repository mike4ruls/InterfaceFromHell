namespace InterfaceFromHell
{
    partial class Form6
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
            this.components = new System.ComponentModel.Container();
            this.QuestionBox = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.AnswerTextBox = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.Button1 = new System.Windows.Forms.RadioButton();
            this.Button2 = new System.Windows.Forms.RadioButton();
            this.Button3 = new System.Windows.Forms.RadioButton();
            this.Button4 = new System.Windows.Forms.RadioButton();
            this.EnterButton = new System.Windows.Forms.Button();
            this.ScoreBox = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // QuestionBox
            // 
            this.QuestionBox.AutoSize = true;
            this.QuestionBox.BackColor = System.Drawing.Color.White;
            this.QuestionBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.QuestionBox.Location = new System.Drawing.Point(38, 30);
            this.QuestionBox.Name = "QuestionBox";
            this.QuestionBox.Size = new System.Drawing.Size(187, 18);
            this.QuestionBox.TabIndex = 0;
            this.QuestionBox.Text = "Question 1:  What is 2 + 2?";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 264);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Console:";
            // 
            // AnswerTextBox
            // 
            this.AnswerTextBox.AutoSize = true;
            this.AnswerTextBox.Location = new System.Drawing.Point(55, 264);
            this.AnswerTextBox.Name = "AnswerTextBox";
            this.AnswerTextBox.Size = new System.Drawing.Size(128, 13);
            this.AnswerTextBox.TabIndex = 2;
            this.AnswerTextBox.Text = "What are these answers?";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(41, 229);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(566, 23);
            this.progressBar1.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.progressBar1.TabIndex = 3;
            this.progressBar1.Click += new System.EventHandler(this.progressBar1_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Button1
            // 
            this.Button1.AutoSize = true;
            this.Button1.Location = new System.Drawing.Point(41, 65);
            this.Button1.Name = "Button1";
            this.Button1.Size = new System.Drawing.Size(31, 17);
            this.Button1.TabIndex = 4;
            this.Button1.TabStop = true;
            this.Button1.Text = "4";
            this.Button1.UseVisualStyleBackColor = true;
            this.Button1.CheckedChanged += new System.EventHandler(this.Button1_CheckedChanged);
            // 
            // Button2
            // 
            this.Button2.AutoSize = true;
            this.Button2.Location = new System.Drawing.Point(41, 97);
            this.Button2.Name = "Button2";
            this.Button2.Size = new System.Drawing.Size(37, 17);
            this.Button2.TabIndex = 5;
            this.Button2.TabStop = true;
            this.Button2.Text = "22";
            this.Button2.UseVisualStyleBackColor = true;
            this.Button2.CheckedChanged += new System.EventHandler(this.Button2_CheckedChanged);
            // 
            // Button3
            // 
            this.Button3.AutoSize = true;
            this.Button3.Location = new System.Drawing.Point(42, 133);
            this.Button3.Name = "Button3";
            this.Button3.Size = new System.Drawing.Size(36, 17);
            this.Button3.TabIndex = 6;
            this.Button3.TabStop = true;
            this.Button3.Text = "@";
            this.Button3.UseVisualStyleBackColor = true;
            this.Button3.CheckedChanged += new System.EventHandler(this.Button3_CheckedChanged);
            // 
            // Button4
            // 
            this.Button4.AutoSize = true;
            this.Button4.Location = new System.Drawing.Point(41, 166);
            this.Button4.Name = "Button4";
            this.Button4.Size = new System.Drawing.Size(77, 17);
            this.Button4.TabIndex = 7;
            this.Button4.TabStop = true;
            this.Button4.Text = "I Love You";
            this.Button4.UseVisualStyleBackColor = true;
            this.Button4.CheckedChanged += new System.EventHandler(this.Button4_CheckedChanged);
            // 
            // EnterButton
            // 
            this.EnterButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EnterButton.Location = new System.Drawing.Point(210, 189);
            this.EnterButton.Name = "EnterButton";
            this.EnterButton.Size = new System.Drawing.Size(232, 34);
            this.EnterButton.TabIndex = 8;
            this.EnterButton.Text = "ENTER";
            this.EnterButton.UseVisualStyleBackColor = true;
            this.EnterButton.Click += new System.EventHandler(this.EnterButton_Click);
            // 
            // ScoreBox
            // 
            this.ScoreBox.AutoSize = true;
            this.ScoreBox.Location = new System.Drawing.Point(578, 264);
            this.ScoreBox.Name = "ScoreBox";
            this.ScoreBox.Size = new System.Drawing.Size(56, 13);
            this.ScoreBox.TabIndex = 9;
            this.ScoreBox.Text = "SCORE: 0";
            // 
            // Form6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SpringGreen;
            this.ClientSize = new System.Drawing.Size(646, 286);
            this.Controls.Add(this.ScoreBox);
            this.Controls.Add(this.EnterButton);
            this.Controls.Add(this.Button4);
            this.Controls.Add(this.Button3);
            this.Controls.Add(this.Button2);
            this.Controls.Add(this.Button1);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.AnswerTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.QuestionBox);
            this.Name = "Form6";
            this.Text = "Form6";
            this.Load += new System.EventHandler(this.Form6_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label QuestionBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label AnswerTextBox;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.RadioButton Button1;
        private System.Windows.Forms.RadioButton Button2;
        private System.Windows.Forms.RadioButton Button3;
        private System.Windows.Forms.RadioButton Button4;
        private System.Windows.Forms.Button EnterButton;
        private System.Windows.Forms.Label ScoreBox;
    }
}