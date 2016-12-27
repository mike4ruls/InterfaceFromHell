using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows;

namespace InterfaceFromHell
{
    public partial class Form7 : Form
    {
        int buttClicked;
        public Form7()
        {
            InitializeComponent();
            buttClicked = 0;
            TextboxAnswer.Text = "What happened here??";
        }

        private void LogInButton_Click(object sender, EventArgs e)
        {
            
        }

        private void SignUpButton_Click(object sender, EventArgs e)
        {

        }
    }
}
