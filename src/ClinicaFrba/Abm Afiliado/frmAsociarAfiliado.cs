using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClinicaFrba.Clases;
using ClinicaFrba.Abm_Afiliado;
using System.Data.SqlClient;

namespace ClinicaFrba.Abm_Afiliado
{
    public partial class frmAsociarAfiliado : Form
    {
        private SqlConnection conexion;
        private string fname = "";
        private string lname = "";
        private string tipodocu = "";
        private Int64 nrodocu ;
        private char sexo ;
        private string direc;
        private Int64 telef;
        private string estciv;
        private string email ;
        DateTime fechanac ; 
        private int cantfami ;
        private Int64 nroGrupoFamiliar ;
        private Int64 retorno;
        
        private int nroafilint;
        private Int64 nroafiliado;

        public frmAsociarAfiliado(string nombre, string apellido, string tipoDoc, Int64 nroDoc, string direccion, Int64 telefono, string estadocivil, string mail,  DateTime fecha , char sexo, int cant_familiar)
        {
            InitializeComponent();
            fname = nombre ;
            lname= apellido ;
            tipodocu= tipoDoc ;
            nrodocu = nroDoc ;
            this.sexo = sexo;
            direc = direccion ;
            telef = telefono ;
            estciv= estadocivil ;
            email= mail ;
            fechanac = fecha ;
            cantfami = cant_familiar ;
        }

        public frmAsociarAfiliado(Int64 nroGrupo ,string nombre, string apellido, string tipoDoc, Int64 nroDoc, string direccion, Int64 telefono, string estadocivil, string mail, DateTime fecha, char sexo, int cant_familiar)
        {
            InitializeComponent();
            fname = nombre;
            lname = apellido;
            tipodocu = tipoDoc;
            nrodocu = nroDoc;
            this.sexo = sexo;
            direc = direccion;
            telef = telefono;
            estciv = estadocivil;
            email = mail;
            fechanac = fecha;
            cantfami = cant_familiar;
            txtNroAfiliadoPrincipal.Text = nroGrupo.ToString();
            txtNroAfiliadoPrincipal.Enabled = false;
        }


        private void btnVolver_Click(object sender, EventArgs e)
        {
            frmAltaAfiliado alta = new frmAltaAfiliado();
            this.Hide();
            alta.Show();
        }



        private void limpiar()
        {
            
            txtNroAfiliadoPrincipal.Clear();
           
            //limpio radio button
            optHijo.Checked = false;
            optConyuge.Checked = false;


        }



        private void btnAsociar_Click(object sender, EventArgs e)
        {

            if (String.IsNullOrEmpty(txtNroAfiliadoPrincipal.Text) || ((optHijo.Checked == false) && (optConyuge.Checked == false)))
            {
                MessageBox.Show("Por favor, ingrese datos en todos los campos obligatorios y de manera correcta", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else
            {
                if (optConyuge.Checked == true)
                {
                    nroafilint = 1;
                }
                else
                {
                    nroafilint = 0;
                }
                retorno = 0;
                nroGrupoFamiliar = Convert.ToInt64(txtNroAfiliadoPrincipal.Text);
                //aca tengo que enganchar el stored procedure de lo que hace el afiliado
                conexion = Clases.BaseDeDatosSQL.ObtenerConexion();

                SqlCommand command = new SqlCommand("NEXTGDD.agregarAfiliadoFamilia", conexion);
                command.CommandType = CommandType.StoredProcedure;

                SqlParameter parNombre = new SqlParameter("@nombre", fname);
                SqlParameter parApellido = new SqlParameter("@apellido", lname);
                SqlParameter parFecNac = new SqlParameter("@fecha_nac", fechanac);
                SqlParameter parSexo = new SqlParameter("@sexo", sexo);
                SqlParameter parTipoDoc = new SqlParameter("@tipo_doc", tipodocu);
                SqlParameter parNroDoc = new SqlParameter("@nrodocumento", nrodocu);
                parNroDoc.Direction = ParameterDirection.Input;
                parNroDoc.SqlDbType = SqlDbType.Decimal;
                SqlParameter parDomicilio = new SqlParameter("@domicilio", direc);
                SqlParameter parTel = new SqlParameter("@telefono", telef);
                SqlParameter parEstadoCivil = new SqlParameter("@estado_civil", estciv);
                SqlParameter parMail = new SqlParameter("@mail", email);
                SqlParameter parCantFam = new SqlParameter("@cant_familiares", cantfami);

                SqlParameter parNroGrupoFamiliar = new SqlParameter("@grupo_afiliado", nroGrupoFamiliar);
                SqlParameter parIntegranteFam = new SqlParameter("@nro_afiliado_integrante", nroafilint);
               
             
                SqlParameter parRet = new SqlParameter("@ret", retorno);

                parRet.Direction = ParameterDirection.Output;
                parRet.SqlDbType = SqlDbType.Decimal;
                parFecNac.Value = fechanac;

                command.Parameters.Add(parNombre);
                command.Parameters.Add(parApellido);
                command.Parameters.Add(parFecNac);
                command.Parameters.Add(parSexo);
                command.Parameters.Add(parTipoDoc);
                command.Parameters.Add(parNroDoc);
                command.Parameters.Add(parDomicilio);
                command.Parameters.Add(parTel);
                command.Parameters.Add(parEstadoCivil);
                command.Parameters.Add(parMail);
                command.Parameters.Add(parCantFam);
                command.Parameters.Add(parNroGrupoFamiliar);
                command.Parameters.Add(parIntegranteFam);
                command.Parameters.Add(parRet);

                command.ExecuteNonQuery();

                nroafiliado = Int64.Parse(command.Parameters["@ret"].Value.ToString());
                conexion.Close();
                if (nroafiliado.Equals(-1))
                {
                    
                    MessageBox.Show( "Lo sentimos, no podemos procesar tu solicitud. Ingrese otro Nro de Afiliado Raiz o Inténtalo de nuevo más tarde.", "Alta Afiliado", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    if (txtNroAfiliadoPrincipal.Enabled == true)
                    {
                        limpiar();
                    }
                }
                else
                {

                    MessageBox.Show("Registrado exitosamente!\n Tu nro de afiliado es:  " + nroafiliado + "\nNombre de usuario:  " + nroafiliado +"@NEXTGDD" + "\nContraseña:  " + nroafiliado, "AltaAfiliado", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    if (MessageBox.Show("Deseas agregar a un familiar mas a este grupo?", "Asociar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        frmAltaAfiliado alta = new frmAltaAfiliado(nroGrupoFamiliar);
                        this.Hide();
                        alta.Show();

                    }
                    else
                    {
                        frmAltaAfiliado alta = new frmAltaAfiliado();
                        this.Hide();
                        alta.Show();

                    }
                    
                    
                }


                //MessageBox.Show("Asociado exitosamente", "Asociar Afiliado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }


        private void frmAsociarAfiliado_Load(object sender, EventArgs e)
        {
        
        }

        private void txtNroAfiliadoPrincipal_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsSymbol(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Solo numeros", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (char.IsPunctuation(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Solo numeros", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Solo numeros", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Solo numeros", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmAsociarAfiliado_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Realmente desea salir del programa?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.ExitThread();
            }
            else
            {
                e.Cancel = true;
            }
        }
        

    }
}
