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
        private static SqlConnection conexion;
        //private static DataTable tabla = new DataTable();

        public static DataTable obtenerAfilidos() {
            DataTable tabla = new DataTable();
            conexion = BaseDeDatosSQL.ObtenerConexion();
           // conexion.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM NEXTGDD.Pacientes_Afil", conexion);  //NEXTGDD.mostrar_Pacientes_Afil
            cmd.CommandType = CommandType.Text ;//  .StoredProcedure;
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            adapter.Fill(tabla);
            conexion.Close();
            return tabla;
        }

        public static DataTable obtenerHistorial()
        {
           DataTable tabla = new DataTable();
           conexion = BaseDeDatosSQL.ObtenerConexion(); // conexion.Open();
           SqlCommand cmd = new SqlCommand("SELECT * FROM NEXTGDD.Historial", conexion);  //NEXTGDD.mostrar_Pacientes_Afil
           cmd.CommandType = CommandType.Text;//  .StoredProcedure;
           SqlDataAdapter adapter = new SqlDataAdapter(cmd);
           adapter.Fill(tabla);
           conexion.Close();
            //List<SqlParameter> ListaParametro= new List<SqlParameter> ();
            // string comando=  "SELECT * FROM NEXTGDD.Historial" ;

            //SqlDataReader dr = BaseDeDatosSQL.ObtenerDataReader(comando, "T", ListaParametro);
            //tabla.Load(dr);

            return tabla;

        }


        public static int darDeBajaAfiliado(UInt64 nroAfiliado, DateTime fecha )
        {
            int retorno=0;

            conexion = BaseDeDatosSQL.ObtenerConexion();
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

        public static DataTable obtenerHistorial_Afil(UInt64 nroafil)
        {
            DataTable tabla = new DataTable();

            conexion = BaseDeDatosSQL.ObtenerConexion();

            //SqlConnection conexion = new SqlConnection("Data Source=localhost\\SQLSERVER2012;Initial Catalog=GD2C2016;Persist Security Info=True;User ID=gd;Password=gd2016"); //BaseDeDatosSQL.ObtenerConexion();
            //conexion.Open();


            SqlCommand cmd = new SqlCommand("NEXTGDD.mostrarHistorial", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlParameter parNroAfil = new SqlParameter("@nroafiliado", nroafil);
            parNroAfil.Direction = ParameterDirection.Input;
            parNroAfil.SqlDbType = SqlDbType.Decimal;
            cmd.Parameters.Add(parNroAfil);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            adapter.Fill(tabla);
            conexion.Close();
            return tabla;
        }


        public static DataTable obtenerHistorialGrupo(UInt64 nrogrupo)
        {
            DataTable tabla = new DataTable();

            //SqlConnection conexion = new SqlConnection("Data Source=localhost\\SQLSERVER2012;Initial Catalog=GD2C2016;Persist Security Info=True;User ID=gd;Password=gd2016"); //BaseDeDatosSQL.ObtenerConexion();
            //conexion.Open();

            conexion = BaseDeDatosSQL.ObtenerConexion();

            SqlCommand cmd = new SqlCommand("NEXTGDD.mostrarHistorial_ga", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlParameter parNroAfil = new SqlParameter("@grupoafiliado", nrogrupo);
            parNroAfil.Direction = ParameterDirection.Input;
            parNroAfil.SqlDbType = SqlDbType.Decimal;
            cmd.Parameters.Add(parNroAfil);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            adapter.Fill(tabla);
            conexion.Close();
            return tabla;
        }

        public static DataTable mostrarHistorialAfil_grupo(UInt64 nrogrupo, UInt64 nroafil)
        {
           DataTable tabla = new DataTable();

            conexion = BaseDeDatosSQL.ObtenerConexion();

            SqlCommand cmd = new SqlCommand("NEXTGDD.mostrarHistorialAfil_grupo", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlParameter parNrogrupo = new SqlParameter("@grupoafiliado", nrogrupo);
            parNrogrupo.Direction = ParameterDirection.Input;
            parNrogrupo.SqlDbType = SqlDbType.Decimal;

            SqlParameter parNroAfil = new SqlParameter("@nroafiliado", nroafil);
            parNroAfil.Direction = ParameterDirection.Input;
            parNroAfil.SqlDbType = SqlDbType.Decimal;


            cmd.Parameters.Add(parNrogrupo);
            cmd.Parameters.Add(parNroAfil);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            adapter.Fill(tabla);
            conexion.Close();
            return tabla;
        }



    }
}
