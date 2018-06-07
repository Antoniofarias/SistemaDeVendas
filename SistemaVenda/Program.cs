using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaVenda
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

            //frm_usuario frm = new frm_usuario();
            //frm.ShowDialog();

            frm_login frm = new frm_login();
            frm.ShowDialog();

            if (frm.logado == true)
            {
                Application.Run(new frm_menu());
            }


        }
    }
}
