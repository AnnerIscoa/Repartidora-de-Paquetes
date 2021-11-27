using Sistema_repartidore_de_Paquetes.Vistas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Sistema_repartidore_de_Paquetes
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense("NTQwMjUzQDMxMzkyZTMzMmUzMEsraUxTdmlhQWwwRkdhUnQ4TEQzVXpKbTNMbmFmcXBveUF1V2FBbFNKTlE9");
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Inicio());
        }
    }
}
