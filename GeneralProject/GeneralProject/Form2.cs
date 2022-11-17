using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Media;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using static System.Windows.Forms.AxHost;

using LicenseContext = System.ComponentModel.LicenseContext;


namespace GeneralProject
{
    public partial class Form2 : Form
    {
       

        int speed = 8;
        Random number;
        int spaceShipHealth = 100;
        int enemyHealth = 100;
        int score = 0;
        int spaceshipX;
        int enemyX;
        bool isEnemy1Destroyed = false;
        bool isEnemy2Destroyed = false;
        bool isEnemy3Destroyed = false;

        bool goLeft, goRight, goUp, goDown, isShooting;
        bool isVisible = false;
        
    
        
        SoundPlayer s1;
       
        
        List<PictureBox> bullets = new List<PictureBox>();
        List<PictureBox> enemyBullets = new List<PictureBox>();
        List<PictureBox> enemyBullets2 = new List<PictureBox>();
        List<PictureBox> enemyBullets4 = new List<PictureBox>();
        List<PictureBox> enemyBullets5 = new List<PictureBox>();
        List<PictureBox> enemyBullets6 = new List<PictureBox>();
        List<PictureBox> enemyBullets7 = new List<PictureBox>();
        List<PictureBox> enemyBullets8 = new List<PictureBox>();
        List<PictureBox> enemyBullets9 = new List<PictureBox>();
        List<PictureBox> enemyBullets10 = new List<PictureBox>();
        List<PictureBox> enemyBullets11 = new List<PictureBox>();

        List<PictureBox> heals = new List<PictureBox>();


        public int SpaceShipHealth { get => spaceShipHealth; set => spaceShipHealth = value; }
        public int Score { get => score; set => score = value; }
        public int EnemyHealth { get => enemyHealth; set => enemyHealth = value; }

        public Form2()
        {
            InitializeComponent();
            mxp.URL = "game.mp3";
            mxp.settings.playCount = 999;
            mxp1.URL = "enemylaserShoot.mp3";
            mxp2.URL = "laserShoot2.mp3";
            mxp3.URL = "laserShoot3.mp3";
            mxp4.URL = "finalboss.mp3";
            mxp4.settings.playCount = 999;
            mxp5.URL = "victory.mp3";
            mxp6.URL = "gameover.mp3";
            mxp7.URL = "heal.mp3";
            mxp8.URL = "fireball.mp3";
        }

      

