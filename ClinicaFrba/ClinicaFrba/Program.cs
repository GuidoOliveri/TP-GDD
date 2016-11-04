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
            Clases.BaseDeDatosSQL bdd = new Clases.BaseDeDatosSQL();
            bdd.abrirConexion();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);


<<<<<<< HEAD
            Application.Run(new Login.frmLogin());
=======
            Application.Run(new Registro_Llegada.frmRegistroLlegadaAfiliado(bdd));
>>>>>>> 28c0e526f8b5e630da42aeee1c76c116aa70109c
        }
    }
}
