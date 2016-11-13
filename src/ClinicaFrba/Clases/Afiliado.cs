using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data ;
using System.Data.SqlClient ;
using ClinicaFrba.Clases  ;

namespace ClinicaFrba.Clases
{
    class Afiliado
    {

        public static DataTable obtenerAfilidos() {

            DataTable tabla = new DataTable();

            SqlConnection conexion = new SqlConnection("Data Source=localhost\\SQLSERVER2012;Initial Catalog=GD2C2016;Persist Security Info=True;User ID=gd;Password=gd2016"); //BaseDeDatosSQL.ObtenerConexion();
            conexion.Open();
            SqlCommand cmd = new SqlCommand("NEXTGDD.obtenerAfiliados", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            adapter.Fill(tabla);
            conexion.Close();
            return tabla;
        }

        public static DataTable obtenerHistorial()
        {

            DataTable tabla = new DataTable();

            SqlConnection conexion = new SqlConnection("Data Source=localhost\\SQLSERVER2012;Initial Catalog=GD2C2016;Persist Security Info=True;User ID=gd;Password=gd2016"); //BaseDeDatosSQL.ObtenerConexion();
            conexion.Open();
            SqlCommand cmd = new SqlCommand("NEXTGDD.mostrarHistorialPlanes", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            adapter.Fill(tabla);
            conexion.Close();
            return tabla;
        }


        public static int darDeBajaAfiliado(UInt64 nroAfiliado, DateTime fecha )
        {
            int retorno=0;

            SqlConnection conexion = new SqlConnection("Data Source=localhost\\SQLSERVER2012;Initial Catalog=GD2C2016;Persist Security Info=True;User ID=gd;Password=gd2016"); //BaseDeDatosSQL.ObtenerConexion();
            conexion.Open();
            SqlCommand command = new SqlCommand("NEXTGDD.darDeBajaAfiliado", conexion);
            command.CommandType = CommandType.StoredProcedure;

            SqlParameter parNroAfil = new SqlParameter("@nro_afiliado", nroAfiliado);
            parNroAfil.Direction = ParameterDirection.Input;
            parNroAfil.SqlDbType = SqlDbType.Decimal;
            SqlParameter parFecBaja = new SqlParameter("@fecha_baja", SqlDbType.Date);                 
            SqlParameter parRet = new SqlParameter("@ret", retorno);
            parRet.Direction = ParameterDirection.Output;
            parRet.SqlDbType = SqlDbType.SmallInt;
            parFecBaja.Value = fecha;

            command.Parameters.Add(parNroAfil);
            command.Parameters.Add(parFecBaja);
            command.Parameters.Add(parRet);

            command.ExecuteNonQuery();
         
            int resu = Int32.Parse(command.Parameters["@ret"].Value.ToString());
            conexion.Close();

            return resu;
        }

    }
}
