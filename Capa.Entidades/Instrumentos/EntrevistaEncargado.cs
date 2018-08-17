using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa.Entidades
{
    public class EntrevistaEncargado :Instrumentos
    {
        public int Numero { get; set; }
        public string ResumenSituacion { get; set; }
        public string Recomendaciones { get; set; }

    }
}
