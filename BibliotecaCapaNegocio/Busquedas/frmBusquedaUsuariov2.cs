using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace BibliotecaCapaNegocio.Busquedas
{
    public partial class frmBusquedaUsuariov2 : Form
    {
        SqlConnection con = new SqlConnection();
        public frmBusquedaUsuariov2(string sConexion)
        {
            InitializeComponent();
            this.con.ConnectionString = sConexion;
        }

        void cargardg()
        {
            string query = $"select id, Username, Nivel from Usuarios where Username LIKE '%{txtFiltro.Text}%'";
            DataTable dt = new DataTable();
            con.Open();
            SqlDataAdapter da = new SqlDataAdapter(query, con);
            da.Fill(dt);
            dgUsuarios.DataSource = dt;
            con.Close();
        }
        private void frmBusquedaUsuariov2_Load(object sender, EventArgs e)
        {
            cargardg();
            dgUsuarios.Rows[0].Selected = true;
        }

        private void txtFiltro_TextChanged(object sender, EventArgs e)
        {
            cargardg();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void dgUsuarios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = dgUsuarios.CurrentRow.Index;
            dgUsuarios.Rows[i].Selected = true;
        }
    }
}
