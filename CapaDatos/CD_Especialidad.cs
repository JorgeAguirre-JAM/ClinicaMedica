using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaEntities;
using MySqlConnector;
using Dapper;

namespace CapaDatos
{
    public class CD_Especialidad : Conexion
    {

        public List<CE_Especialidad> ListarEspecialidades()
        {
            using (var conexion = ObtenerConexion())
            {
                conexion.Open();
                string query = "SELECT IdEspecialidad, Nombre FROM especialidad ORDER BY Nombre ASC";
                return conexion.Query<CE_Especialidad>(query).ToList();
            }
        }

        public bool AgregarEspecialidad(string nombre, string descripcion)
        {
            try
            {
                using (var conexion = ObtenerConexion())
                {
                    conexion.Open();
                    string query = "INSERT INTO especialidad (Nombre, Descripcion) VALUES (@Nombre, @Descripcion)";

                    using (var cmd = new MySqlCommand(query, conexion))
                    {
                        cmd.Parameters.AddWithValue("@Nombre", nombre);
                        cmd.Parameters.AddWithValue("@Descripcion", descripcion);
                        return cmd.ExecuteNonQuery() > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al guardar especialidad: " + ex.Message);
            }
        }
    }
}
