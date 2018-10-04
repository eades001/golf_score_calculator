using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GolfScoreCalculator
{
    public partial class Form1 : Form
    {
        private int[] scoresGolfer1, scoresGolfer2;
        private int totalScoreGolfer1, totalScoreGolfer2;

        public Form1()
        {
            InitializeComponent();

            // Initialize golfer scores and total scores
            scoresGolfer1 = new int[9];
            scoresGolfer2 = new int[9];
            totalScoreGolfer1 = 0;
            totalScoreGolfer2 = 0;
        }

        private void nextButton1_Click(object sender, EventArgs e)
        {
            int holeNumber = Convert.ToInt32(holeNumberLabel1.Text);
            int score = Convert.ToInt32(holeScoreTextBox1.Text);

            // Add score to array
            scoresGolfer1[holeNumber - 1] = score;

            // Assemble hole score string and add to list box
            string listItem = String.Format("Hole {0}: scored {1}", holeNumber.ToString(), score.ToString());
            scoresListBox1.Items.Add(listItem);
            
            // Set hole number label to next hole
            holeNumberLabel1.Text = Convert.ToString(holeNumber + 1);
        }

        private void winnerButton_Click(object sender, EventArgs e)
        {
            resultsLabel.Text = nameTextBox1.Text;
        }
    }
}
