using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClinicaFrba.Abm_Afiliado
{
    public partial class frmModificarAfiliado : Form {
        
        private string comando = "";

        int idAfiliado=0;

        private String direccion = "";
        private String telefono = "";
        private String mail = "";
        private string plan = "";

        public frmModificarAfiliado(UInt64 nroAfil)
        {
            InitializeComponent();

            plan = (string)cmbPlanMedico.SelectedItem;
            
            //this.idAfiliado = 27281; //hardcodeado, despues vemos 

          ////  int idPersona = 1123960; // Hardcode de prueba
          //  comando = "select * from GD2C2016.NEXTGDD.Persona where id_persona ="+idPersona;
          //  System.Collections.ArrayList persona = this.bdd.obtenerRow(comando);

          //  lblNombreAfiliado.Text = persona[1].ToString() +" "+ persona[2].ToString();
          //  direccion = (string)persona[3];
          //  telefono = persona[4].ToString();
          //  mail = (string)persona[5];

            txtDir.Text = "direcion del afil "+ nroAfil  ;
            txtMail.Text = "mail del afil " + nroAfil;
            txtTel.Text = "telefono del afil "+ nroAfil;
            textBox1.Text = " cant hijos" + nroAfil;
            txtMotivo.Text = "Si cambia de Plan, Ingrese el motivo por favor" ;  

          //  */
            comando = "select distinct descripcion from NEXTGDD.Plan_Medico";
            cargar(Clases.BaseDeDatosSQL.ObtenerLista(comando, "descripcion"), cmbPlanMedico);
            
            btnGuardar.Click += new EventHandler(btnGuardar_Click);
            
            
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
            if (txtDir.Text != direccion && txtDir.Text!=null )
            {
                comando = "EXECUTE NEXTGDD.modificar_Afiliado_Domic @id='" + idAfiliado + "',@nuevo_dom='" + txtDir.Text;
                Clases.BaseDeDatosSQL.EjecutarStoredProcedure(comando);
                MessageBox.Show("Actualizacion exitosa!", "Actualizacion", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            if (txtTel.Text != telefono && txtTel.Text!=null)
            {
                comando = "EXECUTE NEXTGDD.modificar_Afiliado_Telef @id='" + idAfiliado + "',@nuevo_nuevo_telef='" + txtTel.Text;
                Clases.BaseDeDatosSQL.EjecutarStoredProcedure(comando);
                MessageBox.Show("Actualizacion exitosa!", "Actualizacion", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            if (txtMail.Text != mail && txtMail.Text!=null)
            {
                comando = "EXECUTE NEXTGDD.modificar_Afiliado_Mail @id='" + idAfiliado + "',@nuevo_mail='" + txtDir.Text;
                Clases.BaseDeDatosSQL.EjecutarStoredProcedure(comando);
                MessageBox.Show("Actualizacion exitosa!", "Actualizacion", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            frmBuscarAfiliado buscar = new frmBuscarAfiliado();
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
    }
}
