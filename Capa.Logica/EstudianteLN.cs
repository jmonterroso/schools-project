using Capa.Datos;
using Capa.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa.Logica
{
   public class EstudianteLN
    {
        /// <summary>
        /// Guarda una Estudiante en la bd, valida que el nombre este correcto
        /// </summary>
        /// <param name="est">Categoría a guardar</param>
        public void Guardar(Estudiante est)
        {
            if (est.NombreCompleto.Length == 0)
                throw new ApplicationException("Debe digitar el nombre");

            EstudianteDatos datos = new EstudianteDatos();
            if (datos.SeleccionarPorId(( est.Identificacion)) == null)
                datos.Insertar(est);
            else
                datos.Actualizar(est);
        }

        public List<Estudiante> SeleccionarTodos()
        {
            EstudianteDatos datos = new EstudianteDatos();
            return datos.SeleccionarTodos();
        }

        public void Eliminar(Estudiante est)
        {
            EstudianteDatos datos = new EstudianteDatos();

            if (datos.SeleccionarPorId(est.Identificacion) == null)
                throw new ApplicationException("El estudiante buscado no existe");

            datos.Eliminar(est);
        }

        public Estudiante SeleccionarPorId(string id)
        {
            Datos.EstudianteDatos datos = new Datos.EstudianteDatos();
            return datos.SeleccionarPorId(id);
        }
        public List<Estudiante> SeleccionarEstudiantePorNombre(string nombre)
        {
            if (nombre.Length == 0)
                throw new ApplicationException("Debe digitar una opcion");

            List<Estudiante> lista = new List<Estudiante>();
            EstudianteDatos datos = new EstudianteDatos();



            lista = datos.SeleccionarEstudiantePorNombre(nombre);

           




            return lista;
        }

    }
}


