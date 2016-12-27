using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InterfaceFromHell
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void YeahButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            label1.Text = "You ARE going to pLay...";
            AnswerTextBox.Text = "You still don't get how this works do you...";
        }

        private void WtfButton_Click(object sender, EventArgs e)
        {
            AreYouRdyBox.Text = "SCREW YOU";
            AnswerTextBox.Text = "Why would go ahead say that and hurt it's feeling, it was born that way...Savage";
        }

        private void Form5_Load(object sender, EventArgs e)
        {

        }
    }
}
