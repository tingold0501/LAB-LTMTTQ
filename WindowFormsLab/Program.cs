using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowFormsLab.Forms;

namespace WindowFormsLab
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FormLogin());
            //Application.Run(new FormTime());
            //Application.Run(new FormMaxMinThreeNumber());
            //Application.Run(new FormMaxMinTwoNumber());
            //Application.Run(new FormSumANumber());
            //Application.Run(new FormConvertNumberToString());

        }
    }
}
