using Capa.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;


namespace Capa.Datos
{
    public class EncargadoDatos
    {

        public void Insertar(Encargado enc)
        {
            // SqlConnection requiere el using System.Data.SqlClient;
            SqlConnection conexion = new SqlConnection(Conexion.Cadena);
            try
            {
                conexion.Open(); // un error aca: revisar cadena de conexion
                // El command permite ejecutar un comando en la conexion establecida
                SqlCommand comando = new SqlCommand("PA_InsertarEncargado", conexion);
                // Como es en Store Procedure se debe indicar el tipo de comando
                comando.CommandType = System.Data.CommandType.StoredProcedure;
                // Si el SP requeire parametros se le deben asignar al comando
                comando.Parameters.AddWithValue("@Identificacion", enc.Identificacion);
                comando.Parameters.AddWithValue("@NombreCompleto", enc.NombreCompleto);
                comando.Parameters.AddWithValue("@CorreoElectronico", enc.CorreoElectronico);
                comando.Parameters.AddWithValue("@Ocupacion", enc.Ocupacion);
                comando.Parameters.AddWithValue("@Parentesco", enc.Parentesco);
               // comando.Parameters.AddWithValue("@Telefonos", enc.listaTelefonos);


                // Finalmente ejecutamos el comando
                // al ser un insert no requiere retornar un consulta
                comando.ExecuteNonQuery();
            }
            catch (Exception )
            {
                throw;
            }
            finally
            {
                conexion.Close();
            }
        }

        public void Actualizar(Encargado enc)
        {
            // SqlConnection requiere el using System.Data.SqlClient;
            SqlConnection conexion = new SqlConnection(Conexion.Cadena);
            try
            {
                conexion.Open(); // un error aca: revisar cadena de conexion
                // El command permite ejecutar un comando en la conexion establecida
                SqlCommand comando = new SqlCommand("PA_ActualizarEncargado", conexion);
                // Como es en Store Procedure se debe indicar el tipo de comando
                comando.CommandType = System.Data.CommandType.StoredProcedure;
                // Si el SP requeire parametros se le deben asignar al comando
                comando.Parameters.AddWithValue("@Identificacion", enc.Identificacion);
                comando.Parameters.AddWithValue("@NombreCompleto", enc.NombreCompleto);
                comando.Parameters.AddWithValue("@CorreoElectronico", enc.CorreoElectronico);
                comando.Parameters.AddWithValue("@Ocupacion", enc.Ocupacion);
                comando.Parameters.AddWithValue("@Parentesco", enc.Parentesco);
                //comando.Parameters.AddWithValue("@Telefonos", enc.listaTelefonos);


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

        //public void Eliminar(int EncargadoId)
        //{
        //    Encargado enc = new Encargado();
        //    enc.Identificacion = EncargadoId.ToString();
        //    this.Eliminar(enc);
        //}
        public void Eliminar(Encargado enc)
        {
            // SqlConnection requiere el using System.Data.SqlClient;
            SqlConnection conexion = new SqlConnection(Conexion.Cadena);
            try
            {
                conexion.Open(); // un error aca: revisar cadena de conexion
                // El command permite ejecutar un comando en la conexion establecida
                SqlCommand comando = new SqlCommand("PA_EliminarEncargado", conexion);
                // Como es en Store Procedure se debe indicar el tipo de comando
                comando.CommandType = System.Data.CommandType.StoredProcedure;
                // Si el SP requeire parametros se le deben asignar al comando
                comando.Parameters.AddWithValue("@Identificacion", enc.Identificacion);
               
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

        public List<Encargado> SeleccionarTodos()
        {
            // SqlConnection requiere el using System.Data.SqlClient;
            SqlConnection conexion = new SqlConnection(Conexion.Cadena);
            List<Encargado> lista = new List<Encargado>();
            try
            {
                conexion.Open(); // un error aca: revisar cadena de conexion
                // El command permite ejecutar un comando en la conexion establecida
                SqlCommand comando = new SqlCommand("PA_SeleccionarEncargado", conexion);
                // Como es en Store Procedure se debe indicar el tipo de comando
                comando.CommandType = System.Data.CommandType.StoredProcedure;
                // NO recibe parametros
                // Finalmente ejecutamos el comando
                // al ser una consulta debemos usar ExecuteReader
                SqlDataReader reader = comando.ExecuteReader();
                // es necesario recorrer el reader para extraer todos los registros
                while (reader.Read()) // cada vez que se llama el Read retorna una tupla
                {
                    Encargado enc = new Encargado();
                    enc.Identificacion = reader["Identificacion"].ToString();
                    enc.NombreCompleto = reader["NombreCompleto"].ToString();
                    enc.CorreoElectronico = reader["CorreoElectronico"].ToString();
                    enc.Parentesco = reader["Parentesco"].ToString();
                    enc.Ocupacion = reader["Ocupacion"].ToString();
                    lista.Add(enc);
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

        public Encargado SeleccionarPorId(string Identificacion)
        {
            // SqlConnection requiere el using System.Data.SqlClient;
            SqlConnection conexion = new SqlConnection(Conexion.Cadena);
            try
            {
                conexion.Open(); // un error aca: revisar cadena de conexion
                // El command permite ejecutar un comando en la conexion establecida
                SqlCommand comando = new SqlCommand("PA_SeleccionarEncargadoPorId", conexion);
                // Como es en Store Procedure se debe indicar el tipo de comando
                comando.CommandType = System.Data.CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@Identificacion", Identificacion);
                // Finalmente ejecutamos el comando
                // al ser una consulta debemos usar ExecuteReader
                SqlDataReader reader = comando.ExecuteReader();
                // es necesario recorrer el reader para extraer todos los registros
                while (reader.Read()) // cada vez que se llama el Read retorna una tupla
                {
                    Encargado enc = new Encargado();
                    enc.Identificacion = reader["Identificacion"].ToString();
                    enc.NombreCompleto = reader["NombreCompleto"].ToString();
                    enc.CorreoElectronico = reader["CorreoElectronico"].ToString();
                    enc.Ocupacion = reader["Ocupacion"].ToString();
                    enc.Parentesco = reader["Parentesco"].ToString();


                    return enc;
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



