﻿using System;
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
    //    public decimal Codigo_Persona { get; set; }
        public decimal Nro_afiliado { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Tipo_Doc { get; set; }

        public decimal Nro_Doc { get; set; }
        public string Direccion { get; set; }
        //public bool Activo { get; set; }
        public decimal Telefono { get; set; }
        public string Mail { get; set; }
        public string Plan_Medico { get; set; }
        public DateTime Fecha_Nac { get; set; }       
        public string Estado_Civil { get; set; }
        public Byte Cant_Hijos { get; set; }      
 
        private static SqlConnection conexion;
        //private static DataTable tabla = new DataTable();

        public static DataTable obtenerAfiliados() {

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


        public static List<Afiliado> ObtenerAfiliados2(String nombre, String apellido, String dni, String numeroAfiliado, String codigoPlan)
        {
            List<Afiliado> Lista = new List<Afiliado>();

            List<SqlParameter> ListaParametros = new List<SqlParameter>();
            if (nombre != "") ListaParametros.Add(new SqlParameter("@nombre", "%" + nombre + "%")); 
            else ListaParametros.Add(new SqlParameter("@nombre", "%%"));
            if (apellido != "") ListaParametros.Add(new SqlParameter("@apellido", "%" + apellido + "%"));
            else ListaParametros.Add(new SqlParameter("@apellido", "%%"));
            if (dni != "") ListaParametros.Add(new SqlParameter("@dni", "%" + dni + "%")); 
            else ListaParametros.Add(new SqlParameter("@dni", "%%"));
            if (numeroAfiliado != "") ListaParametros.Add(new SqlParameter("@numeroAfiliado", "%" + numeroAfiliado+ "%")); 
            else ListaParametros.Add(new SqlParameter("@numeroAfiliado", "%%"));
            if (codigoPlan != "") ListaParametros.Add(new SqlParameter("@codigoPlan", "%" + codigoPlan + "%")); 
            else ListaParametros.Add(new SqlParameter("@codigoPlan", "%%"));

            SqlDataReader lector = Clases.BaseDeDatosSQL.ObtenerDataReader("SELECT * FROM NEXTGDD.Pacientes_Afil WHERE Nombre LIKE @nombre AND Apellido LIKE @apellido AND  Nro_Doc LIKE @dni AND Nro_Afiliado LIKE @numeroAfiliado AND Plan_Medico LIKE @codigoPlan", "T", ListaParametros);

            if (lector.HasRows)
            {
                while (lector.Read())
                {
                    Afiliado unAfiliado = new Afiliado();
                 
                    unAfiliado.Nro_afiliado = (UInt64)(decimal)lector["Nro_Afiliado"];
                    //unAfiliado.Codigo_Persona = unAfiliado.Id;
                    unAfiliado.Nombre = (string)lector["Nombre"];
                    unAfiliado.Apellido = (string)lector["Apellido"];
                    unAfiliado.Tipo_Doc = (string)lector["Tipo_Doc"];
                    unAfiliado.Nro_Doc = (decimal)lector["Nro_Doc"];
                    unAfiliado.Direccion = (String)lector["Direccion"];
                    unAfiliado.Telefono = (decimal)lector["Telefono"];
                    unAfiliado.Mail = (String)lector["Mail"];
                    unAfiliado.Plan_Medico = (string)lector["Plan_Medico"];
                    unAfiliado.Fecha_Nac = (DateTime)lector["Fecha_Nac"];
                    unAfiliado.Estado_Civil = (string)lector["Estado_Civil"];
                    unAfiliado.Cant_Hijos = (Byte)lector["Cant_Hijos"];
                   
                    Lista.Add(unAfiliado);
                }
                lector.Close();
            }
            return Lista;

        }


        public static List<Afiliado> ObtenerTodos()
        {
            List<Afiliado> Lista = new List<Afiliado>();

            List<SqlParameter> ListaParametros = new List<SqlParameter>();

            SqlDataReader lector = Clases.BaseDeDatosSQL.ObtenerDataReader("SELECT * FROM NEXTGDD.Pacientes_Afil", "T", ListaParametros);

            if (lector.HasRows)
            {
                while (lector.Read())
                {
                    Afiliado unAfiliado = new Afiliado();
                    
                    unAfiliado.Nro_afiliado = (UInt64)(decimal)lector["Nro_Afiliado"];
                    unAfiliado.Nombre = (string)lector["Nombre"];
                    unAfiliado.Apellido = (string)lector["Apellido"];
                    unAfiliado.Tipo_Doc = (string)lector["Tipo_Doc"];
                    unAfiliado.Nro_Doc = (decimal)lector["Nro_Doc"];
                    unAfiliado.Direccion = (String)lector["Direccion"];
                    unAfiliado.Telefono = (decimal)lector["Telefono"];
                    unAfiliado.Mail = (String)lector["Mail"];
                    unAfiliado.Plan_Medico = (string)lector["Plan_Medico"];
                    unAfiliado.Fecha_Nac = (DateTime)lector["Fecha_Nac"];
                    unAfiliado.Estado_Civil = (string)lector["Estado_Civil"];
                    unAfiliado.Cant_Hijos = (Byte)lector["Cant_Hijos"];

                    Lista.Add(unAfiliado);
                }
                lector.Close();
            }
            return Lista; ;
        }


    }
}
