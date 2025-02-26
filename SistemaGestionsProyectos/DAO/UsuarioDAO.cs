using SistemaGestionsProyectos.DAO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace SistemaGestionsProyectos.Forms
{
    internal class UsuarioDAO
    {
        public bool CorreoExiste(string correo)
        {
            SqlDataReader resultado;
            SqlConnection sqlCon = new SqlConnection();
            bool existe = false;

            try
            {
                sqlCon = Conexion.getInstancia().CrearConexion();
                SqlCommand comando = new SqlCommand("sp_ValidarCorreoUnico", sqlCon);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@Correo", correo);

                sqlCon.Open();
                resultado = comando.ExecuteReader();
                if (resultado.Read())
                {
                    existe = resultado.GetInt32(0) > 0;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (sqlCon.State == ConnectionState.Open)
                    sqlCon.Close();
            }
            return existe;
        }

        public int ObtenerEmpleadoIdPorDUI(string dui)
        {
            SqlDataReader resultado;
            SqlConnection sqlCon = new SqlConnection();
            int empleadoId = -1;

            try
            {
                sqlCon = Conexion.getInstancia().CrearConexion();
                SqlCommand comando = new SqlCommand("sp_ObtenerEmpleadoPorDUI", sqlCon);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@DUI", dui);

                sqlCon.Open();
                resultado = comando.ExecuteReader();
                if (resultado.Read())
                {
                    empleadoId = resultado.GetInt32(0);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (sqlCon.State == ConnectionState.Open)
                    sqlCon.Close();
            }
            return empleadoId;
        }




        public bool CrearUsuario(string correo, string contrasenia, int rolId, int empleadoId, int estadoId)
        {
            SqlConnection sqlCon = new SqlConnection();
            bool resultado = false;

            try
            {
                sqlCon = Conexion.getInstancia().CrearConexion();
                SqlCommand comando = new SqlCommand("sp_CrearUsuario", sqlCon);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@Correo", correo);
                comando.Parameters.AddWithValue("@Contrasenia", contrasenia);
                comando.Parameters.AddWithValue("@RolId", rolId);
                comando.Parameters.AddWithValue("@EmpleadoId", empleadoId);
                comando.Parameters.AddWithValue("@EstadoId", estadoId);

                sqlCon.Open();
                int filasAfectadas = comando.ExecuteNonQuery();
                resultado = filasAfectadas > 0;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (sqlCon.State == ConnectionState.Open)
                    sqlCon.Close();
            }
            return resultado;
        }



        public DataTable ObtenerEstados()
        {
            SqlDataReader resultado;
            DataTable tabla = new DataTable();
            SqlConnection sqlCon = new SqlConnection();

            try
            {
                sqlCon = Conexion.getInstancia().CrearConexion();
                SqlCommand comando = new SqlCommand("sp_ObtenerEstados", sqlCon);
                comando.CommandType = CommandType.StoredProcedure;

                sqlCon.Open();
                resultado = comando.ExecuteReader();
                tabla.Load(resultado);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (sqlCon.State == ConnectionState.Open)
                    sqlCon.Close();
            }
            return tabla;
        }



        public DataTable ObtenerRoles()
        {
            SqlDataReader resultado;
            DataTable tabla = new DataTable();
            SqlConnection sqlCon = new SqlConnection();

            try
            {
                sqlCon = Conexion.getInstancia().CrearConexion();
                SqlCommand comando = new SqlCommand("sp_ObtenerRoles", sqlCon);
                comando.CommandType = CommandType.StoredProcedure;

                sqlCon.Open();
                resultado = comando.ExecuteReader();
                tabla.Load(resultado);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (sqlCon.State == ConnectionState.Open)
                    sqlCon.Close();
            }
            return tabla;
        }
        public DataTable ObtenerEmpleados()
        {
            SqlDataReader resultado;
            DataTable tabla = new DataTable();
            SqlConnection sqlCon = new SqlConnection();

            try
            {
                sqlCon = Conexion.getInstancia().CrearConexion();
                SqlCommand comando = new SqlCommand("sp_GetEmpleados", sqlCon);
                comando.CommandType = CommandType.StoredProcedure;

                sqlCon.Open();
                resultado = comando.ExecuteReader();
                tabla.Load(resultado);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (sqlCon.State == ConnectionState.Open)
                    sqlCon.Close();
            }
            return tabla;
        }


        public DataTable ObtenerUsuarios()
        {
            SqlDataReader resultado;
            DataTable tabla = new DataTable();
            SqlConnection sqlCon = new SqlConnection();

            try
            {
                sqlCon = Conexion.getInstancia().CrearConexion();
                SqlCommand comando = new SqlCommand("sp_ObtenerUsuariosConEmpleados", sqlCon);
                comando.CommandType = CommandType.StoredProcedure;

                sqlCon.Open();
                resultado = comando.ExecuteReader();
                tabla.Load(resultado);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (sqlCon.State == ConnectionState.Open)
                    sqlCon.Close();
            }
            return tabla;
        }



    }
}
