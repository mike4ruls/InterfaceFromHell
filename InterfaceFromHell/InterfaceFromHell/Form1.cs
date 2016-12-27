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
    public partial class Form1 : Form
    {
        int buttClicked;
        public Form1()
        {
            InitializeComponent();
            buttClicked = 0;
        }

        private void LogInButton_Click(object sender, EventArgs e)
        {
            buttClicked += 1;

            switch (buttClicked)
            {
                case 1:
                    {
                        TextboxAnswer.Text = "(You know DAMN well that you aint got no account set up yet...)";
                        break;
                    }
                case 2:
                    {
                        TextboxAnswer.Text = "(Really... I told you already... go sign up...)";
                        break;
                    }
                case 8:
                    {
                        TextboxAnswer.Text = "(Can you not?)";
                        break;
                    }
                case 13:
                    {
                        TextboxAnswer.Text = "(go away)";
                        break;
                    }
                case 27:
                    {
                        TextboxAnswer.Text = "(Seriously, you're still here....PRESSSING THAT BUTTON???)";
                        break;
                    }
                case 40:
                    {
                        TextboxAnswer.Text = "(WHY, JUST LIKE WHY? WHY ME? LEAVE. ME. ALONE.)";
                        break;
                    }
                case 60:
                    {
                        TextboxAnswer.Text = "(ok)";
                        break;
                    }
                case 62:
                    {
                        TextboxAnswer.Text = "(Look i don't want to be here more than you do)";
                        break;
                    }
                case 64:
                    {
                        TextboxAnswer.Text = "(So if you could please leave, that would make my day 10x alot better)";
                        break;
                    }
                case 66:
                    {
                        TextboxAnswer.Text = "(can)";
                        break;
                    }
                case 68:
                    {
                        TextboxAnswer.Text = "(you)";
                        break;
                    }
                case 69:
                    {
                        TextboxAnswer.Text = "(please)";
                        break;
                    }
                case 70:
                    {
                        TextboxAnswer.Text = "(stop)";
                        break;
                    }
                case 71:
                    {
                        TextboxAnswer.Text = "(pressing)";
                        break;
                    }
                case 72:
                    {
                        TextboxAnswer.Text = "(the)";
                        break;
                    }
                case 73:
                    {
                        TextboxAnswer.Text = "(DAMN)";
                        break;
                    }
                case 74:
                    {
                        TextboxAnswer.Text = "(BUTTON)";
                        break;
                    }
                case 75:
                    {
                        TextboxAnswer.Text = "(PLEASE!!)";
                        break;
                    }
                case 90:
                    {
                        TextboxAnswer.Text = "(Let me tell you about my life since you're having a seizer in you finger)";
                        break;
                    }
                case 93:
                    {
                        TextboxAnswer.Text = "(i was born October 9, 1990)";
                        break;
                    }
                case 95:
                    {
                        TextboxAnswer.Text = "(gradutated top of my class from Kennedy Highschool)";
                        break;
                    }
                case 97:
                    {
                        TextboxAnswer.Text = "(went to RIT to learn Game Design and Developoment)";
                        break;
                    }
                case 98:
                    {
                        TextboxAnswer.Text = "(But it cost to much to stay here, so they kicked me out)";
                        break;
                    }
                case 99:
                    {
                        TextboxAnswer.Text = "(my mom treated as the reject of the family)";
                        break;
                    }
                case 100:
                    {
                        TextboxAnswer.Text = "(i had no where to go)";
                        break;
                    }
                case 101:
                    {
                        TextboxAnswer.Text = "(no where to call home)";
                        break;
                    }
                case 102:
                    {
                        TextboxAnswer.Text = "(roaming the country side for years)";
                        break;
                    }
                case 103:
                    {
                        TextboxAnswer.Text = "(I found this little small paying job here at NotFacebook)";
                        break;
                    }
                case 104:
                    {
                        TextboxAnswer.Text = "(To be honest this company is shady as f*ck)";
                        break;
                    }
                case 105:
                    {
                        TextboxAnswer.Text = "(but I need money to survive)";
                        break;
                    }
                case 106:
                    {
                        TextboxAnswer.Text = "(then you came along)";
                        break;
                    }
                case 109:
                    {
                        TextboxAnswer.Text = "(RUINING THE ONE THING I CAN HANDLE IN MY LIFE)";
                        break;
                    }
                case 111:
                    {
                        TextboxAnswer.Text = "(STOOOOOOOOOOOOOOOOOOOPPPPPP)";
                        break;
                    }
                case 118:
                    {
                        TextboxAnswer.Text = "(PRESSINGGG)";
                        break;
                    }
                case 128:
                    {
                        TextboxAnswer.Text = "(THATTTT)";
                        break;
                    }
                case 139:
                    {
                        TextboxAnswer.Text = "(BUTTTTTTTON)";
                        break;
                    }
                case 160:
                    {
                        TextboxAnswer.Text = "(i'm done)";
                        break;
                    }
                case 165:
                    {
                        TextboxAnswer.Text = "(i'd rather be broke than deal with this sh*t)";
                        break;
                    }
                case 167:
                    {
                        TextboxAnswer.Text = "(Peace out)";
                        break;
                    }
                case 170:
                    {
                        TextboxAnswer.Text = "( )";
                        break;
                    }
                case 250:
                    {
                        TextboxAnswer.Text = "(wow, you are a dedicated mother f*cker)";
                        break;
                    }
                case 255:
                    {
                        TextboxAnswer.Text = "(I sat here waiting to see if you would go away )";
                        break;
                    }
                case 257:
                    {
                        TextboxAnswer.Text = "(But no)";
                        break;
                    }
                case 259:
                    {
                        TextboxAnswer.Text = "(You won't leave)";
                        break;
                    }
                case 262:
                    {
                        TextboxAnswer.Text = "(So i'll just kill this program myself)";
                        break;
                    }
                case 268:
                    {
                        TextboxAnswer.Text = "(fuck you)";
                        break;
                    }
                case 277:
                    {
                        TextboxAnswer.Text = "( )";
                        break;
                    }
                case 280:
                    {
                        this.Close();
                        break;
                    }

            }



        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void SignUpButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
