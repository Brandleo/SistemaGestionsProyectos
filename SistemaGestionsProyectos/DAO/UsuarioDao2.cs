using SistemaGestionsProyectos.ClasesDao;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaGestionsProyectos.DAO
{
    internal class UsuarioDao2
    {
        private Conexion _conexion;

        public UsuarioDao2(Conexion conexion)
        {
            _conexion = conexion;
        }

        public Usuario ValidarCredenciales(string correo, string contraseña)
        {
            Usuario usuario = null;

            using (SqlConnection connection = _conexion.CrearConexion())
            {
                try
                {
                    connection.Open();

                    // Verificar si el usuario está bloqueado
                    string verificarBloqueo = "SELECT IntentosFallidos, BloqueadoHasta FROM Usuarios WHERE Correo = @Correo";
                    using (SqlCommand cmdVerificar = new SqlCommand(verificarBloqueo, connection))
                    {
                        cmdVerificar.Parameters.AddWithValue("@Correo", correo);
                        using (SqlDataReader reader = cmdVerificar.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                int intentosFallidos = reader.GetInt32(0);
                                object bloqueadoHastaObj = reader[1];

                                if (bloqueadoHastaObj != DBNull.Value)
                                {
                                    DateTime bloqueadoHasta = Convert.ToDateTime(bloqueadoHastaObj);
                                    if (bloqueadoHasta > DateTime.Now)
                                    {
                                        throw new Exception("Cuenta bloqueada temporalmente. Intente más tarde.");
                                    }
                                }
                            }
                        }
                    }

                    // Verificar credenciales
                    string query = "SELECT Id, Correo, Contraseña, EstadoId, RolId, empleado_id FROM Usuarios WHERE Correo = @Correo AND Contraseña = @Contraseña";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Correo", correo);
                        command.Parameters.AddWithValue("@Contraseña", contraseña);

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.HasRows)
                            {
                                reader.Read();
                                usuario = new Usuario
                                {
                                    Id = reader.GetInt32(0),
                                    Correo = reader.GetString(1),
                                    Contraseña = reader.GetString(2),
                                    EstadoId = reader.GetInt32(3),
                                    RolId = reader.GetInt32(4),
                                    Empleado_id = reader.GetInt32(5),
                                };

                                ResetearIntentosFallidos(correo);
                            }
                            else
                            {
                                RegistrarIntentoFallido(correo);
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error al validar credenciales: {ex.Message}");
                    throw;
                }
            }

            return usuario;
        }

        private void RegistrarIntentoFallido(string correo)
        {
            using (SqlConnection connection = _conexion.CrearConexion())
            {
                connection.Open();

                string query = "SELECT IntentosFallidos FROM Usuarios WHERE Correo = @Correo";
                int intentos = 0;

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Correo", correo);
                    object result = command.ExecuteScalar();
                    intentos = result != DBNull.Value ? Convert.ToInt32(result) : 0;
                }

                intentos++;

                if (intentos >= 5)
                {
                    string bloquear = "UPDATE Usuarios SET IntentosFallidos = @Intentos, BloqueadoHasta = @BloqueadoHasta WHERE Correo = @Correo";
                    using (SqlCommand command = new SqlCommand(bloquear, connection))
                    {
                        command.Parameters.AddWithValue("@Intentos", intentos);
                        command.Parameters.AddWithValue("@BloqueadoHasta", DateTime.Now.AddMinutes(1));
                        command.Parameters.AddWithValue("@Correo", correo);
                        command.ExecuteNonQuery();
                    }
                }
                else
                {
                    string actualizarIntentos = "UPDATE Usuarios SET IntentosFallidos = @Intentos WHERE Correo = @Correo";
                    using (SqlCommand command = new SqlCommand(actualizarIntentos, connection))
                    {
                        command.Parameters.AddWithValue("@Intentos", intentos);
                        command.Parameters.AddWithValue("@Correo", correo);
                        command.ExecuteNonQuery();
                    }
                }
            }
        }

        private void ResetearIntentosFallidos(string correo)
        {
            using (SqlConnection connection = _conexion.CrearConexion())
            {
                connection.Open();
                string query = "UPDATE Usuarios SET IntentosFallidos = 0, BloqueadoHasta = NULL WHERE Correo = @Correo";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Correo", correo);
                    command.ExecuteNonQuery();
                }
            }
        }
    }
}
