using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace winProyectoFe
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        /// 
        static public frmMenu frm;
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
<<<<<<< HEAD
            frm = new frmMenu();
            Application.Run(frm);
=======
            Application.Run(new frmQuiz());
>>>>>>> 240449b92dba4e9041562bebd35dfae0c21d36c4
        }
    }
}
