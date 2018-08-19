using Capa.Datos.Instrumentos;
using Capa.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa.Logica.InstrumentosLN
{
    public class InformeVisitaAlHogarLN: InstrumentoLN
    {
   

        /// <summary>
        ///  Guarda un informe de visita al hogar en la bd, valida que el nombre este correcto
        /// </summary>

        public  void Guardar(InformeVisitaAlHogar ent)
        {
            InformeVistaHogarDatos datos = new InformeVistaHogarDatos();
            if (datos.SeleccionarPorId(ent.Id) == null)
                datos.Insertar(ent);
            else
                datos.Actualizar(ent);
        }
        
        public List<Referencia> SeleccionarTodos()
        {
            InformeVistaHogarDatos datos = new InformeVistaHogarDatos();
            return datos.SeleccionarTodos();
        }
    }
}
