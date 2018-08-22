using Capa.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Capa.Entidades.Enumeradores;

namespace Capa.Datos.Instrumentos
{
   public  class EntrevistaEncargadoDatos
    {
        public void Insertar(EntrevistaEncargado entEnc)
        {
            // SqlConnection requiere el using System.Data.SqlClient;
            SqlConnection conexion = new SqlConnection(Conexion.Cadena);
            try
            {
                conexion.Open(); // un error aca: revisar cadena de conexion
                // El command permite ejecutar un comando en la conexion establecida
                SqlCommand comando = new SqlCommand("PA_InsertarEntrevistaEncargado", conexion);
                // Como es en Store Procedure se debe indicar el tipo de comando
                comando.CommandType = System.Data.CommandType.StoredProcedure;
                // Si el SP requeire parametros se le deben asignar al comando

                comando.Parameters.AddWithValue("@Recomendaciones", entEnc.Recomendaciones);
                comando.Parameters.AddWithValue("@ConvocadoPorInstitucion", entEnc.ConvocadoPorInstitucion);
                comando.Parameters.AddWithValue("@ConvocadoPorEncargado", entEnc.ConvocadoPorEncargado);
                comando.Parameters.AddWithValue("@Situacion", entEnc.Situacion);
                comando.Parameters.AddWithValue("@Acciones", entEnc.Acciones);
                comando.Parameters.AddWithValue("@Intervencion", entEnc.Intervencion);
                comando.Parameters.AddWithValue("@IdMotivo", entEnc.Motivo.IdMotivo);
                comando.Parameters.AddWithValue("@IdExpediente", entEnc.IdExpediente);
                comando.Parameters.AddWithValue("@TipoInstrumento", entEnc.TipoInstrumento);


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

        public void Actualizar(EntrevistaEncargado entEnc)
        {
            // SqlConnection requiere el using System.Data.SqlClient;
            SqlConnection conexion = new SqlConnection(Conexion.Cadena);
            try
            {
                conexion.Open(); // un error aca: revisar cadena de conexion
                // El command permite ejecutar un comando en la conexion establecida
                SqlCommand comando = new SqlCommand("PA_ActualizarEntrevistaEncargado", conexion);
                // Como es en Store Procedure se debe indicar el tipo de comando
                comando.CommandType = System.Data.CommandType.StoredProcedure;
                // Si el SP requeire parametros se le deben asignar al comando

                comando.Parameters.AddWithValue("@Numero", entEnc.Id);


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
        public List<EntrevistaEncargado> SeleccionarPorExpedienteId(int IdExpediente)
        {
            // SqlConnection requiere el using System.Data.SqlClient;
            SqlConnection conexion = new SqlConnection(Conexion.Cadena);
            List<EntrevistaEncargado> lista = new List<EntrevistaEncargado>();
            try
            {
                conexion.Open(); // un error aca: revisar cadena de conexion
                // El command permite ejecutar un comando en la conexion establecida
                SqlCommand comando = new SqlCommand("PA_SeleccionarEntrevistaEncargadoPorExpediente", conexion);
                // Como es en Store Procedure se debe indicar el tipo de comando
                comando.CommandType = System.Data.CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@IdExpediente", IdExpediente);
                // NO recibe parametros
                // Finalmente ejecutamos el comando
                // al ser una consulta debemos usar ExecuteReader
                SqlDataReader reader = comando.ExecuteReader();
                // es necesario recorrer el reader para extraer todos los registros
                while (reader.Read()) // cada vez que se llama el Read retorna una tupla
                {
                    EntrevistaEncargado entEnc = new EntrevistaEncargado();
                    entEnc.Id = Convert.ToInt32(reader["Id"]);
                    entEnc.FechaCreacion = Convert.ToDateTime(reader["FechaCreacion"]);
                    entEnc.Motivo = new MotivoAtencionDatos().SeleccionarporId(Convert.ToInt32(reader["IdMotivo"]));
                    entEnc.Situacion = reader["Situacion"].ToString();
                    entEnc.Acciones = reader["Acciones"].ToString();
                    entEnc.Intervencion = reader["Intervencion"].ToString();
                    entEnc.Recomendaciones = reader["Recomendaciones"].ToString();
                    entEnc.ConvocadoPorInstitucion = (bool)reader["ConvocadoPorInstitucion"];
                    entEnc.ConvocadoPorEncargado = (bool)reader["ConvocadoPorEncargado"];
                    entEnc.TipoInstrumento = (TipoInstrumentos)Convert.ToInt32(reader["TipoInstrumento"]);
                    lista.Add(entEnc);
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
        //public void Eliminar(int EncargadoId)
        //{
        //    Encargado enc = new Encargado();
        //    enc.Identificacion = EncargadoId.ToString();
        //    this.Eliminar(enc);
        //}
        //public void Eliminar(Encargado enc)
        //{
        //    // SqlConnection requiere el using System.Data.SqlClient;
        //    SqlConnection conexion = new SqlConnection(Conexion.Cadena);
        //    try
        //    {
        //        conexion.Open(); // un error aca: revisar cadena de conexion
        //        // El command permite ejecutar un comando en la conexion establecida
        //        SqlCommand comando = new SqlCommand("PA_EliminarEncargado", conexion);
        //        // Como es en Store Procedure se debe indicar el tipo de comando
        //        comando.CommandType = System.Data.CommandType.StoredProcedure;
        //        // Si el SP requeire parametros se le deben asignar al comando
        //        comando.Parameters.AddWithValue("@Identificacion", enc.Identificacion);

        //        // al ser un update no requiere retornar un consulta
        //        comando.ExecuteNonQuery();
        //    }
        //    catch (Exception)
        //    {
        //        throw;
        //    }
        //    finally
        //    {
        //        conexion.Close();
        //    }
        //}

        public List<EntrevistaEncargado> SeleccionarTodos()
        {
            // SqlConnection requiere el using System.Data.SqlClient;
            SqlConnection conexion = new SqlConnection(Conexion.Cadena);
            List<EntrevistaEncargado> lista = new List<EntrevistaEncargado>();
            try
            {
                conexion.Open(); // un error aca: revisar cadena de conexion
                // El command permite ejecutar un comando en la conexion establecida
                SqlCommand comando = new SqlCommand("PA_SeleccionarEntrevistaEncargado", conexion);
                // Como es en Store Procedure se debe indicar el tipo de comando
                comando.CommandType = System.Data.CommandType.StoredProcedure;
                // NO recibe parametros
                // Finalmente ejecutamos el comando
                // al ser una consulta debemos usar ExecuteReader
                SqlDataReader reader = comando.ExecuteReader();
                // es necesario recorrer el reader para extraer todos los registros
                while (reader.Read()) // cada vez que se llama el Read retorna una tupla
                {
                    EntrevistaEncargado entEnc = new EntrevistaEncargado();

                    entEnc.Id = Convert.ToInt32(reader["Numero"]);
                    lista.Add(entEnc);
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

        public EntrevistaEncargado SeleccionarPorId(int Id)
        {
            // SqlConnection requiere el using System.Data.SqlClient;
            SqlConnection conexion = new SqlConnection(Conexion.Cadena);
            try
            {
                conexion.Open(); // un error aca: revisar cadena de conexion
                // El command permite ejecutar un comando en la conexion establecida
                SqlCommand comando = new SqlCommand("PA_SeleccionarEntrevistaEncargadoPorId", conexion);
                // Como es en Store Procedure se debe indicar el tipo de comando
                comando.CommandType = System.Data.CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@Id", Id);
                // Finalmente ejecutamos el comando
                // al ser una consulta debemos usar ExecuteReader
                SqlDataReader reader = comando.ExecuteReader();
                // es necesario recorrer el reader para extraer todos los registros
                while (reader.Read()) // cada vez que se llama el Read retorna una tupla
                {                    
                    EntrevistaEncargado entEnc = new EntrevistaEncargado();
                    entEnc.Id = Convert.ToInt32(reader["Id"]);
                    entEnc.FechaCreacion = Convert.ToDateTime(reader["FechaCreacion"]);
                    entEnc.Motivo = new MotivoAtencionDatos().SeleccionarporId(Convert.ToInt32(reader["IdMotivo"]));
                    entEnc.Situacion = reader["Situacion"].ToString();
                    entEnc.Acciones = reader["Acciones"].ToString();
                    entEnc.Intervencion = reader["Intervencion"].ToString();
                    entEnc.Recomendaciones = reader["Recomendaciones"].ToString();
                    entEnc.ConvocadoPorInstitucion = (bool)reader["ConvocadoPorInstitucion"];
                    entEnc.ConvocadoPorInstitucion= (bool)reader["ConvocadoPorInstitucion"];
                    return entEnc;
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

    

