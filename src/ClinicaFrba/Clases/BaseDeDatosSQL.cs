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
using System.Windows.Forms;
using System.Xml;

namespace ClinicaFrba.Clases
{
    public class BaseDeDatosSQL
    {
        private static string obtenerStringConexion()
        {
            return System.Configuration.ConfigurationManager.ConnectionStrings["connectionKeys"].ConnectionString;
        }

        public static SqlConnection ObtenerConexion()
        {
            SqlConnection conexion = new SqlConnection(obtenerStringConexion() ) ;
            
            if (conexion.State == ConnectionState.Closed)
               {
                   conexion.Open();  
              }
        
            return conexion;
              
        }


        /********************** METODOS PARA QUERYS *****************/

        public static SqlDataReader ObtenerDataReader(string commandtext, string commandtype, List<SqlParameter> ListaParametro)
        {
            using (SqlConnection conexion = new SqlConnection(obtenerStringConexion()))
            {
                conexion.Open();
                SqlCommand comando = new SqlCommand();
                comando.Connection = conexion;
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
        }


        public static bool EscribirEnBase(string commandtext, string commandtype, List<SqlParameter> ListaParametro)
        {
            using (SqlConnection conexion = new SqlConnection(obtenerStringConexion()))
            {
                conexion.Open();
                SqlCommand comando = new SqlCommand();
                comando.Connection = conexion;
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
        }
        /*
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
        
        public ArrayList obtenerRow(String comando)
        {
            using (conexion)
            {
                SqlCommand command = new SqlCommand(comando, conexion);

                command.ExecuteNonQuery();
                SqlDataReader reader = command.ExecuteReader();

                ArrayList rowEnLista = new ArrayList();

                if (reader.HasRows)
                {

                    reader.Read();
                    for (int i = 0; i < reader.FieldCount; i++)

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
        */
         
        public static decimal ExecStoredProcedure(string commandtext, List<SqlParameter> ListaParametro)
        {
            using (SqlConnection conexion = new SqlConnection(obtenerStringConexion()))
            {
                try
                {
                    conexion.Open();
                    SqlCommand comando = new SqlCommand();
                    comando.Connection = conexion;
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

        public static List<String> ObtenerLista(string queryString, string campo)
        {
            using (SqlConnection conexion = new SqlConnection(obtenerStringConexion()))
            {
                conexion.Open();
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
        }


        public static string buscarCampo(string queryString)
        {
            using (SqlConnection conexion = new SqlConnection(obtenerStringConexion()))
            {
                conexion.Open();
                SqlCommand command = new SqlCommand(queryString, conexion);
                string result = (string)command.ExecuteScalar().ToString();
                if (result != null)
                {
                    return result;
                }
                return "";
            }
        }

        public static Boolean validarCampo(string queryString)
        {
            using (SqlConnection conexion = new SqlConnection(obtenerStringConexion()))
            {
                conexion.Open();
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
        }
        public static void EjecutarStoredProcedure(string commandtext)
        {
            using (SqlConnection conexion = new SqlConnection(obtenerStringConexion()))
            {
                conexion.Open();
                SqlCommand comando = new SqlCommand(commandtext, conexion);
                comando.CommandText = commandtext;
                comando.ExecuteNonQuery();
            }
        }

        public static DataTable ObtenerTabla(string queryString, List<string> campos)
        {
            using (SqlConnection conexion = new SqlConnection(obtenerStringConexion()))
            {
                conexion.Open();
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
                        for (int i = 0; i < campos.Count(); i++)
                        {
                            fila[i] = String.Format("{0}", reader[campos.ElementAt(i)]);
                        }
                        dt.Rows.Add(fila);
                    }
                }
                return dt;
            }
        }

    }
}
