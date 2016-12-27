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
    public partial class Form8 : Form
    {
        string name;
        int num;
        public Form8()
        {
            InitializeComponent();
            num = 0;
            name = "";
        }

        private void NameBox_TextChanged(object sender, EventArgs e)
        {
            name = NameBox.Text;
        }

        private void EnterButton_Click(object sender, EventArgs e)
        {
            if (NameBox.Text != "")
            {


                num += 1;

                switch (num)
                {
                    case 1:
                        {
                            AnswerTextBox.Text = "Click the enter button again to see the story i guess";
                            StoryBox.Text = "I've generated the best story for you to read from what you gave me";
                            break;
                        }
                    case 2:
                        {
                            AnswerTextBox.Text = "What a beautiful story";
                            StoryBox.Text = "One day " + name + " Woke up and got shot. THE END";
                            break;
                        }
                }
            }
            else
            {
                AnswerTextBox.Text = "DUDE I JUST WANNA READ STORY, HURRY!! ";
                StoryBox.Text = "FILL OUT ALL THE CATAGORIES";
            }
            
        }
    }
}
