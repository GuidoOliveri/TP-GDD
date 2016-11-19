using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClinicaFrba.Clases ;

namespace ClinicaFrba.Abm_Afiliado
{
    public partial class frmModificarAfiliado : Form {
        
        private string comando = "";

        //int idAfiliado=0;

        //private String direccion = "";
        //private String telefono = "";
        //private String mail = "";
        private string planAnt = "";
        private string planNuev = "";
        private string operacion = "Modificar";

        public frmModificarAfiliado(UInt64 nroAfil,string dir, string mail,string estcivil,string cantfamil,string telefono,string planmedico )
        {
            InitializeComponent();

            planAnt = (string)cmbPlanMedico.SelectedItem;
          
          //  */
            comando = "select distinct descripcion from NEXTGDD.Plan_Medico";
            cargar(Clases.BaseDeDatosSQL.ObtenerLista(comando, "descripcion"), cmbPlanMedico);

            comando = "select nombre from NEXTGDD.Estado_Civil";
            cargar(Clases.BaseDeDatosSQL.ObtenerLista(comando, "nombre"), cmdEstadoCivil);
            
            cmdEstadoCivil.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbPlanMedico.DropDownStyle = ComboBoxStyle.DropDownList;

           // btnGuardar.Click += new EventHandler(btnGuardar_Click);

            txtDir.Text = dir;
            txtMail.Text = mail;
            txtTel.Text = telefono;
            cmdEstadoCivil.SelectedItem = estcivil;
            textCantH.Text = cantfamil;
            txtMotivo.Text = "Si cambia de Plan, Ingrese el motivo por favor";
            cmbPlanMedico.SelectedItem = planmedico;
            planAnt = planmedico;
        }

        private void cargar(List<string> lista, ComboBox cmb)
        {
            foreach (string elemento in lista)
            {
                cmb.Items.Add(elemento);
            }
        }

        private void frmModificarAfiliado_Load(object sender, EventArgs e)
        {
            
        }

        private void pnlModDatosPersonales_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {

            planNuev = (string)cmbPlanMedico.SelectedItem;

            if (String.IsNullOrEmpty(txtDir.Text) || String.IsNullOrEmpty(txtTel.Text) || String.IsNullOrEmpty(txtTel.Text) || Int32.Parse(txtTel.Text) < 0 || Afiliado.email_bien_escrito(txtMail.Text) == false || String.IsNullOrEmpty(textCantH.Text) || Int32.Parse(textCantH.Text) < 0 || (cmdEstadoCivil.Items.Count <= 0) || (string)cmbPlanMedico.SelectedItem == "(ninguno)" || cmbPlanMedico.SelectedIndex == -1)
            {
                MessageBox.Show("Por favor, ingrese datos en todos los campos obligatorios y de manera correcta", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (planAnt != planNuev && String.IsNullOrEmpty(txtMotivo.Text))
                {

                    MessageBox.Show("Por favor, ingrese el motivo del cambio de plan", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
            else if (planAnt != planNuev)
            {
                MessageBox.Show("Ingresaste correctamente los datos,  en breve realizaremos los cambios y la modificacion de: " + planAnt + "  al " + planNuev, "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else {
                MessageBox.Show("Ingresaste correctamente los datos,  en breve realizaremos los cambios. No has modificado el plan medico, Plan actual: " + planNuev, "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

            
            }




            //{

            //    MessageBox.Show("Ingresaste correctamente los datos, en breve realizaremos las modificaciones ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //}

           


        }
        //     nroAfiliado = 0;
            
        //     //Se guarda de la forma NOMBRE Apellido, sin importar como ingrese el usuario
        //     nombre = txtNombre.Text.ToUpper();
        //     string primeraLetra = txtApellido.Text.Substring(0, 1).ToUpper();
        //     string resto= txtApellido.Text.Substring(1,txtApellido.Text.Length-1).ToLower();
        //     apellido = primeraLetra + resto;
          
        //     tipoDoc = (string)cmbTipoDoc.SelectedItem;
        //     nroDoc = Convert.ToInt64(txtNroDoc.Text);

        //     primeraLetra = txtCalle.Text.Substring(0, 1).ToUpper();
        //     resto = txtCalle.Text.Substring(1, txtCalle.Text.Length - 1).ToLower();
        //     calle = primeraLetra+resto;
        //     altura = Convert.ToInt32(txtAltura.Text);
        //     pisoSinConvertir = txtPiso.Text;
        //     deptoSinConvertir = txtDepto.Text;




        //    if (txtDir.Text != direccion && txtDir.Text!=null )
        //    {
        //        comando = "EXECUTE NEXTGDD.modificar_Afiliado_Domic @id='" + idAfiliado + "',@nuevo_dom='" + txtDir.Text;
        //        Clases.BaseDeDatosSQL.EjecutarStoredProcedure(comando);
        //        MessageBox.Show("Actualizacion exitosa!", "Actualizacion", MessageBoxButtons.OK, MessageBoxIcon.Information);

        //    }
        //    if (txtTel.Text != telefono && txtTel.Text!=null)
        //    {
        //        comando = "EXECUTE NEXTGDD.modificar_Afiliado_Telef @id='" + idAfiliado + "',@nuevo_nuevo_telef='" + txtTel.Text;
        //        Clases.BaseDeDatosSQL.EjecutarStoredProcedure(comando);
        //        MessageBox.Show("Actualizacion exitosa!", "Actualizacion", MessageBoxButtons.OK, MessageBoxIcon.Information);

        //    }
        //    if (txtMail.Text != mail && txtMail.Text!=null)
        //    {
        //        comando = "EXECUTE NEXTGDD.modificar_Afiliado_Mail @id='" + idAfiliado + "',@nuevo_mail='" + txtDir.Text;
        //        Clases.BaseDeDatosSQL.EjecutarStoredProcedure(comando);
        //        MessageBox.Show("Actualizacion exitosa!", "Actualizacion", MessageBoxButtons.OK, MessageBoxIcon.Information);

        //    }

        //}

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            frmBuscarAfiliado buscar = new frmBuscarAfiliado(operacion);
            this.Hide();
            buscar.Show();
        }

        private void txtDir_TextChanged(object sender, EventArgs e)
        {
        }

        private void frmModificarAfiliado_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Realmente desea salir del programa?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void txtTel_KeyPress(object sender, KeyPressEventArgs e)
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

        private void textCantH_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsSymbol(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Solo cantidad en numeros", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (char.IsPunctuation(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Solo cantidad en numeros", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Solo cantidad en numeros", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Solo cantidad en numeros", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtDir_KeyPress(object sender, KeyPressEventArgs e)
        {
           

        }

        private void txtMail_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }
    }
}
