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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void lblFecha_Paint(object sender, PaintEventArgs e)
        {
            lblFecha.Text = DateTime.Now.ToString("dd/MM/yyyy");
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtClave.Text == "" || txtUsuario.Text == "")
            {

            } else
            {
                dPersona unDp = new dPersona();
                ePersona persona = unDp.login(txtUsuario.Text, txtClave.Text);
                if (persona == null)
                {

                } else
                {

                }
            }

        }
    }
}
