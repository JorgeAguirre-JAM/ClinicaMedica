using CapaEntities;
using Dapper;
using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class CD_Doctor : Conexion
    {
        public bool AddDoctor(CE_Doctor doctor)
        {
            using (MySqlConnection conexion = ObtenerConexion())
            {
                conexion.Open();
                string query = @"INSERT INTO doctor (Nombre, Apellidos,Telefono, IdEspecialidad, NumeroColegiado,  RutaDoctos) 
                 VALUES (@Nombre, @Apellidos,@Telefono,@IdEspecialidad, @NumeroColegiado,@RutaDoctos)";

                using (MySqlCommand cmd = new MySqlCommand(query, conexion))
                {

                    cmd.Parameters.AddWithValue("@Nombre", doctor.Nombre);
                    cmd.Parameters.AddWithValue("@Apellidos", doctor.Apellidos);
                    cmd.Parameters.AddWithValue("@Telefono", doctor.Telefono);
                    cmd.Parameters.AddWithValue("@IdEspecialidad", doctor.IdEspecialidad);
                    cmd.Parameters.AddWithValue("@NumeroColegiado", doctor.NumeroColegiado);
                    cmd.Parameters.AddWithValue("@RutaDoctos", doctor.RutaDoctos);


                    int filasAfectadas = cmd.ExecuteNonQuery();
                    return filasAfectadas > 0;
                }
            }
        }


        //  (Leer)
        public CE_Doctor GetDoctorById(int idDoctor)
        {
            CE_Doctor doctor = null;

            using (MySqlConnection conexion = ObtenerConexion())
            {
                conexion.Open();
                string query = "SELECT * FROM doctor WHERE IdDoctor = @Id";

                using (MySqlCommand cmd = new MySqlCommand(query, conexion))
                {
                    cmd.Parameters.AddWithValue("@Id", idDoctor);

                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            doctor = new CE_Doctor
                            {
                                IdDoctor = Convert.ToInt32(reader["IdDoctor"]),
                                Nombre = reader["Nombre"].ToString(),
                                Apellidos = reader["Apellidos"].ToString(),
                                Telefono = reader["Telefono"].ToString(),
                                IdEspecialidad = Convert.ToInt32(reader["IdEspecialidad"]),
                                NumeroColegiado = reader["NumeroColegiado"].ToString(),

                            };
                        }
                    }
                }
            }
            return doctor;
        }


        // UpdDoctor (Actualizar)

        public bool UpdDoctor(CE_Doctor doctor)
        {
            try
            {
                using (var conexion = ObtenerConexion())
                {
                    conexion.Open();
            
                    string query = @"UPDATE doctor SET  
                             Nombre = @Nombre,  
                             Apellidos = @Apellidos,  
                             Telefono = @Telefono,  
                             IdEspecialidad = @IdEspecialidad,
                             NumeroColegiado = @NumeroColegiado, 
                             RutaDoctos = @RutaDoctos
                             WHERE IdDoctor = @IdDoctor";

                   
                    int filas = conexion.Execute(query, doctor);
                    return filas > 0;

             
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error en la BD al actualizar: " + ex.Message);
            }
        }

        //(Eliminar)
        public bool EliminarDoctorConTurnos(int idDoctor)
        {
            try
            {
                using (MySqlConnection conexion = ObtenerConexion())
                {
                    conexion.Open();


                    string queryTurnos = "DELETE FROM turno WHERE IdDoctor = @IdDoctor";

                    using (MySqlCommand cmdTurnos = new MySqlCommand(queryTurnos, conexion))
                    {
                        cmdTurnos.Parameters.AddWithValue("@IdDoctor", idDoctor);
                        cmdTurnos.ExecuteNonQuery();
                    }

 
                    string queryDoctor = "DELETE FROM doctor WHERE IdDoctor = @IdDoctor";

                    using (MySqlCommand cmdDoctor = new MySqlCommand(queryDoctor, conexion))
                    {
                        cmdDoctor.Parameters.AddWithValue("@IdDoctor", idDoctor);
                        return cmdDoctor.ExecuteNonQuery() > 0;
                    }
                }
            }
            catch (Exception ex)
            {

                throw new Exception("Error al eliminar el médico y su agenda: " + ex.Message);
            }
        }

        public List<CE_Doctor> ListarDoctor()
        {
            using (var conexion = ObtenerConexion())
            {
                conexion.Open();

                string query = @"SELECT d.IdDoctor, d.Nombre, d.Apellidos, d.Telefono, 
                                d.IdEspecialidad, d.NumeroColegiado, d.RutaDoctos,
                                e.Nombre AS NombreEspecialidad 
                         FROM doctor d
                         INNER JOIN especialidad e ON d.IdEspecialidad = e.IdEspecialidad";

                return conexion.Query<CE_Doctor>(query).ToList();
            }
        }

    }
}
