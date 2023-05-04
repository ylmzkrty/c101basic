using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Passaparola
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int qno = 0, qtrue = 0, qfalse = 0;

        private void RchAnswer_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                switch (qno)
                {
                    case 1:
                        if (RchAnswer.Text == "Iğdır")
                        {
                            BtnA.BackColor = Color.Green;
                        }
                        else
                        { 
                            BtnA.BackColor = Color.Red;
                        }
                        break;

                    case 2:
                        if (RchAnswer.Text == "7")
                        {
                            BtnB.BackColor = Color.Green;
                        }
                        else
                        {
                            BtnB.BackColor = Color.Red;
                        }
                        break;
                    case 3:
                        if (RchAnswer.Text == "1881")
                        {
                            BtnC.BackColor = Color.Green;
                        }
                        else
                        {
                            BtnC.BackColor = Color.Red;
                        }
                        break;
                    case 4:
                        if (RchAnswer.Text == "Friday")
                        {
                            BtnD.BackColor = Color.Green;
                        }
                        else
                        {
                            BtnD.BackColor = Color.Red;
                        }
                        break;
                    case 5:
                        if (RchAnswer.Text == "Old")
                        {
                            BtnE.BackColor = Color.Green;
                        }
                        else
                        {
                            BtnE.BackColor = Color.Red;
                        }
                        break;
                    case 6:
                        if (RchAnswer.Text == "Sun")
                        {
                            BtnF.BackColor = Color.Green;
                        }
                        else
                        {
                            BtnF.BackColor = Color.Red;
                        }
                        break;
                    case 7:
                        if (RchAnswer.Text == "365")
                        {
                            BtnG.BackColor = Color.Green;
                        }
                        else
                        {
                            BtnG.BackColor = Color.Red;
                        }
                        break;
                    case 8:
                        if (RchAnswer.Text == "Ankara")
                        {
                            BtnH.BackColor = Color.Green;
                        }
                        else
                        {
                            BtnH.BackColor = Color.Red;
                        }
                        break;
                    case 9:
                        if (RchAnswer.Text == "25th December")
                        {
                            BtnI.BackColor = Color.Green;
                        }
                        else
                        {
                            BtnI.BackColor = Color.Red;
                        }
                        break;
                    case 10:
                        if (RchAnswer.Text == "Messi")
                        {
                            BtnJ.BackColor = Color.Green;
                        }
                        else
                        {
                            BtnJ.BackColor = Color.Red;
                        }
                        break;
                    case 11:
                        if (RchAnswer.Text == "Moon")
                        {
                            BtnK.BackColor = Color.Green;
                        }
                        else
                        {
                            BtnK.BackColor = Color.Red;
                        }
                        break;
                    case 12:
                        if (RchAnswer.Text == "Water")
                        {
                            BtnL.BackColor = Color.Green;
                        }
                        else
                        {
                            BtnL.BackColor = Color.Red;
                        }
                        break;
                    case 13:
                        if (RchAnswer.Text == "Russia")
                        {
                            BtnM.BackColor = Color.Green;
                        }
                        else
                        {
                            BtnM.BackColor = Color.Red;
                        }
                        break;
                    case 14:
                        if (RchAnswer.Text == "Oslo")
                        {
                            BtnN.BackColor = Color.Green;
                        }
                        else
                        {
                            BtnN.BackColor = Color.Red;
                        }
                        break;
                    case 15:
                        if (RchAnswer.Text == "Asia")
                        {
                            BtnO.BackColor = Color.Green;
                        }
                        else
                        {
                            BtnO.BackColor = Color.Red;
                        }
                        break;
                    case 16:
                        if (RchAnswer.Text == "Tenis")
                        {
                            BtnP.BackColor = Color.Green;
                        }
                        else
                        {
                            BtnP.BackColor = Color.Red;
                        }
                        break;
                    case 17:
                        if (RchAnswer.Text == "Alaska")
                        {
                            BtnR.BackColor = Color.Green;
                        }
                        else
                        {
                            BtnR.BackColor = Color.Red;
                        }
                        break;
                    case 18:
                        if (RchAnswer.Text == "Boxing")
                        {
                            BtnS.BackColor = Color.Green;
                        }
                        else
                        {
                            BtnS.BackColor = Color.Red;
                        }
                        break;
                    case 19:
                        if (RchAnswer.Text == "Tiger Woods")
                        {
                            BtnT.BackColor = Color.Green;
                        }
                        else
                        {
                            BtnT.BackColor = Color.Red;
                        }
                        break;
                    case 20:
                        if (RchAnswer.Text == "4")
                        {
                            BtnU.BackColor = Color.Green;
                        }
                        else
                        {
                            BtnU.BackColor = Color.Red;
                        }
                        break;
                    case 21:
                        if (RchAnswer.Text == "Jupiter")
                        {
                            BtnV.BackColor = Color.Green;
                        }
                        else
                        {
                            BtnV.BackColor = Color.Red;
                        }
                        break;
                    case 22:
                        if (RchAnswer.Text == "China")
                        {
                            BtnX.BackColor = Color.Green;
                        }
                        else
                        {
                            BtnX.BackColor = Color.Red;
                        }
                        break;
                    case 23:
                        if (RchAnswer.Text == "Pekin")
                        {
                            BtnY.BackColor = Color.Green;
                        }
                        else
                        {
                            BtnY.BackColor = Color.Red;
                        }
                        break;

                    case 24:
                        if (RchAnswer.Text == "Neptune")
                        {
                            BtnZ.BackColor = Color.Green;
                        }
                        else
                        {
                            BtnZ.BackColor = Color.Red;
                        }
                        break;


                      

                }
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            linkLabel1.Text = "Next";
            qno++;
            this.Text = qno.ToString();

            if (qno == 1)
            {
                RchQuestion.Text = "Which is the easternmost province of Turkey?";
                BtnA.BackColor = Color.Yellow;
            }

            if (qno == 2)
            {
                RchQuestion.Text = "How many regions does Turkey have?";
                BtnB.BackColor = Color.Yellow;
            }

            if (qno == 3)
            {
                RchQuestion.Text = "In what year was Ataturk born?";
                BtnC.BackColor = Color.Yellow;
            }

            if (qno == 4)
            {
                RchQuestion.Text = "What is the holy day of Muslims?";
                BtnD.BackColor = Color.Yellow;
            }

            if (qno == 5)
            {
                RchQuestion.Text = "What is the antonym of the word new?";
                BtnE.BackColor = Color.Yellow;
            }

            if (qno == 6)
            {
                RchQuestion.Text = "What is the earth's heat source?";
                BtnF.BackColor = Color.Yellow;
            }

            if (qno == 7)
            {
                RchQuestion.Text = "How many days are in a year?";
                BtnG.BackColor = Color.Yellow;
            }

            if (qno == 8)
            {
                RchQuestion.Text = "Where is the Anıtkabir?";
                BtnH.BackColor = Color.Yellow;
            }

            if (qno == 9)
            {
                RchQuestion.Text = "When is Christmas Day?";
                BtnI.BackColor = Color.Yellow;
            }

            if (qno == 10)
            {
                RchQuestion.Text = "Which football player won a Ballondor last year?";
                BtnJ.BackColor = Color.Yellow;
            }

            if (qno == 11)
            {
                RchQuestion.Text = "Which is the nearest star ?";
                BtnK.BackColor = Color.Yellow;
            }

            if (qno == 12)
            {
                RchQuestion.Text = "What is H2O?";
                BtnL.BackColor = Color.Yellow;
            }

            if (qno == 13)
            {
                RchQuestion.Text = "Which country has the most people?";
                BtnM.BackColor = Color.Yellow;
            }

            if (qno == 14)
            {
                RchQuestion.Text = "What is the capital city of Norway?";
                BtnN.BackColor = Color.Yellow;
            }

            if (qno == 15)
            {
                RchQuestion.Text = "Which country has the biggest land area?";
                BtnO.BackColor = Color.Yellow;
            }

            if (qno == 16)
            {
                RchQuestion.Text = "What sport is played at Wimbledon?";
                BtnP.BackColor = Color.Yellow;
            }

            if (qno == 17)
            {
                RchQuestion.Text = "What is the biggest state in the U.S.A.?";
                BtnR.BackColor = Color.Yellow;
            }

            if (qno == 18)
            {
                RchQuestion.Text = "Which sport was Muhammad Ali the world champion?";
                BtnS.BackColor = Color.Yellow;
            }

            if (qno == 19)
            {
                RchQuestion.Text = "Which famous golf player's mother comes from Thailand?";
                BtnT.BackColor = Color.Yellow;
            }

            if (qno == 20)
            {
                RchQuestion.Text = "How many strings does a violin have?";
                BtnU.BackColor = Color.Yellow;
            }

            if (qno == 21)
            {
                RchQuestion.Text = "Which planet is the fifth from the sun?";
                BtnV.BackColor = Color.Yellow;
            }

            if (qno == 22)
            {
                RchQuestion.Text = "Which continent has the biggest population?";
                BtnX.BackColor = Color.Yellow;
            }

            if (qno == 23)
            {
                RchQuestion.Text = "In which city were the 2008 Olympic Games held?";
                BtnY.BackColor = Color.Yellow;
            }

            if (qno == 24)
            {
                RchQuestion.Text = "Triton is a moon of which planet?";
                BtnZ.BackColor = Color.Yellow;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        
    }
}
