﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.OleDb;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Data.SqlTypes;

namespace ClinicaFrba.Clases
{
    class Funcionalidades
    {
        public static List<Funcionalidad> ObtenerFuncionalidades()
        {
            List<Funcionalidad> Lista = new List<Funcionalidad>();

            List<SqlParameter> ListaParametros = new List<SqlParameter>();
            SqlDataReader lector = Clases.BaseDeDatosSQL.ObtenerDataReader("SELECT * from NEXTGDD.Funcionalidad", "T", ListaParametros);

            if (lector.HasRows)
            {
                while (lector.Read())
                {
                    Funcionalidad unaFuncionalidad = new Funcionalidad();
                    unaFuncionalidad.Id = Int32.Parse(lector["id_funcionalidad"].ToString());
                    unaFuncionalidad.Nombre = lector["nombre"].ToString();
                    Lista.Add(unaFuncionalidad);
                }
            }
            return Lista;
        }

        public static List<Funcionalidad> ObtenerFuncionalidades(string filtro)
        {
            List<Funcionalidad> Lista = new List<Funcionalidad>();

            List<SqlParameter> ListaParametros = new List<SqlParameter>();
            ListaParametros.Add(new SqlParameter("@txt", filtro));
            SqlDataReader lector = Clases.BaseDeDatosSQL.ObtenerDataReader("SELECT id_funcionalidad, nombre FROM NEXTGDD.Funcionalidad WHERE nombre LIKE '%' + @txt + '%' ", "T", ListaParametros);

            if (lector.HasRows)
            {
                while (lector.Read())
                {
                    Funcionalidad unaFuncionalidad = new Funcionalidad();
                    unaFuncionalidad.Id = Int32.Parse(lector["id_funcionalidad"].ToString());
                    unaFuncionalidad.Nombre = lector["nombre"].ToString();
                    Lista.Add(unaFuncionalidad);
                }
            }
            return Lista;
        }

        public static List<Funcionalidad> ObtenerFuncionalidades(int idRol)
        {
            List<Funcionalidad> Lista = new List<Funcionalidad>();

            List<SqlParameter> ListaParametros = new List<SqlParameter>();
            ListaParametros.Add(new SqlParameter("@rol", idRol));
            SqlDataReader lector = Clases.BaseDeDatosSQL.ObtenerDataReader("SELECT F.id_rol, F.nombre FROM NEXTGDD.Rol R JOIN NEXTGDD.Funcionalidad_X_Rol FM ON R.id_rol = FM.id_rol JOIN NEXTGDD.Funcionalidad F ON FM.id_funcionalidad = F.id_funcionalidad WHERE R.id_rol = @rol", "T", ListaParametros);

            if (lector.HasRows)
            {
                while (lector.Read())
                {
                    Funcionalidad unaFuncionalidad = new Funcionalidad();
                    unaFuncionalidad.Id = Int32.Parse(lector["id_funcionalidad"].ToString());
                    unaFuncionalidad.Nombre = lector["nombre"].ToString();
                    Lista.Add(unaFuncionalidad);
                }
            }
            return Lista;
        }

        public static List<String> ObtenerFuncionalidadesPorRol(int idRol)
        {
            List<String> Lista = new List<String>();

            List<SqlParameter> ListaParametros = new List<SqlParameter>();
            ListaParametros.Add(new SqlParameter("@rol", idRol));
            SqlDataReader lector = Clases.BaseDeDatosSQL.ObtenerDataReader("SELECT F.id_rol, F.nombre FROM NEXTGDD.Rol R JOIN NEXTGDD.Funcionalidad_X_Rol FM ON R.id_rol = FM.id_rol JOIN NEXTGDD.Funcionalidad F ON FM.id_funcionalidad = F.id_funcionalidad WHERE R.id_rol = @rol", "T", ListaParametros);

            if (lector.HasRows)
            {
                while (lector.Read())
                {
                    Funcionalidad unaFuncionalidad = new Funcionalidad();
                    unaFuncionalidad.Id = Int32.Parse(lector["id_funcionalidad"].ToString());
                    unaFuncionalidad.Nombre = lector["nombre"].ToString();
                    Lista.Add(unaFuncionalidad.Nombre);
                }
            }
            return Lista;
        }

        public static bool EliminarFuncionalidadPorRol(int idRol, Funcionalidad unaFunc)
        {
            List<SqlParameter> ListaParametros = new List<SqlParameter>();
            ListaParametros.Add(new SqlParameter("@idRol", idRol));
            ListaParametros.Add(new SqlParameter("@idFunc", unaFunc.Id));

            //ver que necesito para eliminar una func.
            return Clases.BaseDeDatosSQL.EscribirEnBase("delete from NEXTGDD.Funcionalidad_X_Rol where (id_rol=@idRol AND id_funcionalidad=@idFunc)", "T", ListaParametros);

        }

        public static bool AgregarFuncionalidadEnRol(int idRol, Funcionalidad unaFunc)
        {
            List<SqlParameter> ListaParametros = new List<SqlParameter>();
            ListaParametros.Add(new SqlParameter("@idRol", idRol));
            ListaParametros.Add(new SqlParameter("@idFunc", unaFunc.Id));

            return Clases.BaseDeDatosSQL.EscribirEnBase("INSERT INTO NEXTGDD.Funcionalidad_X_Rol (id_rol, id_funcionalidad) VALUES (@idRol, @idFunc)", "T", ListaParametros);
        }
    }
}