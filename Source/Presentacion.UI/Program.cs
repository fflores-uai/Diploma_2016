using Presentacion.UI.Areas;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Presentacion.UI
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        private static void Main()
        {
            InitApplication();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Login());
        }

        private static void InitApplication()
        {
            Servicios.Idioma.Global.Recursos = new Dictionary<string, string>();
        }
    }
}