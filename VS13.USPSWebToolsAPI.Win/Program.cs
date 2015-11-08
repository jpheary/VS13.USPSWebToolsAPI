using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VS13 {
    //
    static class Program {
        //The main entry point for the application
        [STAThread]
        static void Main() {
            //
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new VS13.USPS.winTests());
        }
    }
}
