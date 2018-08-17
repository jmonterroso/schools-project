using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa.Entidades
{
    public class EntrevistaFuncionario :Instrumentos
    {
        public int Numero { get; set; }
        public string NombreFuncionario { get; set; }
        public string Puesto { get; set; }
        public string Cedula { get; set; }
        public string Resumen { get; set; }
        public string AcuerdosAccionesASeguir { get; set; }
        public string Recomendaciones { get; set; }
    }
}
