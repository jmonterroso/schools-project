using Capa.Entidades.Enumeradores;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa.Entidades
{
     public abstract class ClaseInstrumento 
        {
        public int Id { get; set; }
        public  DateTime FechaCreacion { get; set; }
        public  MotivoAtencion Motivo {get; set;}        
        public string Situacion { get; set; }
        public string Acciones { get; set; }
        public string Intervencion { get; set; }
        public string Recomendaciones { get; set; }
        public string Nombre { get; set; }

    }
}
