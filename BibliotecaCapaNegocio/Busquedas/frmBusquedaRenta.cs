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
    public partial class frmBusquedaRenta : Form
    {
        string sConexion;
        public frmBusquedaRenta(string sConexion)
        {
            InitializeComponent();
            this.sConexion = sConexion;
            this.vRentaTableAdapter.Connection.ConnectionString = sConexion;
            this.vRentaDetalleTableAdapter.Connection.ConnectionString = sConexion;
        }

        private void frmBusquedaRenta_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dsvRentaDetalle.vRentaDetalle' Puede moverla o quitarla según sea necesario.
           // this.vRentaDetalleTableAdapter.Fill(this.dsvRentaDetalle.vRentaDetalle);
            // TODO: esta línea de código carga datos en la tabla 'dsvRenta.vRenta' Puede moverla o quitarla según sea necesario.
            this.vRentaTableAdapter.Fill(this.dsvRenta.vRenta);

        }
        void cargardetalles(int id)
        {
            this.vRentaDetalleTableAdapter.Fill(this.dsvRentaDetalle.vRentaDetalle, id);
        }

        private void dgRenta_SelectionChanged(object sender, EventArgs e)
        {
            cargardetalles(dsvRenta.vRenta[vRentaBindingSource.Position].id);
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
