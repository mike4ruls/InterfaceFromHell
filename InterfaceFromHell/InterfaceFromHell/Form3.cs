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
    public partial class Form3 : Form
    {
        int num1;
        int num2;
        int num3;
        string[] names;
        Random rgen;
        public Form3()
        {
            InitializeComponent();
            names = new string[]{"Lunch Bag", "Scrub","SwoopMasterFlex", "MyDad", "BronzeBadie", "FindMyDad.Com", "JimmyRustler", "Mom'sSpahgetti", "Pizza", 
                                   "Sk8OrDieMom", "Xxx360NoScopexxX", "MLGpro", "MountainXDewXDoritos", "My Dog Died and I Can't Stop Laughing", "HoneyBooBooGoesToTheTrapHouse", 
                                   "Waldo", "BurntWaffles", "Mike4ruls", "BootyShaker69", "JaxIsn'tBroken", "Adc or Feed", "Afk or Feed", "WAT ARE THOOOSSEEE", "WATER THOOOSE"};

            rgen = new Random();
            num1 = 0;
            num2 = 0;
            num3 = 0;
            UserNameBox.Text = names[rgen.Next(0, 25)];
        }

        private void UserNameBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void MaybeButton_Click(object sender, EventArgs e)
        {
            num2 += 1;

            switch (num2)
            {
                case 1:
                    {
                        AnswerTextBox.Text = "Whatchu mean maybe? this is a yes or no question...";
                        break;
                    }
                case 2:
                    {
                        AnswerTextBox.Text = "What exactly are you expecting this button to do?";
                        break;
                    }
                case 3:
                    {
                        AnswerTextBox.Text = "Seriously i don't even know what this is suppose to do";
                        break;
                    }
                case 4:
                    {
                        AnswerTextBox.Text = "Ok how about we just delete it";
                        MaybeButton.Text = "";
                        break;
                    }
            }
            
        }

        private void YesButton_Click(object sender, EventArgs e)
        {
            num1 += 1;
            switch (num1)
            {
                case 1:
                    {
                        AnswerTextBox.Text = "liar";
                        break;
                    }
                case 2:
                    {
                        AnswerTextBox.Text = "You really want this name";
                        break;
                    }
                case 3:
                    {
                        AnswerTextBox.Text = "Lol wow ok w.e just go log in now";
                        YesButton.Text = "Log In";
                        break;
                    }
                case 4:
                    {
                        this.Close();
                        break;
                    }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            num3 += 1;
            switch (num3)
            {
                case 1:
                    {
                        label1.Text = "Wait.........";
                        AnswerTextBox.Text = "Wait hold up was this your user name?";
                        UserNameBox.Text = names[rgen.Next(0, 25)];
                        break;
                    }
                case 2:
                    {
                        label1.Text = "???...........";
                        AnswerTextBox.Text = "Wat? this wasn't it either?";
                        UserNameBox.Text = names[rgen.Next(0, 25)];
                        break;
                    }
                case 3:
                    {
                        label1.Text = "Hold On .  .  .  ";
                        AnswerTextBox.Text = "uuuuuuuumm this????";
                        UserNameBox.Text = names[rgen.Next(0, 25)];
                        break;
                    }
                case 4:
                    {
                        label1.Text = "Wut.....";
                        AnswerTextBox.Text = "GG whatever i'm just gonna take you back to the main page";
                        button1.Text = "Go Back";
                        UserNameBox.Text = names[rgen.Next(0, 25)];
                        break;
                    }
                case 5:
                    {
                        this.Close();
                        break;
                    }
            }
            
        }
    }
}
