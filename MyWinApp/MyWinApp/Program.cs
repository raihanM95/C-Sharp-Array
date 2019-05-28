using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyWinApp
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
            //Application.Run(new HomeForm());
            //Application.Run(new ArrayForm());
            //Application.Run(new ListForm());
            //Application.Run(new CustomerForm());
            Application.Run(new BankInfo());
        }
    }
}
