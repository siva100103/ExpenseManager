using ExpenseManager.Forms;
using ExpenseManager.ManagerClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExpenseManager
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
            if (ExpenseManagerClass.CheckDbConfiguration())
            {
                Application.Run(new MainForm());
            }
            else
            {
                Application.Run(new DataBaseDetailsForm());
            }
        }


    }
}
