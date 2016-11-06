using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.OleDb;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Data.SqlTypes;

namespace ClinicaFrba.Clases
{
    class Roles
    {
        public static List<Rol> ObtenerRoles(string filtro)
        {
            List<Rol> listaDeRoles = new List<Rol>();

            List<SqlParameter> ListaParametros = new List<SqlParameter>();
            ListaParametros.Add(new SqlParameter("@txt", "%" + filtro + "%"));

            SqlDataReader lector = Clases.BaseDeDatosSQL.ObtenerDataReader("SELECT id_rol, nombre, habilitado FROM NEXTGDD.Rol WHERE nombre like @txt", "T", ListaParametros);
            

            if (lector.HasRows)
            {
                while (lector.Read())
                {
                    Rol unRol = new Rol();
                    unRol.Id = Int32.Parse(lector["id_rol"].ToString());
                    unRol.Nombre = lector["nombre"].ToString();
                    unRol.Habilitado = lector.GetBoolean(2);
                    listaDeRoles.Add(unRol);
                }
            }
            lector.Close();
            return listaDeRoles;
        }

        public static List<Rol> ObtenerRolesActivo(string filtro)
        {
            List<Rol> listaDeRoles = new List<Rol>();

            List<SqlParameter> ListaParametros = new List<SqlParameter>();
            ListaParametros.Add(new SqlParameter("@txt", "%" + filtro + "%"));

            SqlDataReader lector = Clases.BaseDeDatosSQL.ObtenerDataReader("SELECT id_rol, nombre FROM NEXTGDD.Rol WHERE habilitado=1AND nombre like @txt", "T", ListaParametros);

            if (lector.HasRows)
            {
                while (lector.Read())
                {
                    Rol unRol = new Rol();
                    unRol.Id = Int32.Parse(lector["id_rol"].ToString());
                    unRol.Nombre = lector["nombre"].ToString();
                    unRol.Habilitado = lector.GetBoolean(2);
                    listaDeRoles.Add(unRol);
                }
            }
            lector.Close();
            return listaDeRoles;
        }

        public static bool Eliminar(int id)
        {
            try
            {
                List<SqlParameter> ListaParametros = new List<SqlParameter>();
                ListaParametros.Add(new SqlParameter("@id", id));
                return Clases.BaseDeDatosSQL.EscribirEnBase("update NEXTGDD.Rol set habilitado =0 where id_rol=@id", "T", ListaParametros);
            }
            catch { return false; }
        }

        public static bool ModificarNombre(string nombre, int idRol)
        {
            try
            {
                List<SqlParameter> ListaParametros = new List<SqlParameter>();
                ListaParametros.Add(new SqlParameter("@id", idRol));
                ListaParametros.Add(new SqlParameter("@nombre", nombre));
                return Clases.BaseDeDatosSQL.EscribirEnBase("update NEXTGDD.Rol set nombre =@nombre where id_rol=@id", "T", ListaParametros);
            }
            catch { return false; }
        }

        public static bool CambiarEstado(int idRol, bool estado)
        {
            try
            {
                List<SqlParameter> ListaParametros = new List<SqlParameter>();
                ListaParametros.Add(new SqlParameter("@id", idRol));
                ListaParametros.Add(new SqlParameter("@estado", estado));
                return Clases.BaseDeDatosSQL.EscribirEnBase("update NEXTGDD.Rol set habilitado=@estado where id_rol=@id", "T", ListaParametros);
            }
            catch { return false; }
        }

        public static bool Agregar(string nombre, List<Funcionalidad> listaDeFunc)
        {
            try
            {
                List<SqlParameter> ListaParametros = new List<SqlParameter>();
                ListaParametros.Add(new SqlParameter("@nombreRol", nombre));
                SqlParameter paramRet = new SqlParameter("@ret", System.Data.SqlDbType.Decimal);
                paramRet.Direction = System.Data.ParameterDirection.Output;
                ListaParametros.Add(paramRet);

                //INSERTA EL ROL EN LA BASE DE DATOS, CHEQUEAR EL NOMBRE DEL STORED PROCEDURE 
                int ret = (int)Clases.BaseDeDatosSQL.ExecStoredProcedure("NEXTGDD.agregar_Rol", ListaParametros);

                if (ret != -1)
                {
                    //TENGO QUE DAR DE ALTA LAS FUNCIONALIDADES DE ESE ROL
                    foreach (Funcionalidad unaFunc in listaDeFunc)
                    {
                        //AGREGO EN FUNCIONALIDAD_ROL EL ROL Y LA FUNC.
                        Funcionalidades.AgregarFuncionalidadEnRol(ret, unaFunc);
                    }
                    return true;
                }
                else { return false; }
            }
            catch { return false; }
        }

        public static List<Rol> ObtenerTodos()
        {
            List<Rol> listaDeRoles = new List<Rol>();

            List<SqlParameter> ListaParametros = new List<SqlParameter>();

            SqlDataReader lector = Clases.BaseDeDatosSQL.ObtenerDataReader("SELECT id_rol, nombre, habilitado FROM NEXTGDD.Rol", "T", ListaParametros);

            if (lector.HasRows)
            {
                while (lector.Read())
                {
                    Rol unRol = new Rol();
                    unRol.Id = Int32.Parse(lector["id_rol"].ToString());
                    unRol.Nombre = lector["nombre"].ToString();
                    unRol.Habilitado = lector.GetBoolean(2);
                    listaDeRoles.Add(unRol);
                }
            }
            lector.Close();
            return listaDeRoles; ;
        }

        public static List<Rol> ObtenerTodosActivos()
        {
            List<Rol> listaDeRoles = new List<Rol>();

            List<SqlParameter> ListaParametros = new List<SqlParameter>();

            SqlDataReader lector = Clases.BaseDeDatosSQL.ObtenerDataReader("SELECT id_rol, nombre, habilitado FROM NEXTGDD.Rol WHERE habilitado=1", "T", ListaParametros);

            if (lector.HasRows)
            {
                while (lector.Read())
                {
                    Rol unRol = new Rol();
                    unRol.Id = Int32.Parse(lector["id_rol"].ToString());
                    unRol.Nombre = lector["nombre"].ToString();
                    unRol.Habilitado = lector.GetBoolean(2);
                    listaDeRoles.Add(unRol);
                }
            }
            lector.Close();
            return listaDeRoles; ;
        }
    }
}
