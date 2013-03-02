using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace TicTacToe
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Create and show a new SplashScreen.
            SplashScreen aSplashScreen = new SplashScreen();
            aSplashScreen.ShowDialog();

            Application.Run(new TicTacToe());
        }
    }
}
