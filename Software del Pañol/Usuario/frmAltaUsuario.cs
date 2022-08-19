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
    public partial class frmAltaUsuario : Form
    {
        public frmAltaUsuario()
        {
            InitializeComponent();
            dUsuario usuario = new dUsuario();
            dgvUsuarios.DataSource = usuario.listarUsuario();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            eUsuario usuario = new eUsuario();
            usuario.ci = txtCi.Text;
            usuario.nombre = txtNombre.Text;
            usuario.apellido = txtApellido.Text;
            usuario.clave = txtClave.Text;

            dUsuario unU = new dUsuario();
            unU.altaUsuario(usuario);
            dgvUsuarios.DataSource = unU.listarUsuario();
        }
    }
}
