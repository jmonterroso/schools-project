﻿using Capa.Entidades.Enumeradores;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa.Entidades
{
    public class ExpedienteFacade
    {

        public Estudiante estudiante { get; set; }
        public Encargado encargado { get; set; }
        private Ciclo ciclo { get; set; }
        private Nivel nivel { get; set; }
        private Periodos periodo { get; set; }
        //private Instrumento instrumento { get; set; }
        private MotivoAtencion motivo { get; set; }
        public List<ClaseInstrumento> Instrumentos { get; set; }
        public int Id { get; set; }
        public string IdEstudiante { get; set; }
        //public string MotivoDescripcion { get { return this.motivo.Descripcion; } }



        public ExpedienteFacade()
        {

        }

        public void AgregarEstudiante(string identificacion, string nombre, Secciones secc, Sexo sexo, DateTime fechaN, string direccion)
        {
            Estudiante est = new Estudiante();
            est.Identificacion = identificacion;
            est.NombreCompleto = nombre;
            est.Seccion = secc;
            est.Sexo = sexo;
            est.FechaNacimiento = fechaN;
            est.Direccion = direccion;

            estudiante = est;

        }

        public void AgregarEncargado(string identificacion, string nombre, string correo, string ocupacion, string pa)
        {
            Encargado enc = new Encargado();
            enc.Identificacion = identificacion;
            enc.NombreCompleto = nombre;
            enc.CorreoElectronico = correo;
            enc.Ocupacion = ocupacion;
            enc.Parentesco = pa;

            encargado = enc;

        }

        public void AgregarInstrumento(ClaseInstrumento inst)
        {
            //Instrumento.Add(inst);

        }

        public void AgregarNivel(Nivel nivelAgregado)
        {
            nivel = nivelAgregado;
        }
        public void AgregarPeriodo(Periodos periodoAgregado)
        {
            periodo = periodoAgregado;
        }

        public void AgregarCiclo(Ciclo cicloAgregado)
        {
            ciclo = cicloAgregado;
        }


    }
}
