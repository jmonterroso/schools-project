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
        public TipoUsuario Rol { get; set; }
        static  public Usuario UsuarioActual {get; set;} 
        public string Identificacion { get; set; }
        public string Password { get; set; }

    }
}
