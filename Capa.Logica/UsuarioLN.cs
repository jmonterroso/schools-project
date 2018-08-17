using Capa.Datos;
using Capa.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa.Logica
{
    public class UsuarioLN
    {
        public void Guardar(Usuario usu)
        {
            if (usu.Identificacion.Length == 0)
                throw new ApplicationException("Debe digitar su identificacion");

            UsuarioDatos datos = new UsuarioDatos();
            if (datos.SeleccionarPorId(usu.Identificacion) == null)
                datos.Insertar(usu);
            else
                datos.Actualizar(usu);
        }

        public List<Usuario> SeleccionarTodos()
        {
            UsuarioDatos datos = new UsuarioDatos();
            return datos.SeleccionarTodos();
        }

        public void Eliminar(Usuario usu)
        {
            UsuarioDatos datos = new UsuarioDatos();

            if (datos.SeleccionarPorId(usu.Identificacion) == null)
                throw new ApplicationException("El usuario no existe");

            datos.Eliminar(usu);
        }
    }
}

    

