using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GeneralProject
{
    public partial class HighScores : Form
    {

        List<int> Scores = new List<int>();
        string data;

        public HighScores()
        {
            InitializeComponent();
        }

        private void HighScores_Load(object sender, EventArgs e)
        {
           
            StreamReader reader = new StreamReader("scores.txt");
            data = reader.ReadLine();
            while (data != null)
            {
                Scores.Add(Int32.Parse(data));
                data = reader.ReadLine();
            }

            Scores.Sort();
            Scores.Reverse();

         
            score1.Text = Scores[0].ToString();
            score2.Text = Scores[1].ToString();
            score3.Text = Scores[2].ToString();
            score4.Text = Scores[3].ToString();
            score5.Text = Scores[4].ToString();
            score6.Text = Scores[5].ToString();
            score7.Text = Scores[6].ToString();
            score8.Text = Scores[7].ToString();
            score9.Text = Scores[8].ToString();
            score10.Text = Scores[9].ToString();

        }

        
    }
}
