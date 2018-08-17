using Capa.Entidades.Enumeradores;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa.Entidades
{
     public abstract class Instrumentos 
        {
        public int Id { get; set; }
        public  DateTime FechaCreacion { get; set; }
        public  MotivoAtencion Motivo {get; set;}
     //cambio 12/8
        public Estudiante est { get; set; }
        public Encargado enc { get; set; }

        }
}
