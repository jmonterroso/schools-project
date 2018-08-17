using Capa.Entidades.Enumeradores;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa.Entidades
{
    public class Secciones
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public Nivel Nivel { get; set; }
    
        public override string ToString()
        {
             string hilera = Nivel + " " + Nombre;
            return hilera;


        }
        //public string Display { get { return ToString(); } }


    }
}
