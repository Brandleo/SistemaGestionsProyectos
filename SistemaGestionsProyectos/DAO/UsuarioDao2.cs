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

                    string query = "SELECT * FROM Usuarios WHERE Correo = @Correo AND Contraseña = @Contraseña";

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
                                    Estado = reader.GetBoolean(3),
                                    RolId = reader.GetInt32(4)
                                };
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
    }
}
