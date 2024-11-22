using BibliotecaCapaNegocio.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BibliotecaCapaCliente.Formularios
{
    public partial class frmRenta : Form
    {
        string sConexion = "";
        static Conexion c = new Conexion();
        SqlConnection con = new SqlConnection(c.conexion());
        int idDetalle = 0;
        public frmRenta(string sConexion)
        {
            InitializeComponent();
            this.sConexion = sConexion;
            consecutivo();
            idDetalle = consecutivodetalle();
        }
        void cargarcb(string value, string display, string tabla, ComboBox Combo)
        {
            string consulta = $"select * from {tabla}";
            DataTable dt = new DataTable();
            con.Open();
            SqlDataAdapter da = new SqlDataAdapter(consulta, con);
            da.Fill(dt);
            con.Close();
            Combo.DataSource = dt;
            Combo.DisplayMember = display;
            Combo.ValueMember = value;
        }
        private void frmRenta_Load(object sender, EventArgs e)
        {
            cargarcb("id", "NombreCompleto", "Clientes", cbCliente);
            cargarcb("id", "Titulo", "Libros", cbLibro);
        }
        void consecutivo()
        {
            int id = 0;
            string consulta = $"SELECT ISNULL(MAX(id) + 1,1) as maxid from Renta";
            con.Open();
            SqlCommand cmd = new SqlCommand(consulta, con);
            SqlDataReader lector = cmd.ExecuteReader();
            if (lector.Read())
            {
                txtID.Text = lector["maxid"].ToString();
            }
            con.Close();
        }
        int consecutivodetalle()
        {
            int id = 0;
            string consulta = $"SELECT ISNULL(max(id),0) as maxid from RentaDetalle";
            con.Open();
            SqlCommand cmd = new SqlCommand(consulta, con);
            SqlDataReader lector = cmd.ExecuteReader();
            if (lector.Read())
            {
                id = int.Parse(lector["maxid"].ToString());
            }
            con.Close();
            return id;
        }
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            int u;
            
            if (idDetalle == 0)
            {
                u = 0;
            }
            else
            {
                u = idDetalle;
            }

            if(dtDetalle.Rows.Count>0)
            {
                string s = dsVentaDet.spRentaDet.Compute("MAX(id)", "").ToString();

                if (idDetalle == 0)
                {
                    u = 0;
                }
                else
                {
                    u = int.Parse(s);
                }
            }
            u++;
            dsVentaDet.spRentaDetRow R;
            R = dsVentaDet.spRentaDet.NewspRentaDetRow();
            R.id = u;
            R.idRenta = int.Parse(txtID.Text);
            R.idLibro = int.Parse(cbLibro.SelectedValue.ToString());
            R.Titulo = cbLibro.Text;
            dsVentaDet.spRentaDet.AddspRentaDetRow(R);
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            BibliotecaCapaNegocio.Clases.Renta x = new Renta(sConexion);
            x.detalles = dsVentaDet.spRentaDet;
            x.id = int.Parse(txtID.Text);
            x.fecha_i = dtpFechaRenta.Value;
            x.fecha_r = dtpFechaRegreso.Value;
            x.Multa = decimal.Parse(txtMulta.Text);
            x.Cantidad = int.Parse(txtCantidad.Text);
            x.idCliente = int.Parse(cbCliente.SelectedValue.ToString());
            MessageBox.Show(x.guardar());
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            BibliotecaCapaNegocio.Clases.Renta x = new BibliotecaCapaNegocio.Clases.Renta(sConexion);
            x.buscar();
            txtID.Text = x.id.ToString();
            cbCliente.SelectedValue = x.idCliente;
            dtpFechaRenta.Value = x.fecha_i;
            dtpFechaRegreso.Value = x.fecha_r;
            txtMulta.Text = x.Multa.ToString();
            txtCantidad.Text = x.Cantidad.ToString();
            this.spRentaDetTableAdapter.Fill(this.dsVentaDet.spRentaDet, x.id);
        }
    }
}
