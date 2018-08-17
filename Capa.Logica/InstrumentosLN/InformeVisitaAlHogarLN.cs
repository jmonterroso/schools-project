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

        public  void Guardar()
        {
            Referencia ent = new Referencia();
            if (ent.Numero == 0)
                throw new ApplicationException("Debe digitar el nombre");

            InformeVistaHogarDatos datos = new InformeVistaHogarDatos();
            if (datos.SeleccionarPorId(ent.Numero) == null)
                datos.Insertar(ent);
            else
                datos.Actualizar(ent);
        }
        public  void Guardar(Referencia ent)
        {
           // InformeVistaAlHogar ent = new InformeVistaAlHogar();
            if (ent.Numero == 0)
                throw new ApplicationException("Debe digitar el nombre");

            InformeVistaHogarDatos datos = new InformeVistaHogarDatos();
            if (datos.SeleccionarPorId(ent.Numero) == null)
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
