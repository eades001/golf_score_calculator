using System;
using System.Windows.Forms;

/*****************************************/
/*  Project 3:   Golf Score Calculator   */
/*  Author:      Lynn Eades              */
/*  Date:        10/7/2018               */
/*****************************************/

namespace GolfScoreCalculator
{
    public partial class Form1 : Form
    {
        const int TOTAL_HOLES = 9;

        private int[] scoresGolfer1, scoresGolfer2;
        private int totalScoreGolfer1, totalScoreGolfer2;

        public Form1()
        {
            InitializeComponent();

            // Initialize golfer scores list and total scores
            scoresGolfer1 = new int[TOTAL_HOLES];
            scoresGolfer2 = new int[TOTAL_HOLES];
            totalScoreGolfer1 = 0;
            totalScoreGolfer2 = 0;
        }

        private void quitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void nextButton1_Click(object sender, EventArgs e)
        {
            // Get the current hole number
            int thisHole = Convert.ToInt16(holeNumberLabel1.Text);

            // clear out any error message if displayed
            errorLabel1.Text = "";
            
            // Handle non-integer scores entered with try-catch
            try
            {
                // Add entered score to scores array
                int thisScore = Convert.ToInt16(holeScoreTextBox1.Text);
                scoresGolfer1[thisHole - 1] = thisScore;
                
                // Keep a running total
                totalScoreGolfer1 += thisScore;

                // Clear last score from text box
                holeScoreTextBox1.Clear();

                // If more holes to enter, set next hole number label
                if (thisHole != TOTAL_HOLES)
                {
                    holeNumberLabel1.Text = Convert.ToString(thisHole + 1);
                    holeScoreTextBox1.Focus();
                }
                // If this is the last hole, display score results
                else
                {
                    // Disable input box and button to prevent entering more than 9 scores
                    nextButton1.Enabled = false;
                    holeScoreTextBox1.Enabled = false;

                    // Display the scores in the listbox and the total score
                    for (int hole = 1; hole <= scoresGolfer1.Length; hole++)
                    {
                        int score = scoresGolfer1[hole - 1];

                        // Assemble hole score string and add to list box
                        string listItem = String.Format("  Hole #{0}   Score {1}", hole.ToString(), score.ToString());
                        scoresListBox1.Items.Add(listItem);
                    }

                    // Display the total score
                    totalLabel1.Text = Convert.ToString(totalScoreGolfer1);
                }
            }
            // If score entered is not an integer, display an error
            catch
            {
                // Show the error
                string errorString = "Please enter a whole number";
                errorLabel1.Text = errorString;

                // Clear the bad stuff and set focus for next try
                holeScoreTextBox1.Clear();
                holeScoreTextBox1.Focus();
            }
        }

        private void nextButton2_Click(object sender, EventArgs e)
        {
            // Get the current hole number
            int thisHole = Convert.ToInt16(holeNumberLabel2.Text);

            // clear out any error message if displayed
            errorLabel2.Text = "";
            
            // Handle non-integer scores with try-catch
            try
            {
                // Add entered score to scores array
                int thisScore = Convert.ToInt16(holeScoreTextBox2.Text);
                scoresGolfer2[thisHole - 1] = thisScore;

                // Keep a running total
                totalScoreGolfer2 += thisScore;

                // Clear last score from text box
                holeScoreTextBox2.Clear();

                // If more holes to enter, set next hole number label
                if (thisHole != TOTAL_HOLES)
                {
                    holeNumberLabel2.Text = Convert.ToString(thisHole + 1);
                    holeScoreTextBox2.Focus();
                }
                // If this is the last hole, display score results
                else
                {
                    // Disable input box and button to prevent entering more than 9 scores
                    nextButton2.Enabled = false;
                    holeScoreTextBox2.Enabled = false;

                    // Display the scores in the listbox and the total score
                    for (int hole = 1; hole <= scoresGolfer2.Length; hole++)
                    {
                        int score = scoresGolfer2[hole - 1];

                        // Assemble hole score string and add to list box
                        string listItem = String.Format("  Hole #{0}   Score {1}", hole.ToString(), score.ToString());
                        scoresListBox2.Items.Add(listItem);
                    }

                    // Display the total score
                    totalLabel2.Text = Convert.ToString(totalScoreGolfer2);
                }
            }
            // If score entered is not an integer, display an error
            catch
            {
                // Show the error
                string errorString = "Please enter a whole number";
                errorLabel2.Text = errorString;

                // Clear the bad stuff and set focus for next try
                holeScoreTextBox2.Clear();
                holeScoreTextBox2.Focus();
            }
        }

        private void winnerButton_Click(object sender, EventArgs e)
        {
            string winnerText;

            // Determine the winner - lowest score wins in golf
            if (totalScoreGolfer1 < totalScoreGolfer2)
            {
                string firstName = nameTextBox1.Text.Split()[0].Trim();
                winnerText = String.Format("{0} WINS!", firstName);
            }
            else if (totalScoreGolfer2 < totalScoreGolfer1)
            {
                // Get just the first name if user adds more than 1
                string firstName = nameTextBox2.Text.Split()[0].Trim();
                winnerText = String.Format("{0} WINS!", firstName);
            }
            else // must be a tie
            {
                winnerText = String.Format("It's a TIE!");
            }

            // Display winner or a tie
;           resultsLabel.Text = winnerText;
        }
    }
}
