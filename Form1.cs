using System.ComponentModel;
using System.Media;
using System.Net.NetworkInformation;
using System.Numerics;

namespace BasicPlatformGame
{
    public partial class Form1 : Form
    {
        bool start = true;
        bool goLeft, goRight, jumping, goDown;
        bool spinning = true;
        bool isGameOver = false;
        int playerSpeed = 12;
        int horizontalSpeed = 5;
        int verticalSpeed = 3;
        int enemyOneSpeed = 8;
        int enemyTwoSpeed = 5;
        int ennemyLoopTimeOne = 0;
        int ennemyLoopTimeTwo = 0;
        Control plateformeChecked;

        int Score = 0;
        int JumpForce = 14;


        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //moveBoxe();
            if (goLeft)
            {
                Player.Left -= playerSpeed;
            }
            if (goRight)
            {
                Player.Left += playerSpeed;
            }

            if (goDown)
            {
                Player.Top += verticalSpeed + horizontalSpeed;

                //jumping = false;
            }
            if (jumping)
            {

                Player.Top -= JumpForce;

                JumpForce -= 1;


            }
            if (!jumping)
            {
                verticalSpeed = 2;
                JumpForce = 14;

            }
            if (Score >= 12)
            {
                Exit.Visible = true;

            }
            if (Player.Bounds.IntersectsWith(Exit.Bounds) && Exit.Visible)
            {
                endGameText.Text = "Victory";
                isGameOver = true;
                
            }
            if (isGameOver)
            {
                timer1.Stop();
                restartButton.Visible = true;
                restartButton.Enabled = true;
                exitButton.Enabled = true;
                exitButton.Visible = true;
                endGameText.Visible = true;
            }
            foreach (Control item in this.Controls)
            {

                if (item.Name == "ennemyOne")
                {
                    if (ennemyLoopTimeOne < 19 && ennemyLoopTimeOne > 0)
                    {
                        item.Left += enemyOneSpeed;
                        ennemyLoopTimeOne += 1;
                    }
                    else if (ennemyLoopTimeOne >= 19)
                    {
                        ennemyLoopTimeOne = -20;

                    }
                    if (ennemyLoopTimeOne >= -20 && ennemyLoopTimeOne < 0)
                    {
                        item.Left -= enemyOneSpeed;
                        ennemyLoopTimeOne += 1;
                    }
                    else if (ennemyLoopTimeOne == 0)
                    {
                        item.Left = 230;
                        ennemyLoopTimeOne = 1;
                    }
                }
                if (item.Name == "ennemyTwo")
                {
                    if (ennemyLoopTimeTwo < 26 && ennemyLoopTimeTwo > 0)
                    {
                        item.Left += enemyTwoSpeed;
                        ennemyLoopTimeTwo += 1;
                    }
                    else if (ennemyLoopTimeTwo >= 26)
                    {
                        ennemyLoopTimeTwo = -26;

                    }
                    if (ennemyLoopTimeTwo >= -26 && ennemyLoopTimeTwo < 0)
                    {
                        item.Left -= enemyTwoSpeed;
                        ennemyLoopTimeTwo += 1;
                    }
                    else if (ennemyLoopTimeTwo == 0)
                    {
                        item.Left = 102;
                        ennemyLoopTimeTwo = 1;
                    }
                }
                Console.WriteLine(item.Text);
                if (item.Tag == "Coin")
                {
                    coinSpin(item);
                    if (item.Bounds.IntersectsWith(Player.Bounds) && item.Visible == true)
                    {
                        item.Visible = false;
                        Score++;
                        label1.Text = "Score :" + Score;
                    }
                }
                if (item.Tag == "ennemy")
                    if (Player.Bounds.IntersectsWith(item.Bounds))
                    {
                        endGameText.Text = "Defeat";
                        isGameOver = true;
                    }

                if (item.Tag == "plateform")
                {
                    Console.WriteLine(jumping);
                    if (Player.Bounds.IntersectsWith(item.Bounds))
                    {
                        plateformeChecked = item;
                    }
                    if (Player.Bounds.IntersectsWith(item.Bounds) && Player.Bottom >= item.Top && Player.Bottom <= item.Bottom && jumping)
                    {

                        Console.WriteLine("IT HAPPENS");

                        /*if (Player.Bottom >= item.Top && Player.Bottom <= item.Bottom && jumping)
                        {*/
                        Console.WriteLine("IT HAPPENS");
                        jumping = false;
                        Player.Top = item.Top - Player.Height + 1;

                    }
                    if (Player.Bounds.IntersectsWith(item.Bounds) && Player.Bottom >= item.Top && Player.Bottom <= item.Bottom && goDown)
                    {
                        goDown = false;
                        Player.Top = item.Top - Player.Height + 1;

                    }

                    if (!Player.Bounds.IntersectsWith(item.Bounds) && jumping == false)
                    {
                        if (item == plateformeChecked)
                        {
                            goDown = true;
                        }
                    }

                }

                /*                    if ( Player.Bottom >= item.Top && Player.Bottom <= item.Bottom)
                                   {

                                        if ( (Player.Left >= item.Left && Player.Left <= item.Right) || (Player.Right >= item.Left && Player.Right <= item.Right) && jumping == true)
                                       {
                                           //falling = false;
                                           jumping = false;
                                            // item.BackColor = Color.White;
                                           //Player.Top = item.Top - Player.Height;
                                       }
                                       else
                                       {
                                           goDown = true;
                                     }
                                         jumping = false;
                                         item.BackColor = Color.White;
                                         Player.Top = item.Top - Player.Height;
                                   }
                                   else
                                    {
                                       //goDown = true;
                                   }*/
            }
        }




