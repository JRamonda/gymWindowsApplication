using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using PAV1_GYM.InterfacesDeUsuarios;

namespace PAV1_GYM
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            PrincipalMenu PrincipalMenu = new PrincipalMenu();
            PrincipalMenu.Show();
            Application.Run();
        }
    }
}