        private void gameTimer_Tick(object sender, EventArgs e)
        {
            if(isVisible == true)
            {
                rocketFire1.Visible = true;
                rocketFire2.Visible = true;
                rocketFire1.Location = new Point(spaceship.Location.X + 20, spaceship.Location.Y + 70);
                rocketFire2.Location = new Point(spaceship.Location.X + 52, spaceship.Location.Y + 70);
            }
            else
            {
                rocketFire1.Visible = false;
                rocketFire2.Visible = false;
            }

        

            foreach (PictureBox bullet in bullets)
            {
                bullet.Location = new Point(bullet.Location.X, bullet.Location.Y - 10);
                if(isEnemy1Destroyed == false)
                {
                    increaseScore(bullet, enemy);
                }
                if (isEnemy1Destroyed == true && isEnemy2Destroyed == false)
                {
                    increaseScore(bullet, enemy2);
                }
                if (isEnemy1Destroyed == true && isEnemy2Destroyed == true && isEnemy3Destroyed == false)
                {
                    increaseScore(bullet, enemy3);
                }
                if (isEnemy1Destroyed == true && isEnemy2Destroyed == true && isEnemy3Destroyed == true)
                {
                    increaseScore(bullet, finalBoss);
                }

                if (bullet.Bounds.IntersectsWith(enemy.Bounds) || bullet.Bounds.IntersectsWith(enemy2.Bounds) || bullet.Bounds.IntersectsWith(enemy3.Bounds) || bullet.Top < 0 || bullet.Bounds.IntersectsWith(finalBoss.Bounds))
                {
                    bullet.BringToFront();
                    Controls.Remove(bullet);
                }



            }
            foreach (PictureBox enemy_bullet in enemyBullets)
            {
                enemy_bullet.Location = new Point(enemy_bullet.Location.X , enemy_bullet.Location.Y + 8);
                enemy_bullet.BringToFront();
                hitSpaceShip(enemy_bullet, spaceship);
                dicreaseSpacehipHealth(enemy_bullet, spaceship);
               
                if (enemy_bullet.Location.Y > 900)
                {
                    Controls.Remove(enemy_bullet);
                }
            }

            
            foreach (PictureBox enemy_bullet in enemyBullets2)
            {
                enemy_bullet.Location = new Point(enemy_bullet.Location.X + findPlayerLocationX(enemyX, spaceshipX)/100 , enemy_bullet.Location.Y + 10);
                enemy_bullet.BringToFront();
                hitSpaceShip(enemy_bullet, spaceship);
                dicreaseSpacehipHealth(enemy_bullet, spaceship);
                if (enemy_bullet.Location.Y > 900)
                {
                    Controls.Remove(enemy_bullet);
                }
            }



            moveSpaceShip();

            isSpaceShipAlive();

            
            if (isEnemy1Destroyed == true )
            {
               
                foreach (PictureBox enemy_bullet in enemyBullets4)
                {
                    enemy_bullet.Location = new Point(enemy_bullet.Location.X, enemy_bullet.Location.Y + 11);
                    enemy_bullet.BringToFront();
                    hitSpaceShip(enemy_bullet, spaceship);
                    dicreaseSpacehipHealth2(enemy_bullet, spaceship);
                    if (enemy_bullet.Location.Y > 900)
                    {
                        Controls.Remove(enemy_bullet);
                    }
                }
                foreach (PictureBox enemy_bullet in enemyBullets5)
                {
                    enemy_bullet.Location = new Point(enemy_bullet.Location.X, enemy_bullet.Location.Y + 9);
                    enemy_bullet.BringToFront();
                    hitSpaceShip(enemy_bullet, spaceship);
                    dicreaseSpacehipHealth(enemy_bullet, spaceship);
                    if (enemy_bullet.Location.Y > 900)
                    {
                        Controls.Remove(enemy_bullet);
                    }
                }
                foreach (PictureBox enemy_bullet in enemyBullets6)
                {
                    enemy_bullet.Location = new Point(enemy_bullet.Location.X, enemy_bullet.Location.Y + 10);
                    enemy_bullet.BringToFront();
                    hitSpaceShip(enemy_bullet, spaceship);
                    dicreaseSpacehipHealth2(enemy_bullet, spaceship);
                    if (enemy_bullet.Location.Y > 900)
                    {
                        Controls.Remove(enemy_bullet);
                    }
                }

            }

            if (isEnemy1Destroyed == true && isEnemy2Destroyed == true)
            {
               
                foreach (PictureBox enemy_bullet in enemyBullets7)
                {
                    
                    enemy_bullet.Location = new Point(enemy_bullet.Location.X - 3, enemy_bullet.Location.Y + 9);
                    enemy_bullet.BringToFront();
                    hitSpaceShip(enemy_bullet, spaceship);
                    dicreaseSpacehipHealth2(enemy_bullet, spaceship);
                    if (enemy_bullet.Location.Y > 900)
                    {
                        Controls.Remove(enemy_bullet);
                    }
                }
                foreach (PictureBox enemy_bullet in enemyBullets8)
                {

                    enemy_bullet.Location = new Point(enemy_bullet.Location.X + 3, enemy_bullet.Location.Y + 9);
                    enemy_bullet.BringToFront();
                    hitSpaceShip(enemy_bullet, spaceship);
                    dicreaseSpacehipHealth2(enemy_bullet, spaceship);
                    if (enemy_bullet.Location.Y > 900)
                    {
                        Controls.Remove(enemy_bullet);
                    }
                }
               
                   foreach (PictureBox enemy_bullet in enemyBullets9)
                    {

                        enemy_bullet.Location = new Point(enemy_bullet.Location.X , enemy_bullet.Location.Y + 9);
                        enemy_bullet.BringToFront();
                        hitSpaceShip(enemy_bullet, spaceship);
                        dicreaseSpacehipHealth2(enemy_bullet, spaceship);
                        if (enemy_bullet.Location.Y > 900)
                        {
                            Controls.Remove(enemy_bullet);
                        }
                    }
            }

            if (isEnemy1Destroyed == true && isEnemy2Destroyed == true && isEnemy3Destroyed == true)
            {
                foreach (PictureBox enemy_bullet in enemyBullets10)
                {
                    enemy_bullet.Location = new Point(enemy_bullet.Location.X + findPlayerLocationX(enemyX, spaceshipX) / 100, enemy_bullet.Location.Y + 13);
                    enemy_bullet.BringToFront();
                    hitSpaceShip(enemy_bullet, spaceship);
                    dicreaseSpacehipHealth(enemy_bullet, spaceship);
                    if (enemy_bullet.Location.Y > 900)
                    {
                        Controls.Remove(enemy_bullet);
                    }
                }

                foreach (PictureBox enemy_bullet in enemyBullets11)
                {
                    enemy_bullet.Location = new Point(enemy_bullet.Location.X, enemy_bullet.Location.Y + 8);
                    enemy_bullet.BringToFront();
                    hitSpaceShip(enemy_bullet, spaceship);
                    dicreaseSpacehipHealth2(enemy_bullet, spaceship);
                    if (enemy_bullet.Location.Y > 900)
                    {
                        Controls.Remove(enemy_bullet);
                    }
                }
            }

                foreach (PictureBox heal in heals)
            {

                heal.Location = new Point(heal.Location.X, heal.Location.Y + 6);
                heal.BringToFront();
                healSpaceShip(heal, spaceship);

                if (heal.Location.Y > 900)
                {
                    Controls.Remove(heal);
                }
            }


        }

