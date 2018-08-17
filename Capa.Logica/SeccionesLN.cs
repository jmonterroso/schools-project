using Capa.Datos;
using Capa.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa.Logica
{
    public class SeccionesLN
    {

        public void Guardar(Secciones secc)
        {
            if (secc.Nombre.Length == 0)
                throw new ApplicationException("Debe digitar el nombre");

            SeccionesDatos datos = new SeccionesDatos();
            if (datos.SeleccionarPorId(secc.Id) == null)
                datos.Insertar(secc);
            else
                datos.Actualizar(secc);
        }

        public List<Secciones> SeleccionarTodos()
        {
            SeccionesDatos datos = new SeccionesDatos();
            return datos.SeleccionarTodos();
        }

        public void Eliminar(Secciones secc)
        {
            SeccionesDatos datos = new SeccionesDatos();

            if (datos.SeleccionarPorId(secc.Id) == null)
                throw new ApplicationException("La  seccion no existe");

            datos.Eliminar(secc);
        }
        public Secciones SeleccionarPorId(int Id)
        {
            Datos.SeccionesDatos datos = new Datos.SeccionesDatos();
            return datos.SeleccionarPorId(Id);
        }
        public List<Secciones> SeleccionarSeccionPorNivel(int id)
        {
            SeccionesDatos datos = new SeccionesDatos();


            var lista = datos.SeleccionarSeccionPorNivel(id);
           
            return lista;
        }
    }
}



 

        
