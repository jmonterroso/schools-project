using Capa.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Capa.Entidades.Enumeradores;

namespace Capa.Datos
{
   public  class SeccionesDatos
    {
        public void Insertar(Secciones secc)
        {
            // SqlConnection requiere el using System.Data.SqlClient;
            SqlConnection conexion = new SqlConnection(Conexion.Cadena);
            try
            {
                conexion.Open(); // un error aca: revisar cadena de conexion
                // El command permite ejecutar un comando en la conexion establecida
                SqlCommand comando = new SqlCommand("PA_InsertarSecciones", conexion);
                // Como es en Store Procedure se debe indicar el tipo de comando
                comando.CommandType = System.Data.CommandType.StoredProcedure;
                // Si el SP requeire parametros se le deben asignar al comando
                // comando.Parameters.AddWithValue("@Id", pro.Id);
                //comando.Parameters.AddWithValue("@Id", secc.Id);
                comando.Parameters.AddWithValue("@Nombre", secc.Nombre);
                comando.Parameters.AddWithValue("@IdNivel", secc.Nivel.IdNivel);

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

        public void Actualizar(Secciones secc)
        {
            // SqlConnection requiere el using System.Data.SqlClient;
            SqlConnection conexion = new SqlConnection(Conexion.Cadena);
            try
            {
                conexion.Open(); // un error aca: revisar cadena de conexion
                // El command permite ejecutar un comando en la conexion establecida
                SqlCommand comando = new SqlCommand("PA_ActualizarSecciones", conexion);
                // Como es en Store Procedure se debe indicar el tipo de comando
                comando.CommandType = System.Data.CommandType.StoredProcedure;
                // Si el SP requeire parametros se le deben asignar al comando
                comando.Parameters.AddWithValue("@Id", secc.Id);
                comando.Parameters.AddWithValue("@Nombre", secc.Nombre);
                comando.Parameters.AddWithValue("@Nivel", secc.Nivel);
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

       
        public void Eliminar(Secciones secc)
        {
            // SqlConnection requiere el using System.Data.SqlClient;
            SqlConnection conexion = new SqlConnection(Conexion.Cadena);
            try
            {
                conexion.Open(); // un error aca: revisar cadena de conexion
                // El command permite ejecutar un comando en la conexion establecida
                SqlCommand comando = new SqlCommand("PA_EliminarSecciones", conexion);
                // Como es en Store Procedure se debe indicar el tipo de comando
                comando.CommandType = System.Data.CommandType.StoredProcedure;
                // Si el SP requeire parametros se le deben asignar al comando
                comando.Parameters.AddWithValue("@Id", secc.Id);
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

        public List<Secciones> SeleccionarTodos()
        {
            // SqlConnection requiere el using System.Data.SqlClient;
            SqlConnection conexion = new SqlConnection(Conexion.Cadena);
            List<Secciones> lista = new List<Secciones>();
            try
            {
                conexion.Open(); // un error aca: revisar cadena de conexion
                // El command permite ejecutar un comando en la conexion establecida
                SqlCommand comando = new SqlCommand("PA_SeleccionarSeccion", conexion);
                // Como es en Store Procedure se debe indicar el tipo de comando
                comando.CommandType = System.Data.CommandType.StoredProcedure;
                // NO recibe parametros
                // Finalmente ejecutamos el comando
                // al ser una consulta debemos usar ExecuteReader
                SqlDataReader reader = comando.ExecuteReader();
                // es necesario recorrer el reader para extraer todos los registros
                while (reader.Read()) // cada vez que se llama el Read retorna una tupla
                {
                 
                    Secciones s = new Secciones();
                    s.Id = Convert.ToInt32(reader["Id"]);
                    s.Nombre = reader["Nombre"].ToString();
                    s.Nivel = new NivelDatos().SeleccionarPorId(Convert.ToInt32(reader["IdNivel"]));
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

        public Secciones SeleccionarPorId(int id)
        {
            // SqlConnection requiere el using System.Data.SqlClient;
            SqlConnection conexion = new SqlConnection(Conexion.Cadena);
            try
            {
                conexion.Open(); // un error aca: revisar cadena de conexion
                // El command permite ejecutar un comando en la conexion establecida
                SqlCommand comando = new SqlCommand("PA_SeleccionarSeccionesPorId", conexion);
                // Como es en Store Procedure se debe indicar el tipo de comando
                comando.CommandType = System.Data.CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@Id", id);
                // Finalmente ejecutamos el comando
                // al ser una consulta debemos usar ExecuteReader
                SqlDataReader reader = comando.ExecuteReader();
                // es necesario recorrer el reader para extraer todos los registros
                while (reader.Read()) // cada vez que se llama el Read retorna una tupla
                {
                    Secciones s = new Secciones();
                    s.Id = Convert.ToInt32(reader["Id"]);
                    s.Nombre = reader["Nombre"].ToString();
                    s.Nivel = new NivelDatos().SeleccionarPorId(Convert.ToInt32(reader["IdNivel"].ToString()));
                    return s;
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



        public List<Secciones> SeleccionarSeccionPorNivel(int idNivel)
        {
            List<Secciones> lista = new List<Secciones>();

            using (SqlConnection conn = new SqlConnection(Conexion.Cadena))

            {
                conn.Open();
                SqlCommand comando = new SqlCommand("PA_SeleccionarSeccionPorNivel", conn);
                comando.CommandType = System.Data.CommandType.StoredProcedure;

                comando.Parameters.AddWithValue("@IdNivel", idNivel);
                SqlDataReader reader = comando.ExecuteReader();
                while (reader.Read())
                {
                    Secciones sec = new Secciones();
                    sec.Id = Convert.ToInt32(reader["Id"]);
                    sec.Nivel= new NivelDatos().SeleccionarPorId(Convert.ToInt32(reader["IdNivel"]));
                    sec.Nombre = reader["Nombre"].ToString();


                    lista.Add(sec);
                }
            }
            return lista;
        }
    }
}