        private void Form2_Load(object sender, EventArgs e)
        {
         
            
            number = new Random();
            mxp1.Ctlcontrols.stop();
            mxp2.Ctlcontrols.stop();
            mxp3.Ctlcontrols.stop();
            mxp4.Ctlcontrols.stop();
            mxp5.Ctlcontrols.stop();
            mxp6.Ctlcontrols.stop();
            mxp7.Ctlcontrols.stop();
            mxp8.Ctlcontrols.stop();
            s1 = new SoundPlayer("laserShoot.wav");
         
       

            mxp.Ctlcontrols.play();
      

        }

   



        private void healing()
        {
            PictureBox heal = new PictureBox();
            heal.Image = Properties.Resources.healing;
            heal.Location = new Point(number.Next(Width - enemy.Width), 0);
            heal.Size = new Size(45, 50);
            heal.SizeMode = PictureBoxSizeMode.StretchImage;
            Controls.Add(heal);
            heals.Add(heal);
        
        }

        private void saveScore()
        {
            using (StreamWriter w = File.AppendText("scores.txt"))
            {
                w.WriteLine(score.ToString());
            }
        }

  


        private void createBullet(int startX)
        {
            PictureBox bullet = new PictureBox();
            bullet.Image = Properties.Resources.greenlaser;
            bullet.Location = new Point(startX + 27, spaceship.Location.Y - 50);
            bullet.Size = new Size(35, 60);
            bullet.SizeMode = PictureBoxSizeMode.StretchImage;
            Controls.Add(bullet);
            bullets.Add(bullet);
            s1.Play();
            
            
            
        }

        private void createEnemyBullet(int enemyX, int enemyY)
        {
            PictureBox enemy_bullet = new PictureBox();
            enemy_bullet.Image = Properties.Resources.redbullet;
            enemy_bullet.Location = new Point(enemyX + 50, enemyY + 54);
            enemy_bullet.Size = new Size(25, 80);
            enemy_bullet.SizeMode = PictureBoxSizeMode.StretchImage;
            mxp1.Ctlcontrols.play();
            Controls.Add(enemy_bullet);
            enemyBullets.Add(enemy_bullet);
        }
        private void createEnemyBullet2(int enemyX, int enemyY)
        {
            PictureBox enemy_bullet1 = new PictureBox();
            enemy_bullet1.Image = Properties.Resources.laserball;
            enemy_bullet1.Location = new Point(enemyX , enemyY + 75);
            enemy_bullet1.Size = new Size(30, 30);
            enemy_bullet1.SizeMode = PictureBoxSizeMode.StretchImage;

            PictureBox enemy_bullet2 = new PictureBox();
            enemy_bullet2.Image = Properties.Resources.laserball;
            enemy_bullet2.Location = new Point(enemyX + 95, enemyY + 75);
            enemy_bullet2.Size = new Size(30, 30);
            enemy_bullet2.SizeMode = PictureBoxSizeMode.StretchImage;

            mxp2.Ctlcontrols.play();
            Controls.Add(enemy_bullet1);
            Controls.Add(enemy_bullet2);
            enemyBullets2.Add(enemy_bullet1);
            enemyBullets2.Add(enemy_bullet2);
        }

