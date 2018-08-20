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
    public class InformeVistaHogarDatos
    {

        public void Insertar(InformeVisitaAlHogar ent)
        {
            // SqlConnection requiere el using System.Data.SqlClient;
            SqlConnection conexion = new SqlConnection(Conexion.Cadena);
            try
            {
                conexion.Open(); // un error aca: revisar cadena de conexion
                // El command permite ejecutar un comando en la conexion establecida
                SqlCommand comando = new SqlCommand("PA_InsertarInformeVisitaAlHogar", conexion);
                // Como es en Store Procedure se debe indicar el tipo de comando
                comando.CommandType = System.Data.CommandType.StoredProcedure;
                // Si el SP requeire parametros se le deben asignar al comando


                comando.Parameters.AddWithValue("@Recomendaciones", ent.Recomendaciones);
                comando.Parameters.AddWithValue("@NombreFuncionario", ent.NombreFuncionario);
                comando.Parameters.AddWithValue("@Puesto", ent.Puesto);
                comando.Parameters.AddWithValue("@Situacion", ent.Situacion);
                comando.Parameters.AddWithValue("@Acciones", ent.Acciones);
                comando.Parameters.AddWithValue("@Intervencion", ent.Intervencion);
                comando.Parameters.AddWithValue("@IdMotivo", ent.Motivo.IdMotivo);
                comando.Parameters.AddWithValue("@IdExpediente", ent.IdExpediente);
                comando.Parameters.AddWithValue("@TipoInstrumento", ent.TipoInstrumento);





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

        public void Actualizar(InformeVisitaAlHogar ent)
        {
            // SqlConnection requiere el using System.Data.SqlClient;
            SqlConnection conexion = new SqlConnection(Conexion.Cadena);
            try
            {
                conexion.Open(); // un error aca: revisar cadena de conexion
                // El command permite ejecutar un comando en la conexion establecida
                SqlCommand comando = new SqlCommand("PA_ActualizarInformeVistaAlHogar", conexion);
                // Como es en Store Procedure se debe indicar el tipo de comando
                comando.CommandType = System.Data.CommandType.StoredProcedure;
                // Si el SP requeire parametros se le deben asignar al comando

                comando.Parameters.AddWithValue("@Recomendaciones", ent.Recomendaciones);
                comando.Parameters.AddWithValue("@NombreFuncionario", ent.NombreFuncionario);
                comando.Parameters.AddWithValue("@Puesto", ent.Puesto);
                comando.Parameters.AddWithValue("@Situacion", ent.Situacion);
                comando.Parameters.AddWithValue("@Acciones", ent.Acciones);
                comando.Parameters.AddWithValue("@Intervencion", ent.Intervencion);
                comando.Parameters.AddWithValue("@IdMotivo", ent.Motivo.IdMotivo);
                comando.Parameters.AddWithValue("@IdExpediente", ent.IdExpediente);
                comando.Parameters.AddWithValue("@TipoInstrumento", ent.TipoInstrumento);


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
                SqlCommand comando = new SqlCommand("PA_SeleccionarInformeVistaAlHogar", conexion);
                // Como es en Store Procedure se debe indicar el tipo de comando
                comando.CommandType = System.Data.CommandType.StoredProcedure;
                // NO recibe parametros
                // Finalmente ejecutamos el comando
                // al ser una consulta debemos usar ExecuteReader
                SqlDataReader reader = comando.ExecuteReader();
                // es necesario recorrer el reader para extraer todos los registros
                while (reader.Read()) // cada vez que se llama el Read retorna una tupla
                {
                    Referencia inf = new Referencia();

                    inf.Id = Convert.ToInt32(reader["Id"]);
                    lista.Add(inf);
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

        public InformeVisitaAlHogar SeleccionarPorId(int numero)
        {
            // SqlConnection requiere el using System.Data.SqlClient;
            SqlConnection conexion = new SqlConnection(Conexion.Cadena);
            try
            {
                conexion.Open(); // un error aca: revisar cadena de conexion
                // El command permite ejecutar un comando en la conexion establecida
                SqlCommand comando = new SqlCommand("PA_SeleccionarInformeVisitaAlHogarPorId", conexion);
                // Como es en Store Procedure se debe indicar el tipo de comando
                comando.CommandType = System.Data.CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@Id", numero);
                // Finalmente ejecutamos el comando
                // al ser una consulta debemos usar ExecuteReader
                SqlDataReader reader = comando.ExecuteReader();
                // es necesario recorrer el reader para extraer todos los registros
                while (reader.Read()) // cada vez que se llama el Read retorna una tupla
                {
                    InformeVisitaAlHogar entEnc = new InformeVisitaAlHogar();
                    entEnc.FechaCreacion = Convert.ToDateTime(reader["FechaCreacion"]);
                    entEnc.Motivo = new MotivoAtencionDatos().SeleccionarporId(Convert.ToInt32(reader["IdMotivo"]));
                    entEnc.Situacion = reader["Situacion"].ToString();
                    entEnc.Acciones = reader["Acciones"].ToString();
                    entEnc.Intervencion = reader["Intervencion"].ToString();
                    entEnc.Recomendaciones = reader["Recomendaciones"].ToString();
                    entEnc.NombreFuncionario = reader["NombreFuncionario"].ToString();
                    entEnc.Puesto = reader["Puesto"].ToString();
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

        public List<InformeVisitaAlHogar> SeleccionarPorExpedienteId(int IdExpediente)
        {
            // SqlConnection requiere el using System.Data.SqlClient;
            SqlConnection conexion = new SqlConnection(Conexion.Cadena);
            List<InformeVisitaAlHogar> lista = new List<InformeVisitaAlHogar>();
            try
            {
                conexion.Open(); // un error aca: revisar cadena de conexion
                // El command permite ejecutar un comando en la conexion establecida
                SqlCommand comando = new SqlCommand("PA_SeleccionarInformeVisitaAlHogarPorExpediente", conexion);
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
                    InformeVisitaAlHogar ent = new InformeVisitaAlHogar();
                    ent.Id = Convert.ToInt32(reader["Id"]);
                    ent.FechaCreacion = Convert.ToDateTime(reader["FechaCreacion"]);
                    ent.Motivo = new MotivoAtencionDatos().SeleccionarporId(Convert.ToInt32(reader["IdMotivo"]));
                    ent.Situacion = reader["Situacion"].ToString();
                    ent.Acciones = reader["Acciones"].ToString();
                    ent.Intervencion = reader["Intervencion"].ToString();
                    ent.Recomendaciones = reader["Recomendaciones"].ToString();
                    ent.NombreFuncionario = reader["NombreFuncionario"].ToString();
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
