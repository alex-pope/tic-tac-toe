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
    public partial class NameDialog : Form
    {
        public NameDialog()
        {
            InitializeComponent();

            // Initialize defaults using properties so that UI is also updated.
            this.PlayerNames = new string[]{ "Player1","Player2" };
        }

        // Properties.
        public string[] PlayerNames
        {
            get
            {
                return this.playerNamesStrings;
            }
            set
            {

                this.playerNamesStrings = value;

                // Update the UI.
                this.playerOneTextBox.Text = this.playerNamesStrings[0];
                this.playerTwoTextBox.Text = this.playerNamesStrings[1];
            }
        }

        #region Events

        // Store the inputted names in the playerNamesString array then close the dialog.
        private void okayButton_Click(object sender, EventArgs e)
        {
            this.playerNamesStrings = new string[] { this.playerOneTextBox.Text, this.playerTwoTextBox.Text };
            //this.playerNameStrings[0] = this.playerOneTextBox.Text;
            //this.playerNameStrings[1] = this.playerTwoTextBox.Text;

            this.Close();
        }

        // Cancels the name change by just closing with no assignments.
        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #endregion

        // Declare private class Variables.
        private string[] playerNamesStrings;
    }
}
