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
    public class ReferenciaDatos
    {
        public void Insertar(Referencia entFun)
        {
            // SqlConnection requiere el using System.Data.SqlClient;
            SqlConnection conexion = new SqlConnection(Conexion.Cadena);
            try
            {
                conexion.Open(); // un error aca: revisar cadena de conexion
                // El command permite ejecutar un comando en la conexion establecida
                SqlCommand comando = new SqlCommand("PA_InsertarReferenciaExterna", conexion);
                // Como es en Store Procedure se debe indicar el tipo de comando
                comando.CommandType = System.Data.CommandType.StoredProcedure;
                // Si el SP requeire parametros se le deben asignar al comando

                comando.Parameters.AddWithValue("@Recomendaciones", entFun.Recomendaciones);
                comando.Parameters.AddWithValue("@PersonaRefiere", entFun.PersonaRefiere);
                comando.Parameters.AddWithValue("@Puesto", entFun.Puesto);
                comando.Parameters.AddWithValue("@Situacion", entFun.Situacion);
                comando.Parameters.AddWithValue("@Acciones", entFun.Acciones);
                comando.Parameters.AddWithValue("@Intervencion", entFun.Intervencion);
                comando.Parameters.AddWithValue("@IdMotivo", entFun.Motivo.IdMotivo);
                comando.Parameters.AddWithValue("@IdExpediente", entFun.IdExpediente);
                comando.Parameters.AddWithValue("@InstitucionRefiere", entFun.InstitucionRefiere);
                comando.Parameters.AddWithValue("@TipoInstrumento", entFun.TipoInstrumento);
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

        public void Actualizar(Referencia refe)
        {
            // SqlConnection requiere el using System.Data.SqlClient;
            SqlConnection conexion = new SqlConnection(Conexion.Cadena);
            try
            {
                conexion.Open(); // un error aca: revisar cadena de conexion
                // El command permite ejecutar un comando en la conexion establecida
                SqlCommand comando = new SqlCommand("PA_ActualizarReferencia", conexion);
                // Como es en Store Procedure se debe indicar el tipo de comando
                comando.CommandType = System.Data.CommandType.StoredProcedure;
                // Si el SP requeire parametros se le deben asignar al comando
            
                comando.Parameters.AddWithValue("@Id", refe.Id);


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

        public List<Referencia> SeleccionarTodos()
        {
            // SqlConnection requiere el using System.Data.SqlClient;
            SqlConnection conexion = new SqlConnection(Conexion.Cadena);
            List<Referencia> lista = new List<Referencia>();
            try
            {
                conexion.Open(); // un error aca: revisar cadena de conexion
                // El command permite ejecutar un comando en la conexion establecida
                SqlCommand comando = new SqlCommand("PA_SeleccionarReferencia", conexion);
                // Como es en Store Procedure se debe indicar el tipo de comando
                comando.CommandType = System.Data.CommandType.StoredProcedure;
                // NO recibe parametros
                // Finalmente ejecutamos el comando
                // al ser una consulta debemos usar ExecuteReader
                SqlDataReader reader = comando.ExecuteReader();
                // es necesario recorrer el reader para extraer todos los registros
                while (reader.Read()) // cada vez que se llama el Read retorna una tupla
                {
                    Referencia refe = new Referencia();

                    refe.Id= Convert.ToInt32(reader["Id"]);
                    lista.Add(refe);
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

        public Referencia SeleccionarPorId(int Id)
        {
            // SqlConnection requiere el using System.Data.SqlClient;
            SqlConnection conexion = new SqlConnection(Conexion.Cadena);
            try
            {
                conexion.Open(); // un error aca: revisar cadena de conexion
                // El command permite ejecutar un comando en la conexion establecida
                SqlCommand comando = new SqlCommand("PA_SeleccionarReferenciaExternaPorId", conexion);
                // Como es en Store Procedure se debe indicar el tipo de comando
                comando.CommandType = System.Data.CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@Id", Id);
                // Finalmente ejecutamos el comando
                // al ser una consulta debemos usar ExecuteReader
                SqlDataReader reader = comando.ExecuteReader();
                // es necesario recorrer el reader para extraer todos los registros
                while (reader.Read()) // cada vez que se llama el Read retorna una tupla
                {                    
                    Referencia refe = new Referencia();
                    refe.FechaCreacion = Convert.ToDateTime(reader["FechaCreacion"]);
                    refe.Motivo = new MotivoAtencionDatos().SeleccionarporId(Convert.ToInt32(reader["IdMotivo"]));
                    refe.Id = Convert.ToInt32(reader["Id"]);
                    refe.Situacion = reader["Situacion"].ToString();
                    refe.Acciones = reader["Acciones"].ToString();
                    refe.Intervencion = reader["Intervencion"].ToString();
                    refe.Recomendaciones = reader["Recomendaciones"].ToString();
                    refe.PersonaRefiere = reader["PersonaRefiere"].ToString();
                    refe.Puesto = reader["Puesto"].ToString();
                    refe.InstitucionRefiere = reader["InstitucionRefiere"].ToString();

                    return refe;


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
        public List<Referencia> SeleccionarPorExpedienteId(int IdExpediente)
        {
            // SqlConnection requiere el using System.Data.SqlClient;
            SqlConnection conexion = new SqlConnection(Conexion.Cadena);
            List<Referencia> lista = new List<Referencia>();
            try
            {
                conexion.Open(); // un error aca: revisar cadena de conexion
                // El command permite ejecutar un comando en la conexion establecida
                SqlCommand comando = new SqlCommand("PA_SeleccionarReferenciaPorExpediente", conexion);
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
                    Referencia ent = new Referencia();
                    ent.Id = Convert.ToInt32(reader["Id"]);
                    ent.FechaCreacion = Convert.ToDateTime(reader["FechaCreacion"]);
                    ent.Motivo = new MotivoAtencionDatos().SeleccionarporId(Convert.ToInt32(reader["IdMotivo"]));
                    ent.Situacion = reader["Situacion"].ToString();
                    ent.Acciones = reader["Acciones"].ToString();
                    ent.Intervencion = reader["Intervencion"].ToString();
                    ent.Recomendaciones = reader["Recomendaciones"].ToString();
                    ent.PersonaRefiere = reader["PersonaRefiere"].ToString();
                    ent.InstitucionRefiere = reader["InstitucionRefiere"].ToString();
                    ent.Puesto = reader["Puesto"].ToString();
                    ent.TipoInstrumento = (TipoInstrumentos)Convert.ToInt32(reader["TipoInstrumento"]);
                    lista.Add(ent);
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
    }
}
