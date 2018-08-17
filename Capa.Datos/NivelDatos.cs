using Capa.Entidades;
using Capa.Entidades.Enumeradores;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa.Datos
{
    public class NivelDatos
    {

        public void Insertar(Nivel nivel)
        {
            // SqlConnection requiere el using System.Data.SqlClient;
            SqlConnection conexion = new SqlConnection(Conexion.Cadena);
            try
            {
                conexion.Open(); // un error aca: revisar cadena de conexion
                // El command permite ejecutar un comando en la conexion establecida
                SqlCommand comando = new SqlCommand("PA_InsertarNivel", conexion);
                // Como es en Store Procedure se debe indicar el tipo de comando
                comando.CommandType = System.Data.CommandType.StoredProcedure;
                // Si el SP requeire parametros se le deben asignar al comando
                // comando.Parameters.AddWithValue("@Id", pro.Id);
                comando.Parameters.AddWithValue("@Ciclo", nivel.Ciclo.Id);
                comando.Parameters.AddWithValue("@Nombre", nivel.Nombre);


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

        

        public List<Nivel> SeleccionarTodos()
        {
            // SqlConnection requiere el using System.Data.SqlClient;
            SqlConnection conexion = new SqlConnection(Conexion.Cadena);
            List<Nivel> lista = new List<Nivel>();
            try
            {
                conexion.Open(); // un error aca: revisar cadena de conexion
                // El command permite ejecutar un comando en la conexion establecida
                SqlCommand comando = new SqlCommand("PA_SeleccionarNivel", conexion);
                // Como es en Store Procedure se debe indicar el tipo de comando
                comando.CommandType = System.Data.CommandType.StoredProcedure;
                // NO recibe parametros
                // Finalmente ejecutamos el comando
                // al ser una consulta debemos usar ExecuteReader
                SqlDataReader reader = comando.ExecuteReader();
                // es necesario recorrer el reader para extraer todos los registros
                while (reader.Read()) // cada vez que se llama el Read retorna una tupla
                {

                    Nivel s = new Nivel();
                    s.IdNivel = Convert.ToInt32(reader["Id"]);
                    s.Nombre = reader["NombreNivel"].ToString();
                    //s.Ciclo = (Ciclo)Enum.Parse(typeof(Ciclo), reader["IdCiclo"].ToString());
                    s.Ciclo = new CicloDatos().SeleccionarPorId(Convert.ToInt32(reader["Ciclo"]));
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

        public Nivel SeleccionarPorId(int id)
        {
            // SqlConnection requiere el using System.Data.SqlClient;
            SqlConnection conexion = new SqlConnection(Conexion.Cadena);
            try
            {
                conexion.Open(); // un error aca: revisar cadena de conexion
                // El command permite ejecutar un comando en la conexion establecida
                SqlCommand comando = new SqlCommand("PA_SeleccionarNivelPorId", conexion);
                // Como es en Store Procedure se debe indicar el tipo de comando
                comando.CommandType = System.Data.CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@Id", id);
                // Finalmente ejecutamos el comando
                // al ser una consulta debemos usar ExecuteReader
                SqlDataReader reader = comando.ExecuteReader();
                // es necesario recorrer el reader para extraer todos los registros
                while (reader.Read()) // cada vez que se llama el Read retorna una tupla
                {
                    Nivel s = new Nivel();
                    s.IdNivel = Convert.ToInt32(reader["Id"]);
                    s.Nombre = reader["NombreNivel"].ToString();
                    s.Ciclo = new CicloDatos().SeleccionarPorId(Convert.ToInt32(reader["Ciclo"]));
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



        public List<Entidades.Nivel> SeleccionarNivelPorCiclo(int id)
        {
            List<Entidades.Nivel> lista = new List<Entidades.Nivel>();

            using (SqlConnection conn = new SqlConnection(Conexion.Cadena))

            {
                conn.Open();
                SqlCommand comando = new SqlCommand("PA_SeleccionarNivelPorCiclo", conn);
                comando.CommandType = System.Data.CommandType.StoredProcedure;

                comando.Parameters.AddWithValue("@Ciclo",id);
                SqlDataReader reader = comando.ExecuteReader();
                while (reader.Read())
                {
                    Entidades.Nivel sec = new Entidades.Nivel();
                    sec.IdNivel = Convert.ToInt32(reader["Id"]);
                    sec.Nombre = reader["NombreNivel"].ToString();
                    //sec.Ciclo = reader["Ciclo"].ToString();
                    sec.Ciclo = new CicloDatos().SeleccionarPorId(Convert.ToInt32(reader["Ciclo"]));


                    lista.Add(sec);
                }
            }
            return lista;
        }
    }
}
