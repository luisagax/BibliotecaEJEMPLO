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
    public partial class frmMenu : Form
    {
        string sConexion = "";
        public frmMenu()
        {
            InitializeComponent();
        }
        public frmMenu(string sconexion)
        {
            InitializeComponent();
            this.sConexion = sconexion;
        }
        private void msUsuarios_Click(object sender, EventArgs e)
        {
            frmUsuarios x = new frmUsuarios(sConexion);
            x.ShowDialog();
        }

        private void rentaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmRenta x = new frmRenta(sConexion);
            x.ShowDialog();
        }
    }
}
