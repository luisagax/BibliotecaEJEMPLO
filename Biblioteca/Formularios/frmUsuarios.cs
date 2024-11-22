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
    public partial class frmUsuarios : Form
    {
        string sConexion = "";
        public frmUsuarios()
        {
            InitializeComponent();
        }
        public frmUsuarios(string sconexion)
        {
            InitializeComponent();
            sConexion = sconexion;
        }

        private void tsGuardar_Click(object sender, EventArgs e)
        {
            if (txtClave.Text != txtRepClave.Text)
                MessageBox.Show("Las constraseñas no coinciden");
            else
            {
                BibliotecaCapaNegocio.Clases.Usuarios x = new BibliotecaCapaNegocio.Clases.Usuarios(sConexion);
                x.id = int.Parse(txtID.Text);
                x.Username = txtNomUsuario.Text;
                x.Clave = txtClave.Text;
                if (rbSa.Checked == true)
                {
                    x.Nivel = 1;
                }
                else if (rbAdmin.Checked == true)
                {
                    x.Nivel = 2;
                }
                else if (rbUsComun.Checked == true)
                {
                    x.Nivel = 3;
                }
                MessageBox.Show(x.guardar());
            }
        }

        private void tsBuscar_Click(object sender, EventArgs e)
        {
            BibliotecaCapaNegocio.Clases.Usuarios x = new BibliotecaCapaNegocio.Clases.Usuarios(sConexion);
            x.buscar2();
            if(x.encontro == true)
            {
                txtID.Visible = true;
                txtID.Text = x.id.ToString();
                txtNomUsuario.Text = x.Username;
                txtClave.Text = x.Clave;
                if(x.Nivel == 1)
                {
                    rbSa.Checked = true;
                }
                else if (x.Nivel == 2)
                {
                    rbAdmin.Checked = true;
                }
                else
                {
                    rbUsComun.Checked = true;
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Informes.frmFiltroUsuarios x = new Informes.frmFiltroUsuarios(sConexion);
            x.ShowDialog();
        }

        private void frmUsuarios_Load(object sender, EventArgs e)
        {

        }
    }
}
