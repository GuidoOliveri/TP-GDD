using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ClinicaFrba.Clases
{
    static class Utiles
    {
        public static Boolean ExisteDni(decimal tipo, decimal dni)
        {
            List<SqlParameter> ListaParametros = new List<SqlParameter>();
            ListaParametros.Add(new SqlParameter("@tipo", tipo));
            ListaParametros.Add(new SqlParameter("@dni", dni));

            String query = @"SELECT *
                            FROM NEXTGDD.Persona
                            WHERE tipo_doc = @tipo AND documento = @dni";

            SqlDataReader lector = Clases.BaseDeDatosSQL.ObtenerDataReader(query, "T", ListaParametros);

            if (lector.HasRows)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static string ObtenerTipoDoc(decimal tipoDoc)
        {
            List<SqlParameter> ListaParametros = new List<SqlParameter>();
            ListaParametros.Add(new SqlParameter("@id", tipoDoc));

            SqlDataReader lector = Clases.BaseDeDatosSQL.ObtenerDataReader("SELECT tipo FROM NEXTGDD.Tipo_Documento where id=@id", "T", ListaParametros);
            if (lector.HasRows)
            {
                lector.Read();
            }
            return ((string)lector["tipo"]);
        }
    }
}
