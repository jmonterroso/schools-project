using Capa.Datos.Instrumentos;
using Capa.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa.Logica.InstrumentosLN
{
   public class EntrevistaEstudianteLN :InstrumentoLN
    {
       

        public void Guardar(EntrevistaEstudiante ent)
        {

            EntrevistaEstudianteDatos datos = new EntrevistaEstudianteDatos();
            //if (datos.SeleccionarPorId(ent.Id) == null)
                datos.Insertar(ent);
            //else
            //    datos.Actualizar(ent);
        }

        public List<EntrevistaEstudiante> SeleccionarTodos()
        {
            EntrevistaEstudianteDatos datos = new EntrevistaEstudianteDatos();
            return datos.SeleccionarTodos();
        }
        public EntrevistaEstudiante SeleccionarPorId(int id)
        {
            Datos.Instrumentos.EntrevistaEstudianteDatos datos = new Datos.Instrumentos.EntrevistaEstudianteDatos();
            return datos.SeleccionarPorId(id);
        }
    }
}
