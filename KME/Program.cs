using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace KME
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
            MessageControl.SetControl();
            Application.Run(new Form1());
        }
    }
}
