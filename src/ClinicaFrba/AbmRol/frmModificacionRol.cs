using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ClinicaFrba.Clases;

namespace ClinicaFrba.AbmRol
{
    public partial class frmModificacionRol : Form
    {

        public frmModificacionRol()
        {
            InitializeComponent();
        }

        //lista de roles que voy a tener para mostrar
        private List<Funcionalidad> listaDeFuncionalidades = new List<Funcionalidad>();
        private List<Funcionalidad> listaDeTodas = new List<Funcionalidad>();
        public Rol unRol { get; set; }

        private void lstSeleccionFuncionalidad_Load(object sender, EventArgs e)
        {
          //  try
           // {
                if (unRol != null)
                {
                    //ME TRAIGO TODAS PARA MOSTRARLAS DESCHEACKEADAS
                    listaDeTodas = Funcionalidades.ObtenerFuncionalidades();
                    grillaFuncionalidades.DataSource = listaDeTodas;
                    grillaFuncionalidades.ValueMember = "Id";
                    grillaFuncionalidades.DisplayMember = "Nombre";

                    if (unRol.Habilitado )
                    {
                        cbHabilitado.Checked = true;
                    }
                    else { cbHabilitado.Checked = false; }

                    //ME MANDARON UN ROL ESPECIFICO -> MUESTRO SOLO LAS FUNC DE ESTE ROL
                    listaDeFuncionalidades = Funcionalidades.ObtenerFuncionalidades(unRol.Id);

                    CheckearFuncionalidades();
                }
                txtRol.Text = unRol.Nombre;
           // }
           // catch
            //{MessageBox.Show("Se ha producido un error,vuelva a intentarlo", "Error!", MessageBoxButtons.OK);}
        }

        private void cmdAgregar_Click(object sender, EventArgs e)
        {
            //SI EL NOMBRE ES DISTINTO, LO MODIFICO
            if(unRol.Nombre != txtRol.Text)
            {
                Roles.ModificarNombre(txtRol.Text, unRol.Id);
            }
            Roles.CambiarEstado(unRol.Id, cbHabilitado.Checked);

            //LISTA DE FUNCIONALIDADES QUE TIENE ESE ROL
            List<Funcionalidad> listaQueTiene = Funcionalidades.ObtenerFuncionalidades(unRol.Id);

            //LISTA DE FUNCIONALIDADES CHEKEADAS
            List<Funcionalidad> listaDeFunc = new List<Funcionalidad>();
            foreach (Funcionalidad unaFunc in grillaFuncionalidades.CheckedItems)
            {
                listaDeFunc.Add(unaFunc);
            }

            //DOY DE BAJA LAS FUNC QUE YA NO ESTAN
            foreach (Funcionalidad unaFunc in listaQueTiene)
            {
                Funcionalidades.EliminarFuncionalidadPorRol(unRol.Id, unaFunc);
            }

            //DOY DE ALTA LAS NUEVAS
            foreach (Funcionalidad unaFunc in listaDeFunc)
            {
                Funcionalidades.AgregarFuncionalidadEnRol(unRol.Id, unaFunc);
            }

            MessageBox.Show("Se ha modificado el rol con éxito", "Enhorabuena!", MessageBoxButtons.OK);
            this.Hide();
            frmElegirAccionRol elegir = new frmElegirAccionRol();
            elegir.Show();
        }


        public void CheckearFuncionalidades()
        {
            //CHECKEO LAS QUE TIENE
            foreach (Funcionalidad unaFunc in listaDeTodas)
            {
                var probar = listaDeFuncionalidades.SingleOrDefault(fun => fun.Id == unaFunc.Id);
                if (probar != null)
                {
                    grillaFuncionalidades.SetItemChecked(listaDeTodas.IndexOf(unaFunc), true);
                }
            }
        }

        private void frmModificacionRol_FormClosing(object sender, FormClosingEventArgs e)
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

        private void txtRol_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Solo letras", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (char.IsNumber(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Solo letras", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (char.IsSymbol(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Solo letras", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (char.IsPunctuation(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Solo letras", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
