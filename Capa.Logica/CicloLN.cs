using Capa.Datos;
using Capa.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa.Logica
{
   public  class CicloLN
    {

            public List<Ciclo> SeleccionarTodos()
            {
                CicloDatos datos = new CicloDatos();
                return datos.SeleccionarTodos();
            }


            public Ciclo SeleccionarPorId(int Id)
            {
                Datos.CicloDatos datos = new Datos.CicloDatos();
                return datos.SeleccionarPorId(Id);
            }
        }
}
