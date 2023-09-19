using Login.Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //Screen primaryScreen = Screen.PrimaryScreen;
            //int screenWidth = primaryScreen.Bounds.Width;
            //int screenHeight = primaryScreen.Bounds.Height;

            //MessageBox.Show($"Screen Width: {screenWidth} pixels" + $"Screen Height: {screenHeight} pixels");

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new DashboardForm());
        }
    }
}
