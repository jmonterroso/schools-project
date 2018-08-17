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
   public class EstudianteDatos
    {
        public void Insertar(Estudiante est)
        {
            // SqlConnection requiere el using System.Data.SqlClient;
            SqlConnection conexion = new SqlConnection(Conexion.Cadena);
            try
            {
                conexion.Open(); // un error aca: revisar cadena de conexion
                // El command permite ejecutar un comando en la conexion establecida
                SqlCommand comando = new SqlCommand("PA_InsertarEstudiante", conexion);
                // Como es en Store Procedure se debe indicar el tipo de comando
                comando.CommandType = System.Data.CommandType.StoredProcedure;
                // Si el SP requeire parametros se le deben asignar al comando
                comando.Parameters.AddWithValue("@Identificacion", est.Identificacion);
                comando.Parameters.AddWithValue("@NombreCompleto", est.NombreCompleto);
                comando.Parameters.AddWithValue("@IdSeccion", est.Seccion.Id);
                comando.Parameters.AddWithValue("@Sexo", est.Sexo.ToString());
                comando.Parameters.AddWithValue("@FechaNacimiento", est.FechaNacimiento);
                comando.Parameters.AddWithValue("@Direccion", est.Direccion);
                comando.Parameters.AddWithValue("@Foto", est.Foto);
                comando.Parameters.AddWithValue("@IdEncargado", est.IdEncargado);


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

        public void Actualizar(Estudiante est)
        {
            // SqlConnection requiere el using System.Data.SqlClient;
            SqlConnection conexion = new SqlConnection(Conexion.Cadena);
            try
            {
                conexion.Open(); // un error aca: revisar cadena de conexion
                // El command permite ejecutar un comando en la conexion establecida
                SqlCommand comando = new SqlCommand("PA_ActualizarEstudiante", conexion);
                // Como es en Store Procedure se debe indicar el tipo de comando
                comando.CommandType = System.Data.CommandType.StoredProcedure;
                // Si el SP requeire parametros se le deben asignar al comando
                comando.Parameters.AddWithValue("@Identificacion", est.Identificacion);
                comando.Parameters.AddWithValue("@NombreCompleto", est.NombreCompleto);
                comando.Parameters.AddWithValue("@IdSeccion", est.Seccion);
                comando.Parameters.AddWithValue("@Sexo", est.Sexo.ToString());
                comando.Parameters.AddWithValue("@FechaNacimiento", est.FechaNacimiento);
                comando.Parameters.AddWithValue("@Direccion", est.Direccion);
                comando.Parameters.AddWithValue("@Foto", est.Direccion);
                comando.Parameters.AddWithValue("@IdEncargado", est.IdEncargado);



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

        public void Eliminar(int EstudianteId)
        {
            Estudiante est = new Estudiante();
            est.Identificacion = EstudianteId.ToString();
            this.Eliminar(est);
        }
        public void Eliminar(Estudiante est)
        {
            // SqlConnection requiere el using System.Data.SqlClient;
            SqlConnection conexion = new SqlConnection(Conexion.Cadena);
            try
            {
                conexion.Open(); // un error aca: revisar cadena de conexion
                // El command permite ejecutar un comando en la conexion establecida
                SqlCommand comando = new SqlCommand("PA_EliminarEstudiante", conexion);
                // Como es en Store Procedure se debe indicar el tipo de comando
                comando.CommandType = System.Data.CommandType.StoredProcedure;
                // Si el SP requeire parametros se le deben asignar al comando
                comando.Parameters.AddWithValue("@Identificacion", est.Identificacion);
       
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

        public List<Estudiante> SeleccionarTodos()
        {
            // SqlConnection requiere el using System.Data.SqlClient;
            SqlConnection conexion = new SqlConnection(Conexion.Cadena);
            List<Estudiante> lista = new List<Estudiante>();
            try
            {
                conexion.Open(); // un error aca: revisar cadena de conexion
                // El command permite ejecutar un comando en la conexion establecida
                SqlCommand comando = new SqlCommand("PA_SeleccionarEstudiantes", conexion);
                // Como es en Store Procedure se debe indicar el tipo de comando
                comando.CommandType = System.Data.CommandType.StoredProcedure;
                // NO recibe parametros
                // Finalmente ejecutamos el comando
                // al ser una consulta debemos usar ExecuteReader
                SqlDataReader reader = comando.ExecuteReader();
                // es necesario recorrer el reader para extraer todos los registros
                while (reader.Read()) // cada vez que se llama el Read retorna una tupla
                {
                    Estudiante est = new Estudiante();
                    est.Identificacion = reader["Identificacion"].ToString();
                    est.NombreCompleto = reader["NombreCompleto"].ToString();
                    
                    est.Seccion = new SeccionesDatos().SeleccionarPorId(Convert.ToInt32(reader["IdSeccion"]));
                   est.Sexo = (Sexo)Enum.Parse(typeof(Sexo), reader["Sexo"].ToString());
                    est.Direccion = reader["Direccion"].ToString();
                    est.Direccion = reader["IdEncargado"].ToString();
                    est.FechaNacimiento = (DateTime)reader["FechaNacimiento"];
                   est.Foto = (byte[])reader["Foto"];
                    lista.Add(est);
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

        //public Estudiante SeleccionarPorId(int id)
        //{
        //    // SqlConnection requiere el using System.Data.SqlClient;
        //    SqlConnection conexion = new SqlConnection(Conexion.Cadena);
        //    try
        //    {
        //        conexion.Open(); // un error aca: revisar cadena de conexion
        //        // El command permite ejecutar un comando en la conexion establecida
        //        SqlCommand comando = new SqlCommand("PA_SeleccionarEstudiantePorId", conexion);
        //        // Como es en Store Procedure se debe indicar el tipo de comando
        //        comando.CommandType = System.Data.CommandType.StoredProcedure;
        //        comando.Parameters.AddWithValue("@Id", id);
        //        // Finalmente ejecutamos el comando
        //        // al ser una consulta debemos usar ExecuteReader
        //        SqlDataReader reader = comando.ExecuteReader();
        //        // es necesario recorrer el reader para extraer todos los registros
        //        while (reader.Read()) // cada vez que se llama el Read retorna una tupla
        //        {
        //            Estudiante est = new Estudiante();
        //            est.Identificacion = reader["Id"].ToString();
        //            est.NombreCompleto = reader["Nombre"].ToString();
                    
                  
        //            return est;
        //        }

        //    }
        //    catch (Exception)
        //    {
        //        throw;
        //    }
        //    finally
        //    {
        //        conexion.Close();
        //    }

        //    return null;
        //}
        public Estudiante SeleccionarPorId(string Identificacion)
        {

            using (SqlConnection conn = new SqlConnection(Conexion.Cadena))
            {

                conn.Open();
                SqlCommand comando = new SqlCommand("PA_SeleccionarEstudiantePorId", conn);
                comando.CommandType = System.Data.CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@Identificacion", Identificacion);
                SqlDataReader reader = comando.ExecuteReader();
                while (reader.Read())
                {
                    Estudiante est = new Estudiante();
                    est.Identificacion = reader["Identificacion"].ToString();
                    est.NombreCompleto = reader["NombreCompleto"].ToString();
                    est.Seccion = new SeccionesDatos().SeleccionarPorId(Convert.ToInt32(reader["IdSeccion"]));
                    est.Sexo = (Sexo)reader["Sexo"];
                    est.Direccion = reader["Direccion"].ToString();
                    est.IdEncargado = reader["IdEncargado"].ToString();
                    est.FechaNacimiento = (DateTime)reader["FechaNacimiento"];
                    est.Foto = (byte[])reader["Foto"];

                    //nueva linea

                    return est;

                }
            }
            return null;

        }

        public List<Estudiante> SeleccionarPorFiltro(string Identificacion, string NombreCompleto, string Seccion, DateTime FechaNacimiento, string Direccion, byte Foto)
        {
            List<Estudiante> lista = new List<Estudiante>();
            using (SqlConnection conn = new SqlConnection(Conexion.Cadena))

            {

                conn.Open();
                SqlCommand comando = new SqlCommand("PA_SeleccionarProductosConFiltros", conn);
                comando.CommandType = System.Data.CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@Identificacion", Identificacion);
                comando.Parameters.AddWithValue("@NombreCompleto", NombreCompleto);
                comando.Parameters.AddWithValue("@Seccion", Seccion);
                comando.Parameters.AddWithValue("@FechaNacimiento", FechaNacimiento);
                comando.Parameters.AddWithValue("@Direccion", Direccion);
                comando.Parameters.AddWithValue("@Foto", Foto);



                SqlDataReader reader = comando.ExecuteReader();

                while (reader.Read())
                {
                    Estudiante e = new Estudiante();
                    e.Identificacion = reader["Identificacion"].ToString();
                    e.NombreCompleto = reader["NombreCompleto"].ToString();
                    e.Seccion = (Secciones)reader["Seccion"];
                    e.FechaNacimiento = Convert.ToDateTime( reader["FechaNacimiento"].ToString());
                    e.Direccion = reader["Direccion"].ToString();
                    e.Foto = (byte[])reader["Foto"];
                    lista.Add(e);


                    
                }
            }
            return lista;

        }
    }
}

    
