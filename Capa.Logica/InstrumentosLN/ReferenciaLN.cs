using Capa.Datos.Instrumentos;
using Capa.Entidades;
using Capa.Entidades.Enumeradores;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa.Logica.InstrumentosLN
{
    public class ReferenciaLN
    {

        /// <summary>
        /// 
        /// </summary>
        public void Guardar(Referencia ent)
        {

            ReferenciaDatos datos = new ReferenciaDatos();
            if (datos.SeleccionarPorId(ent.Id) == null)
                datos.Insertar(ent);
            else
                datos.Actualizar(ent);
        }
        public List<Referencia> SeleccionarTodos()
        {
            ReferenciaDatos datos = new ReferenciaDatos();
            return datos.SeleccionarTodos();
        }
}


}
