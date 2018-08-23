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
    public class EntrevistaEstudianteDatos
    {

        public void InsertarArchivos(int Id, Archivo archivo)
        {
            // SqlConnection requiere el using System.Data.SqlClient;
            SqlConnection conexion = new SqlConnection(Conexion.Cadena);
            try
            {
                conexion.Open(); // un error aca: revisar cadena de conexion
                // El command permite ejecutar un comando en la conexion establecida
                SqlCommand comando = new SqlCommand("PA_InsertarEntrevistaEstudianteArchivos", conexion);
                // Como es en Store Procedure se debe indicar el tipo de comando
                comando.CommandType = System.Data.CommandType.StoredProcedure;
                // Si el SP requeire parametros se le deben asignar al comando

                comando.Parameters.AddWithValue("@IdEntrevista", Id);
                comando.Parameters.AddWithValue("@Archivo", archivo.ArchivoBytes);
                comando.Parameters.AddWithValue("@Nombre", archivo.Nombre);


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
        public void Insertar(EntrevistaEstudiante entEst)
        {
            // SqlConnection requiere el using System.Data.SqlClient;
            SqlConnection conexion = new SqlConnection(Conexion.Cadena);
            try
            {
                conexion.Open(); // un error aca: revisar cadena de conexion
                // El command permite ejecutar un comando en la conexion establecida
                SqlCommand comando = new SqlCommand("PA_InsertarEntrevistaEstudiante", conexion);
                // Como es en Store Procedure se debe indicar el tipo de comando
                comando.CommandType = System.Data.CommandType.StoredProcedure;
                // Si el SP requeire parametros se le deben asignar al comando

                comando.Parameters.AddWithValue("@Recomendaciones", entEst.Recomendaciones);
                comando.Parameters.AddWithValue("@DetecciondelProfesional", entEst.DetecciondelProfesional);
                comando.Parameters.AddWithValue("@Referencia", entEst.Referencia);
                comando.Parameters.AddWithValue("@Solicitud", entEst.Solicitud);
                comando.Parameters.AddWithValue("@Otros", entEst.Otros);
                comando.Parameters.AddWithValue("@OtrosExplicacion", entEst.OtrosExplicacion);
                comando.Parameters.AddWithValue("@Situacion", entEst.Situacion);
                comando.Parameters.AddWithValue("@Acciones", entEst.Acciones);
                comando.Parameters.AddWithValue("@Intervencion", entEst.Intervencion);
                comando.Parameters.AddWithValue("@IdMotivo", entEst.Motivo.IdMotivo);
                comando.Parameters.AddWithValue("@IdExpediente", entEst.IdExpediente);
                comando.Parameters.AddWithValue("@TipoInstrumento", entEst.TipoInstrumento);
                // Finalmente ejecutamos el comando
                // al ser un insert no requiere retornar un consulta
                int Id = Convert.ToInt32(comando.ExecuteScalar());
                if(entEst.Archivos.Count > 0)
                {
                    foreach (var archivo in entEst.Archivos)
                    {
                        InsertarArchivos(Id, archivo);
                    }
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
        }

        public void Actualizar(EntrevistaEstudiante entEst)
        {
            // SqlConnection requiere el using System.Data.SqlClient;
            SqlConnection conexion = new SqlConnection(Conexion.Cadena);
            try
            {
                conexion.Open(); // un error aca: revisar cadena de conexion
                // El command permite ejecutar un comando en la conexion establecida
                SqlCommand comando = new SqlCommand("PA_ActualizarEntrevistaEstudiante", conexion);
                // Como es en Store Procedure se debe indicar el tipo de comando
                comando.CommandType = System.Data.CommandType.StoredProcedure;
                // Si el SP requeire parametros se le deben asignar al comando

                comando.Parameters.AddWithValue("@Id", entEst.Id);


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

        public List<EntrevistaEstudiante> SeleccionarTodos()
        {
            // SqlConnection requiere el using System.Data.SqlClient;
            SqlConnection conexion = new SqlConnection(Conexion.Cadena);
            List<EntrevistaEstudiante> lista = new List<EntrevistaEstudiante>();
            try
            {
                conexion.Open(); // un error aca: revisar cadena de conexion
                // El command permite ejecutar un comando en la conexion establecida
                SqlCommand comando = new SqlCommand("PA_SeleccionarEntrevistaEstudiante", conexion);
                // Como es en Store Procedure se debe indicar el tipo de comando
                comando.CommandType = System.Data.CommandType.StoredProcedure;
                // NO recibe parametros
                // Finalmente ejecutamos el comando
                // al ser una consulta debemos usar ExecuteReader
                SqlDataReader reader = comando.ExecuteReader();
                // es necesario recorrer el reader para extraer todos los registros
                while (reader.Read()) // cada vez que se llama el Read retorna una tupla
                {
                    EntrevistaEstudiante entEst = new EntrevistaEstudiante();

                    entEst.Id = Convert.ToInt32(reader["Id"]);
                    lista.Add(entEst);
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

        public List<Archivo> SeleccionarArchivosPorId(int Id)
        {
            // SqlConnection requiere el using System.Data.SqlClient;
            SqlConnection conexion = new SqlConnection(Conexion.Cadena);
            List<Archivo> lista = new List<Archivo>();
            try
            {
                conexion.Open(); // un error aca: revisar cadena de conexion
                // El command permite ejecutar un comando en la conexion establecida
                SqlCommand comando = new SqlCommand("PA_SeleccionarEntrevistaEstudianteArchivosPorId", conexion);
                // Como es en Store Procedure se debe indicar el tipo de comando
                comando.CommandType = System.Data.CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@IdEntrevista", Id);
                // NO recibe parametros

                // Finalmente ejecutamos el comando
                // al ser una consulta debemos usar ExecuteReader
                SqlDataReader reader = comando.ExecuteReader();
                // es necesario recorrer el reader para extraer todos los registros
                while (reader.Read()) // cada vez que se llama el Read retorna una tupla
                {
                    Archivo ar = new Archivo();
                    ar.Id = Convert.ToInt32(reader["Id"]);
                    ar.Nombre = reader["Nombre"].ToString();
                    ar.ArchivoBytes = (byte[]) reader["Archivo"];
                    lista.Add(ar);
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
        public List<EntrevistaEstudiante> SeleccionarPorExpedienteId(int IdExpediente)
        {
            // SqlConnection requiere el using System.Data.SqlClient;
            SqlConnection conexion = new SqlConnection(Conexion.Cadena);
            List<EntrevistaEstudiante> lista = new List<EntrevistaEstudiante>();
            try
            {
                conexion.Open(); // un error aca: revisar cadena de conexion
                // El command permite ejecutar un comando en la conexion establecida
                SqlCommand comando = new SqlCommand("PA_SeleccionarEntrevistaEstudiantePorExpediente", conexion);
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
                    EntrevistaEstudiante entEst = new EntrevistaEstudiante();
                    entEst.Id = Convert.ToInt32(reader["Id"]);
                    entEst.FechaCreacion = Convert.ToDateTime(reader["FechaCreacion"]);
                    entEst.TipoInstrumento = TipoInstrumentos.EntrevistaEstudiante;
                    entEst.Motivo = new MotivoAtencionDatos().SeleccionarporId(Convert.ToInt32(reader["IdMotivo"]));
                    entEst.Situacion = reader["Situacion"].ToString();
                    entEst.Acciones = reader["Acciones"].ToString();
                    entEst.Intervencion = reader["Intervencion"].ToString();
                    entEst.Recomendaciones = reader["Recomendaciones"].ToString();
                    entEst.DetecciondelProfesional = (bool)reader["DetecciondelProfesional"];
                    entEst.Referencia = (bool)reader["Referencia"];
                    entEst.Otros = (bool)reader["Otros"];
                    entEst.OtrosExplicacion = reader["OtrosExplicacion"].ToString();
                    lista.Add(entEst);
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

        public EntrevistaEstudiante SeleccionarPorId(int Id)
        {
            // SqlConnection requiere el using System.Data.SqlClient;
            SqlConnection conexion = new SqlConnection(Conexion.Cadena);
            try
            {
                conexion.Open(); // un error aca: revisar cadena de conexion
                // El command permite ejecutar un comando en la conexion establecida
                SqlCommand comando = new SqlCommand("PA_SeleccionarEntrevistaEstudiantePorId", conexion);
                // Como es en Store Procedure se debe indicar el tipo de comando
                comando.CommandType = System.Data.CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@Id", Id);
                // Finalmente ejecutamos el comando
                // al ser una consulta debemos usar ExecuteReader
                SqlDataReader reader = comando.ExecuteReader();
                // es necesario recorrer el reader para extraer todos los registros
                while (reader.Read()) // cada vez que se llama el Read retorna una tupla
                {
                    EntrevistaEstudiante entEst = new EntrevistaEstudiante();
                    entEst.Id = Convert.ToInt32(reader["Id"]);
                    entEst.FechaCreacion = Convert.ToDateTime(reader["FechaCreacion"]);
                    entEst.Motivo = new MotivoAtencionDatos().SeleccionarporId(Convert.ToInt32(reader["IdMotivo"]));
                    entEst.Situacion = reader["Situacion"].ToString();
                    entEst.Acciones = reader["Acciones"].ToString();
                    entEst.Intervencion = reader["Intervencion"].ToString();
                    entEst.Recomendaciones = reader["Recomendaciones"].ToString();
                    entEst.DetecciondelProfesional = (bool)reader["DetecciondelProfesional"];
                    entEst.Referencia = (bool)reader["Referencia"];
                    entEst.Otros = (bool)reader["Otros"];
                    entEst.OtrosExplicacion = reader["OtrosExplicacion"].ToString();
                    entEst.TipoInstrumento = TipoInstrumentos.EntrevistaEstudiante;
                    entEst.Archivos = SeleccionarArchivosPorId(entEst.Id);

                    return entEst;
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

    