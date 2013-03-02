namespace TicTacToe
{
    partial class SplashScreen
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
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
			this.aTimer = new System.Windows.Forms.Timer(this.components);
			this.productLabel = new System.Windows.Forms.Label();
			this.versionLabel = new System.Windows.Forms.Label();
			this.companyLabel = new System.Windows.Forms.Label();
			this.copyrightLabel = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// aTimer
			// 
			this.aTimer.Enabled = true;
			this.aTimer.Interval = 5000;
			this.aTimer.Tick += new System.EventHandler(this.aTimer_Tick);
			// 
			// productLabel
			// 
			this.productLabel.BackColor = System.Drawing.Color.Transparent;
			this.productLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
			this.productLabel.ForeColor = System.Drawing.Color.Black;
			this.productLabel.Location = new System.Drawing.Point(12, 9);
			this.productLabel.Name = "productLabel";
			this.productLabel.Size = new System.Drawing.Size(120, 17);
			this.productLabel.TabIndex = 0;
			this.productLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// versionLabel
			// 
			this.versionLabel.BackColor = System.Drawing.Color.Transparent;
			this.versionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
			this.versionLabel.ForeColor = System.Drawing.Color.Black;
			this.versionLabel.Location = new System.Drawing.Point(12, 32);
			this.versionLabel.Name = "versionLabel";
			this.versionLabel.Size = new System.Drawing.Size(120, 17);
			this.versionLabel.TabIndex = 1;
			this.versionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// companyLabel
			// 
			this.companyLabel.BackColor = System.Drawing.Color.Transparent;
			this.companyLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
			this.companyLabel.ForeColor = System.Drawing.Color.Black;
			this.companyLabel.Location = new System.Drawing.Point(138, 9);
			this.companyLabel.Name = "companyLabel";
			this.companyLabel.Size = new System.Drawing.Size(170, 17);
			this.companyLabel.TabIndex = 2;
			this.companyLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// copyrightLabel
			// 
			this.copyrightLabel.BackColor = System.Drawing.Color.Transparent;
			this.copyrightLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
			this.copyrightLabel.ForeColor = System.Drawing.Color.Black;
			this.copyrightLabel.Location = new System.Drawing.Point(138, 32);
			this.copyrightLabel.Name = "copyrightLabel";
			this.copyrightLabel.Size = new System.Drawing.Size(170, 17);
			this.copyrightLabel.TabIndex = 3;
			this.copyrightLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// SplashScreen
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = global::TicTacToe.Properties.Resources.tictactoe;
			this.ClientSize = new System.Drawing.Size(320, 240);
			this.ControlBox = false;
			this.Controls.Add(this.copyrightLabel);
			this.Controls.Add(this.companyLabel);
			this.Controls.Add(this.versionLabel);
			this.Controls.Add(this.productLabel);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "SplashScreen";
			this.Padding = new System.Windows.Forms.Padding(9);
			this.ShowIcon = false;
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "SplashScreen";
			this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer aTimer;
        private System.Windows.Forms.Label productLabel;
        private System.Windows.Forms.Label versionLabel;
        private System.Windows.Forms.Label companyLabel;
        private System.Windows.Forms.Label copyrightLabel;

    }
}
