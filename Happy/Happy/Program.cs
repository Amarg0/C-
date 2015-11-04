using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Happy
{
    public static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            UserBase userBase = new UserBase();
            object userso = userBase;
            int problemCounter;
            List<Problem> problems = new List<Problem>();
            int UserCounter;
            List<User> users = new List<User>();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new Form1());
            Application.Run(new Logon(userso));
        }


    }
}
