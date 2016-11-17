using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClinicaFrba.Clase_Persona;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using ClinicaFrba.Abm_Afiliado;


namespace ClinicaFrba.Clases
{
    public static class Usuario
    {
        public static int Codigo_Persona { get; set; }
        public static string Name { get; set; }
        public static string Password { get; set; }
        public static bool Activo { get; set; }
        public static decimal CantFallidos { get; set; }
        public static string id_rol { get; set; }
        public static int Nro_Afiliado { get; set; }
        public static int Matricula { get; set; }


        //public Usuario(string userName)
        //{
        //    List<SqlParameter> ListaParametros = new List<SqlParameter>();
        //    ListaParametros.Add(new SqlParameter("@userName", userName));

        //    SqlDataReader lector = Clases.BaseDeDatosSQL.ObtenerDataReader("SELECT * FROM NEXTGDD.Usuario where username=@userName", "T", ListaParametros);
        //    if (lector.HasRows)
        //    {
        //        lector.Read();
        //        Name = userName;
        //        if (lector["persona"] != DBNull.Value)
        //        {
        //            Codigo_Persona = (int)(decimal)lector["persona"];
        //        }
        //        else { Codigo_Persona = -1; }
        //        Password = ((string)lector["pw"]).ToUpper();
        //        Activo = (bool)lector["activo"];
        //        CantFallidos = (decimal)lector["intentos_login"];
        //    }
        //}

        //public Usuario() { }

        //public bool ActualizarFallidos()
        //{
        //    List<SqlParameter> Lista = new List<SqlParameter>();
        //    Lista.Add(new SqlParameter("@intentos_login", CantFallidos + 1));
        //    Lista.Add(new SqlParameter("@nombre", Name));
        //    //VER ESTO COMO SP
        //    if (CantFallidos == 2)
        //    {
        //        return Clases.BaseDeDatosSQL.EscribirEnBase("update NEXTGDD..Usuario set habilitado=0, logins_fallidos=@intentos_login where username=@nombre", "T", Lista);
        //    }
        //    else
        //    {
        //        return Clases.BaseDeDatosSQL.EscribirEnBase("update NEXTGDD.Usuario set logins_fallidos=@intentos_login where username=@nombre", "T", Lista);
        //    }
        //}

        //public bool ReiniciarFallidos()
        //{
        //    List<SqlParameter> Lista = new List<SqlParameter>();
        //    Lista.Add(new SqlParameter("@nombre", Name));
        //    return Clases.BaseDeDatosSQL.EscribirEnBase("update NEXTGDD.Usuario set logins_fallidos=0 where username=@nombre", "T", Lista);
        //}

        //public void setearUser(string user) {
        //    Name = user;
        //}

        //public string dameUser()
        //{
        //    return Name;
        //}

        //public void setearRol(short id)
        //{


        //}
   }
}
