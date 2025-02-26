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
        public bool InsertarEmpleado(string dui, string nombre, string apellido, string direccion, string habilidades, string puesto)
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
                        cmd.Parameters.AddWithValue("@Puesto", puesto);

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
        public DataTable ObtenerEmpleados()
        {
            using (SqlConnection conexion = Conexion.getInstancia().CrearConexion())
            {
                conexion.Open();

                using (SqlCommand cmd = new SqlCommand("SP_ObtenerEmpleados", conexion))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    return dt;
                }
            }
        }

        public DataTable ObtenerHistorialTareas(int empleadoId)
        {
            using (SqlConnection conexion = Conexion.getInstancia().CrearConexion())
            {
                conexion.Open();

                using (SqlCommand cmd = new SqlCommand("SP_ObtenerHistorialTareas", conexion))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@EmpleadoId", empleadoId);
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    return dt;
                }
            }
        }
        }
}
