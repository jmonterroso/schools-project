using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
namespace Capa.Datos
{
    public class Conexion
    {
        public static string Cadena
        {
            get
            {
                //clase encargada de obtener los datos del app.conf fr la capa grafica
                //es necesario agregar referencia system.Configuration en capa datos
                //es necesario agregar el using. configuration
                //el nombre esta en app.conf  name 


                //importante corregir la direccion

                return ConfigurationManager.ConnectionStrings["Conexion"].ConnectionString;
                //otra forma
                //string name ="Capa.Grafica.Properties.Settings.SqlServer";
                //  return ConfigurationManager.ConnectionStrings[name].ConnectionString;
            }
        }
    }
}
