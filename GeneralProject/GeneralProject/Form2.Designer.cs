namespace GeneralProject
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.labelHealth = new System.Windows.Forms.Label();
            this.healthBar = new System.Windows.Forms.ProgressBar();
            this.enemyMovement = new System.Windows.Forms.Timer(this.components);
            this.enemyHealthBar = new System.Windows.Forms.ProgressBar();
            this.labelEnemy = new System.Windows.Forms.Label();
            this.enemyShoot1 = new System.Windows.Forms.Timer(this.components);
            this.labelScore = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.enemyShoot2 = new System.Windows.Forms.Timer(this.components);
            this.trackPlayerX = new System.Windows.Forms.Timer(this.components);
            this.timer3 = new System.Windows.Forms.Timer(this.components);
            this.enemyShoot4 = new System.Windows.Forms.Timer(this.components);
            this.timer4 = new System.Windows.Forms.Timer(this.components);
            this.finalBossProgressBar = new System.Windows.Forms.ProgressBar();
            this.labelfinalBoss = new System.Windows.Forms.Label();
            this.enemyMovement2 = new System.Windows.Forms.Timer(this.components);
            this.healing_timer = new System.Windows.Forms.Timer(this.components);
            this.invisible = new System.Windows.Forms.Timer(this.components);
            this.invisible_duration = new System.Windows.Forms.Timer(this.components);
            this.winTitle = new System.Windows.Forms.PictureBox();
            this.gameover = new System.Windows.Forms.PictureBox();
            this.finalBoss = new System.Windows.Forms.PictureBox();
            this.enemy3 = new System.Windows.Forms.PictureBox();
            this.enemy2 = new System.Windows.Forms.PictureBox();
            this.rocketFire2 = new System.Windows.Forms.PictureBox();
            this.rocketFire1 = new System.Windows.Forms.PictureBox();
            this.enemy = new System.Windows.Forms.PictureBox();
            this.spaceship = new System.Windows.Forms.PictureBox();
            this.mxp8 = new AxWMPLib.AxWindowsMediaPlayer();
            this.mxp7 = new AxWMPLib.AxWindowsMediaPlayer();
            this.mxp6 = new AxWMPLib.AxWindowsMediaPlayer();
            this.mxp5 = new AxWMPLib.AxWindowsMediaPlayer();
            this.mxp4 = new AxWMPLib.AxWindowsMediaPlayer();
            this.mxp3 = new AxWMPLib.AxWindowsMediaPlayer();
            this.mxp2 = new AxWMPLib.AxWindowsMediaPlayer();
            this.mxp1 = new AxWMPLib.AxWindowsMediaPlayer();
            this.mxp = new AxWMPLib.AxWindowsMediaPlayer();
            this.winTimer = new System.Windows.Forms.Timer(this.components);
            this.gameoverTimer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.winTitle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gameover)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.finalBoss)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemy3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemy2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rocketFire2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rocketFire1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spaceship)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mxp8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mxp7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mxp6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mxp5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mxp4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mxp3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mxp2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mxp1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mxp)).BeginInit();
            this.SuspendLayout();
            // 
            // gameTimer
            // 
            this.gameTimer.Enabled = true;
            this.gameTimer.Interval = 10;
            this.gameTimer.Tick += new System.EventHandler(this.gameTimer_Tick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(-3, 2);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 31);
            this.label2.TabIndex = 1;
            this.label2.Text = "Score: ";
            // 
            // labelHealth
            // 
            this.labelHealth.AutoSize = true;
            this.labelHealth.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.labelHealth.ForeColor = System.Drawing.Color.White;
            this.labelHealth.Location = new System.Drawing.Point(-2, 852);
            this.labelHealth.Name = "labelHealth";
            this.labelHealth.Size = new System.Drawing.Size(74, 25);
            this.labelHealth.TabIndex = 2;
            this.labelHealth.Text = "Health";
            // 
            // healthBar
            // 
            this.healthBar.Location = new System.Drawing.Point(3, 880);
            this.healthBar.Name = "healthBar";
            this.healthBar.Size = new System.Drawing.Size(178, 17);
            this.healthBar.TabIndex = 3;
            this.healthBar.Value = 100;
            // 
            // enemyMovement
            // 
            this.enemyMovement.Enabled = true;
            this.enemyMovement.Interval = 1700;
            this.enemyMovement.Tick += new System.EventHandler(this.enemyMovement_Tick);
            // 
            // enemyHealthBar
            // 
            this.enemyHealthBar.ForeColor = System.Drawing.Color.Transparent;
            this.enemyHealthBar.Location = new System.Drawing.Point(1079, 12);
            this.enemyHealthBar.Name = "enemyHealthBar";
            this.enemyHealthBar.Size = new System.Drawing.Size(219, 17);
            this.enemyHealthBar.TabIndex = 5;
            this.enemyHealthBar.Value = 100;
            // 
            // labelEnemy
            // 
            this.labelEnemy.AutoSize = true;
            this.labelEnemy.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.labelEnemy.ForeColor = System.Drawing.Color.White;
            this.labelEnemy.Location = new System.Drawing.Point(949, 9);
            this.labelEnemy.Name = "labelEnemy";
            this.labelEnemy.Size = new System.Drawing.Size(134, 24);
            this.labelEnemy.TabIndex = 6;
            this.labelEnemy.Text = "Enemy Health:";
            // 
            // enemyShoot1
            // 
            this.enemyShoot1.Enabled = true;
            this.enemyShoot1.Interval = 1600;
            this.enemyShoot1.Tick += new System.EventHandler(this.enemyShoot1_Tick);
            // 
            // labelScore
            // 
            this.labelScore.AutoSize = true;
            this.labelScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.labelScore.ForeColor = System.Drawing.Color.White;
            this.labelScore.Location = new System.Drawing.Point(79, 2);
            this.labelScore.Name = "labelScore";
            this.labelScore.Size = new System.Drawing.Size(29, 31);
            this.labelScore.TabIndex = 7;
            this.labelScore.Text = "0";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 350;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Enabled = true;
            this.timer2.Interval = 1500;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // enemyShoot2
            // 
            this.enemyShoot2.Enabled = true;
            this.enemyShoot2.Interval = 6700;
            this.enemyShoot2.Tick += new System.EventHandler(this.enemyShoot2_Tick);
            // 
            // trackPlayerX
            // 
            this.trackPlayerX.Enabled = true;
            this.trackPlayerX.Interval = 6690;
            this.trackPlayerX.Tick += new System.EventHandler(this.trackPlayerX_Tick);
            // 
            // timer3
            // 
            this.timer3.Enabled = true;
            this.timer3.Interval = 2000;
            this.timer3.Tick += new System.EventHandler(this.timer3_Tick);
            // 
            // enemyShoot4
            // 
            this.enemyShoot4.Enabled = true;
            this.enemyShoot4.Interval = 1300;
            this.enemyShoot4.Tick += new System.EventHandler(this.enemyShoot4_Tick);
            // 
            // timer4
            // 
            this.timer4.Interval = 18000;
            this.timer4.Tick += new System.EventHandler(this.timer4_Tick);
            // 
            // finalBossProgressBar
            // 
            this.finalBossProgressBar.ForeColor = System.Drawing.Color.Transparent;
            this.finalBossProgressBar.Location = new System.Drawing.Point(337, 12);
            this.finalBossProgressBar.Name = "finalBossProgressBar";
            this.finalBossProgressBar.Size = new System.Drawing.Size(736, 17);
            this.finalBossProgressBar.TabIndex = 21;
            this.finalBossProgressBar.Value = 100;
            this.finalBossProgressBar.Visible = false;
            // 
            // labelfinalBoss
            // 
            this.labelfinalBoss.AutoSize = true;
            this.labelfinalBoss.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.labelfinalBoss.ForeColor = System.Drawing.Color.White;
            this.labelfinalBoss.Location = new System.Drawing.Point(170, 8);
            this.labelfinalBoss.Name = "labelfinalBoss";
            this.labelfinalBoss.Size = new System.Drawing.Size(161, 24);
            this.labelfinalBoss.TabIndex = 22;
            this.labelfinalBoss.Text = "Final Boss Health:";
            this.labelfinalBoss.Visible = false;
            // 
            // enemyMovement2
            // 
            this.enemyMovement2.Enabled = true;
            this.enemyMovement2.Interval = 3000;
            this.enemyMovement2.Tick += new System.EventHandler(this.enemyMovement2_Tick);
            // 
            // healing_timer
            // 
            this.healing_timer.Interval = 20000;
            this.healing_timer.Tick += new System.EventHandler(this.healing_timer_Tick);
            // 
            // invisible
            // 
            this.invisible.Interval = 20000;
            this.invisible.Tick += new System.EventHandler(this.invisible_Tick);
            // 
            // invisible_duration
            // 
            this.invisible_duration.Interval = 4980;
            this.invisible_duration.Tick += new System.EventHandler(this.invisible_duration_Tick);
            // 
            // winTitle
            // 
            this.winTitle.BackgroundImage = global::GeneralProject.Properties.Resources.win;
            this.winTitle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.winTitle.Location = new System.Drawing.Point(174, 161);
            this.winTitle.Name = "winTitle";
            this.winTitle.Size = new System.Drawing.Size(865, 461);
            this.winTitle.TabIndex = 27;
            this.winTitle.TabStop = false;
            this.winTitle.Visible = false;
            // 
            // gameover
            // 
            this.gameover.BackgroundImage = global::GeneralProject.Properties.Resources.gameover;
            this.gameover.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.gameover.Location = new System.Drawing.Point(289, 299);
            this.gameover.Name = "gameover";
            this.gameover.Size = new System.Drawing.Size(694, 161);
            this.gameover.TabIndex = 26;
            this.gameover.TabStop = false;
            this.gameover.Visible = false;
            // 
            // finalBoss
            // 
            this.finalBoss.BackColor = System.Drawing.Color.Transparent;
            this.finalBoss.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("finalBoss.BackgroundImage")));
            this.finalBoss.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.finalBoss.Location = new System.Drawing.Point(510, 35);
            this.finalBoss.Name = "finalBoss";
            this.finalBoss.Size = new System.Drawing.Size(223, 139);
            this.finalBoss.TabIndex = 20;
            this.finalBoss.TabStop = false;
            this.finalBoss.Visible = false;
            // 
            // enemy3
            // 
            this.enemy3.BackColor = System.Drawing.Color.Transparent;
            this.enemy3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("enemy3.BackgroundImage")));
            this.enemy3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.enemy3.Location = new System.Drawing.Point(318, 54);
            this.enemy3.Name = "enemy3";
            this.enemy3.Size = new System.Drawing.Size(125, 101);
            this.enemy3.TabIndex = 14;
            this.enemy3.TabStop = false;
            this.enemy3.Visible = false;
            // 
            // enemy2
            // 
            this.enemy2.BackColor = System.Drawing.Color.Transparent;
            this.enemy2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("enemy2.BackgroundImage")));
            this.enemy2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.enemy2.Location = new System.Drawing.Point(781, 54);
            this.enemy2.Name = "enemy2";
            this.enemy2.Size = new System.Drawing.Size(125, 101);
            this.enemy2.TabIndex = 10;
            this.enemy2.TabStop = false;
            this.enemy2.Visible = false;
            // 
            // rocketFire2
            // 
            this.rocketFire2.BackColor = System.Drawing.Color.Transparent;
            this.rocketFire2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("rocketFire2.BackgroundImage")));
            this.rocketFire2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.rocketFire2.Location = new System.Drawing.Point(628, 849);
            this.rocketFire2.Name = "rocketFire2";
            this.rocketFire2.Size = new System.Drawing.Size(17, 19);
            this.rocketFire2.TabIndex = 9;
            this.rocketFire2.TabStop = false;
            this.rocketFire2.Visible = false;
            // 
            // rocketFire1
            // 
            this.rocketFire1.BackColor = System.Drawing.Color.Transparent;
            this.rocketFire1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("rocketFire1.BackgroundImage")));
            this.rocketFire1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.rocketFire1.Location = new System.Drawing.Point(591, 849);
            this.rocketFire1.Name = "rocketFire1";
            this.rocketFire1.Size = new System.Drawing.Size(17, 19);
            this.rocketFire1.TabIndex = 8;
            this.rocketFire1.TabStop = false;
            this.rocketFire1.Visible = false;
            // 
            // enemy
            // 
            this.enemy.BackColor = System.Drawing.Color.Transparent;
            this.enemy.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("enemy.BackgroundImage")));
            this.enemy.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.enemy.Location = new System.Drawing.Point(570, 37);
            this.enemy.Name = "enemy";
            this.enemy.Size = new System.Drawing.Size(125, 99);
            this.enemy.TabIndex = 4;
            this.enemy.TabStop = false;
            // 
            // spaceship
            // 
            this.spaceship.BackColor = System.Drawing.Color.Transparent;
            this.spaceship.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("spaceship.BackgroundImage")));
            this.spaceship.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.spaceship.Location = new System.Drawing.Point(575, 770);
            this.spaceship.Name = "spaceship";
            this.spaceship.Size = new System.Drawing.Size(90, 80);
            this.spaceship.TabIndex = 0;
            this.spaceship.TabStop = false;
            // 
            // mxp8
            // 
            this.mxp8.Enabled = true;
            this.mxp8.Location = new System.Drawing.Point(3, 680);
            this.mxp8.Name = "mxp8";
            this.mxp8.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("mxp8.OcxState")));
            this.mxp8.Size = new System.Drawing.Size(75, 23);
            this.mxp8.TabIndex = 24;
            this.mxp8.Visible = false;
            // 
            // mxp7
            // 
            this.mxp7.Enabled = true;
            this.mxp7.Location = new System.Drawing.Point(3, 651);
            this.mxp7.Name = "mxp7";
            this.mxp7.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("mxp7.OcxState")));
            this.mxp7.Size = new System.Drawing.Size(75, 23);
            this.mxp7.TabIndex = 23;
            this.mxp7.Visible = false;
            // 
            // mxp6
            // 
            this.mxp6.Enabled = true;
            this.mxp6.Location = new System.Drawing.Point(3, 622);
            this.mxp6.Name = "mxp6";
            this.mxp6.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("mxp6.OcxState")));
            this.mxp6.Size = new System.Drawing.Size(75, 23);
            this.mxp6.TabIndex = 18;
            this.mxp6.Visible = false;
            // 
            // mxp5
            // 
            this.mxp5.Enabled = true;
            this.mxp5.Location = new System.Drawing.Point(3, 593);
            this.mxp5.Name = "mxp5";
            this.mxp5.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("mxp5.OcxState")));
            this.mxp5.Size = new System.Drawing.Size(75, 23);
            this.mxp5.TabIndex = 17;
            this.mxp5.Visible = false;
            // 
            // mxp4
            // 
            this.mxp4.Enabled = true;
            this.mxp4.Location = new System.Drawing.Point(3, 564);
            this.mxp4.Name = "mxp4";
            this.mxp4.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("mxp4.OcxState")));
            this.mxp4.Size = new System.Drawing.Size(75, 23);
            this.mxp4.TabIndex = 16;
            this.mxp4.Visible = false;
            // 
            // mxp3
            // 
            this.mxp3.Enabled = true;
            this.mxp3.Location = new System.Drawing.Point(3, 535);
            this.mxp3.Name = "mxp3";
            this.mxp3.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("mxp3.OcxState")));
            this.mxp3.Size = new System.Drawing.Size(75, 23);
            this.mxp3.TabIndex = 15;
            this.mxp3.Visible = false;
            // 
            // mxp2
            // 
            this.mxp2.Enabled = true;
            this.mxp2.Location = new System.Drawing.Point(3, 506);
            this.mxp2.Name = "mxp2";
            this.mxp2.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("mxp2.OcxState")));
            this.mxp2.Size = new System.Drawing.Size(75, 23);
            this.mxp2.TabIndex = 13;
            this.mxp2.Visible = false;
            // 
            // mxp1
            // 
            this.mxp1.Enabled = true;
            this.mxp1.Location = new System.Drawing.Point(3, 477);
            this.mxp1.Name = "mxp1";
            this.mxp1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("mxp1.OcxState")));
            this.mxp1.Size = new System.Drawing.Size(75, 23);
            this.mxp1.TabIndex = 12;
            this.mxp1.Visible = false;
            // 
            // mxp
            // 
            this.mxp.Enabled = true;
            this.mxp.Location = new System.Drawing.Point(3, 448);
            this.mxp.Name = "mxp";
            this.mxp.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("mxp.OcxState")));
            this.mxp.Size = new System.Drawing.Size(75, 23);
            this.mxp.TabIndex = 11;
            this.mxp.Visible = false;
            // 
            // winTimer
            // 
            this.winTimer.Interval = 21000;
            this.winTimer.Tick += new System.EventHandler(this.winTimer_Tick);
            // 
            // gameoverTimer
            // 
            this.gameoverTimer.Interval = 10000;
            this.gameoverTimer.Tick += new System.EventHandler(this.gameoverTimer_Tick);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlText;
            this.ClientSize = new System.Drawing.Size(1300, 900);
            this.Controls.Add(this.winTitle);
            this.Controls.Add(this.gameover);
            this.Controls.Add(this.mxp8);
            this.Controls.Add(this.mxp7);
            this.Controls.Add(this.labelfinalBoss);
            this.Controls.Add(this.finalBossProgressBar);
            this.Controls.Add(this.finalBoss);
            this.Controls.Add(this.mxp6);
            this.Controls.Add(this.mxp5);
            this.Controls.Add(this.mxp4);
            this.Controls.Add(this.mxp3);
            this.Controls.Add(this.enemy3);
            this.Controls.Add(this.mxp2);
            this.Controls.Add(this.mxp1);
            this.Controls.Add(this.mxp);
            this.Controls.Add(this.enemy2);
            this.Controls.Add(this.rocketFire2);
            this.Controls.Add(this.rocketFire1);
            this.Controls.Add(this.labelScore);
            this.Controls.Add(this.labelEnemy);
            this.Controls.Add(this.enemyHealthBar);
            this.Controls.Add(this.enemy);
            this.Controls.Add(this.healthBar);
            this.Controls.Add(this.labelHealth);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.spaceship);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form2_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form2_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.winTitle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gameover)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.finalBoss)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemy3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemy2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rocketFire2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rocketFire1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spaceship)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mxp8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mxp7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mxp6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mxp5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mxp4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mxp3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mxp2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mxp1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mxp)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox spaceship;
        private System.Windows.Forms.Timer gameTimer;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelHealth;
        private System.Windows.Forms.ProgressBar healthBar;
        private System.Windows.Forms.PictureBox enemy;
        private System.Windows.Forms.Timer enemyMovement;
        private System.Windows.Forms.ProgressBar enemyHealthBar;
        private System.Windows.Forms.Label labelEnemy;
        private System.Windows.Forms.Timer enemyShoot1;
        private System.Windows.Forms.Label labelScore;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Timer enemyShoot2;
        private System.Windows.Forms.PictureBox rocketFire1;
        private System.Windows.Forms.PictureBox rocketFire2;
        private System.Windows.Forms.Timer trackPlayerX;
        private System.Windows.Forms.PictureBox enemy2;
        private AxWMPLib.AxWindowsMediaPlayer mxp;
        private AxWMPLib.AxWindowsMediaPlayer mxp1;
        private AxWMPLib.AxWindowsMediaPlayer mxp2;
        private System.Windows.Forms.Timer timer3;
        private System.Windows.Forms.PictureBox enemy3;
        private AxWMPLib.AxWindowsMediaPlayer mxp3;
        private System.Windows.Forms.Timer enemyShoot4;
        private System.Windows.Forms.Timer timer4;
        private AxWMPLib.AxWindowsMediaPlayer mxp4;
        private AxWMPLib.AxWindowsMediaPlayer mxp5;
        private AxWMPLib.AxWindowsMediaPlayer mxp6;
        private System.Windows.Forms.PictureBox finalBoss;
        private System.Windows.Forms.ProgressBar finalBossProgressBar;
        private System.Windows.Forms.Label labelfinalBoss;
        private System.Windows.Forms.Timer enemyMovement2;
        private System.Windows.Forms.Timer healing_timer;
        private AxWMPLib.AxWindowsMediaPlayer mxp7;
        private System.Windows.Forms.Timer invisible;
        private System.Windows.Forms.Timer invisible_duration;
        private AxWMPLib.AxWindowsMediaPlayer mxp8;
        private System.Windows.Forms.PictureBox gameover;
        private System.Windows.Forms.PictureBox winTitle;
        private System.Windows.Forms.Timer winTimer;
        private System.Windows.Forms.Timer gameoverTimer;
    }
}