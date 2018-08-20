using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Capa.Entidades;
using Capa.Entidades.Enumeradores;

namespace Capa.Datos.Instrumentos
{
    public class EntrevistaFuncionarioDatos
    {
        public void Insertar(EntrevistaFuncionario entFun)
        {
            // SqlConnection requiere el using System.Data.SqlClient;
            SqlConnection conexion = new SqlConnection(Conexion.Cadena);
            try
            {
                conexion.Open(); // un error aca: revisar cadena de conexion
                // El command permite ejecutar un comando en la conexion establecida
                SqlCommand comando = new SqlCommand("PA_InsertarEntrevistaFuncionario", conexion);
                // Como es en Store Procedure se debe indicar el tipo de comando
                comando.CommandType = System.Data.CommandType.StoredProcedure;
                // Si el SP requeire parametros se le deben asignar al comando

                comando.Parameters.AddWithValue("@Recomendaciones", entFun.Recomendaciones);
                comando.Parameters.AddWithValue("@NombreFuncionario", entFun.NombreFuncionario);
                comando.Parameters.AddWithValue("@Puesto", entFun.Puesto);
                comando.Parameters.AddWithValue("@Situacion", entFun.Situacion);
                comando.Parameters.AddWithValue("@Acciones", entFun.Acciones);
                comando.Parameters.AddWithValue("@Intervencion", entFun.Intervencion);
                comando.Parameters.AddWithValue("@IdMotivo", entFun.Motivo.IdMotivo);
                comando.Parameters.AddWithValue("@IdExpediente", entFun.IdExpediente);
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

        public void Actualizar(EntrevistaFuncionario entFun)
        {
            // SqlConnection requiere el using System.Data.SqlClient;
            SqlConnection conexion = new SqlConnection(Conexion.Cadena);
            try
            {
                conexion.Open(); // un error aca: revisar cadena de conexion
                // El command permite ejecutar un comando en la conexion establecida
                SqlCommand comando = new SqlCommand("PA_ActualizarEntrevistaFuncionario", conexion);
                // Como es en Store Procedure se debe indicar el tipo de comando
                comando.CommandType = System.Data.CommandType.StoredProcedure;
                // Si el SP requeire parametros se le deben asignar al comando

                comando.Parameters.AddWithValue("@Numero", entFun.Id);


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

        public List<EntrevistaFuncionario> SeleccionarTodos()
        {
            // SqlConnection requiere el using System.Data.SqlClient;
            SqlConnection conexion = new SqlConnection(Conexion.Cadena);
            List<EntrevistaFuncionario> lista = new List<EntrevistaFuncionario>();
            try
            {
                conexion.Open(); // un error aca: revisar cadena de conexion
                // El command permite ejecutar un comando en la conexion establecida
                SqlCommand comando = new SqlCommand("PA_SeleccionarEntrevistaFuncionario", conexion);
                // Como es en Store Procedure se debe indicar el tipo de comando
                comando.CommandType = System.Data.CommandType.StoredProcedure;
                // NO recibe parametros
                // Finalmente ejecutamos el comando
                // al ser una consulta debemos usar ExecuteReader
                SqlDataReader reader = comando.ExecuteReader();
                // es necesario recorrer el reader para extraer todos los registros
                while (reader.Read()) // cada vez que se llama el Read retorna una tupla
                {
                    EntrevistaFuncionario entFun = new EntrevistaFuncionario();

                    entFun.Id= Convert.ToInt32(reader["Id"]);
                    lista.Add(entFun);
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

        public EntrevistaFuncionario SeleccionarPorId(int Id)
        {
            // SqlConnection requiere el using System.Data.SqlClient;
            SqlConnection conexion = new SqlConnection(Conexion.Cadena);
            try
            {
                conexion.Open(); // un error aca: revisar cadena de conexion
                // El command permite ejecutar un comando en la conexion establecida
                SqlCommand comando = new SqlCommand("PA_SeleccionarEntrevistaFuncionarioPorId", conexion);
                // Como es en Store Procedure se debe indicar el tipo de comando
                comando.CommandType = System.Data.CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@Id", Id);
                // Finalmente ejecutamos el comando
                // al ser una consulta debemos usar ExecuteReader
                SqlDataReader reader = comando.ExecuteReader();
                // es necesario recorrer el reader para extraer todos los registros
                while (reader.Read()) // cada vez que se llama el Read retorna una tupla
                {
                    EntrevistaFuncionario entFun = new EntrevistaFuncionario();
                    entFun.FechaCreacion = Convert.ToDateTime(reader["FechaCreacion"]);
                    entFun.Motivo = new MotivoAtencionDatos().SeleccionarporId(Convert.ToInt32(reader["IdMotivo"]));
                    entFun.Situacion = reader["Situacion"].ToString();
                    entFun.Acciones = reader["Acciones"].ToString();
                    entFun.Intervencion = reader["Intervencion"].ToString();
                    entFun.Recomendaciones = reader["Recomendaciones"].ToString();
                    entFun.NombreFuncionario = reader["NombreFuncionario"].ToString();
                    entFun.Puesto = reader["Puesto"].ToString();

                    return entFun;
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
        public List<EntrevistaFuncionario> SeleccionarPorExpedienteId(int IdExpediente)
        {
            // SqlConnection requiere el using System.Data.SqlClient;
            SqlConnection conexion = new SqlConnection(Conexion.Cadena);
            List<EntrevistaFuncionario> lista = new List<EntrevistaFuncionario>();
            try
            {
                conexion.Open(); // un error aca: revisar cadena de conexion
                // El command permite ejecutar un comando en la conexion establecida
                SqlCommand comando = new SqlCommand("PA_SeleccionarEntrevistaFuncionarioPorExpediente", conexion);
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
                    EntrevistaFuncionario entEnc = new EntrevistaFuncionario();
                    entEnc.Id = Convert.ToInt32(reader["Id"]);
                    entEnc.FechaCreacion = Convert.ToDateTime(reader["FechaCreacion"]);
                    entEnc.Motivo = new MotivoAtencionDatos().SeleccionarporId(Convert.ToInt32(reader["IdMotivo"]));
                    entEnc.Situacion = reader["Situacion"].ToString();
                    entEnc.Acciones = reader["Acciones"].ToString();
                    entEnc.Intervencion = reader["Intervencion"].ToString();
                    entEnc.Recomendaciones = reader["Recomendaciones"].ToString();
                    entEnc.NombreFuncionario= reader["NombreFuncionario"].ToString();
                    entEnc.Puesto = reader["Puesto"].ToString();
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
    }
}