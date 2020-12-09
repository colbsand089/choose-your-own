// colbey sands
// december 8 
// choose your path adventure game
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;


namespace choose_your_own
{
    public partial class Form1 : Form
    {
        int scene = 1;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.G)       //greem button press
            {
                if (scene == 0)
                {
                    scene = 1;
                }
                else if (scene == 1)
                {
                    scene = 4;
                }
                else if (scene == 2)
                {
                    scene = 4;
                }
                else if (scene == 3)
                {
                    scene = 0;
                }
                else if (scene == 4)
                {
                    scene = 6;
                }
                else if (scene == 5)
                {
                    scene = 0;
                }
                else if (scene == 6)
                {
                    scene = 8;
                }
                else if (scene == 7)
                {
                    scene = 0;
                }
                else if (scene == 8)
                {
                    scene = 10;
                }
                else if (scene == 9)
                {
                    scene = 0;
                }
                else if (scene == 10)
                {
                    scene = 12;
                }
                else if (scene == 11)
                {
                    scene = 0;
                }
                else if (scene == 12)
                {
                    scene = 14;
                }
                else if (scene == 13)
                {
                    scene = 0;
                }
                else if (scene == 14)
                {
                    scene = 16;
                }
                else if (scene == 15)
                {
                    scene = 0;
                }
                else if (scene == 16)
                {
                    scene = 18;
                }
                else if (scene == 17)
                {
                    scene = 0;
                }
                else if (scene == 18)
                {
                    scene = 0;
                }
               
            }
            else if (e.KeyCode == Keys.R)  //Red button press
            {
                if (scene == 0)
                {
                    scene = 1;
                }
                else if (scene == 1)
                {
                    scene = 2;
                }
                else if (scene == 2)
                {
                    scene = 3;
                }
                else if (scene == 3)
                {
                    scene = 0;
                }
                else if (scene == 4)
                {
                    scene = 5;
                }
                else if (scene == 5)
                {
                    scene = 0;
                }
                else if (scene == 6)
                {
                    scene = 7;
                }
                else if (scene == 7)
                {
                    scene = 0;
                }
                else if (scene == 8)
                {
                    scene = 9;
                }
                else if (scene == 9)
                {
                    scene = 0;
                }
                else if (scene == 10)
                {
                    scene = 11;
                }
                else if (scene == 11)
                {
                    scene = 0;
                }
                else if (scene == 12)
                {
                    scene = 13;
                }
                else if (scene == 13)
                {
                    scene = 0;
                }
                else if (scene == 14)
                {
                    scene = 15;
                }
                else if (scene == 15)
                {
                    scene = 0;
                }
                else if (scene == 16)
                {
                    scene = 17;
                }
                else if (scene == 17)
                {
                    scene = 0;
                }
                else if (scene == 18)
                {
                    scene = 0;
                }
            }


