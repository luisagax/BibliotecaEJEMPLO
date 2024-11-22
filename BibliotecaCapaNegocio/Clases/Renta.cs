using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaCapaNegocio.Clases
{
    public class Renta
    {
        static Conexion c = new Conexion();
        SqlConnection con = new SqlConnection(c.conexion());
        SqlDataReader lector;
        SqlCommand comando = new SqlCommand();
        public int id;
        public int idCliente;
        public DateTime fecha_i;
        public DateTime fecha_r;
        public int Cantidad;
        public decimal Multa;
        public DataTable detalles;

        public Renta(string sConexion)
        {
            con.ConnectionString = sConexion;
            comando.Connection = con;
        }

        public string guardar()
        {
            string msj = "";
            comando.CommandType = CommandType.StoredProcedure;
            comando.CommandText = "spRenta";
            comando.Parameters.Clear();
            comando.Parameters.AddWithValue("@op",2);
            comando.Parameters.AddWithValue("@id", id);
            comando.Parameters.AddWithValue("@FechaRenta", fecha_i);
            comando.Parameters.AddWithValue("@FechaRegreso", fecha_r);
            comando.Parameters.AddWithValue("@Multa", Multa);
            comando.Parameters.AddWithValue("@Cantidad", Cantidad);
            comando.Parameters.AddWithValue("@idCliente", idCliente);
            SqlParameter vParam = comando.Parameters.AddWithValue("@detalles", detalles);
            vParam.SqlDbType = SqlDbType.Structured;
            vParam.TypeName = "dbo.t_RentaDetalle";

            con.Open();
            comando.ExecuteNonQuery();
            con.Close();

            msj = "Listo";
            return msj;

        }
        public void buscar()
        {
            Busquedas.frmBusquedaRenta x = new Busquedas.frmBusquedaRenta(con.ConnectionString);
            x.ShowDialog();

            if(x.DialogResult == System.Windows.Forms.DialogResult.OK)
            {
                id = x.dsvRenta.vRenta[x.vRentaBindingSource.Position].id;
                idCliente = x.dsvRenta.vRenta[x.vRentaBindingSource.Position].idCliente;
                fecha_i = x.dsvRenta.vRenta[x.vRentaBindingSource.Position].FechaRenta;
                fecha_r = x.dsvRenta.vRenta[x.vRentaBindingSource.Position].FechaRegreso;
                Cantidad = x.dsvRenta.vRenta[x.vRentaBindingSource.Position].Cantidad;
                Multa = x.dsvRenta.vRenta[x.vRentaBindingSource.Position].Multa;
                detalles = x.dsvRentaDetalle.vRentaDetalle;
            }
        }
    }
}
