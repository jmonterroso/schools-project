using Capa.Datos;
using Capa.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa.Logica
{
    public class TelefonoLN
    {
        public void Guardar(Telefono tel)
        {
            if (tel.NumeroTelefono == 0)
                throw new ApplicationException("Debe digitar un numero de telefono");

            TelefonoDatos datos = new TelefonoDatos();
            if (datos.SeleccionarPorNumero(Int32.Parse(tel.NumeroTelefono.ToString())) == null)
                datos.Insertar(tel);
            else
                datos.Actualizar(tel);
        }

        public List<Telefono> SeleccionarTodos()
        {
            TelefonoDatos datos = new TelefonoDatos();
            return datos.SeleccionarTodos();
        }


        //public List<Telefono> SeleccionarPorEncargado(int encargadoId)
        //{
        //    EncargadoTelefonoDatos datos = new EncargadoTelefonoDatos();
        //    return datos.SeleccionarProveedoresPorProducto(productoId);
        //}
    //    public void Eliminar(Telefono tel)
    //    {
    //        TelefonoDatos datos = new TelefonoDatos();

    //        if (datos.SeleccionarPorNumero(Int32.Parse(tel.NumeroTelefono.ToString())) == null)
    //            throw new ApplicationException("El Telefono buscado no existe");

    //        datos.Eliminar(tel);
    //    }
    }
}



    