            /// the scenes and the conent in them
            switch (scene)
            {
                case 0:  //start scene  
                    pictureBox1.BackgroundImage = Properties.Resources.gordan;

                    outputLabel.Text = "You are trapped with Gordon Ramsey in a restaurant";
                    greenButtonOutputLabel.Text = "Play";
                    redButtonOutputLabel.Text = "";
                    break;

                case 1:
                    pictureBox1.BackgroundImage = Properties.Resources.gordonWaiting;

                    outputLabel.Text = "You are trapped with Gordon Ramsey in a restaurant. He askes you to cook him a meal";
                    greenButtonOutputLabel.Text = "Cook";
                    redButtonOutputLabel.Text = "Dont cook";
                    break;

                case 2:
                    outputLabel.Text = "He gives you one more chance to cook him a meal";
                    greenButtonOutputLabel.Text = "Cook";
                    redButtonOutputLabel.Text = "Dont cook";
                    break;

                case 3:
                    pictureBox1.BackgroundImage = Properties.Resources.insideOven;

                    SoundPlayer player = new SoundPlayer(Properties.Resources.Evil_Laugh_1_Timothy_64737261);
                    player.Play();

                    outputLabel.Text = "He stuffs you in an oven and cooks you";
                    greenButtonOutputLabel.Text = "Play again?";
                    redButtonOutputLabel.Text = "Dont play again";
                    break;

                case 4:
                    pictureBox1.BackgroundImage = Properties.Resources.gordonTalking;

                    SoundPlayer player8 = new SoundPlayer(Properties.Resources._1_person_cheering_Jett_Rifkin_1851518140);
                    player8.Play();


                   outputLabel.Text = "He tells you to make him eggs and bacon";
                    greenButtonOutputLabel.Text = "Make crispy bacon";
                    redButtonOutputLabel.Text = "Make chewy bacon";
                    break;

                case 5:
                    pictureBox1.BackgroundImage = Properties.Resources.madgordan;

                    SoundPlayer player1 = new SoundPlayer(Properties.Resources.Evil_Laugh_1_Timothy_64737261);
                    player1.Play();

                    outputLabel.Text = "He hates chewy bacon and and strangles you with his shoelace";
                    greenButtonOutputLabel.Text = "Play again?";
                    redButtonOutputLabel.Text = "Dont play again";
                    break;
                case 6:
                    pictureBox1.BackgroundImage = Properties.Resources.happy;

                    SoundPlayer player9 = new SoundPlayer(Properties.Resources._1_person_cheering_Jett_Rifkin_1851518140);
                    player9.Play();

                    outputLabel.Text = "Gordon likes the crispy bacon and asks for a drink with it";
                    greenButtonOutputLabel.Text = "Water";
                    redButtonOutputLabel.Text = "Juice";
                    break;

                case 7:
                    pictureBox1.BackgroundImage = Properties.Resources.mad_2_0;

                    SoundPlayer player2 = new SoundPlayer(Properties.Resources.Evil_Laugh_1_Timothy_64737261);
                    player2.Play();

                    outputLabel.Text = "Gordon does not like the juice you brought him and he drowns you in it";
                    greenButtonOutputLabel.Text = "Play again?";
                    redButtonOutputLabel.Text = "Dont Play again";
                    break;

                case 8:
                    pictureBox1.BackgroundImage = Properties.Resources.gordan;

                    SoundPlayer player10 = new SoundPlayer(Properties.Resources._1_person_cheering_Jett_Rifkin_1851518140);
                    player10.Play();

                    outputLabel.Text = "He drinks the water and gives you his plate he then asks for desert";
                    greenButtonOutputLabel.Text = "Give him lamb sauce";
                    redButtonOutputLabel.Text = "Give him ice cream";
                    break;

                case 9:
                    pictureBox1.BackgroundImage = Properties.Resources.lamb;

                    SoundPlayer player3 = new SoundPlayer(Properties.Resources.Evil_Laugh_1_Timothy_64737261);
                    player3.Play();

                    outputLabel.Text = "He takes the ice cream and throws it across the room then throws you across the room";
                    greenButtonOutputLabel.Text = "Play again";
                    redButtonOutputLabel.Text = "Dont play again";
                    break;

                case 10:
                    pictureBox1.BackgroundImage = Properties.Resources.happy;

                    SoundPlayer player11 = new SoundPlayer(Properties.Resources._1_person_cheering_Jett_Rifkin_1851518140);
                    player11.Play();

                    outputLabel.Text = "He loves the lamb sauce its his favorite, he needs you to clean up.";
                    greenButtonOutputLabel.Text = "Grab the plates";
                    redButtonOutputLabel.Text = "Grab the cups";
                    break;

                case 11:
                    pictureBox1.BackgroundImage = Properties.Resources.Knifes;

                    SoundPlayer player4 = new SoundPlayer(Properties.Resources.Evil_Laugh_1_Timothy_64737261);
                    player4.Play();

                    outputLabel.Text = "The cups are wet and you drop one throwing Gordon into a rage he stabs you";
                    greenButtonOutputLabel.Text = "Play again";
                    redButtonOutputLabel.Text = "Dont play again";
                    break;

                case 12:
                    pictureBox1.BackgroundImage = Properties.Resources.money;

                    SoundPlayer player12 = new SoundPlayer(Properties.Resources._1_person_cheering_Jett_Rifkin_1851518140);
                    player12.Play();

                    outputLabel.Text = "You take the plate to the sink. he gives you $400000 and askes you to get him something";
                    greenButtonOutputLabel.Text = "Get him a knife";
                    redButtonOutputLabel.Text = "Get him a spoon";
                    break;

                case 13:
                    pictureBox1.BackgroundImage = Properties.Resources.spoon;

                    SoundPlayer player5 = new SoundPlayer(Properties.Resources.Evil_Laugh_1_Timothy_64737261);
                    player5.Play();

                    outputLabel.Text = "He scoops out your eye with the horrible spoon you gave him";
                    greenButtonOutputLabel.Text = "Play agian?";
                    redButtonOutputLabel.Text = "Dont play again";
                    break;

                case 14:
                    pictureBox1.BackgroundImage = Properties.Resources.knool;

                    SoundPlayer player13 = new SoundPlayer(Properties.Resources._1_person_cheering_Jett_Rifkin_1851518140);
                    player13.Play();

                    outputLabel.Text = "Gordan loves knives and wants to show you his skills";
                    greenButtonOutputLabel.Text = "Yeah sure";
                    redButtonOutputLabel.Text = "Not now";
                    break;

                case 15:
                    pictureBox1.BackgroundImage = Properties.Resources.bleeeding;

                    SoundPlayer player6 = new SoundPlayer(Properties.Resources.Evil_Laugh_1_Timothy_64737261);
                    player6.Play();

                    outputLabel.Text = "He cuts you up with the knife";
                    greenButtonOutputLabel.Text = "Play again?";
                    redButtonOutputLabel.Text = "Dont play again";
                    break;

                case 16:
                    pictureBox1.BackgroundImage = Properties.Resources.steak;

                    SoundPlayer player14 = new SoundPlayer(Properties.Resources._1_person_cheering_Jett_Rifkin_1851518140);
                    player14.Play();

                    outputLabel.Text = "He cuts up some steak and gives it to you, it tastes bad";
                    greenButtonOutputLabel.Text = "Pretend its good";
                    redButtonOutputLabel.Text = "Tell him its bad";
                    break;

                case 17:
                    pictureBox1.BackgroundImage = Properties.Resources.W;

                    SoundPlayer player15 = new SoundPlayer(Properties.Resources._1_person_cheering_Jett_Rifkin_1851518140);
                    player15.Play();

                    outputLabel.Text = "He lets you go because he likes you, you win";
                    greenButtonOutputLabel.Text = "Play again?";
                    redButtonOutputLabel.Text = "";
                    break;

                case 18:
                    pictureBox1.BackgroundImage = Properties.Resources.lose;

                    SoundPlayer player7 = new SoundPlayer(Properties.Resources.Evil_Laugh_1_Timothy_64737261);
                    player7.Play();

                    outputLabel.Text = "He calls you a donkey and hits you with a chair, you lose ";
                    greenButtonOutputLabel.Text = "Play again?";
                    redButtonOutputLabel.Text = "";
                    break;
                default:
                    break;
            }
        }

       
    }
}
