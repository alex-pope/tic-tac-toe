namespace TicTacToe
{
    partial class ScoreDialog
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
            this.gameHistoryListBox = new System.Windows.Forms.ListBox();
            this.gameHistoryLabel = new System.Windows.Forms.Label();
            this.playerOneLabel = new System.Windows.Forms.Label();
            this.playerTwoLabel = new System.Windows.Forms.Label();
            this.resetButton = new System.Windows.Forms.Button();
            this.cancelScoreButton = new System.Windows.Forms.Button();
            this.playerTwoScoreLabel = new System.Windows.Forms.Label();
            this.playerOneScoreLabel = new System.Windows.Forms.Label();
            this.aToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // gameHistoryListBox
            // 
            this.gameHistoryListBox.FormattingEnabled = true;
            this.gameHistoryListBox.Location = new System.Drawing.Point(9, 81);
            this.gameHistoryListBox.Name = "gameHistoryListBox";
            this.gameHistoryListBox.Size = new System.Drawing.Size(160, 95);
            this.gameHistoryListBox.TabIndex = 6;
            this.aToolTip.SetToolTip(this.gameHistoryListBox, "The last five games played.");
            // 
            // gameHistoryLabel
            // 
            this.gameHistoryLabel.AutoSize = true;
            this.gameHistoryLabel.Location = new System.Drawing.Point(9, 65);
            this.gameHistoryLabel.Name = "gameHistoryLabel";
            this.gameHistoryLabel.Size = new System.Drawing.Size(70, 13);
            this.gameHistoryLabel.TabIndex = 5;
            this.gameHistoryLabel.Text = "Game History";
            this.aToolTip.SetToolTip(this.gameHistoryLabel, "The last five games played.");
            // 
            // playerOneLabel
            // 
            this.playerOneLabel.AutoSize = true;
            this.playerOneLabel.Location = new System.Drawing.Point(12, 9);
            this.playerOneLabel.Name = "playerOneLabel";
            this.playerOneLabel.Size = new System.Drawing.Size(42, 13);
            this.playerOneLabel.TabIndex = 1;
            this.playerOneLabel.Text = "Player1";
            this.aToolTip.SetToolTip(this.playerOneLabel, "The Player\'s scores.");
            // 
            // playerTwoLabel
            // 
            this.playerTwoLabel.AutoSize = true;
            this.playerTwoLabel.Location = new System.Drawing.Point(12, 32);
            this.playerTwoLabel.Name = "playerTwoLabel";
            this.playerTwoLabel.Size = new System.Drawing.Size(42, 13);
            this.playerTwoLabel.TabIndex = 3;
            this.playerTwoLabel.Text = "Player2";
            this.aToolTip.SetToolTip(this.playerTwoLabel, "The Player\'s scores.");
            // 
            // resetButton
            // 
            this.resetButton.Location = new System.Drawing.Point(9, 182);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(160, 23);
            this.resetButton.TabIndex = 7;
            this.resetButton.Text = "Reset Scores and Return";
            this.aToolTip.SetToolTip(this.resetButton, "Resets the scores and clears history.");
            this.resetButton.UseVisualStyleBackColor = true;
            this.resetButton.Click += new System.EventHandler(this.resetButton_Click);
            // 
            // cancelScoreButton
            // 
            this.cancelScoreButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelScoreButton.Location = new System.Drawing.Point(9, 231);
            this.cancelScoreButton.Name = "cancelScoreButton";
            this.cancelScoreButton.Size = new System.Drawing.Size(160, 23);
            this.cancelScoreButton.TabIndex = 0;
            this.cancelScoreButton.Text = "Cancel";
            this.aToolTip.SetToolTip(this.cancelScoreButton, "Returns to the game.");
            this.cancelScoreButton.UseVisualStyleBackColor = true;
            this.cancelScoreButton.Click += new System.EventHandler(this.doneButton_Click);
            // 
            // playerTwoScoreLabel
            // 
            this.playerTwoScoreLabel.AutoSize = true;
            this.playerTwoScoreLabel.Location = new System.Drawing.Point(159, 32);
            this.playerTwoScoreLabel.Name = "playerTwoScoreLabel";
            this.playerTwoScoreLabel.Size = new System.Drawing.Size(13, 13);
            this.playerTwoScoreLabel.TabIndex = 4;
            this.playerTwoScoreLabel.Text = "0";
            this.playerTwoScoreLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.aToolTip.SetToolTip(this.playerTwoScoreLabel, "The Player\'s scores.");
            // 
            // playerOneScoreLabel
            // 
            this.playerOneScoreLabel.AutoSize = true;
            this.playerOneScoreLabel.Location = new System.Drawing.Point(159, 9);
            this.playerOneScoreLabel.Name = "playerOneScoreLabel";
            this.playerOneScoreLabel.Size = new System.Drawing.Size(13, 13);
            this.playerOneScoreLabel.TabIndex = 2;
            this.playerOneScoreLabel.Text = "0";
            this.playerOneScoreLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.aToolTip.SetToolTip(this.playerOneScoreLabel, "The Player\'s scores.");
            // 
            // ScoreDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.cancelScoreButton;
            this.ClientSize = new System.Drawing.Size(184, 266);
            this.Controls.Add(this.playerTwoScoreLabel);
            this.Controls.Add(this.playerOneScoreLabel);
            this.Controls.Add(this.cancelScoreButton);
            this.Controls.Add(this.resetButton);
            this.Controls.Add(this.playerTwoLabel);
            this.Controls.Add(this.playerOneLabel);
            this.Controls.Add(this.gameHistoryLabel);
            this.Controls.Add(this.gameHistoryListBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "ScoreDialog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Scores";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox gameHistoryListBox;
        private System.Windows.Forms.Label gameHistoryLabel;
        private System.Windows.Forms.Label playerOneLabel;
        private System.Windows.Forms.Label playerTwoLabel;
        private System.Windows.Forms.Button resetButton;
        private System.Windows.Forms.Button cancelScoreButton;
        private System.Windows.Forms.Label playerTwoScoreLabel;
        private System.Windows.Forms.Label playerOneScoreLabel;
        private System.Windows.Forms.ToolTip aToolTip;
    }
}