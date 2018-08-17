using Capa.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient; //esta referencia permite conectarnos a sql server


namespace Capa.Datos
{
    public class MotivoAtencionDatos
    {
        public void Insertar(MotivoAtencion motivo)
        {

            //sqlconetion requiere el using System.Data.SqlClient
            SqlConnection conexion = new SqlConnection(Conexion.Cadena);
            try
            {
                conexion.Open();//un error aca : revisar cadena de conexion

                //permite ejecutar un comando en la conexion establecida
                SqlCommand comando = new SqlCommand("PA_InsertarMotivoAtencion", conexion);
                //como es un store procedure se debe indicar el tipo de comando

                comando.CommandType = System.Data.CommandType.StoredProcedure;

                //si el sp requiere parametros se le deben asignar al comando
                comando.Parameters.AddWithValue("@NumeroMotivo", motivo.IdMotivo);

                comando.Parameters.AddWithValue("@Descripcion", motivo.Descripcion);

                //finalmente ejecutamos el comando
                //al ser un insert no requiere retornar una consulta

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
        public void Actualizar(MotivoAtencion motivo)
        {

            //sqlconetion requiere el using System.Data.SqlClient
            SqlConnection conexion = new SqlConnection(Conexion.Cadena);
            try
            {
                conexion.Open();//un error aca : revisar cadena de conexion

                //permite ejecutar un comando en la conexion establecida
                SqlCommand comando = new SqlCommand("PA_ActualizarMotivoAtencion", conexion);
                //como es un store procedure se debe indicar el tipo de comando

                comando.CommandType = System.Data.CommandType.StoredProcedure;

                //si el sp requiere parametros se le deben asignar al comando
                comando.Parameters.AddWithValue("@NumeroMotivo", motivo.IdMotivo);

                comando.Parameters.AddWithValue("@Descripcion", motivo.Descripcion);

                //finalmente ejecutamos el comando
                //al ser un update no requiere retornar una consulta

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
        public List<MotivoAtencion> SeleccionarTodos()
        {

            //sqlconetion requiere el using System.Data.SqlClient
            SqlConnection conexion = new SqlConnection(Conexion.Cadena);

            List<MotivoAtencion> lista = new List<MotivoAtencion>();

            try
            {
                conexion.Open();//un error aca : revisar cadena de conexion

                //permite ejecutar un comando en la conexion establecida
                SqlCommand comando = new SqlCommand("PA_SeleccionarMotivoAtencion", conexion);
                //como es un store procedure se debe indicar el tipo de comando

                comando.CommandType = System.Data.CommandType.StoredProcedure;

                //no recibe parametros

                //finalmente ejecutamos el comando
                //al ser una consulta debemos usar ExecuteReader

                SqlDataReader reader = comando.ExecuteReader();

                //es necesario recorrer el reder para extraewr todos los regisstos q resultan de la consulta
                while (reader.Read())   //cada vez q se llama el read retorna una tupla 
                {
                    MotivoAtencion motivo = new MotivoAtencion();
                    motivo.IdMotivo = Convert.ToInt32(reader["NumeroMotivo"]);
                    motivo.Descripcion = reader["Descripcion"].ToString();
                    lista.Add(motivo);
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

        public MotivoAtencion SeleccionarporId(int numeroMotivo)
        {

            //sqlconetion requiere el using System.Data.SqlClient
            SqlConnection conexion = new SqlConnection(Conexion.Cadena);
            try
            {
                conexion.Open();//un error aca : revisar cadena de conexion

                //permite ejecutar un comando en la conexion establecida
                SqlCommand comando = new SqlCommand("PA_SeleccionarMotivoAtencionPorId", conexion);
                //como es un store procedure se debe indicar el tipo de comando

                comando.CommandType = System.Data.CommandType.StoredProcedure;

                comando.Parameters.AddWithValue("@NumeroMotivo", numeroMotivo);

                //finalmente ejecutamos el comando
                //al ser una consulta debemos usar ExecuteReader

                SqlDataReader reader = comando.ExecuteReader();

                //es necesario recorrer el reder para extraewr todos los regisstos q resultan de la consulta
                if (reader.HasRows) { 
                while (reader.Read())  //cada vez q se llama el read retorna una tupla 
                {
                    MotivoAtencion mot = new MotivoAtencion();
                    mot.IdMotivo = Convert.ToInt32(reader["NumeroMotivo"]);
                    mot.Descripcion = reader["Descripcion"].ToString();
                    return mot;
                }
                } else
                {
                    return null;
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


        public void Eliminar(MotivoAtencion moti)
        {
            // SqlConnection requiere el using System.Data.SqlClient;
            SqlConnection conexion = new SqlConnection(Conexion.Cadena);
            try
            {
                conexion.Open(); // un error aca: revisar cadena de conexion
                // El command permite ejecutar un comando en la conexion establecida
                SqlCommand comando = new SqlCommand("PA_EliminarMotivoAtencion", conexion);
                // Como es en Store Procedure se debe indicar el tipo de comando
                comando.CommandType = System.Data.CommandType.StoredProcedure;
                // Si el SP requeire parametros se le deben asignar al comando
                comando.Parameters.AddWithValue("@NumeroMotivo", moti.IdMotivo);
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

    }
    }


