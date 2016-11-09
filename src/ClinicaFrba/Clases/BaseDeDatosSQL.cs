using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Configuration;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Data.OleDb;
using System.Linq;


namespace ClinicaFrba.Clases
{
    public class BaseDeDatosSQL
    {
        //private static SqlConnection _conexion = new SqlConnection();
        private static SqlConnection conexion = new SqlConnection("Data Source=localhost\\SQLSERVER2012;Initial Catalog=GD2C2016;Persist Security Info=True;User ID=gd;Password=gd2016");

        public static SqlConnection ObtenerConexion()
        {
            if (conexion.State == ConnectionState.Closed)
            {
                conexion.ConnectionString = ConfigurationSettings.AppSettings["ConnectionString"];
                conexion.Open();
            }
            return conexion;
        }

        public static SqlDataReader ObtenerDataReader(string commandtext, string commandtype, List<SqlParameter> ListaParametro)
        {

            SqlCommand comando = new SqlCommand();
            comando.Connection = ObtenerConexion();
            comando.CommandText = commandtext;
            foreach (SqlParameter elemento in ListaParametro)
            {
                comando.Parameters.Add(elemento);
            }
            // lean esto que es importante para saber que es cada cosa 
            switch (commandtype)
            {
                case "T":
                    comando.CommandType = CommandType.Text;
                    break;
                case "TD":
                    comando.CommandType = CommandType.TableDirect;
                    break;
                case "SP":
                    comando.CommandType = CommandType.StoredProcedure;
                    break;
            }
            SqlDataReader reader = comando.ExecuteReader();
            /*if(reader.Hasrows)
                {
                While(reader.READ())
                {
                    elemento.PropiedadString=reader.GetString(0);
                    elemento.PropiedadInteger=reader.GetInt32(1);
                    TuLista_DE_Objetos.ADD(elemento)
                }
            }
            reader.Close();*/
            //comando.Connection.Close();
            return reader;
        }


        public static bool EscribirEnBase(string commandtext, string commandtype, List<SqlParameter> ListaParametro)
        {
            SqlCommand comando = new SqlCommand();
            comando.Connection = ObtenerConexion();
            comando.CommandText = commandtext;
            foreach (SqlParameter elemento in ListaParametro)
            {
                comando.Parameters.Add(elemento);
            }
            switch (commandtype)
            {
                case "T":
                    comando.CommandType = CommandType.Text;
                    break;
                case "SP":
                    comando.CommandType = CommandType.StoredProcedure;
                    break;
            }
            try
            {
                comando.ExecuteNonQuery();
                return true;
            }
            catch
            { return false; }
        }

        public static bool ObtenerCampo(int codigo, string tabla, string campo)
        {
            try
            {
                SqlCommand comando = new SqlCommand();
                comando.Connection = ObtenerConexion();
                comando.CommandText = "select " + campo + "from " + tabla + "where codigo= " + codigo;
                object objeto = comando.ExecuteScalar();
                return true;
            }
            catch
            { return false; }
        }

        /* VER DE UNIR AL RESTO ************/

        public void abrirConexion()
        {
            conexion.Open();
        }

        public void cerrarConexion()
        {
            conexion.Close();
        }

        public List<String> ObtenerLista(string queryString, string campo)
        {
            SqlCommand command = new SqlCommand(queryString, conexion);
            command.ExecuteNonQuery();
            List<String> resultados = new List<String>();
            using (SqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    resultados.Add(String.Format("{0}", reader[campo]));
                }
            }
            return resultados;
        }

        public ArrayList obtenerRow(String comando)
        {
            using (conexion)
            {
                SqlCommand command = new SqlCommand(
                  comando,
                  conexion);

                command.ExecuteNonQuery();
                SqlDataReader reader = command.ExecuteReader();

                ArrayList rowEnLista = new ArrayList();
                
                if (reader.HasRows)
                {

                    reader.Read();
                    for (int i = 0; i < reader.FieldCount; i ++ )

                        rowEnLista.Add(reader[i]);
                 
                }
                else
                {
                    Console.WriteLine("No rows found.");
                }
                reader.Close();
                return rowEnLista;
            }

        }

        public string buscarCampo(string queryString)
        {
            SqlCommand command = new SqlCommand(queryString, conexion);
            string result= (string) command.ExecuteScalar().ToString();
            if (result != null)
            {
                return result;
            }
            return "";
        }

        public Boolean validarCampo(string queryString)
        {
            SqlCommand command = new SqlCommand(queryString, conexion);
            command.ExecuteNonQuery();
            int num = (int)command.ExecuteScalar();
            if (num > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public void ExecStoredProcedure2(string commandtext)
        {
            SqlCommand comando = new SqlCommand(commandtext, conexion);
            comando.CommandText = commandtext;
            comando.ExecuteNonQuery();
        }
        
        public static List<String> ObtenerLista(string queryString, string connectionString, string campo)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(queryString, connection);
                command.Connection.Open();
                command.ExecuteNonQuery();
                List<String> resultados = new List<String>();
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        resultados.Add(String.Format("{0}", reader[campo]));
                    }
                }
                return resultados;
            }
        }

        public DataTable ObtenerListado(string queryString, List<string> campos)
        {
            DataTable dt = new DataTable();
            foreach (string campo in campos)
            {
                dt.Columns.Add(campo);
            }
            SqlCommand command = new SqlCommand(queryString, conexion);
            command.ExecuteNonQuery();
            using (SqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    DataRow fila = dt.NewRow();
                    for (int i=0;i<campos.Count();i++)
                    {
                        fila[i] = String.Format("{0}", reader[campos.ElementAt(i)]);
                    }
                    dt.Rows.Add(fila);
                }
            }
            return dt;
        }
        /*
        public static Boolean validarCampo(string queryString, string connectionString)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(queryString, connection);
                command.Connection.Open();
                command.ExecuteNonQuery();
                int num = (int)command.ExecuteScalar();
                if (num>0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }
        public static void ExecStoredProcedure2(string commandtext,string connectionString)
        {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    SqlCommand comando = new SqlCommand(commandtext,connection);
                    comando.Connection.Open();
                    comando.CommandText = commandtext;
                    comando.ExecuteNonQuery();
                }
        }
        */

        /*****************************/
        public static decimal ExecStoredProcedure(string commandtext, List<SqlParameter> ListaParametro)
        {
            try
            {
                SqlCommand comando = new SqlCommand();
                comando.Connection = ObtenerConexion();
                comando.CommandText = commandtext;
                comando.CommandType = CommandType.StoredProcedure;

                foreach (SqlParameter elemento in ListaParametro)
                {
                    comando.Parameters.Add(elemento);
                }

                comando.ExecuteNonQuery();
                return (decimal)comando.Parameters["@ret"].Value;
            }
            catch
            {
                return 0;
            }
        }

    }
}
