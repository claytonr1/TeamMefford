using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RuffCoJetReservation
{
    static class Program
    {
        public static Form1 myForm1;
        public static Form2 myForm2;
        public static Form3 myForm3;
        public static Person theUser;

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            
            Application.Run(new Form1());
            
        }
    }
}
