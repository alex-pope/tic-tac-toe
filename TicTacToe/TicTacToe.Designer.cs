namespace TicTacToe
{
    partial class TicTacToe
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
			this.topLeftButton = new System.Windows.Forms.Button();
			this.topCenterButton = new System.Windows.Forms.Button();
			this.topRightButton = new System.Windows.Forms.Button();
			this.middleLeftButton = new System.Windows.Forms.Button();
			this.middleCenterButton = new System.Windows.Forms.Button();
			this.middleRightButton = new System.Windows.Forms.Button();
			this.bottomLeftButton = new System.Windows.Forms.Button();
			this.bottomCenterButton = new System.Windows.Forms.Button();
			this.bottomRightButton = new System.Windows.Forms.Button();
			this.aMenuStrip = new System.Windows.Forms.MenuStrip();
			this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.newGameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.namesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.scoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.turnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.undoTurnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.aboutToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
			this.aToolTip = new System.Windows.Forms.ToolTip(this.components);
			this.aStatusStrip = new System.Windows.Forms.StatusStrip();
			this.playerToolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
			this.aMenuStrip.SuspendLayout();
			this.aStatusStrip.SuspendLayout();
			this.SuspendLayout();
			// 
			// topLeftButton
			// 
			this.topLeftButton.Location = new System.Drawing.Point(18, 42);
			this.topLeftButton.Name = "topLeftButton";
			this.topLeftButton.Size = new System.Drawing.Size(80, 80);
			this.topLeftButton.TabIndex = 0;
			this.topLeftButton.TabStop = false;
			this.topLeftButton.UseVisualStyleBackColor = true;
			this.topLeftButton.Click += new System.EventHandler(this.board_Click);
			// 
			// topCenterButton
			// 
			this.topCenterButton.Location = new System.Drawing.Point(102, 42);
			this.topCenterButton.Name = "topCenterButton";
			this.topCenterButton.Size = new System.Drawing.Size(80, 80);
			this.topCenterButton.TabIndex = 1;
			this.topCenterButton.TabStop = false;
			this.topCenterButton.UseVisualStyleBackColor = true;
			this.topCenterButton.Click += new System.EventHandler(this.board_Click);
			// 
			// topRightButton
			// 
			this.topRightButton.Location = new System.Drawing.Point(186, 42);
			this.topRightButton.Name = "topRightButton";
			this.topRightButton.Size = new System.Drawing.Size(80, 80);
			this.topRightButton.TabIndex = 2;
			this.topRightButton.TabStop = false;
			this.topRightButton.UseVisualStyleBackColor = true;
			this.topRightButton.Click += new System.EventHandler(this.board_Click);
			// 
			// middleLeftButton
			// 
			this.middleLeftButton.Location = new System.Drawing.Point(18, 126);
			this.middleLeftButton.Name = "middleLeftButton";
			this.middleLeftButton.Size = new System.Drawing.Size(80, 80);
			this.middleLeftButton.TabIndex = 3;
			this.middleLeftButton.TabStop = false;
			this.middleLeftButton.UseVisualStyleBackColor = true;
			this.middleLeftButton.Click += new System.EventHandler(this.board_Click);
			// 
			// middleCenterButton
			// 
			this.middleCenterButton.Location = new System.Drawing.Point(102, 126);
			this.middleCenterButton.Name = "middleCenterButton";
			this.middleCenterButton.Size = new System.Drawing.Size(80, 80);
			this.middleCenterButton.TabIndex = 4;
			this.middleCenterButton.TabStop = false;
			this.middleCenterButton.UseVisualStyleBackColor = true;
			this.middleCenterButton.Click += new System.EventHandler(this.board_Click);
			// 
			// middleRightButton
			// 
			this.middleRightButton.Location = new System.Drawing.Point(186, 126);
			this.middleRightButton.Name = "middleRightButton";
			this.middleRightButton.Size = new System.Drawing.Size(80, 80);
			this.middleRightButton.TabIndex = 5;
			this.middleRightButton.TabStop = false;
			this.middleRightButton.UseVisualStyleBackColor = true;
			this.middleRightButton.Click += new System.EventHandler(this.board_Click);
			// 
			// bottomLeftButton
			// 
			this.bottomLeftButton.Location = new System.Drawing.Point(18, 210);
			this.bottomLeftButton.Name = "bottomLeftButton";
			this.bottomLeftButton.Size = new System.Drawing.Size(80, 80);
			this.bottomLeftButton.TabIndex = 6;
			this.bottomLeftButton.TabStop = false;
			this.bottomLeftButton.UseVisualStyleBackColor = true;
			this.bottomLeftButton.Click += new System.EventHandler(this.board_Click);
			// 
			// bottomCenterButton
			// 
			this.bottomCenterButton.Location = new System.Drawing.Point(102, 210);
			this.bottomCenterButton.Name = "bottomCenterButton";
			this.bottomCenterButton.Size = new System.Drawing.Size(80, 80);
			this.bottomCenterButton.TabIndex = 7;
			this.bottomCenterButton.TabStop = false;
			this.bottomCenterButton.UseVisualStyleBackColor = true;
			this.bottomCenterButton.Click += new System.EventHandler(this.board_Click);
			// 
			// bottomRightButton
			// 
			this.bottomRightButton.Location = new System.Drawing.Point(186, 210);
			this.bottomRightButton.Name = "bottomRightButton";
			this.bottomRightButton.Size = new System.Drawing.Size(80, 80);
			this.bottomRightButton.TabIndex = 8;
			this.bottomRightButton.TabStop = false;
			this.bottomRightButton.UseVisualStyleBackColor = true;
			this.bottomRightButton.Click += new System.EventHandler(this.board_Click);
			// 
			// aMenuStrip
			// 
			this.aMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem,
            this.turnToolStripMenuItem,
            this.aboutToolStripMenuItem});
			this.aMenuStrip.Location = new System.Drawing.Point(0, 0);
			this.aMenuStrip.Name = "aMenuStrip";
			this.aMenuStrip.Size = new System.Drawing.Size(284, 24);
			this.aMenuStrip.TabIndex = 9;
			this.aMenuStrip.Text = "menuStrip1";
			// 
			// menuToolStripMenuItem
			// 
			this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newGameToolStripMenuItem,
            this.namesToolStripMenuItem,
            this.scoresToolStripMenuItem,
            this.exitToolStripMenuItem});
			this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
			this.menuToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
			this.menuToolStripMenuItem.Text = "&Menu";
			// 
			// newGameToolStripMenuItem
			// 
			this.newGameToolStripMenuItem.Name = "newGameToolStripMenuItem";
			this.newGameToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
			this.newGameToolStripMenuItem.Text = "New &Game";
			this.newGameToolStripMenuItem.Click += new System.EventHandler(this.newGameToolStripMenuItem_Click);
			// 
			// namesToolStripMenuItem
			// 
			this.namesToolStripMenuItem.Name = "namesToolStripMenuItem";
			this.namesToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
			this.namesToolStripMenuItem.Text = "&Names...";
			this.namesToolStripMenuItem.Click += new System.EventHandler(this.namesToolStripMenuItem_Click);
			// 
			// scoresToolStripMenuItem
			// 
			this.scoresToolStripMenuItem.Name = "scoresToolStripMenuItem";
			this.scoresToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
			this.scoresToolStripMenuItem.Text = "&Scores...";
			this.scoresToolStripMenuItem.Click += new System.EventHandler(this.scoresToolStripMenuItem_Click);
			// 
			// exitToolStripMenuItem
			// 
			this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
			this.exitToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
			this.exitToolStripMenuItem.Text = "E&xit";
			this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
			// 
			// turnToolStripMenuItem
			// 
			this.turnToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.undoTurnToolStripMenuItem});
			this.turnToolStripMenuItem.Name = "turnToolStripMenuItem";
			this.turnToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
			this.turnToolStripMenuItem.Text = "&Turn";
			// 
			// undoTurnToolStripMenuItem
			// 
			this.undoTurnToolStripMenuItem.Name = "undoTurnToolStripMenuItem";
			this.undoTurnToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
			this.undoTurnToolStripMenuItem.Text = "&Undo Turn";
			this.undoTurnToolStripMenuItem.Click += new System.EventHandler(this.undoTurnToolStripMenuItem_Click);
			// 
			// aboutToolStripMenuItem
			// 
			this.aboutToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem1});
			this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
			this.aboutToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
			this.aboutToolStripMenuItem.Text = "&Help";
			// 
			// aboutToolStripMenuItem1
			// 
			this.aboutToolStripMenuItem1.Name = "aboutToolStripMenuItem1";
			this.aboutToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
			this.aboutToolStripMenuItem1.Text = "&About";
			this.aboutToolStripMenuItem1.Click += new System.EventHandler(this.aboutToolStripMenuItem1_Click);
			// 
			// aStatusStrip
			// 
			this.aStatusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.playerToolStripStatusLabel});
			this.aStatusStrip.Location = new System.Drawing.Point(0, 310);
			this.aStatusStrip.Name = "aStatusStrip";
			this.aStatusStrip.Size = new System.Drawing.Size(284, 22);
			this.aStatusStrip.TabIndex = 10;
			this.aStatusStrip.Text = "statusStrip1";
			// 
			// playerToolStripStatusLabel
			// 
			this.playerToolStripStatusLabel.Name = "playerToolStripStatusLabel";
			this.playerToolStripStatusLabel.Size = new System.Drawing.Size(0, 17);
			// 
			// TicTacToe
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(284, 332);
			this.Controls.Add(this.aStatusStrip);
			this.Controls.Add(this.bottomRightButton);
			this.Controls.Add(this.bottomCenterButton);
			this.Controls.Add(this.bottomLeftButton);
			this.Controls.Add(this.middleRightButton);
			this.Controls.Add(this.middleCenterButton);
			this.Controls.Add(this.middleLeftButton);
			this.Controls.Add(this.topRightButton);
			this.Controls.Add(this.topCenterButton);
			this.Controls.Add(this.topLeftButton);
			this.Controls.Add(this.aMenuStrip);
			this.MainMenuStrip = this.aMenuStrip;
			this.Name = "TicTacToe";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Tic Tac Toe";
			this.Load += new System.EventHandler(this.namesToolStripMenuItem_Click);
			this.aMenuStrip.ResumeLayout(false);
			this.aMenuStrip.PerformLayout();
			this.aStatusStrip.ResumeLayout(false);
			this.aStatusStrip.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button topLeftButton;
        private System.Windows.Forms.Button topCenterButton;
        private System.Windows.Forms.Button topRightButton;
        private System.Windows.Forms.Button middleLeftButton;
        private System.Windows.Forms.Button middleCenterButton;
        private System.Windows.Forms.Button middleRightButton;
        private System.Windows.Forms.Button bottomLeftButton;
        private System.Windows.Forms.Button bottomCenterButton;
        private System.Windows.Forms.Button bottomRightButton;
        private System.Windows.Forms.MenuStrip aMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newGameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem scoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem turnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem undoTurnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem1;
        private System.Windows.Forms.ToolTip aToolTip;
        private System.Windows.Forms.ToolStripMenuItem namesToolStripMenuItem;
        private System.Windows.Forms.StatusStrip aStatusStrip;
        private System.Windows.Forms.ToolStripStatusLabel playerToolStripStatusLabel;
    }
}

