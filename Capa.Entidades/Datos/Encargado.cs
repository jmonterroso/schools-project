using Capa.Entidades.Enumeradores;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa.Entidades
{
    public class Encargado
    {

        public string Identificacion { get; set; }
        public string NombreCompleto { get; set; }
        public string CorreoElectronico { get; set; }
        public string Ocupacion { get; set; }
        public string Parentesco { get; set; }
        public List<Telefono> listaTelefonos { get; set; }
       

        

    }
}
