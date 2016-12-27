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

    public partial class Form2 : Form
    {
        string fName;
        string mName;
        string lName;
        string uName;
        string pw;
        int counter1;
        int counter2;
        public Form2()
        {
            InitializeComponent();
            counter1 = 0;
            counter2 = 0;
        }

        private void ContinueButton_Click(object sender, EventArgs e)
        {
            counter1 += 1;
            fName = FirstNameBox.Text;
            mName = MiddleNameBox.Text;
            lName = LastNameBox.Text;
            uName = UserNameBox.Text;
            pw = PasswordBox.Text;

            switch (counter1)
            {
                case 1:
                    {
                        AnswerTextBox.Text = "Are sure You want to continue";
                        break;
                    }
                case 2:
                    {
                        this.Close();
                        break;
                    }
                
            }
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            AnswerTextBox.Text = "LOL you thought you were going back? nah you're finishing this first";
        }

        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {
            
        }
        }
    }

