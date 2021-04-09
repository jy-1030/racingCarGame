using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hw5_racingcar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            //over.Visible = false;
            //button1.Visible = false;
            die.Visible = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            moveline(gamespeed);
            enemy(gamespeed);
            coin(gamespeed);
            gameover();
            collectionCoin();
        }


     
        Random r = new Random();
        int x;
        void enemy(int speed)
        {
            if(enemy1.Top >= 500)
            {
                x = r.Next(0, 100);
                //y = r.Next(0, 400);

                enemy1.Location = new Point(x, 0);

            }

            else
            {
                enemy1.Top += speed;
            }

            if (enemy2.Top >= 500)
            {
                x = r.Next(0, 200);
                //y = r.Next(0, 400);

                enemy2.Location = new Point(x, 0);

            }

            else
            {
                enemy2.Top += speed;
            }

            if (enemy3.Top >= 500)
            {
                x = r.Next(100, 230);
                //y = r.Next(0, 400);

                enemy3.Location = new Point(x, 0);

            }

            else
            {
                enemy3.Top += speed;
            }


        }

        void coin(int speed)
        {
            if (coin1.Top >= 500)
            {
               

            }

            else
            {
                coin1.Top += speed;
            }

            if (coin2.Top >= 500)
            {
                x = r.Next(0, 200);
                //y = r.Next(0, 400);

                coin2.Location = new Point(x, 0);

            }

            else
            {
                coin2.Top += speed;
            }

            if (coin3.Top >= 500)
            {
                x = r.Next(100, 230);
                //y = r.Next(0, 400);

                coin3.Location = new Point(x, 0);

            }

            else
            {
                coin3.Top += speed;
            }


        }

      





        void moveline(int speed)
        {
            if (pictureBox1.Top >= 500)
            {
                pictureBox1.Top = 0;
            }
            else
            {
                pictureBox1.Top += speed;
            }

            if (pictureBox2.Top >= 500)
            {
                pictureBox2.Top = 0;
            }
            else
            {
                pictureBox2.Top += speed;
            }

            if (pictureBox3.Top >= 500)
            {
                pictureBox3.Top = 0;
            }
            else
            {
                pictureBox3.Top += speed;
            }

            if (pictureBox4.Top >= 500)
            {
                pictureBox4.Top = 0;
            }
            else
            {
                pictureBox4.Top += speed;
            }
        }

        int collectCoin = 0;
        void collectionCoin()
        {
            if (user.Bounds.IntersectsWith(coin1.Bounds))
            {
                collectCoin++;
                label1.Text = "Coin = " + collectCoin.ToString();
                x = r.Next(0, 100);
              

                coin1.Location = new Point(x, 0);

            }
            if (user.Bounds.IntersectsWith(coin2.Bounds))
            {
                collectCoin++;
                label1.Text = "Coin = " + collectCoin.ToString();
                x = r.Next(0, 100);
              

                coin2.Location = new Point(x, 0);

            }
            if (user.Bounds.IntersectsWith(coin3.Bounds))
            {
                collectCoin++;
                label1.Text = "Coin = " + collectCoin.ToString();

                x = r.Next(0, 100);
             

                coin3.Location = new Point(x, 0);

            }

        }

        void gameover()
        {
            if (user.Bounds.IntersectsWith(enemy1.Bounds))
            {
                timer1.Enabled = false;
               // over.Visible = true;
                die.Visible = true;
                user.Visible = false;

           //     button1.Enabled = true; 
           //     button1.Visible = true;
            }
            if (user.Bounds.IntersectsWith(enemy2.Bounds))
            {
                timer1.Enabled = false;
                //over.Visible = true;
                die.Visible = true;
                user.Visible = false;
                //   button1.Enabled = true; 
                //   button1.Visible = true;
            }
            if (user.Bounds.IntersectsWith(enemy3.Bounds))
            {
                timer1.Enabled = false;
                //over.Visible = true;
                die.Visible = true;
                user.Visible = false;
                //    button1.Enabled = true;
                //    button1.Visible = true;
            }

        }

     


        int gamespeed = 0;
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                if (user.Left > 0)
                    //user.Left += -gamespeed;
                    user.Left += -8;
            }

            if (e.KeyCode == Keys.Right)
            {
                if (user.Right < 250)
                    // user.Left += gamespeed;
                    user.Left += 8;
            }
            if (e.KeyCode == Keys.Up)
            {
                if (gamespeed < 21)
                { 
                    gamespeed++;
                }
            }

            if (e.KeyCode == Keys.Down)
            {
                if (gamespeed > 0)
                {
                    gamespeed--;
                }

            }
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {

            if (e.Button == MouseButtons.Left)
            {
                if (gamespeed == 1)
                {
                    gamespeed = 0; 
                    timer1.Enabled = false;
                }
                else
                {
                    gamespeed = 1;
                    timer1.Enabled = true;
                }

            }

        }





        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void over_Click(object sender, EventArgs e)
        {

        }


      /*  
        private void button1_Click(object sender, EventArgs e)
        {
            button1.Enabled = false; 
            button1.Visible = false;
            // game_init();
            moveline(gamespeed);
            enemy(gamespeed);
            coin(gamespeed);
            gameover();
            collectionCoin();
            timer1.Enabled = true;
        }

    */

    
    }
}