using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GeneralProject
{
    public partial class Menu : Form
    {
        SoundPlayer s;
        public Menu()
        {
            InitializeComponent();

            
        }

        private void Menu_Load(object sender, EventArgs e)
        {
            s = new SoundPlayer("menu1.wav");
            s.PlayLooping();
            
        }

      

        private void play_btn_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            s.Stop();
          
            form2.Show();
        }

        private void highscores_btn_Click(object sender, EventArgs e)
        {
            HighScores highScores = new HighScores();
            Form2 form2 = new Form2();
            s.Stop();

            form2.Show();


            highScores.Show();
        }
    }
}
