using Capa.Datos;
using Capa.Entidades;
using Capa.Entidades.Enumeradores;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa.Logica
{
   public class NivelLN
    {

        public void Guardar(Nivel nivel)
        {
            if (nivel.Nombre.Length == 0)
                throw new ApplicationException("Debe digitar el nombre nivel");

            NivelDatos datos = new NivelDatos();
                datos.Insertar(nivel);
           
        }

        public List<Nivel> SeleccionarTodos()
        {
            NivelDatos datos = new NivelDatos();
            return datos.SeleccionarTodos();
        }

       
        public Nivel SeleccionarPorId(int Id)
        {
            Datos.NivelDatos datos = new Datos.NivelDatos();
            return datos.SeleccionarPorId(Id);
        }
        public List<Nivel> SeleccionarNivelPorCiclo(int  id)
        {
            NivelDatos datos = new NivelDatos();


            var lista = datos.SeleccionarNivelPorCiclo(id);
           return lista;
        }
    }
}
