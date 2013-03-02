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
    public partial class TicTacToe : Form
    {
        #region Methods

        public TicTacToe()
        {
            InitializeComponent();

            // Initialize class variables with default values.
            this.currentPlayerInt = 0;
            this.playerNamesStrings = new string[] { "Player1", "Player2" };
            this.playerScoresInts = new int[] { 0, 0 };
            this.previousWinsQueue = new Queue<string>(5);

            // Clear the board for inital board state.
            this.ResetBoard();

            // Update remaining UI.
            this.playerToolStripStatusLabel.Text = this.playerNamesStrings[this.currentPlayerInt] + "'s turn.";
        }

        // Checks for a win with nested if statements and returns 0 for no win, 1 for win, 2 for tie.
        // All possible wins must have a piece on the outside edge, so check those first.
        // No need to check edges opposite to previously checked ones. 
        private int CheckForWin()
        {
            // Corners have the most possible wins so start there.
            if (this.boardInts[(int)BoardPosition.TOP_LEFT] == this.currentPlayerInt)
            {
                // Check for a horizontal win.
                if (this.boardInts[(int)BoardPosition.TOP_CENTER] == this.currentPlayerInt &&
                    this.boardInts[(int)BoardPosition.TOP_RIGHT] == this.currentPlayerInt) {  return 1; }

                // Check for a vertical win.
                if (this.boardInts[(int)BoardPosition.MIDDLE_LEFT] == this.currentPlayerInt &&
                    this.boardInts[(int)BoardPosition.BOTTOM_LEFT] == this.currentPlayerInt) { return 1; }

                // Check for a diagonal win.
                if (this.boardInts[(int)BoardPosition.MIDDLE_CENTER] == this.currentPlayerInt &&
                    this.boardInts[(int)BoardPosition.BOTTOM_RIGHT] == this.currentPlayerInt) { return 1; }
            }

            // Check the another corner.
            if (this.boardInts[(int)BoardPosition.TOP_RIGHT] == this.currentPlayerInt)
            {
                // Horizontal win containing TOP_RIGHT has already been checked so check for a vertical win.
                if (this.boardInts[(int)BoardPosition.MIDDLE_RIGHT] == this.currentPlayerInt &&
                    this.boardInts[(int)BoardPosition.BOTTOM_RIGHT] == this.currentPlayerInt) { return 1; }

                // Check for diagonal win.
                if (this.boardInts[(int)BoardPosition.MIDDLE_CENTER] == this.currentPlayerInt &&
                    this.boardInts[(int)BoardPosition.BOTTOM_LEFT] == this.currentPlayerInt) { return 1; }
            }

            // Check the remaining horizontal and vertical wins.
            if (this.boardInts[(int)BoardPosition.TOP_CENTER] == this.currentPlayerInt &&
                this.boardInts[(int)BoardPosition.MIDDLE_CENTER] == this.currentPlayerInt &&
                this.boardInts[(int)BoardPosition.BOTTOM_CENTER] == this.currentPlayerInt) { return 1; }

            if (this.boardInts[(int)BoardPosition.MIDDLE_LEFT] == this.currentPlayerInt &&
                this.boardInts[(int)BoardPosition.MIDDLE_CENTER] == this.currentPlayerInt &&
                this.boardInts[(int)BoardPosition.MIDDLE_RIGHT] == this.currentPlayerInt) { return 1; }

            if (this.boardInts[(int)BoardPosition.BOTTOM_LEFT] == this.currentPlayerInt &&
                this.boardInts[(int)BoardPosition.BOTTOM_CENTER] == this.currentPlayerInt &&
                this.boardInts[(int)BoardPosition.BOTTOM_RIGHT] == this.currentPlayerInt) { return 1; }

            // If a win hasn't occurred by now, see if the board is full. If not full, return no win, otherwise it's a tie.
            if (this.pieceCountInt < 9) { return 0; } else { return 2; }
        }

        // Clears the board and sets default values.
        private void ResetBoard()
        {
            // Clear the board by giving it a new array and initializing to a default value (-1).
            this.boardInts = new int[] { -1, -1, -1, -1, -1, -1, -1, -1, -1 };
            this.undoPositionInt = -1;
            this.pieceCountInt = 0;

            // Update the UI by clearing each of the board's buttons and disabling Undo.
            foreach (Button button in this.Controls.OfType<Button>()) { button.Text = ""; }
            this.undoTurnToolStripMenuItem.Enabled = false;
        }

        #endregion

        #region Events

        // Starts a new game resetting the board.
        private void newGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.ResetBoard();
        }

        // Opens a NameDialog in which names can be changed.
        private void namesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Create a NameDialog,
            NameDialog aNameDialog = new NameDialog();

            // initialize names, display the dialog, then grab new names.
            aNameDialog.PlayerNames = this.playerNamesStrings;
            
            aNameDialog.ShowDialog();
            
            this.playerNamesStrings = aNameDialog.PlayerNames;

            // Update the UI.
            this.playerToolStripStatusLabel.Text = this.playerNamesStrings[this.currentPlayerInt] + "'s turn";
        }

        // Opens a ScoreDialog in which scores can be viewed and resetted.
        private void scoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Create a ScoreDialog,
            ScoreDialog aScoreDialog = new ScoreDialog();

            // initialize names, scores, and wins, display the dialog, then grab resetted scores, wins.
            aScoreDialog.PlayerNames = this.playerNamesStrings;
            aScoreDialog.PlayerScores = this.playerScoresInts;
            aScoreDialog.PreviousWins = this.previousWinsQueue;

            aScoreDialog.ShowDialog();

            this.playerScoresInts = aScoreDialog.PlayerScores;
            this.previousWinsQueue = aScoreDialog.PreviousWins;
        }

        // Closes the program.
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Undoes the last piece placed.
        private void undoTurnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Check to see if lastPositionInt is valid; Undo is single use.
            if (this.undoPositionInt >= 0)
            {
                // Find and clear the matching button.
                foreach (Button button in this.Controls.OfType<Button>())
                {
                    if (button.TabIndex == this.undoPositionInt) { button.Text = ""; }
                }

                // Free a position in boardInts and subtract a piece.
                this.boardInts[undoPositionInt] = -1;
                this.pieceCountInt--; // Almost missed this

                // Set lastPositionInt to invalid
                this.undoPositionInt = -1;

                // Switch back the player.
                this.currentPlayerInt = this.currentPlayerInt == 0 ? 1 : 0;

                // Disable Undo and update UI.
                this.undoTurnToolStripMenuItem.Enabled = false;
                this.playerToolStripStatusLabel.Text = this.playerNamesStrings[this.currentPlayerInt] + "'s turn";
            }
        }

        // Shows an AboutBox.
        private void aboutToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            // Create an Aboutbox, then display it.
            AboutBox anAboutBox = new AboutBox();

            anAboutBox.ShowDialog();
        }

        // Event handler for each button that checks for an empty space,
        // places pieces, checks for wins and updates UI.
        // Stores the pieces placed and by whom.
        private void board_Click(object sender, EventArgs e)
        {
            // Cast the generic sender as Button for functionality.
            Button selectedButton = (Button)sender;

            // Temporary storage of the next player.
            int nextPlayerInt;

            // Check to see if the selected spot is empty (-1). If occupied, do nothing and return.
            // The button's TabIndex corresponds to it's position on the board.
            if (this.boardInts[selectedButton.TabIndex] != -1) {  return; }
            else
            {
                // Place the player's piece on the board,
                this.boardInts[selectedButton.TabIndex] = this.currentPlayerInt;

                // count it,
                this.pieceCountInt++;

                // set Undo related values,
                this.undoPositionInt = selectedButton.TabIndex;
                this.undoTurnToolStripMenuItem.Enabled = true;

                // and reflect action in the UI and queue player.
                if (this.currentPlayerInt == 0)
                {
                    selectedButton.Text = "X";
                    nextPlayerInt = 1;
                }
                else
                {
                    selectedButton.Text = "O";
                    nextPlayerInt = 0;
                }

                // temporary storage for the CheckForWin result.
                int resultInt;

                // Display message boxes for a win (1) or tie (2), otherwise do nothing (0).
                switch (resultInt = CheckForWin())
                {
                    case 1:
                        // Temporary string, picking player names for the win message box.
                        string winnerString = this.playerNamesStrings[this.currentPlayerInt] + " has won!";

                        MessageBox.Show(winnerString, "Win!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                        // Reset the board.
                        this.ResetBoard();

                        // Although not necessary, I would like to store only the last 5 wins, so remove oldest win.
                        if (this.previousWinsQueue.Count > 4) this.previousWinsQueue.Dequeue();

                        // Increment the player's win.
                        this.previousWinsQueue.Enqueue(this.playerNamesStrings[this.currentPlayerInt]);
                        this.playerScoresInts[this.currentPlayerInt]++;

                        break;
                    case 2:
                        MessageBox.Show("No one has won because a tie has occured!", "Tie!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                        this.ResetBoard();

                        if (this.previousWinsQueue.Count > 4) this.previousWinsQueue.Dequeue();

                        this.previousWinsQueue.Enqueue("Tie");

                        break;
                    default:
                        break;
                }

                // Switch players.
                this.currentPlayerInt = nextPlayerInt;

                // Update UI.
                this.playerToolStripStatusLabel.Text = this.playerNamesStrings[this.currentPlayerInt] + "'s turn";
            }
        }

        #endregion

        #region Members

        // Declare private class Variables.

        // Enum of possible positions, for clarity.
        private enum BoardPosition { TOP_LEFT, TOP_CENTER, TOP_RIGHT, MIDDLE_LEFT, MIDDLE_CENTER, MIDDLE_RIGHT, BOTTOM_LEFT, BOTTOM_CENTER, BOTTOM_RIGHT }

        // Stores the pieces placed and by whom.
        private int[] boardInts;

        // Stores the current player number.
        private int currentPlayerInt;

        // Counts the pieces placed, used to quickly check for tied games.
        private int pieceCountInt;

        // Stores the players' names.
        private string[] playerNamesStrings;

        // Stores the players' scores.
        private int[] playerScoresInts;

        // Stores the last 5 games played.
        private Queue<string> previousWinsQueue;

        // Stores the last selected position to undo.
        private int undoPositionInt;

        #endregion
    }
}
