using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySqlConnector;

namespace CapaDatos
{
    
    public class Conexion
    {

        private readonly string cadenaConexion = "Server=127.0.0.1; Port=3306; Database=sistemaclinica; Uid=root; Pwd=admin;";

  
        protected MySqlConnection ObtenerConexion()
        {
            return new MySqlConnection(cadenaConexion);
        }
    }
    
}
