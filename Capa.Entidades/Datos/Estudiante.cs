using Capa.Entidades.Enumeradores;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa.Entidades
{
   public class Estudiante
    {
       public string Identificacion { get; set; }
       public string NombreCompleto { get; set; }
       public Secciones Seccion { get; set; }
       public Sexo Sexo { get; set; }
       public DateTime FechaNacimiento { get; set; }
       public string Direccion { get; set; }
       public  byte[] Foto { get; set; }
       public string IdEncargado { get; set; }
    }
}
