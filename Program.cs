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
            using(DbManager dbManager = new DbManager())
            {
                dbManager.Database.EnsureCreated();
            }
            Application.Run(new MainForm());
        }

        private static void CheckForFiles()
        {
            
        }
    }
}
