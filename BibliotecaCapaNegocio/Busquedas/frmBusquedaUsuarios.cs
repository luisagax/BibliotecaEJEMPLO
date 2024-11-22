using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BibliotecaCapaNegocio.Busquedas
{
    public partial class frmBusquedaUsuarios : Form
    {
        public frmBusquedaUsuarios(string sConexion)
        {
            InitializeComponent();
            this.usuariosTableAdapter.Connection.ConnectionString = sConexion;
        }
        void rellenar()
        {
            this.usuariosTableAdapter.Fill(this.dsUsuarios.Usuarios, txtFiltro.Text);
        }
        private void frmBusquedaUsuarios_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dsUsuarios.Usuarios' Puede moverla o quitarla según sea necesario.
            

        }

        private void txtFiltro_TextChanged(object sender, EventArgs e)
        {
            rellenar();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}
