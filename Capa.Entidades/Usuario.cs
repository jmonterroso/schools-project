using Capa.Entidades.Enumeradores;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa.Entidades
{
    public class Usuario
    {
        public TipoUsuario tipoUsuario { get; set; }
        public string Identificacion { get; set; }
        public string contrasenna { get; set; }

    }
}
