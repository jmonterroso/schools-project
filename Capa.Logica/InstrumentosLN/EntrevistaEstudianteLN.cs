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
       

        public override void Guardar()
        {
            EntrevistaEstudiante ent = new EntrevistaEstudiante();
            if (ent.Numero == 0)
                throw new ApplicationException("Debe digitar el nombre");

            EntrevistaEstudianteDatos datos = new EntrevistaEstudianteDatos();
            if (datos.SeleccionarPorId(ent.Numero) == null)
                datos.Insertar(ent);
            else
                datos.Actualizar(ent);
        }

        public List<EntrevistaEstudiante> SeleccionarTodos()
        {
            EntrevistaEstudianteDatos datos = new EntrevistaEstudianteDatos();
            return datos.SeleccionarTodos();
        }
    }
}