        private void createEnemyBullet4(int enemyX, int enemyY)
        {
            PictureBox enemy_bullet = new PictureBox();
            enemy_bullet.Image = Properties.Resources.bluelaser;
            enemy_bullet.Location = new Point(enemyX + 50, enemyY + 54);
            enemy_bullet.Size = new Size(25, 100);
            enemy_bullet.SizeMode = PictureBoxSizeMode.StretchImage;

            mxp2.Ctlcontrols.play();

            Controls.Add(enemy_bullet);
            enemyBullets4.Add(enemy_bullet);
           
        }

        private void createEnemyBullet5(int enemyX, int enemyY)
        {
            PictureBox enemy_bullet1 = new PictureBox();
            enemy_bullet1.Image = Properties.Resources.bluelaser;
            enemy_bullet1.Location = new Point(enemyX  , enemyY + 35);
            enemy_bullet1.Size = new Size(15, 50);
            enemy_bullet1.SizeMode = PictureBoxSizeMode.StretchImage;

            PictureBox enemy_bullet2 = new PictureBox();
            enemy_bullet2.Image = Properties.Resources.bluelaser;
            enemy_bullet2.Location = new Point(enemyX + 110, enemyY + 35);
            enemy_bullet2.Size = new Size(15, 50);
            enemy_bullet2.SizeMode = PictureBoxSizeMode.StretchImage;

            Controls.Add(enemy_bullet1);
            enemyBullets5.Add(enemy_bullet1);
            Controls.Add(enemy_bullet2);
            enemyBullets5.Add(enemy_bullet2);
           
        }
     
        private void createEnemyBullet6()
        {


            PictureBox enemy_bullet = new PictureBox();
            enemy_bullet.Image = Properties.Resources.laserFront;
            enemy_bullet.Location = new Point(number.Next(Width - enemy.Width), 0);
            enemy_bullet.Size = new Size(40, 200);
            enemy_bullet.SizeMode = PictureBoxSizeMode.StretchImage;

            Controls.Add(enemy_bullet);
            enemyBullets6.Add(enemy_bullet);

            mxp3.Ctlcontrols.play();



        }

        bool isenemy_bullet10 = false;

        private void createEnemyBullet7(int enemyX, int enemyY)
        {
            PictureBox enemy_bullet1 = new PictureBox();
            enemy_bullet1.Image = Properties.Resources.laserball;
            enemy_bullet1.Location = new Point(enemyX + 55, enemyY + 70);
            enemy_bullet1.Size = new Size(30, 30);
            enemy_bullet1.SizeMode = PictureBoxSizeMode.StretchImage;

            PictureBox enemy_bullet2 = new PictureBox();
            enemy_bullet2.Image = Properties.Resources.laserball;
            enemy_bullet2.Location = new Point(enemyX + 55, enemyY + 70);
            enemy_bullet2.Size = new Size(30, 30);
            enemy_bullet2.SizeMode = PictureBoxSizeMode.StretchImage;

          
            mxp2.Ctlcontrols.play();
            Controls.Add(enemy_bullet1);
            Controls.Add(enemy_bullet2);

            enemyBullets7.Add(enemy_bullet1);
            enemyBullets8.Add(enemy_bullet2);


        }
        private void createEnemyBullet8(int enemyX, int enemyY)
        {
 

            PictureBox enemy_bullet = new PictureBox();
            enemy_bullet.Image = Properties.Resources.laserball;
            enemy_bullet.Location = new Point(enemyX + 55, enemyY + 70);
            enemy_bullet.Size = new Size(30, 30);
            enemy_bullet.SizeMode = PictureBoxSizeMode.StretchImage;
            mxp2.Ctlcontrols.play();
            Controls.Add(enemy_bullet);
            enemyBullets9.Add(enemy_bullet);

        }

        private void createEnemyBullet9(int enemyX, int enemyY)
        {
            PictureBox enemy_bullet = new PictureBox();
            enemy_bullet.Image = Properties.Resources.greenBullet;
            enemy_bullet.Location = new Point(enemyX + 90, enemyY + 90);
            enemy_bullet.Size = new Size(30, 30);
            enemy_bullet.SizeMode = PictureBoxSizeMode.StretchImage;
            mxp2.Ctlcontrols.play();
            Controls.Add(enemy_bullet);
            enemyBullets10.Add(enemy_bullet);
        }

