using Capa.Datos.Instrumentos;
using Capa.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa.Logica.InstrumentosLN
{
   public class EntrevistaEncargadoLN : InstrumentoLN
    {
       

        public  void Guardar()
        {
            EntrevistaEncargado ent = new EntrevistaEncargado();
            if (ent.Numero == 0)
                throw new ApplicationException("Debe digitar el nombre");

            EntrevistaEncargadoDatos datos = new EntrevistaEncargadoDatos();
            if (datos.SeleccionarPorId(ent.Numero) == null)
                datos.Insertar(ent);
            else
                datos.Actualizar(ent);
        }

        public List<EntrevistaFuncionario> SeleccionarTodos()
        {
            EntrevistaFuncionarioDatos datos = new EntrevistaFuncionarioDatos();
            return datos.SeleccionarTodos();
        }
    }
}
