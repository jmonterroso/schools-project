using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa.Entidades
{
  public  class Referencia :ClaseInstrumento
    {
        public int Numero { get; set; }
        public string Provincia { get; set; }
        public string Canton { get; set; }
        public string Distrito { get; set; }
        public string OtrasSennas { get; set; }
        public string CorreoElectronicoEstudiante { get; set; }
        public string AccionesQueHaRealizadoElCentroEducativo { get; set; }
        public string PersonaqueRefiere { get; set; }
        public string Puesto { get; set; }
        public string SituacionPresenta { get; set; }
        public string ProfesionaQueRealizaLaVisita { get; set; }
        public string ObservacionesyRecomendaciones { get; set; }
        public string InstitucionDondeSeRefiere { get; set; }

      
    }
}
