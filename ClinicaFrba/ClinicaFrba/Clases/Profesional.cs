using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClinicaFrba.Clase_Persona;
using System.Data.SqlClient;
using ClinicaFrba.Clases;

namespace ClinicaFrba.Clases
{
    public class Profesional : Persona
    {
        public int Matricula { get; set; }
        public List<Especialidad> Especialidades { get; set; }

        public Profesional(int personaId)
        {
            List<SqlParameter> ListaParametros = new List<SqlParameter>();
            ListaParametros.Add(new SqlParameter("@persona", personaId));
            SqlDataReader lector = Clases.BaseDeDatosSQL.ObtenerDataReader("SELECT * FROM NEXTGDD.ProfesionalYPersona where codigoPersona=@persona", "T", ListaParametros);

            if (lector.HasRows)
            {
                lector.Read();
                if (lector["matricula"] != DBNull.Value)
                {
                    Matricula = (int)(decimal)lector["matricula"];
                }
                else { Matricula = -1; } //LE PONGO EN -1 PORQUE NO TIENE MATRICULA
                Mail = (string)lector["mail"];
                Nombre = (string)lector["nombre"];
                Apellido = (string)lector["apellido"];
                Id = (int)(decimal)lector["codigoPersona"];
                NumeroDocumento = (decimal)lector["documento"];
                Direccion = (string)lector["direccion"];
                FechaNacimiento = (DateTime)lector["fechaNac"];
                Sexo = (string)lector["sexo"];
                Telefono = (int)(decimal)lector["tel"];
                TipoDocumento = (decimal)lector["tipo_doc"];
            }
        }

        public Profesional()
        { Especialidades = new List<Especialidad>(); }

        // fijarse si tendriamos que invocar desde aca las funciones de registrarAgenda, eliminarAgenda y demas
    }
}
