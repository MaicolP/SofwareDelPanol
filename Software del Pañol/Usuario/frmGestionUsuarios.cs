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
    public partial class frmGestionUsuarios : Form
    {
        public frmGestionUsuarios()
        {
            InitializeComponent();
            dUsuario usuario = new dUsuario();
            dgvUsuarios.DataSource = usuario.listarUsuario();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            bool auxRepetido = false;

            if (txtCi.Text == "" || txtNombre.Text == "" || txtApellido.Text == "" || txtClave.Text == "")
            {
                lblMensaje.Text = "Relle todos los campos porfavor";
            } else if (txtCi.Text == txtNombre.Text || txtCi.Text == txtNombre.Text || txtNombre == txtApellido)
            {
                lblMensaje.Text = "No pueden existir campos con el mismo nombre, excepto CI y Clave";
            } else if (rbDocente.Checked == false && rbAsisTec.Checked == false && rbAlumno.Checked == false)
            {
                lblMensaje.Text = "Porfavor seleccione un tipo de usuario";
            } else
            {
                foreach (DataGridViewRow fila in dgvUsuarios.Rows)
                {
                    if (fila.Cells[1].Value.ToString() == txtCi.Text)
                    {
                        auxRepetido = true;
                    }
                }
                if (auxRepetido == false)
                {
                    dUsuario unU = new dUsuario();
                    
                    if (rbAsisTec.Checked) {
                        eAsisTec asisTec = new eAsisTec();
                        asisTec.ci = txtCi.Text;
                        asisTec.nombre = txtNombre.Text;
                        asisTec.apellido = txtApellido.Text;
                        asisTec.clave = txtClave.Text;

                        eUsuario usuario = asisTec;
                        dUsuario unDu = new dUsuario();
                        unDu.altaUsuario(usuario);

                        dAsisTec unAsis = new dAsisTec();
                        unAsis.altaAsisTec(asisTec);
                    }
                    if (rbDocente.Checked || rbAlumno.Checked)
                    {
                        eCliente cliente = new eCliente();
                        cliente.ci = txtCi.Text;
                        cliente.nombre = txtNombre.Text;
                        cliente.apellido = txtApellido.Text;
                        cliente.clave = txtClave.Text;

                        eUsuario usuario = cliente;
                        dUsuario unDu = new dUsuario();
                        unDu.altaUsuario(usuario);

                        if (rbDocente.Checked) cliente.docente = true;
                        if (rbAlumno.Checked) cliente.docente = false;
                        dCliente unC = new dCliente();
                        unC.altaCliente(cliente);
                    }

                    dgvUsuarios.DataSource = unU.listarUsuario();

                } else
                {
                    lblMensaje.Text = "La CI ingresada ya está en el sistema";
                }

            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            dUsuario unU = new dUsuario();
            DialogResult result = MessageBox.Show("Está seguro que desea eliminar los siguientes " + dgvUsuarios.SelectedRows.Count.ToString() +
                            " usuarios?", "Alerta de seguridad", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
            if (result == DialogResult.OK)
            {
                for (int i = 0; i < dgvUsuarios.SelectedRows.Count; i++)
                {
                    unU.bajaUsuario(dgvUsuarios.SelectedRows[i].Cells[0].Value.ToString());
                }
                dgvUsuarios.DataSource = unU.listarUsuario();
            }
        }

    }
}
