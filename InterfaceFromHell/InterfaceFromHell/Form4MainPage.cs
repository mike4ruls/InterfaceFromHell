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
    public partial class Form4MainPage : Form
    {
        int buttClicked;
        public Form4MainPage()
        {
            InitializeComponent();
            buttClicked = 0;
        }

        private void LogInButton_Click(object sender, EventArgs e)
        {
            TextboxAnswer.Text = "Lol my bad I lost your account information";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void SignUpButton_Click(object sender, EventArgs e)
        {
            TextboxAnswer.Text = "Man I already know you signed up already, so login";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            buttClicked += 1;

            switch (buttClicked)
            {
                case 1:
                    {
                        TextboxAnswer.Text = "Curious on wut this button does aren't cha";
                        break;
                    }
                case 2:
                    {
                        TextboxAnswer.Text = "me too lets see wat happens";
                        button1.Text = "Ok Let's see";
                        break;
                    }
                case 3:
                    {
                        this.Close();
                        break;
                    }
            }
            
        }
    }
}
