using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa.Entidades
{
  public  class EntrevistaEstudiante :Instrumentos
    {
        public int Numero { get; set; }
        public string IntervencionRealizada { get; set; }
        public string ProcesoASeguir { get; set; }
     
        public string SituacionPresentada { get; set; }
        public string Recomendaciones { get; set; }



    }
}
