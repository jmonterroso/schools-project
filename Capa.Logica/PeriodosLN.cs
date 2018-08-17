using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Capa.Logica;
using Capa.Entidades;
using Capa.Datos;

namespace Capa.Logica
{
    public class PeriodosLN
    {

        public void Guardar(Periodos peri)
        {
            if (peri.Nombre.Length == 0)
                throw new ApplicationException("Debe digitar el nombre del periodo");

            PeriodosDatos datos = new PeriodosDatos();
            datos.Insertar(peri);

        }

        public List<Periodos> SeleccionarTodos()
        {
            PeriodosDatos datos = new PeriodosDatos();
            return datos.SeleccionarTodos();
        }

        public Periodos SeleccionarPorId(int Id)
        {
            Datos.PeriodosDatos datos = new Datos.PeriodosDatos();
            return datos.SeleccionarPorId(Id);


        }

        public void Eliminar(Periodos peri)
        {
            PeriodosDatos datos = new PeriodosDatos();

            if (datos.SeleccionarPorId(peri.Codigo) == null)
                throw new ApplicationException("El periodo no existe");

            datos.Eliminar(peri);
        }
    }
}



