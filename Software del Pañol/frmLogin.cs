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
using System.Runtime.InteropServices;

namespace Software_del_Pañol
{
    public partial class frmLogin : Form
    {

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

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
                dUsuario unU = new dUsuario();
                eUsuario usuario = unU.login(txtUsuario.Text, txtClave.Text);
                if (usuario == null)
                {

                } else
                {

                }
            }

        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pnlMenu_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();

            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}
