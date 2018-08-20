using Capa.Entidades.Enumeradores;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa.Entidades
{
   public class Nivel
    {

        public string Nombre { get; set; }
        public int IdNivel { get; set; }
        public Ciclo Ciclo { get; set; }
        public override string ToString()
        {
            return Nombre;

        }
    }
}
