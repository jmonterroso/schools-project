using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa.Entidades
{
  public  class InformeVisitaAlHogar :Instrumentos
    {

        public int Numero { get; set; }
        public string ProfesionaQueRealizaLaVisita { get; set; }
       
        public string Cargo { get; set; }
        public string AccionesSeguimiento { get; set; }
        public string SituacionObservada { get; set; }
        public string Recomendaciones { get; set; }
        public string Direccion { get; set; }



    }
}
