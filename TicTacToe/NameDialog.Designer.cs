namespace TicTacToe
{
    partial class NameDialog
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
			this.playerOneLabel = new System.Windows.Forms.Label();
			this.playerTwoLabel = new System.Windows.Forms.Label();
			this.playerOneTextBox = new System.Windows.Forms.TextBox();
			this.playerTwoTextBox = new System.Windows.Forms.TextBox();
			this.okayButton = new System.Windows.Forms.Button();
			this.cancelNameButton = new System.Windows.Forms.Button();
			this.aToolTip = new System.Windows.Forms.ToolTip(this.components);
			this.SuspendLayout();
			// 
			// playerOneLabel
			// 
			this.playerOneLabel.AutoSize = true;
			this.playerOneLabel.Location = new System.Drawing.Point(12, 9);
			this.playerOneLabel.Name = "playerOneLabel";
			this.playerOneLabel.Size = new System.Drawing.Size(75, 13);
			this.playerOneLabel.TabIndex = 1;
			this.playerOneLabel.Text = "Player One - X";
			this.aToolTip.SetToolTip(this.playerOneLabel, "Please enter Player One\'s name.");
			// 
			// playerTwoLabel
			// 
			this.playerTwoLabel.AutoSize = true;
			this.playerTwoLabel.Location = new System.Drawing.Point(12, 48);
			this.playerTwoLabel.Name = "playerTwoLabel";
			this.playerTwoLabel.Size = new System.Drawing.Size(77, 13);
			this.playerTwoLabel.TabIndex = 3;
			this.playerTwoLabel.Text = "Player Two - O";
			this.aToolTip.SetToolTip(this.playerTwoLabel, "Please enter Player Two\'s name.");
			// 
			// playerOneTextBox
			// 
			this.playerOneTextBox.Location = new System.Drawing.Point(12, 25);
			this.playerOneTextBox.Name = "playerOneTextBox";
			this.playerOneTextBox.Size = new System.Drawing.Size(170, 20);
			this.playerOneTextBox.TabIndex = 2;
			this.aToolTip.SetToolTip(this.playerOneTextBox, "Please enter Player One\'s name.");
			// 
			// playerTwoTextBox
			// 
			this.playerTwoTextBox.Location = new System.Drawing.Point(12, 64);
			this.playerTwoTextBox.Name = "playerTwoTextBox";
			this.playerTwoTextBox.Size = new System.Drawing.Size(170, 20);
			this.playerTwoTextBox.TabIndex = 4;
			this.aToolTip.SetToolTip(this.playerTwoTextBox, "Please enter Player Two\'s name.");
			// 
			// okayButton
			// 
			this.okayButton.Location = new System.Drawing.Point(12, 108);
			this.okayButton.Name = "okayButton";
			this.okayButton.Size = new System.Drawing.Size(170, 23);
			this.okayButton.TabIndex = 5;
			this.okayButton.Text = "Accept Names and Return";
			this.aToolTip.SetToolTip(this.okayButton, "Accept names.");
			this.okayButton.UseVisualStyleBackColor = true;
			this.okayButton.Click += new System.EventHandler(this.okayButton_Click);
			// 
			// cancelNameButton
			// 
			this.cancelNameButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.cancelNameButton.Location = new System.Drawing.Point(12, 137);
			this.cancelNameButton.Name = "cancelNameButton";
			this.cancelNameButton.Size = new System.Drawing.Size(170, 23);
			this.cancelNameButton.TabIndex = 0;
			this.cancelNameButton.Text = "Cancel";
			this.aToolTip.SetToolTip(this.cancelNameButton, "Discards new names.");
			this.cancelNameButton.UseVisualStyleBackColor = true;
			this.cancelNameButton.Click += new System.EventHandler(this.cancelButton_Click);
			// 
			// NameDialog
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.CancelButton = this.cancelNameButton;
			this.ClientSize = new System.Drawing.Size(194, 172);
			this.Controls.Add(this.cancelNameButton);
			this.Controls.Add(this.okayButton);
			this.Controls.Add(this.playerTwoTextBox);
			this.Controls.Add(this.playerOneTextBox);
			this.Controls.Add(this.playerTwoLabel);
			this.Controls.Add(this.playerOneLabel);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.Name = "NameDialog";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Player Names";
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label playerOneLabel;
        private System.Windows.Forms.ToolTip aToolTip;
        private System.Windows.Forms.Label playerTwoLabel;
        private System.Windows.Forms.TextBox playerOneTextBox;
        private System.Windows.Forms.TextBox playerTwoTextBox;
        private System.Windows.Forms.Button okayButton;
        private System.Windows.Forms.Button cancelNameButton;
    }
}