        private void createEnemyBullet10()
        {


            PictureBox enemy_bullet = new PictureBox();
            enemy_bullet.Image = Properties.Resources.fireball;
            enemy_bullet.Location = new Point(number.Next(Width - enemy.Width), 50);
            enemy_bullet.Size = new Size(70, 80);
            enemy_bullet.SizeMode = PictureBoxSizeMode.StretchImage;

            Controls.Add(enemy_bullet);
            enemyBullets11.Add(enemy_bullet);

            mxp8.Ctlcontrols.play();



        }





        private void Form2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                goLeft = true;
                isVisible = true;

            }
            else if (e.KeyCode == Keys.Right)
            {
                goRight = true;
                isVisible = true;
            }
            else if (e.KeyCode == Keys.Up)
            {
                goUp = true;
                isVisible = true;
            }
            else if (e.KeyCode == Keys.Down)
            {
                goDown = true;
                isVisible = true;
            }
            else if (e.KeyCode == Keys.Space)
            {
                isShooting = true;

            }
        }

        private void Form2_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                goLeft = false;
                isVisible = false;

            }
            else if (e.KeyCode == Keys.Right)
            {
                goRight = false;
                isVisible = false;
            }
            else if (e.KeyCode == Keys.Up)
            {
                goUp = false;
                isVisible = false;
            }
            else if (e.KeyCode == Keys.Down)
            {
                goDown = false;
                isVisible = false;
            }
            else if (e.KeyCode == Keys.Space)
            {
                isShooting = false;
                createBullet(spaceship.Location.X);

            }
        }




        private void moveSpaceShip()
        {
            if (goLeft == true && spaceship.Left > 0)
            {
                spaceship.Left -= speed;
            }
            if (goRight == true && spaceship.Left + spaceship.Width + 2.5 < this.ClientSize.Width)
            {
                spaceship.Left += speed;
            }
            if (goUp == true && spaceship.Top > 550)
            {
                spaceship.Top -= speed;
            }
            if (goDown == true && spaceship.Top + spaceship.Height  < this.ClientSize.Height - 50)
            {
                spaceship.Top += speed;
            }


        }

        private void enemyShoot1_Tick(object sender, EventArgs e)
        {
            if (isEnemy1Destroyed == false)
            {
                createEnemyBullet(enemy.Location.X, enemy.Location.Y);
            }
           
            if (isEnemy1Destroyed == true && isEnemy2Destroyed == false)
            {
                createEnemyBullet4(enemy2.Location.X, enemy2.Location.Y);
                createEnemyBullet5(enemy2.Location.X, enemy2.Location.Y);
            }

        }
        private void enemyShoot2_Tick(object sender, EventArgs e)
        {
            createEnemyBullet2(enemy.Location.X, enemy.Location.Y);
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            if (isEnemy1Destroyed == true && isEnemy3Destroyed == false)
            {
                createEnemyBullet6();
            }
            if (isEnemy3Destroyed == true)
            {
                createEnemyBullet10();
            }
        }

        private void enemyShoot4_Tick(object sender, EventArgs e)
        {
            if(isEnemy1Destroyed == true && isEnemy2Destroyed == true && isEnemy3Destroyed == false)
            {
                
                createEnemyBullet7(enemy3.Location.X, enemy3.Location.Y);
                if(isenemy_bullet10 == true)
                {
                    createEnemyBullet8(enemy3.Location.X, enemy3.Location.Y);
                }
               
            }

            if(isEnemy1Destroyed == true && isEnemy2Destroyed == true && isEnemy3Destroyed == true)
            {
                createEnemyBullet9(finalBoss.Location.X, finalBoss.Location.Y);
            } 
        }



        private void enemyMovement_Tick(object sender, EventArgs e)
        {
            enemy.Location = new Point(number.Next(Width - enemy.Width), enemy.Location.Y);
            enemy2.Location = new Point(number.Next(Width - enemy2.Width), enemy2.Location.Y);
            finalBoss.Location = new Point(number.Next(Width - finalBoss.Width), finalBoss.Location.Y);

        }

        private void enemyMovement2_Tick(object sender, EventArgs e)
        {
            enemy3.Location = new Point(number.Next(Width - enemy3.Width), enemy3.Location.Y);
        }

        private void isSpaceShipAlive()
        {
            if (SpaceShipHealth > 1)
            {
                
            }
            else
            {
                saveScore();
                gameTimer.Stop();
                enemyMovement.Stop();
                enemyShoot1.Stop();
                enemyShoot2.Stop();
                timer3.Stop();
                enemyShoot4.Stop();
                mxp.Ctlcontrols.stop();
                mxp4.Ctlcontrols.stop();
                mxp6.Ctlcontrols.play();
                gameover.Visible = true;
                Controls.Remove(enemy);
                Controls.Remove(enemy2);
                Controls.Remove(enemy3);
                Controls.Remove(spaceship);
                rocketFire1.Visible = false;
                rocketFire2.Visible = false;
                gameoverTimer.Enabled = true;


            }
        }

        bool isfalse = false;
        bool isfalse2 = false;
        bool isfalse3 = false;
        bool isfalse4 = false;
        bool isfalse5 = false;
        bool isfalse6 = false;






        private void timer1_Tick(object sender, EventArgs e)
        {
            isfalse = false;
            isfalse3 = false;
            isfalse4 = false;
            isfalse6 = false;

           
            
        }

        private void trackPlayerX_Tick(object sender, EventArgs e)
        {
            spaceshipX = spaceship.Location.X;
            enemyX = enemy.Location.X;
          
        }

        int chaseBullet;
        private int findPlayerLocationX(int enemyX, int playerX)
        {
            if(enemyX < playerX)
            {
                chaseBullet = (playerX+spaceship.Width/2) - (enemyX+enemy.Width/2);
            }
            else if (enemyX > playerX)
            {
                chaseBullet =  (playerX + spaceship.Width / 2) - (enemyX + enemy.Width / 2);
            }
            else
            {
                chaseBullet = 0;
            }

            return chaseBullet;
            
        }

        private void increaseScore(PictureBox bullet , PictureBox enemy)
        {
            if (bullet.Bounds.IntersectsWith(enemy.Bounds) && isfalse == false && isEnemy1Destroyed == false)
            {              
                
                isfalse = true;
                if (enemyHealth > 1)
                {
                    score += 5;
                    enemyHealth -= 5;
                    enemyHealthBar.Value = enemyHealth;
                }
                if(enemyHealth == 0)
                {
                    enemyHealth = 100;
                    enemy2.Visible = true;                                    
                    Controls.Remove(enemy);
                    enemy.Visible = false;                                     
                    enemyShoot2.Stop();
                    score = 200;
                    isEnemy1Destroyed = true;                   
              }

            }

            if (bullet.Bounds.IntersectsWith(enemy.Bounds) && isfalse3 == false && isEnemy1Destroyed == true && isEnemy2Destroyed == false)
            {
                    
                    score += 10;
                    isfalse3 = true;
                    enemyHealth -= 5;
                    if (enemyHealth > 1)
                    {
                        enemyHealthBar.Value = enemyHealth;
                    }
                    if (enemyHealth == 0)
                    {                      
                        enemy3.Visible = true;
                        Controls.Remove(enemy2);
                        enemy.Visible = false;
                        timer3.Stop();
                        score = 900;
                        isEnemy2Destroyed = true;
                        enemyHealth = 100;
                        timer4.Enabled = true;
                        healing_timer.Start();
                    }   
               
            }
            if (bullet.Bounds.IntersectsWith(enemy.Bounds) && isfalse4 == false && isEnemy1Destroyed == true && isEnemy2Destroyed == true && isEnemy3Destroyed == false)
            {

                score += 15;
                enemyHealth -= 2;
                isfalse4 = true;
                if (enemyHealth > 1)
                {
                    enemyHealthBar.Value = enemyHealth;
                }
                if(enemyHealth == 0)
                {

                    isEnemy3Destroyed = true;
                    Controls.Remove(enemy3);
                    mxp.Ctlcontrols.stop();
                    mxp4.Ctlcontrols.play();                
                    enemy.Visible = false;
                    labelEnemy.Visible = false;
                    finalBossProgressBar.Visible = true;
                    labelfinalBoss.Visible = true;
                    finalBoss.Visible = true;
                    enemyHealthBar.Visible = false;
                    enemyHealth = 100;
                    finalBossProgressBar.Value = EnemyHealth;
                    trackPlayerX.Interval = 1290;
                    timer3.Start();
                    invisible.Enabled = true;
                    score = 2650;

                }

            }

            if (bullet.Bounds.IntersectsWith(enemy.Bounds) && isfalse6 == false && isEnemy1Destroyed == true && isEnemy2Destroyed == true && isEnemy3Destroyed == true)
            {

                score += 20;
                enemyHealth -= 2;
                if (enemyHealth > 0)
                {
                    finalBossProgressBar.Value = enemyHealth;
                }
                if (enemyHealth == 0)
                {
                    score = 5000;
                    saveScore();
                    gameTimer.Stop();
                    finalBossProgressBar.Value = 0;
                    Controls.Remove(finalBoss);
                    mxp4.Ctlcontrols.stop();
                    mxp5.Ctlcontrols.play();

                    enemy.Visible = false;

                    labelEnemy.Visible = false;
                   
                    enemyShoot4.Stop();
                    timer3.Stop();
                    winTitle.Visible = true;
                    winTimer.Enabled = true;

                    
                    

                }



                isfalse6 = true;



            }
            labelScore.Text = score.ToString();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            isfalse2 = false;
            isfalse5 = false;
        }

        private void timer4_Tick(object sender, EventArgs e)
        {
            isenemy_bullet10 = true;
        }

        private void healing_timer_Tick(object sender, EventArgs e)
        {
                                       
                healing();                    
        }

        private void invisible_Tick(object sender, EventArgs e)
        {
            invisible_duration.Enabled = true;
            finalBoss.Visible = false;
            
        }

        private void invisible_duration_Tick(object sender, EventArgs e)
        {
            finalBoss.Visible = true;

        }

        private void winTimer_Tick(object sender, EventArgs e)
        {
            this.Close();
        }

        private void gameoverTimer_Tick(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dicreaseSpacehipHealth(PictureBox bullet, PictureBox player)
        {
            if (bullet.Bounds.IntersectsWith(player.Bounds) && isfalse2 == false && spaceShipHealth - 20 > 0)
            {
                spaceShipHealth -= 20;
                healthBar.Value = spaceShipHealth;
                isfalse2 = true;
            


            }
            else if (bullet.Bounds.IntersectsWith(player.Bounds) && isfalse2 == false && spaceShipHealth -  20 <= 0)
            {
                spaceShipHealth = 0;
                healthBar.Value = spaceShipHealth;

            }

        }
        private void dicreaseSpacehipHealth2(PictureBox bullet, PictureBox player)
        {
            if (bullet.Bounds.IntersectsWith(player.Bounds) && isfalse2 == false && spaceShipHealth -  30 > 0)
            {
                spaceShipHealth -= 30;
                healthBar.Value = spaceShipHealth;
                isfalse2 = true;
            }
            else if (bullet.Bounds.IntersectsWith(player.Bounds) && isfalse2 == false && spaceShipHealth - 30 <= 0)
            {
                spaceShipHealth = 0;
                healthBar.Value = spaceShipHealth;

            }
        }

        private void hitSpaceShip(PictureBox bullet, PictureBox player)
        {
            if (bullet.Bounds.IntersectsWith(player.Bounds) && isfalse2 == false && spaceShipHealth - 30 > 0)
            {
                Controls.Remove(bullet);
                spaceship.Visible = false;
                spaceship.Visible = true;
              
            }
        }

        private void healSpaceShip(PictureBox heal, PictureBox player)
        {
            if (heal.Bounds.IntersectsWith(player.Bounds) && isfalse5 == false && spaceShipHealth + 20 <= 100)
            {
                spaceShipHealth += 20;
                healthBar.Value = spaceShipHealth;
                Controls.Remove(heal);
                spaceship.Visible = false;
                spaceship.Visible = true;
                isfalse5 = true;
                mxp7.Ctlcontrols.play();
            }
            else if (heal.Bounds.IntersectsWith(player.Bounds) && isfalse5 == false && spaceShipHealth + 20 > 100)
            {
                spaceShipHealth = 100;
                healthBar.Value = spaceShipHealth;
                Controls.Remove(heal);
                spaceship.Visible = false;
                spaceship.Visible = true;
            }

            
        }

     
      


    }
}
