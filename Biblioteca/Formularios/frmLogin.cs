using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BibliotecaCapaNegocio;

namespace BibliotecaCapaCliente.Formularios
{
    public partial class frmLogin : Form
    {
        static BibliotecaCapaNegocio.Clases.Conexion c = new BibliotecaCapaNegocio.Clases.Conexion();
        string sConexion = c.conexion();
        public frmLogin()
        {
            InitializeComponent();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }

        private void btnIniciarSesion_Click(object sender, EventArgs e)
        {
            BibliotecaCapaNegocio.Clases.Login x = new BibliotecaCapaNegocio.Clases.Login(txtUsuario.Text, txtPassword.Text);
            bool ingresar = x.Ingresar();
            if (ingresar == true)
            {
                frmMenu y = new frmMenu(sConexion);
                y.Show();
                this.Hide();
            }
            else
                MessageBox.Show("Proceso fallido");
        }
    }
}
