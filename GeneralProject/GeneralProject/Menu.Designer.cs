using System.Drawing;
using System.Windows.Forms;

namespace GeneralProject
{
    partial class Menu
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
            this.play_btn = new System.Windows.Forms.Button();
            this.highscores_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // play_btn
            // 
            this.play_btn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.play_btn.BackColor = System.Drawing.Color.Transparent;
            this.play_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.play_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.play_btn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.play_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Magenta;
            this.play_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Magenta;
            this.play_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.play_btn.Font = new System.Drawing.Font("Ravie", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.play_btn.ForeColor = System.Drawing.Color.White;
            this.play_btn.Location = new System.Drawing.Point(570, 487);
            this.play_btn.Name = "play_btn";
            this.play_btn.Size = new System.Drawing.Size(199, 54);
            this.play_btn.TabIndex = 2;
            this.play_btn.Text = "Play";
            this.play_btn.UseVisualStyleBackColor = false;
            this.play_btn.Click += new System.EventHandler(this.play_btn_Click);
            // 
            // highscores_btn
            // 
            this.highscores_btn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.highscores_btn.BackColor = System.Drawing.Color.Transparent;
            this.highscores_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.highscores_btn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.highscores_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Magenta;
            this.highscores_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Magenta;
            this.highscores_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.highscores_btn.Font = new System.Drawing.Font("Ravie", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.highscores_btn.ForeColor = System.Drawing.Color.White;
            this.highscores_btn.Location = new System.Drawing.Point(531, 557);
            this.highscores_btn.Name = "highscores_btn";
            this.highscores_btn.Size = new System.Drawing.Size(278, 59);
            this.highscores_btn.TabIndex = 3;
            this.highscores_btn.Text = "Highscores";
            this.highscores_btn.UseVisualStyleBackColor = false;
            this.highscores_btn.Click += new System.EventHandler(this.highscores_btn_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = global::GeneralProject.Properties.Resources._5509862;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1300, 900);
            this.Controls.Add(this.highscores_btn);
            this.Controls.Add(this.play_btn);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.Menu_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private Button play_btn;
        private Button highscores_btn;
    }
}

