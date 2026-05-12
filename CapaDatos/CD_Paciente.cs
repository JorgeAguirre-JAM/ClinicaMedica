using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySqlConnector;
using CapaEntities;
using System.Collections.Generic;
using System.Linq;
using Dapper;

namespace CapaDatos
{
    public class CD_Paciente : Conexion
    {



        
        // (Crear)
        public bool AddPaciente(CE_Paciente paciente)
        {
            using (MySqlConnection conexion = ObtenerConexion())
            {
                conexion.Open();
                string query = @"INSERT INTO paciente (Nombre, Apellidos, FechNac, Telefono, Direccion, TipoSangre) 
                 VALUES (@Nombre, @Apellidos, @FechNac, @Telefono, @Direccion, @TipoSangre)";

                using (MySqlCommand cmd = new MySqlCommand(query, conexion))
                {

                    cmd.Parameters.AddWithValue("@Nombre", paciente.Nombre);
                    cmd.Parameters.AddWithValue("@Apellidos", paciente.Apellidos);
                    cmd.Parameters.AddWithValue("@FechNac", paciente.FechNac);
                    cmd.Parameters.AddWithValue("@Telefono", paciente.Telefono);
                    cmd.Parameters.AddWithValue("@Direccion", paciente.Direccion);
                    cmd.Parameters.AddWithValue("@TipoSangre", paciente.TipoSangre);

                    int filasAfectadas = cmd.ExecuteNonQuery();
                    return filasAfectadas > 0; 
                }
            }
        }
        

        //  (Leer)
        public CE_Paciente GetPacienteById(int idPaciente)
        {
            CE_Paciente paciente = null;

            using (MySqlConnection conexion = ObtenerConexion())
            {
                conexion.Open();
                string query = "SELECT * FROM Pacientes WHERE IdPaciente = @Id";

                using (MySqlCommand cmd = new MySqlCommand(query, conexion))
                {
                    cmd.Parameters.AddWithValue("@Id", idPaciente);

                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            paciente = new CE_Paciente
                            {
                                IdPaciente = Convert.ToInt32(reader["IdPaciente"]),
                                Nombre = reader["Nombre"].ToString(),
                                Apellidos = reader["Apellidos"].ToString(),
                                Telefono = reader["Telefono"].ToString(),
                                Direccion = reader["Direccion"].ToString(),
                                TipoSangre = reader["TipoSangre"].ToString()
                            };
                        }
                    }
                }
            }
            return paciente;
        }


        // UpdPaciente (Actualizar)

        public bool UpdPaciente(CE_Paciente paciente)
        {
            try
            {
                using (MySqlConnection conexion = ObtenerConexion())
                {
                    conexion.Open();

                   
                    string query = @"UPDATE paciente SET 
                             Nombre = @Nombre, 
                             Apellidos = @Apellidos, 
                             FechNac = @FechNac, 
                             Telefono = @Telefono, 
                             Direccion = @Direccion, 
                             TipoSangre = @TipoSangre 
                             WHERE IdPaciente = @IdPaciente";

                    using (MySqlCommand cmd = new MySqlCommand(query, conexion))
                    {

                        cmd.Parameters.AddWithValue("@IdPaciente", paciente.IdPaciente);
                        cmd.Parameters.AddWithValue("@Nombre", paciente.Nombre);
                        cmd.Parameters.AddWithValue("@Apellidos", paciente.Apellidos);
                        cmd.Parameters.AddWithValue("@FechNac", paciente.FechNac); 
                        cmd.Parameters.AddWithValue("@Telefono", paciente.Telefono);
                        cmd.Parameters.AddWithValue("@Direccion", paciente.Direccion);
                        cmd.Parameters.AddWithValue("@TipoSangre", paciente.TipoSangre);

                     
                        return cmd.ExecuteNonQuery() > 0;
                    }
                }
            }
            catch (Exception ex)
            {
         
                throw new Exception("Error en la BD al actualizar: " + ex.Message);
            }
        }

        //(Eliminar)
        public bool DelPaciente(int idPaciente)
        {
            try
            {
                using (MySqlConnection conexion = ObtenerConexion())
                {
                    conexion.Open();

                 
                    string querySignos = @"DELETE signosvitales FROM signosvitales 
                                   INNER JOIN consulta ON signosvitales.IdConsulta = consulta.IdConsulta 
                                   INNER JOIN cita ON consulta.IdCita = cita.IdCita 
                                   WHERE cita.IdPaciente = @IdPaciente";
                    using (MySqlCommand cmdSignos = new MySqlCommand(querySignos, conexion))
                    {
                        cmdSignos.Parameters.AddWithValue("@IdPaciente", idPaciente);
                        cmdSignos.ExecuteNonQuery();
                    }

                  
                    string queryConsultas = @"DELETE consulta FROM consulta 
                                      INNER JOIN cita ON consulta.IdCita = cita.IdCita 
                                      WHERE cita.IdPaciente = @IdPaciente";
                    using (MySqlCommand cmdConsultas = new MySqlCommand(queryConsultas, conexion))
                    {
                        cmdConsultas.Parameters.AddWithValue("@IdPaciente", idPaciente);
                        cmdConsultas.ExecuteNonQuery();
                    }

                
                    string queryCitas = "DELETE FROM cita WHERE IdPaciente = @IdPaciente";
                    using (MySqlCommand cmdCitas = new MySqlCommand(queryCitas, conexion))
                    {
                        cmdCitas.Parameters.AddWithValue("@IdPaciente", idPaciente);
                        cmdCitas.ExecuteNonQuery();
                    }

                    string queryExpediente = "DELETE FROM expedientemedico WHERE IdPaciente = @IdPaciente";
                    using (MySqlCommand cmdExpediente = new MySqlCommand(queryExpediente, conexion))
                    {
                        cmdExpediente.Parameters.AddWithValue("@IdPaciente", idPaciente);
                        cmdExpediente.ExecuteNonQuery();
                    }

              
                    string query = "DELETE FROM paciente WHERE IdPaciente = @IdPaciente";
                    using (MySqlCommand cmd = new MySqlCommand(query, conexion))
                    {
                        cmd.Parameters.AddWithValue("@IdPaciente", idPaciente);
                        return cmd.ExecuteNonQuery() > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public List<CE_Paciente> ListarPacientes()
{
            using (var conexion = ObtenerConexion())
            {
                conexion.Open();

                string query = @"SELECT IdPaciente, Nombre, Apellidos, Telefono, Direccion, TipoSangre,
                                DATE_FORMAT(FechNac, '%d/%m/%Y') AS FechNac 
                         FROM paciente";

                return conexion.Query<CE_Paciente>(query).ToList();
            }
        }


    }
}
