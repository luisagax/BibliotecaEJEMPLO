using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaCapaNegocio.Clases
{
    public class Conexion
    {
        public string conexion()
        {
            string conex = "";
            string path = @"C:\conex.txt";
            using (StreamReader file = new StreamReader(path))
            {
                conex = @"" + file.ReadToEnd();
                file.Close();
            }
            return conex;
        }
    }
}
