using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;

namespace ClinicaFrba
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

            Clases.FechaSistema.fechaSistema=(string)System.Configuration.ConfigurationManager.AppSettings["date"]+" 00:00:00";
            Application.Run(new frmVentanaPrincipal());
        }
    }
}
