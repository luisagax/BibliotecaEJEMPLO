using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace BibliotecaCapaNegocio.Clases
{
    public class Usuarios
    {
        static Conexion c = new Conexion();
        SqlConnection con = new SqlConnection(@"" + c.conexion());
        SqlCommand comando = new SqlCommand();
        SqlDataReader lector;

        public string sConexion;
        public int id;
        public string Username;
        public string Clave;
        public byte Nivel;
        public bool encontro;

        public Usuarios()
        {
            comando.Connection = con;
        }
        public Usuarios(string sconexion)
        {
            this.sConexion = sconexion;
            con.ConnectionString = sConexion;
            comando.Connection = con;
        }

        public string guardar()
        {
            string msj = "";
            comando.CommandType = CommandType.StoredProcedure;
            comando.CommandText = "spUsuarios";
            comando.Parameters.Clear();
            comando.Parameters.AddWithValue("@op", 2);
            comando.Parameters.AddWithValue("@id", id);
            comando.Parameters.AddWithValue("@Username", Username);
            comando.Parameters.AddWithValue("@Clave", Clave);
            comando.Parameters.AddWithValue("@Nivel", Nivel);

            con.Open();
            comando.ExecuteNonQuery();
            con.Close();

            msj = "Listo";
            return msj;
        }

        public void buscar2()
        {
            Busquedas.frmBusquedaUsuariov2 x = new Busquedas.frmBusquedaUsuariov2(sConexion);
            x.ShowDialog();
            if (x.DialogResult == System.Windows.Forms.DialogResult.OK)
            {
                id = int.Parse(x.dgUsuarios.SelectedRows[0].Cells["id"].Value.ToString());
                Username = x.dgUsuarios.SelectedRows[0].Cells["Username"].Value.ToString();
                Nivel = byte.Parse(x.dgUsuarios.SelectedRows[0].Cells["Nivel"].Value.ToString());
                encontro = true;
            }
            else
                encontro = false;
        }

        public void buscar()
        {
            Busquedas.frmBusquedaUsuarios x = new Busquedas.frmBusquedaUsuarios(con.ConnectionString);
            x.ShowDialog();
            if (x.DialogResult == System.Windows.Forms.DialogResult.OK)
            {
                id = x.dsUsuarios.Usuarios[x.usuariosBindingSource.Position].id;
                Username = x.dsUsuarios.Usuarios[x.usuariosBindingSource.Position].Username;
                Clave = x.dsUsuarios.Usuarios[x.usuariosBindingSource.Position].Clave;
                Nivel = x.dsUsuarios.Usuarios[x.usuariosBindingSource.Position].Nivel;
                encontro = true;
            }
            else
                encontro = false;
        }
    }
}
