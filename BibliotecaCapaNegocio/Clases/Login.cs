using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace BibliotecaCapaNegocio.Clases
{
    public class Login
    {
        string Usuario = "", password = "", sConexion = "";
        static Conexion c = new Conexion();
        SqlConnection con = new SqlConnection(c.conexion());
        SqlDataReader lector;
        public Login(string Usuario, string password)
        {
            this.Usuario = Usuario;
            this.password = password;
        }
        public bool Ingresar()
        {
            bool exito = false;
            int Nivel = 0;
            SqlCommand comando = new SqlCommand($"select * from Usuarios where Username = '{Usuario}' COLLATE SQL_Latin1_General_CP1_CS_AS and Clave = '{password}' COLLATE SQL_Latin1_General_CP1_CS_AS", con);
            con.Open();
            lector = comando.ExecuteReader();
            if (lector.Read())
                Nivel = (byte)lector["Nivel"];
            else
                Nivel = 0;
            con.Close();
            if (Nivel == 0)
                exito = false;
            else
                exito = true;
            return exito;
        }
    }
}
