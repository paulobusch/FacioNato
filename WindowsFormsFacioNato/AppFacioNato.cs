using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

using AppFacioNato.CadBadroom.View;
using AppFacioNato.CadPeople.View;
using AppFacioNato.CadRecurrence.View;
using AppFacioNato.View;

namespace AppFacioNato
{
    static class AppFacioNato
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new FormFacioNato());
            Application.Run(new FormConfRecurrence());
        }
    }
}
