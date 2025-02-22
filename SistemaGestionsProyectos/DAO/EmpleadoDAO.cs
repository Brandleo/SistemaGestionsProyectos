using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaGestionsProyectos.DAO
{
    internal class EmpleadoDAO
    {
        public bool InsertarEmpleado(string dui, string nombre, string apellido, string direccion, string habilidades)
        {
            try
            {
                using (SqlConnection conexion = Conexion.getInstancia().CrearConexion())
                {
                    conexion.Open();

                    using (SqlCommand cmd = new SqlCommand("SP_AgregarEmpleado", conexion))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@DUI", dui);
                        cmd.Parameters.AddWithValue("@Nombre", nombre);
                        cmd.Parameters.AddWithValue("@Apellido", apellido);
                        cmd.Parameters.AddWithValue("@Direccion", direccion);
                        cmd.Parameters.AddWithValue("@Habilidades", habilidades);

                        int filasAfectadas = cmd.ExecuteNonQuery();

                        if (filasAfectadas > 0)
                            return true;
                        else
                            throw new Exception("El procedimiento almacenado no insertó registros.");
                    }
                }
            }
            catch (SqlException ex)
            {
                throw new Exception("Error de SQL: " + ex.Message);
            }
            catch (Exception ex)
            {
                throw new Exception("Error general: " + ex.Message);
            }
        }
    }
}
