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
    public partial class FrmEntrevistaPadre_Madre_Encargado : Form
    {

        Capa.Logica.MotivoAtencionLN logicaMotivo;

        public FrmEntrevistaPadre_Madre_Encargado()
        {
            InitializeComponent();
            logicaMotivo = new Capa.Logica.MotivoAtencionLN();

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void FrmEntrevistaPadre_Madre_Encargado_Load(object sender, EventArgs e)
        {
            CargarComboMotivos();
            mskFecha.Text = DateTime.Now.ToShortDateString();

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {



            if (cboMotivos.SelectedIndex == -1)
            {
                MessageBox.Show("Debe seleccionar un motivo de atencion ");
                cboMotivos.Focus();
                return;
            }

            if (txtResumen.Text == "")
            {
                MessageBox.Show("Debe digitar un resumen de la situacion encontrada ");
                txtResumen.Focus();
                return;
            }

            if (txtRecomendaciones.Text == "")
            {
                MessageBox.Show("Debe digitar las recomendaciones dadas ");
                txtRecomendaciones.Focus();
                return;
            }


            try
            {
                EntrevistaEncargado entrevista = new EntrevistaEncargado();

                entrevista.ResumenSituacion = txtResumen.Text;
                entrevista.Recomendaciones = txtRecomendaciones.Text;
                entrevista.Motivo = (MotivoAtencion)cboMotivos.SelectedItem;

                MessageBox.Show("  Datos guardados con exito ");
                FrmExpediente.entrevistaEncargado.Add(entrevista);
                Limpiar();
                Dispose();


            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error al ingresar la entrevista con el padre/madre/encargado"
                    , MessageBoxButtons.OK, MessageBoxIcon.Error);


            }

        }
        private void CargarComboMotivos()
        {
            // cboMotivos.DataSource = 
            cboMotivos.DataSource = logicaMotivo.SeleccionarTodas();
            cboMotivos.DisplayMember = "Descripcion";

            //refe1
            //cboMotivos.ValueMember = "NumeroMotivo";
            cboMotivos.SelectedIndex = -1;


        }

        private void Limpiar()
        {
            txtNombreEstudiante.Clear();
            txtNombrePadre.Clear();
            txtRecomendaciones.Clear();
            txtResumen.Clear();
        }
    }
    }

