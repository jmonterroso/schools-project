using Capa.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Capa.Datos
{
   public  class PeriodosDatos
    {
        public void Insertar(Periodos peri)
        {
            // SqlConnection requiere el using System.Data.SqlClient;
            SqlConnection conexion = new SqlConnection(Conexion.Cadena);
            try
            {
                conexion.Open(); // un error aca: revisar cadena de conexion
                // El command permite ejecutar un comando en la conexion establecida
                SqlCommand comando = new SqlCommand("PA_InsertarPeriodo", conexion);
                // Como es en Store Procedure se debe indicar el tipo de comando
                comando.CommandType = System.Data.CommandType.StoredProcedure;
                // Si el SP requeire parametros se le deben asignar al comando
                comando.Parameters.AddWithValue("@Nombre", peri.Nombre);
                comando.Parameters.AddWithValue("@Codigo", peri.Codigo);

                comando.Parameters.AddWithValue("@FechaInicio", peri.FechaInicio);
                comando.Parameters.AddWithValue("@FechaFinal", peri.FechaFinal);

                // Finalmente ejecutamos el comando
                // al ser un insert no requiere retornar un consulta
                comando.ExecuteNonQuery();
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                conexion.Close();
            }
        }

        public void Actualizar(Periodos peri)
        {
            // SqlConnection requiere el using System.Data.SqlClient;
            SqlConnection conexion = new SqlConnection(Conexion.Cadena);
            try
            {
                conexion.Open(); // un error aca: revisar cadena de conexion
                // El command permite ejecutar un comando en la conexion establecida
                SqlCommand comando = new SqlCommand("PA_ActualizarPeriodo", conexion);
                // Como es en Store Procedure se debe indicar el tipo de comando
                comando.CommandType = System.Data.CommandType.StoredProcedure;
                // Si el SP requeire parametros se le deben asignar al comando
                comando.Parameters.AddWithValue("@Nombre", peri.Nombre);
                comando.Parameters.AddWithValue("@Codigo", peri.Codigo);

                comando.Parameters.AddWithValue("@FechaInicio", peri.FechaInicio);
                comando.Parameters.AddWithValue("@FechaFinal", peri.FechaFinal);
                // Finalmente ejecutamos el comando
                // al ser un update no requiere retornar un consulta
                comando.ExecuteNonQuery();
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                conexion.Close();
            }
        }

        
        public void Eliminar(Periodos peri)
        {
            // SqlConnection requiere el using System.Data.SqlClient;
            SqlConnection conexion = new SqlConnection(Conexion.Cadena);
            try
            {
                conexion.Open(); // un error aca: revisar cadena de conexion
                // El command permite ejecutar un comando en la conexion establecida
                SqlCommand comando = new SqlCommand("PA_EliminarPeriodo", conexion);
                // Como es en Store Procedure se debe indicar el tipo de comando
                comando.CommandType = System.Data.CommandType.StoredProcedure;
                // Si el SP requeire parametros se le deben asignar al comando
                // Si el SP requeire parametros se le deben asignar al comando
                comando.Parameters.AddWithValue("@Nombre", peri.Nombre);
                comando.Parameters.AddWithValue("@Codigo", peri.Codigo);

                comando.Parameters.AddWithValue("@FechaInicio", peri.FechaInicio);
                comando.Parameters.AddWithValue("@FechaFinal", peri.FechaFinal);
                // Finalmente ejecutamos el comando
                // al ser un update no requiere retornar un consulta
                comando.ExecuteNonQuery();
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                conexion.Close();
            }
        }

        public List<Periodos> SeleccionarTodos()
        {
            // SqlConnection requiere el using System.Data.SqlClient;
            SqlConnection conexion = new SqlConnection(Conexion.Cadena);
            List<Periodos> lista = new List<Periodos>();
            try
            {
                conexion.Open(); // un error aca: revisar cadena de conexion
                // El command permite ejecutar un comando en la conexion establecida
                SqlCommand comando = new SqlCommand("PA_SeleccionarPeriodo", conexion);
                // Como es en Store Procedure se debe indicar el tipo de comando
                comando.CommandType = System.Data.CommandType.StoredProcedure;
                // NO recibe parametros
                // Finalmente ejecutamos el comando
                // al ser una consulta debemos usar ExecuteReader
                SqlDataReader reader = comando.ExecuteReader();
                // es necesario recorrer el reader para extraer todos los registros
                while (reader.Read()) // cada vez que se llama el Read retorna una tupla
                {
                    
                    Periodos s = new Periodos();
                    s.Codigo = Convert.ToInt32(reader["Codigo"]);
                    s.Nombre = reader["Nombre"].ToString();
                    s.FechaFinal = (DateTime)(reader["FechaFinal"]);
                    s.FechaInicio = (DateTime)(reader["FechaInicio"]);


                    lista.Add(s);
                }

            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                conexion.Close();
            }

            return lista;
        }

        public Periodos SeleccionarPorId(int codigo)
        {
            // SqlConnection requiere el using System.Data.SqlClient;
            SqlConnection conexion = new SqlConnection(Conexion.Cadena);
            try
            {
                conexion.Open(); // un error aca: revisar cadena de conexion
                // El command permite ejecutar un comando en la conexion establecida
                SqlCommand comando = new SqlCommand("PA_SeleccionarPeridosPorId", conexion);
                // Como es en Store Procedure se debe indicar el tipo de comando
                comando.CommandType = System.Data.CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@Codigo", codigo);
                // Finalmente ejecutamos el comando
                // al ser una consulta debemos usar ExecuteReader
                SqlDataReader reader = comando.ExecuteReader();
                // es necesario recorrer el reader para extraer todos los registros
                while (reader.Read()) // cada vez que se llama el Read retorna una tupla
                {
                    Periodos s = new Periodos();
                    s.Codigo = Convert.ToInt32(reader["Codigo"]);
                    s.Nombre = reader["Nombre"].ToString();
                    s.FechaFinal = (DateTime)(reader["FechaFinal"]);
                    s.FechaInicio = (DateTime)(reader["FechaInicio"]);
                }

            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                conexion.Close();
            }

            return null;
        }

    }
    
}
