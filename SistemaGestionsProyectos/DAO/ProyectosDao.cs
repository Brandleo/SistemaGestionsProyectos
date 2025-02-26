using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace SistemaGestionsProyectos.DAO
{
    internal class ProyectosDao
    {

        public DataTable VerProyectos()
        {
            SqlDataReader resultado;
            DataTable tabla = new DataTable();
            SqlConnection sqlCon = new SqlConnection();

            try
            {
                sqlCon = Conexion.getInstancia().CrearConexion();
                SqlCommand comando = new SqlCommand("sp_GetProyectos", sqlCon);
                comando.CommandType = CommandType.StoredProcedure;

                sqlCon.Open();
                resultado = comando.ExecuteReader();
                tabla.Load(resultado);
                return tabla;
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
        }




        public DataTable VerProyectosSinPromotor()
        {
            SqlDataReader resultado;
            DataTable tabla = new DataTable();
            SqlConnection sqlCon = new SqlConnection();

            try
            {
                sqlCon = Conexion.getInstancia().CrearConexion();
                SqlCommand comando = new SqlCommand("sp_getProyectosSinPromotor", sqlCon);
                comando.CommandType = CommandType.StoredProcedure;

                sqlCon.Open();
                resultado = comando.ExecuteReader();
                tabla.Load(resultado);
                return tabla;
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
        }




        public DataTable verPromotoresDisponibles()
        {
            SqlDataReader resultado;
            DataTable tabla = new DataTable();
            SqlConnection sqlCon = new SqlConnection();

            try
            {
                sqlCon = Conexion.getInstancia().CrearConexion();
                SqlCommand comando = new SqlCommand("sp_Promotores_disponibles", sqlCon);
                comando.CommandType = CommandType.StoredProcedure;

                sqlCon.Open();
                resultado = comando.ExecuteReader();
                tabla.Load(resultado);
                return tabla;
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
        }






        public int ValidarNombreProyecto(string nombreClave)
        {
            SqlConnection sqlCon = new SqlConnection();
            try
            {
                sqlCon = Conexion.getInstancia().CrearConexion();
                SqlCommand comando = new SqlCommand("sp_ValidarNombreProyecto", sqlCon);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@NombreClave", nombreClave);

                sqlCon.Open();
               
                int existe = Convert.ToInt32(comando.ExecuteScalar());
                return existe;
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
        }

        



        public int InsertProyecto(string nombreClave, string denominacion, DateTime fechaInicio, DateTime fechaFin)
        {
            SqlConnection sqlCon = new SqlConnection();
            try
            {
                sqlCon = Conexion.getInstancia().CrearConexion();
                SqlCommand comando = new SqlCommand("sp_InsertProyecto", sqlCon);
                comando.CommandType = CommandType.StoredProcedure;

                comando.Parameters.AddWithValue("@NombreClave", nombreClave);
                comando.Parameters.AddWithValue("@DenominacionComercial", denominacion);
                comando.Parameters.AddWithValue("@FechaInicio", fechaInicio);
                comando.Parameters.AddWithValue("@FechaFin", fechaFin);

                sqlCon.Open();
                int filasAfectadas = comando.ExecuteNonQuery();
                return filasAfectadas;
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
        }



        public bool AsignarPromotorAProyecto(int proyectoId, int usuarioId)
        {
            bool resultado = false;
            SqlConnection sqlCon = new SqlConnection();

            try
            {
                sqlCon = Conexion.getInstancia().CrearConexion();
                SqlCommand comando = new SqlCommand("sp_AsignarPromotorAProyecto", sqlCon);
                comando.CommandType = CommandType.StoredProcedure;

                comando.Parameters.AddWithValue("@ProyectoId", proyectoId);
                comando.Parameters.AddWithValue("@UsuarioId", usuarioId);

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













    }


    }

