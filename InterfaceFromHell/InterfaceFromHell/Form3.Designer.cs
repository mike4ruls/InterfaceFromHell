namespace InterfaceFromHell
{
    partial class Form3
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
            this.UserNameBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.YesButton = new System.Windows.Forms.Button();
            this.MaybeButton = new System.Windows.Forms.Button();
            this.AnswerTextBox = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label1.Location = new System.Drawing.Point(34, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(309, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Are you sure you want to keep the user name:";
            // 
            // UserNameBox
            // 
            this.UserNameBox.Enabled = false;
            this.UserNameBox.Location = new System.Drawing.Point(66, 48);
            this.UserNameBox.Name = "UserNameBox";
            this.UserNameBox.Size = new System.Drawing.Size(240, 20);
            this.UserNameBox.TabIndex = 1;
            this.UserNameBox.TextChanged += new System.EventHandler(this.UserNameBox_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(268, 102);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "No wtf?";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // YesButton
            // 
            this.YesButton.Location = new System.Drawing.Point(37, 102);
            this.YesButton.Name = "YesButton";
            this.YesButton.Size = new System.Drawing.Size(75, 23);
            this.YesButton.TabIndex = 3;
            this.YesButton.Text = "Yes";
            this.YesButton.UseVisualStyleBackColor = true;
            this.YesButton.Click += new System.EventHandler(this.YesButton_Click);
            // 
            // MaybeButton
            // 
            this.MaybeButton.Location = new System.Drawing.Point(152, 102);
            this.MaybeButton.Name = "MaybeButton";
            this.MaybeButton.Size = new System.Drawing.Size(75, 23);
            this.MaybeButton.TabIndex = 4;
            this.MaybeButton.Text = "Maybe?";
            this.MaybeButton.UseVisualStyleBackColor = true;
            this.MaybeButton.Click += new System.EventHandler(this.MaybeButton_Click);
            // 
            // AnswerTextBox
            // 
            this.AnswerTextBox.AutoSize = true;
            this.AnswerTextBox.Location = new System.Drawing.Point(62, 79);
            this.AnswerTextBox.Name = "AnswerTextBox";
            this.AnswerTextBox.Size = new System.Drawing.Size(0, 13);
            this.AnswerTextBox.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Console:";
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(372, 137);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.AnswerTextBox);
            this.Controls.Add(this.MaybeButton);
            this.Controls.Add(this.YesButton);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.UserNameBox);
            this.Controls.Add(this.label1);
            this.Name = "Form3";
            this.Text = "Form3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox UserNameBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button YesButton;
        private System.Windows.Forms.Button MaybeButton;
        private System.Windows.Forms.Label AnswerTextBox;
        private System.Windows.Forms.Label label2;
    }
}