using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa.Entidades
{
     public class Archivo
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public byte[] ArchivoBytes { get; set; }
        public override string ToString()
        {
            return this.Nombre; 
        }
    }
}
