using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa.Entidades
{
    public class EntrevistaEncargado :ClaseInstrumento
    {
        public bool ConvocadoPorEncargado { get; set; }
        public bool ConvocadoPorInstitucion { get; set; }
    }
}
