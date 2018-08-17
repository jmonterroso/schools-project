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
        public void Guardar( )
        {
            Referencia refe = new Referencia();
            if (refe.Numero == 0)
                throw new ApplicationException("Debe digitar el nombre");

            ReferenciaDatos datos = new ReferenciaDatos();
            if (datos.SeleccionarPorId(refe.Numero) == null) 
                datos.Insertar(refe);
            else
                datos.Actualizar(refe);
        }

        public List<Referencia> SeleccionarTodos()
        {
            ReferenciaDatos datos = new ReferenciaDatos();
            return datos.SeleccionarTodos();
        }
}


}
