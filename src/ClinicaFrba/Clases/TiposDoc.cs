using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace ClinicaFrba.Clases
{
    class TiposDoc
    {
        public static List<TipoDoc> ObtenerTiposDoc()
        {
            List<TipoDoc> Lista = new List<TipoDoc>();

            List<SqlParameter> ListaParametros = new List<SqlParameter>();
            SqlDataReader lector = Clases.BaseDeDatosSQL.ObtenerDataReader("SELECT * FROM NEXTGDD.Tipo_Documento", "T", ListaParametros);

            if (lector.HasRows)
            {
                while (lector.Read())
                {
                    TipoDoc unTipo = new TipoDoc();
                    unTipo.Id = (decimal)lector["id"];
                    unTipo.Descripcion = (string)lector["tipo"];
                    Lista.Add(unTipo);
                }
            }
            return Lista;
        }
    }
}
