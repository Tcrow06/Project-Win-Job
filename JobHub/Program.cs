using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JobHub
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
            Application.Run(new Fmain());
            /*            Fmain fm = new Fmain();
                        Account acc = new Account();
                        acc.Id = 2;
                        fm.Account = acc;
                        Application.Run(new FFollowedCV(fm));*/
            //Application.Run(new FCVDetail());
        }
    }
}
