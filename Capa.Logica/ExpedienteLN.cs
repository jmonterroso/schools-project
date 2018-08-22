using Capa.Datos;
using Capa.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa.Logica
{
    public class ExpedienteLN
    {
        /// <summary>
        /// Guarda una ExpedienteFacade en la bd, valida que el nombre este correcto
        /// </summary>
        /// <param name="est">Categoría a guardar</param>
        public ExpedienteFacade Guardar(ExpedienteFacade est)
        {
            //if (est.NombreCompleto.Length == 0)
            //    throw new ApplicationException("Debe digitar el nombre");

            ExpedienteDatos datos = new ExpedienteDatos();
            if (datos.SeleccionarPorId((est.IdEstudiante)) == null)
                return datos.Insertar(est);

            return est;
            //else
                ///return datos.Actualizar(est);
        }

        public List<ExpedienteFacade> SeleccionarTodos()
        {
            ExpedienteDatos datos = new ExpedienteDatos();
            return datos.SeleccionarTodos();
        }

        public void Eliminar(ExpedienteFacade est)
        {
            ExpedienteDatos datos = new ExpedienteDatos();

            if (datos.SeleccionarPorId(est.IdEstudiante) == null)
                throw new ApplicationException("El estudiante buscado no existe");

            datos.Eliminar(est);
        }

        public ExpedienteFacade SeleccionarPorId(string id)
        {
            Datos.ExpedienteDatos datos = new Datos.ExpedienteDatos();
            return datos.SeleccionarPorId(id);
        }
         public ExpedienteFacade SeleccionarPorIdExpediente(int id)
        {
            Datos.ExpedienteDatos datos = new Datos.ExpedienteDatos();
            return datos.SeleccionarPorIdExpediente(id);
        }
        public List<ExpedienteFacade> SeleccionarPorFiltro(string Id, bool EsEstudiante)
        {
            ExpedienteDatos datos = new ExpedienteDatos();
            return datos.SeleccionarPorFiltro(Id, EsEstudiante);
        }


    }
}


