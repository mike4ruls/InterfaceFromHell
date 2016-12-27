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
    public partial class Form6 : Form
    {
        int answer;
        int score;
        int questionNum;
        int timeCount;
        int timeNeeded;
        int change;

        public Form6()
        {
            InitializeComponent();
            timeCount = 0;
            timeNeeded = 5;
            score = 0;
            questionNum = 1;
            change = 0;

            progressBar1.Value = 0;
            timer1.Interval = 1000;
            timer1.Start();
        }
           

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form6_Load(object sender, EventArgs e)
        {

        }

        private void EnterButton_Click(object sender, EventArgs e)
        {
            if (questionNum >= 12)
            {
                this.Close();
            }
            else if (questionNum == 11)
            {
                timer1.Stop();
                progressBar1.Value = 0;
                questionNum += 1;
                EnterButton.Text = "Continue";
            }
            
            else if (answer >= 1)
            {
                if(questionNum == 6 && change == 1)
                {
                    if (Button3.Checked == true)
                    {

                        AnswerTextBox.Text = "Wow this got weird really fast...";
                        Question();
                        Button1.Checked = false;
                        Button2.Checked = false;
                        Button3.Checked = false;
                        Button4.Checked = false;
                        progressBar1.Value = 0;
                        timeCount = 0;
                        answer = 0;
                    }
                    else
                    {
                        AnswerTextBox.Text = "Welp I guess you got to love him. Do it for the points, the poiiintttsssss...";
                        QuestionBox.Text = "Question 6: Lets try this Again";
                        Button1.Text = "I Love You";
                        Button2.Text = "I Love You";
                        Button3.Text = "I Love You";
                        Button4.Text = "I Love You";

                        Button1.Checked = false;
                        Button2.Checked = false;
                        Button3.Checked = false;
                        Button4.Checked = false;
                        progressBar1.Value = 0;
                        timeCount = 0;
                        answer = 0;
                        change = 0;
                        
                    }
                }
                else if (questionNum == 9 && change == 1)
                {
                    if (Button4.Checked == true)
                    {

                        AnswerTextBox.Text = "Huh so you're honest i give you respect";
                        Question();
                        Button1.Checked = false;
                        Button2.Checked = false;
                        Button3.Checked = false;
                        Button4.Checked = false;
                        progressBar1.Value = 0;
                        timeCount = 0;
                        answer = 0;


                    }
                    else
                    {
                        AnswerTextBox.Text = "YOU'RE A F*CKING LIAR";
                        QuestionBox.Text = "Question 9: You lying ass motherf*cker, Lets do this again";
                        Button1.Text = "Bronze";
                        Button2.Text = "Bronze";
                        Button3.Text = "Bronze";
                        Button4.Text = "Bronze";

                        Button1.Checked = false;
                        Button2.Checked = false;
                        Button3.Checked = false;
                        Button4.Checked = false;
                        progressBar1.Value = 0;
                        timeCount = 0;
                        answer = 0;
                        change = 0;
                    }

                }
                else
                {  
                    progressBar1.Value = 0;
                    timeCount = 0;
                    answer = 0;
                    AnswerTextBox.Text = "";
                    Question();
                    Button1.Checked = false;
                    Button2.Checked = false;
                    Button3.Checked = false;
                    Button4.Checked = false;
                    
                }
            }
            else
            {
            AnswerTextBox.Text = "Bruh you are running out of time PICK AN OPTION ALREADY";
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timeCount++;

            int pct = (timeCount * 100) / timeNeeded;
            if (pct <= 100)
            {
                progressBar1.Value = pct;
            }
            if (questionNum >= 11)
            {
                timer1.Stop();
                progressBar1.Value = 0;
            }
            if (timeCount > timeNeeded)
            {

                progressBar1.Value = 0;
                timeCount = 0;
                answer = 0;
                AnswerTextBox.Text = "Bruh missed a question, step up your game...";
                Question();
            }
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }
        public void Question()
        {
            switch (questionNum)
            {
                case 1:
                    {
                       
                        if (Button2.Checked == true)
                        {
                            score += 1;
                            AnswerTextBox.Text = "Wow ho- how was that even right??????????";
                            ScoreBox.Text = "Score: " + score;                            
                        }                      
                        else if (Button4.Checked == true)
                        {
                            AnswerTextBox.Text = "Why was that even and option and why did you chose it and  WHY IS IT BLUSHING???";
                        }
                        else
                        {
                            AnswerTextBox.Text = "Out of all the answers you had, you still got it wrong... gg";
                        }
                        QuestionBox.Text = "Question 2: How many fingers do you own?";
                        Button1.Text = "40";
                        Button2.Text = "what are fingers...";
                        Button3.Text = "5";
                        Button4.Text = "20";
                        questionNum += 1;
                        break;
                    }
                case 2:
                    {
                        if (Button4.Checked == true)
                        {
                            AnswerTextBox.Text = "OOOooooooohhhhh its 20 because of your toes";
                            score += 1;
                            ScoreBox.Text = "Score: " + score;
                        }
                        else
                        {
                            AnswerTextBox.Text = "What are these answers???";
                        }
                        
                        QuestionBox.Text = "Question 3: what is the circumference of a square";
                        Button1.Text = "Shape";
                        Button2.Text = "I Love You";
                        Button3.Text = "r= WxH^2";
                        Button4.Text = "Wut";
                        questionNum += 1;
                        break;
                    }
                case 3:
                    {
                        if (Button4.Checked == true)
                        {
                            AnswerTextBox.Text = "Wuttt? that was right?";
                            score += 1;
                            ScoreBox.Text = "Score: " + score;
                        }
                        else if (Button2.Checked == true)
                        {
                            AnswerTextBox.Text = "Stop saying I love you to it this is getting weird...";
                        }
                        else
                        {
                            AnswerTextBox.Text = "Is it me or is there 2 options the same answer?";
                        }

                        QuestionBox.Text = "Question 4: How many muscles do you use to stand up";
                        Button1.Text = "I Love You";
                        Button2.Text = "800";
                        Button3.Text = "4";
                        Button4.Text = "4";
                        questionNum += 1;
                        break;
                    }
                case 4:
                    {
                        if (Button2.Checked == true)
                        {
                            AnswerTextBox.Text = "800, huh even i didnt know that but I guess that's cause im software";
                            score += 1;
                            ScoreBox.Text = "Score: " + score;
                        }

                        QuestionBox.Text = "Question 5: If Daquan has 6 apples and Jerry Steals 5 apples from Daquan how many Apples does Daquan have?";
                        Button1.Text = "1";
                        Button2.Text = "6, because Daquan shot Jerry for stealing his stuff";
                        Button3.Text = "40, because Daquan then stole from Lisa. Lisa had 39 apples";
                        Button4.Text = "10 because Daquan is a wizard";
                        questionNum += 1;
                        break;
                    }
                case 5:
                    {
                        if (Button2.Checked == true || Button3.Checked == true || Button4.Checked == true)
                        {
                            AnswerTextBox.Text = "Daquan sounds like a savage";
                            score += 1;
                            ScoreBox.Text = "Score: " + score;
                        }

                        QuestionBox.Text = "Question 6: Do you love me? ";
                        Button1.Text = "Uhh i'm actually not looking for a relationship";
                        Button2.Text = "What's love?";
                        Button3.Text = "I Love You";
                        Button4.Text = "Nah";
                        questionNum += 1;
                        change += 1;
                        break;
                    }
                case 6:
                    {
                            score += 1;
                            ScoreBox.Text = "Score: " + score;

                        QuestionBox.Text = "Question 7: Which Grand Theft Auto was best?";
                        Button1.Text = "GTA: Vice City";
                        Button2.Text = "GTA: Liberty City";
                        Button3.Text = "GTAV";
                        Button4.Text = "Pikimin 3";
                        questionNum += 1;
                        break;
                    }
                case 7:
                    {
                        if (Button4.Checked == true)
                        {
                            AnswerTextBox.Text = "I was more of a Sleeping Dogs guy";
                            score += 1;
                            ScoreBox.Text = "Score: " + score;
                        }
                        else
                        {
                            AnswerTextBox.Text = "I was more of a Sleeping Dogs guy";
                        }

                        QuestionBox.Text = "Question 8: if mary is driving at 90 mph on the freeway, how many pizzas did she buy";
                        Button1.Text = "10";
                        Button2.Text = "I don't know";
                        Button3.Text = "None cause she crashed";
                        Button4.Text = "I Love You";
                        questionNum += 1;
                        break;
                    }
                case 8:
                    {
                        if (Button3.Checked == true)
                        {
                            AnswerTextBox.Text = "Bruh she crashed?!!??! call an ambulance";
                            score += 1;
                            ScoreBox.Text = "Score: " + score;
                        }
                        else
                        {
                            AnswerTextBox.Text = "What is the answer even";
                        }

                        QuestionBox.Text = "Question 9: What rank are you on league?";
                        Button1.Text = "Challenger";
                        Button2.Text = "Master";
                        Button3.Text = "Diamond";
                        Button4.Text = "Bronze";
                        questionNum += 1;
                        change += 1;
                        break;
                    }
                case 9:
                    {

                            AnswerTextBox.Text = "Bronze will be Bronze smh....";
                            score += 1;
                            ScoreBox.Text = "Score: " + score;


                        QuestionBox.Text = "Question 10: What's a dad?";
                        Button1.Text = "???";
                        Button2.Text = "Good question";
                        Button3.Text = "A magical creature";
                        Button4.Text = "A parent";
                        questionNum += 1;
                        break;
                    }
                
                case 10:
                    {
                        AnswerTextBox.Text = "I wouldn't know what a dad is since im software.... Dad ;-;";
                        score += 1;
                        ScoreBox.Text = "Score: " + score;

                        QuestionBox.Text = "Hey you got a " + score + "outta 10 questions get wrekt'd";
                        Button1.Text = "";
                        Button2.Text = "";
                        Button3.Text = "";
                        Button4.Text = "";
                        questionNum += 1;
                        break;
                    }
            }
        }

        private void Button1_CheckedChanged(object sender, EventArgs e)
        {
            answer += 1;
        }

        private void Button2_CheckedChanged(object sender, EventArgs e)
        {
            answer += 1;
        }

        private void Button3_CheckedChanged(object sender, EventArgs e)
        {
            answer += 1;
        }

        private void Button4_CheckedChanged(object sender, EventArgs e)
        {
            answer += 1;
        }
    }
}
