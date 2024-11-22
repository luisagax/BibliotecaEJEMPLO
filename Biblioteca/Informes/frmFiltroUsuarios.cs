using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BibliotecaCapaCliente.Informes
{
    public partial class frmFiltroUsuarios : Form
    {
        string sConexion = null;
        public frmFiltroUsuarios(string sConexion)
        {
            InitializeComponent();
            this.sConexion = sConexion;
        }

        private void frmFiltroUsuarios_Load(object sender, EventArgs e)
        {
            this.vwUsuarios.RefreshReport();
        }

        void cargarreporte()
        {
            int nivel = 0;
            if (rbSa.Checked == true)
            {
                nivel = 1;
            }
            else if (rbAdmin.Checked == true)
            {
                nivel = 2;
            }
            else if (rbUsComun.Checked == true)
            {
                nivel = 3;
            }
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter();
            if (rbTodos.Checked == true)
            {
                da = new SqlDataAdapter("select * from vUsuarios", sConexion);
                da.SelectCommand.CommandType = CommandType.Text;
                da.SelectCommand.Parameters.Clear();
            }
            else
            {
                da = new SqlDataAdapter("select * from vUsuarios where nivel = @nivel", sConexion);
                da.SelectCommand.CommandType = CommandType.Text;
                da.SelectCommand.Parameters.Clear();
                da.SelectCommand.Parameters.AddWithValue("@nivel", nivel);
            }
            da.Fill(dt);

            this.vwUsuarios.LocalReport.DataSources.Clear();
            this.vwUsuarios.LocalReport.ReportEmbeddedResource = "BibliotecaCapaCliente.Informes.rptUsuarios.rdlc";
            
             ReportDataSource r = new ReportDataSource("dsRUsuarios", dt);
            this.vwUsuarios.LocalReport.DataSources.Add(r);
            this.vwUsuarios.RefreshReport();

            //PARA PDF
            ReportViewer viewer = new ReportViewer();
            viewer.LocalReport.DataSources.Clear();
            viewer.LocalReport.ReportEmbeddedResource = "BibliotecaCapaCliente.Informes.rptUsuarios.rdlc";
            ReportDataSource r2 = new ReportDataSource("dsRUsuarios", dt);
            viewer.LocalReport.DataSources.Add(r2);
            viewer.RefreshReport();

            gpdf(viewer, AppDomain.CurrentDomain.BaseDirectory + "\\Reportes\\", "prueba.pdf");
        }
        void gpdf(ReportViewer viewer, string ruta, string nombre)
        {
            byte[] bytes = viewer.LocalReport.Render(format: "PDF", deviceInfo: "");

            using (FileStream stream = new FileStream(Path.Combine(ruta, nombre), FileMode.Create, FileAccess.Write))
            {
                stream.Write(bytes, 0, bytes.Length);
            }

            Process.Start(Path.Combine(ruta, nombre));
        }
        private void btnAceptar_Click(object sender, EventArgs e)
        {
            cargarreporte();
        }
    }
}
