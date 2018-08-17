using Capa.Entidades;
using Capa.Datos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa.Logica
{
   public class EncargadoLN
    {
        /// <summary>
        /// Guarda una Encargado en la bd, valida que el nombre este correcto
        /// </summary>
        /// <param name="enc">Encargado a guardar</param>
        /// 

        public void Guardar(Encargado enc)
        {
            //validaciones de espacios
            if (enc.NombreCompleto.Length == 0)
             throw new ApplicationException("Debe digitar el nombre");

            if (enc.Identificacion.Length == 0)
                throw new ApplicationException("Debe digitar su identificacion");

            if (enc.Ocupacion.Length == 0)
                throw new ApplicationException("Debe digitar una ocupacion");

            if (enc.Parentesco.Length == 0)
                throw new ApplicationException("Debe digitar el parentesco");

            EncargadoDatos datos = new EncargadoDatos();

            if (datos.SeleccionarPorId((enc.Identificacion)) == null)
                datos.Insertar(enc);
            else
              datos.Actualizar(enc);
        }

        public List<Encargado> SeleccionarTodos()
        {
            EncargadoDatos datos = new EncargadoDatos();
        return datos.SeleccionarTodos();
        }

        public void Eliminar(Encargado enc)
        {
            EncargadoDatos datos = new EncargadoDatos();

            if (datos.SeleccionarPorId((enc.Identificacion)) == null)
                throw new ApplicationException("El Encargado buscado no existe");

            datos.Eliminar(enc);


        }

        public Encargado SeleccionarPorId(string enc)
        {
            Datos.EncargadoDatos datos = new Datos.EncargadoDatos();
            return datos.SeleccionarPorId(enc);
        }


    }
}
