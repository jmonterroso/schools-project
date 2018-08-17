using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Capa.Entidades;
using Capa.Entidades.Enumeradores;

namespace Capa.Datos
{
    public class EncargadoTelefonoDatos
    {
        //#1
        public void Insertar(int EncargadoId, int TelefonoId)
        {
            using (SqlConnection conn = new SqlConnection(Conexion.Cadena))
            {
                conn.Open();
                SqlCommand comando = new SqlCommand("PA_InsertarEncargadoTelefono", conn);

                comando.CommandType = System.Data.CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@EncargadoId", EncargadoId);
                comando.Parameters.AddWithValue("@TelefonoId", TelefonoId);
                comando.ExecuteNonQuery();
            }
        }

        //#2

        public void Eliminar(int EncargadoId, int TelefonoId)
        {
            using (SqlConnection conn = new SqlConnection(Conexion.Cadena))
            {
                conn.Open();
                SqlCommand comando = new SqlCommand("PA_EliminarEncargadoTelefono", conn);

                comando.CommandType = System.Data.CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@EncargadoId", EncargadoId);
                comando.Parameters.AddWithValue("@TelefonoId", TelefonoId);
                comando.ExecuteNonQuery();
            }
        }

        //#3

        public List<Encargado> SeleccionarEncargadoPorTelefono(int TelefonoId)
        {
            List<Encargado> lista = new List<Encargado>();

            using (SqlConnection conn = new SqlConnection(Conexion.Cadena))

            {
                conn.Open();
                SqlCommand comando = new SqlCommand("PA_SeleccionarEncargadoPorTelefono", conn);
                comando.CommandType = System.Data.CommandType.StoredProcedure;

                comando.Parameters.AddWithValue("@TelefonoId", TelefonoId);
                SqlDataReader reader = comando.ExecuteReader();
                while (reader.Read())
                {
                    Encargado e = new Encargado();
                    e.Identificacion = reader["Identificacion"].ToString();
                    e.NombreCompleto= reader["NombreCompleto"].ToString();
                    e.CorreoElectronico= reader["CorreoElectronico"].ToString();
                    e.Ocupacion= reader["Ocupacion"].ToString();
                    e.Parentesco = reader["Parentesco"].ToString();
                    lista.Add(e);
                }
            }
            return lista;
        }

    }
}