        private void coinSpin(Control sender)
        {
            if (spinning)
            {
                sender.Width += 2;
                sender.Location = new Point(sender.Location.X - 1, sender.Location.Y);
            }
            else
            {
                sender.Width -= 2;
                sender.Location = new Point(sender.Location.X + 1, sender.Location.Y);
            }

        }
        private void sizeChangedEvent(object sender, EventArgs e)
        {
            if (Coin2.Width <= 5 && spinning == false)
            {
                spinning = !spinning;
            }
            if (Coin2.Width >= 25 && spinning == true)
            {
                spinning = !spinning;
            }
        }
        private void closeEvent(object sender, EventArgs e)
        {
            this.Close();
        }

        private void keyPressed(object sender, KeyEventArgs e)
        {

            Console.WriteLine(e.KeyValue.ToString());
            if (e.KeyValue == 90 && jumping == false)
            {
                jumping = true;
                //JumpForce = 5;
                //verticalSpeed = 2;
            }
            if (e.KeyValue == 83)
            {
                //goDown = true;

            }
            if (e.KeyValue == 81)
            {
                goLeft = true;

            }
            if (e.KeyValue == 68)
            {

                goRight = true;
            }
        }
        private void keyReleased(object sender, KeyEventArgs e)
        {

            Console.WriteLine(e.KeyValue.ToString());
            if (e.KeyValue == 90)
            {

                //jumping = false;

            }
            if (e.KeyValue == 83)
            {

                //goDown = false;
            }
            if (e.KeyValue == 81)
            {
                goLeft = false;

            }
            if (e.KeyValue == 68)
            {

                goRight = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (start)
            {
                timer1.Start();
                start = !start;

            }
            else
            {
                timer1.Stop();
                start = !start;

            }



        }
        private void RestartGame()
        {
            Score = 0;
            jumping = false;
            goLeft = false;
            goRight = false;
            goDown = false;
            isGameOver = false;
            label1.Text = "Score :" + Score;
            Player.Location = new Point(12, 502);
            restartButton.Visible = false;
            restartButton.Enabled = false;
            
            exitButton.Enabled = false;
            exitButton.Visible = false;
            Exit.Visible = false;
            endGameText.Visible = false;
            this.Select();
            timer1.Start();
            foreach (Control item in this.Controls)
            {
                Console.WriteLine(item.Text);
                if (item.Tag == "Coin")
                {
                    item.Visible = true;
                }

            }

        }

        private void restartButton_Click(object sender, EventArgs e)
        {
            RestartGame();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
