using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Capa.Entidades;
using Capa.Datos;

namespace Capa.Logica
{
   public  class MotivoAtencionLN
    {

        public void Guardar(MotivoAtencion motivo)
        {
            //if (String.IsNullOrWhiteSpace(motivo.Descripcion))
            //    throw new ApplicationException("La descripcion del motivo es requerida");


            //if (motivo.NumeroMotivo == 0)
            //    throw new ApplicationException("El codigo del motivo debe ser numerico");

            Datos.MotivoAtencionDatos datos = new Datos.MotivoAtencionDatos();

            if (datos.SeleccionarporId(motivo.IdMotivo) == null)
                datos.Insertar(motivo);
            else
             datos.Actualizar(motivo);
        }
        
        public List<MotivoAtencion> SeleccionarTodas()
        {
            Datos.MotivoAtencionDatos datos = new Datos.MotivoAtencionDatos();
            return datos.SeleccionarTodos();
        }

        public MotivoAtencion SeleccionarPorId(int numeroMotivo)
        {
            Datos.MotivoAtencionDatos datos = new Datos.MotivoAtencionDatos();
            return datos.SeleccionarporId(numeroMotivo);
        }



        public void Eliminar(MotivoAtencion moti)
        {
            MotivoAtencionDatos datos = new MotivoAtencionDatos();

            if (datos.SeleccionarporId(moti.IdMotivo) == null)
                throw new ApplicationException("El motivo de atencion no existe");

            datos.Eliminar(moti);
        }



    }
}

    