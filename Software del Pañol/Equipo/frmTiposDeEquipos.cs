using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;
using Dominio;

namespace Software_del_Pañol
{
    public partial class frmTiposDeEquipos : Form
    {
        public frmTiposDeEquipos()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text != "" || txtSubtipo.Text != "")
            {
                eTipoDeEquipo tipo = new eTipoDeEquipo();
                tipo.nombre = txtNombre.Text;
                tipo.subtipo = txtSubtipo.Text;
                dTipoDeEquipo unTipo = new dTipoDeEquipo();
                unTipo.altaTipoDeEquipo(tipo);
            } else
            {
                lblMensaje.Text = "Porfavor rellene los campos";
            }
        }

        private void modoEdicion(bool aux)
        {
            if (aux == true)
            {
                btnAgregar.Hide();
                btnEliminar.Show();
                btnModificar.Show();
            }
            else
            {
                btnAgregar.Show();
                btnEliminar.Hide();
                btnModificar.Hide();

                txtNombre.Clear();
                txtSubtipo.Clear();
            }
        }

        private void frmTiposDeEquipos_Click(object sender, EventArgs e)
        {
            dgvTipos.ClearSelection();
        }

        private void frmTiposDeEquipos_Load(object sender, EventArgs e)
        {
            modoEdicion(false);
        }


    }
}
