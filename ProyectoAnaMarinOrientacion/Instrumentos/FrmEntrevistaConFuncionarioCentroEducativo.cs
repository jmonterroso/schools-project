﻿using Capa.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoAnaMarinOrientacion.Instrumentos
{
    public partial class FrmEntrevistaConFuncionarioCentroEducativo : Form
    {

        Capa.Logica.InstrumentosLN.EntrevistaConFuncionarioLN logicaFuncionarios = new Capa.Logica.InstrumentosLN.EntrevistaConFuncionarioLN();

        Capa.Logica.MotivoAtencionLN logicaMotivo; 
        public FrmEntrevistaConFuncionarioCentroEducativo()
        {
            InitializeComponent();
            txtNombreEstudiante.Text = (FrmExpediente.est != null) ? FrmExpediente.est.NombreCompleto : "";
            logicaFuncionarios = new Capa.Logica.InstrumentosLN.EntrevistaConFuncionarioLN();
            //falta cargar fecha
            //DateTime dt = DateTime.Parse(mskFecha.Text);
            logicaMotivo= new Capa.Logica.MotivoAtencionLN();
        }

        private void FrmEntrevistaConFuncionarioCentroEducativo_Load(object sender, EventArgs e)
        {
            CargarComboMotivos();
            mskFecha.Text = DateTime.Now.ToShortDateString();
        }


        private void CargarComboMotivos()
        {
           // cboMotivos.DataSource = 
            comboBox1.DataSource = logicaMotivo.SeleccionarTodas();
            

            comboBox1.DisplayMember = "Descripcion";

            //refe1
           // comboBox1.ValueMember = "NumeroMotivo";
            comboBox1.SelectedIndex = -1;


        }
        private void btnAceptar_Click(object sender, EventArgs e)
        {
            //FrmExpediente.entrevistas.Add(ent);


            if (txtNombreFuncionario.Text == "") {
                MessageBox.Show("Debe digitar el nombre del funcionario");
                txtNombreFuncionario.Focus();
                return;
            }

            if (txtPuesto.Text == "")
            {
                MessageBox.Show("Debe digitar el puesto del funcionario ");
                txtPuesto.Focus();
                return;
            }


            if (comboBox1.SelectedIndex == -1)
            {
                MessageBox.Show("Debe seleccionar un motivo de atencion ");
                comboBox1.Focus();
                return;
            }

            if (txtResumen.Text == "")
            {
                MessageBox.Show("Debe digitar un resumen de la situacion encontrada ");
                txtResumen.Focus();
                return;
            }

            if (txtAcuerdos.Text== "") { 
                MessageBox.Show("Debe digitar los acuerdos efectuados ");
            txtAcuerdos.Focus();
            return;
            }

           
            if (txtRecomendaciones.Text == "") { 
                MessageBox.Show("Debe digitar las recomendaciones dadas ");
            txtRecomendaciones.Focus();
            return;
        }

            

            

            try
            {
                EntrevistaFuncionario entrevista = new EntrevistaFuncionario();

                entrevista.NombreFuncionario = txtNombreFuncionario.Text;
                entrevista.Puesto = txtPuesto.Text;
                entrevista.AcuerdosAccionesASeguir = txtAcuerdos.Text;
                entrevista.Recomendaciones = txtRecomendaciones.Text;
                entrevista.Resumen = txtResumen.Text;
                entrevista.Motivo = (MotivoAtencion)comboBox1.SelectedItem;

                MessageBox.Show("  Datos guardados con exito ");
                FrmExpediente.entrevistasFuncionario.Add(entrevista);
                Limpiar();
                Dispose();


            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error al ingresar la entrevista con el funcionario"
                    , MessageBoxButtons.OK, MessageBoxIcon.Error);


            }
        }

        private void Limpiar()
        {
            txtAcuerdos.Clear();
            txtNombreEstudiante.Clear();
            txtNombreFuncionario.Clear();
            txtPuesto.Clear();
            txtRecomendaciones.Clear();
            txtResumen.Clear();
            mskFecha.Clear();

        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            //boton para cancelar
            try
            {
                DialogResult dialogo = MessageBox.Show("Desea cerrar la entrevista con el funcionario.", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk);
                if (dialogo == DialogResult.Yes)
                {
                    Dispose();
                }
                else
                    return;
            }
            catch
            {
            }
        }
    }
}
