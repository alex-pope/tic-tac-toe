using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TicTacToe
{
    public partial class ScoreDialog : Form
    {
        public ScoreDialog()
        {
            InitializeComponent();

            // Initialize defaults using properties so that UI is also updated.
            this.PlayerNames = new string[] { "Player1", "Player2" };
            this.PlayerScores = new int[] { 0, 0 };
            this.PreviousWins = new Queue<string>(5);
        }

        #region Properties

        // Gets and sets the players' names.
        public string[] PlayerNames
        {
            get
            {
                return this.playerNameStrings;
            }
            set
            {
                this.playerNameStrings = value;

                // Update the UI.
                this.playerOneLabel.Text = this.playerNameStrings[0];
                this.playerTwoLabel.Text = this.playerNameStrings[1];
            }
        }
        
        // Gets and sets the players' scores.
        public int[] PlayerScores
        {
            get
            {
                return this.playerScoresInts;
            }
            set
            {
                this.playerScoresInts = value;

                // Update the UI.
                this.playerOneScoreLabel.Text = this.playerScoresInts[0].ToString();
                this.playerTwoScoreLabel.Text = this.playerScoresInts[1].ToString();
            }
        }

        // Gets and sets the queue holding the last 5 games played.
        public Queue<string> PreviousWins
        {
            get
            {
                return this.previousWinsQueue;
            }
            set
            {
                this.previousWinsQueue = value;

                // Update the UI by emptying the list box then adding the array of strings.
                this.gameHistoryListBox.Items.Clear();
                this.gameHistoryListBox.Items.AddRange(this.previousWinsQueue.ToArray());
            }
        }

        #endregion

        #region Events

        // Resets the scores.
        private void resetButton_Click(object sender, EventArgs e)
        {
            DialogResult result;

            result = MessageBox.Show("Do you really want to Reset Scores?", "Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (result == DialogResult.OK)
            {
                // Accessing through properties also updates UI.
                this.PlayerScores = new int[] { 0, 0 };
                this.PreviousWins = new Queue<string>(5);

                // Close the form to return to the game.
                this.Close();
            }
        }

        // Closes the form without doing anything.
        private void doneButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #endregion

        #region Members

        // Declare private class Variables.
        private string[] playerNameStrings;
        private int[] playerScoresInts;
        private Queue<string> previousWinsQueue;

        #endregion
    }
}
