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
        private string planAnt = "";
        private string planNuev = "";
        private string operacion = "Modificar";
        private int resultado;
        private UInt64 nroAfiliado;

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
            nroAfiliado = nroAfil;
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

            if (String.IsNullOrEmpty(txtDir.Text) || String.IsNullOrEmpty(txtMail.Text) || String.IsNullOrEmpty(txtTel.Text) || Int32.Parse(txtTel.Text) < 0 || Afiliado.email_bien_escrito(txtMail.Text) == false || String.IsNullOrEmpty(textCantH.Text) || Int32.Parse(textCantH.Text) < 0 || (cmdEstadoCivil.Items.Count <= 0) || (string)cmbPlanMedico.SelectedItem == "(ninguno)" || cmbPlanMedico.SelectedIndex == -1)
            {
                MessageBox.Show("Por favor, ingrese datos en todos los campos obligatorios y de manera correcta", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (planAnt != planNuev && String.IsNullOrEmpty(txtMotivo.Text))
            {

                MessageBox.Show("Por favor, ingrese el motivo del cambio de plan", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else if (planAnt != planNuev)
            {
                DateTime fechaMod = System.DateTime.Now.Date;

                resultado = Afiliado.RegistrarModificacionCnPlan(nroAfiliado, txtDir.Text, UInt64.Parse(txtTel.Text), txtMail.Text, (String)cmdEstadoCivil.SelectedItem, int.Parse(textCantH.Text), (String)cmbPlanMedico.SelectedItem, txtMotivo.Text, fechaMod);

                if (resultado.Equals(0))
                {
                    MessageBox.Show("Modificacion Exitosa! Plan Actual :" + planNuev, "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (resultado.Equals(-1))
                {
                    MessageBox.Show("No pudimos procesar tu solicitud de modificacion, intente mas tarde", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("No Existe el Afiliado a Modificar ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                frmBuscarAfiliado buscar = new frmBuscarAfiliado(operacion);
                this.Hide();
                buscar.Show();

            }

            else
            {
                resultado = Afiliado.RegistrarModificacionSnPlan(nroAfiliado, txtDir.Text, UInt64.Parse(txtTel.Text), txtMail.Text, (String)cmdEstadoCivil.SelectedItem, int.Parse(textCantH.Text));

                if (resultado.Equals(0))
                {
                    MessageBox.Show("Modificacion Exitosa", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (resultado.Equals(-1))
                {
                    MessageBox.Show("No pudimos procesar tu solicitud de modificacion, intente mas tarde", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (resultado.Equals(-2))
                {
                    MessageBox.Show("No Existe el Afiliado a Modificar " + nroAfiliado, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("No se que paso :(", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                frmBuscarAfiliado buscar = new frmBuscarAfiliado(operacion);
                this.Hide();
                buscar.Show();
            }
        }

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
