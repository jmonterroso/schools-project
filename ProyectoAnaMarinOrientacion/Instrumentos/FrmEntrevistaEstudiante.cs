using Capa.Entidades;
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
    public partial class FrmEntrevistaEstudiante : Form
    {

        Capa.Logica.MotivoAtencionLN logicaMotivo;
        public FrmEntrevistaEstudiante()
        {
            InitializeComponent();
            logicaMotivo = new Capa.Logica.MotivoAtencionLN();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            



            if (cboMotivos.SelectedIndex == -1)
            {
                MessageBox.Show("Debe seleccionar un motivo de atencion ");
                cboMotivos.Focus();
                return;
            }

            if (txtSituacion.Text == "")
            {
                MessageBox.Show("Debe digitar un resumen de la situacion encontrada ");
                txtSituacion.Focus();
                return;
            }
            if (txtIntervencion.Text == "")
            {
                MessageBox.Show("Debe digitar la intervencion  realizada ");
                txtIntervencion.Focus();
                return;
            }

            if (txtProceso.Text == "")
            {
                MessageBox.Show("Debe digitar un proceso a seguir ");
                txtProceso.Focus();
                return;
            }


            if (txtRecomendaciones.Text == "")
            {
                MessageBox.Show("Debe digitar el puesto del funcionario ");
                txtRecomendaciones.Focus();
                return;
            }

            try
            {
                EntrevistaEstudiante entrevista = new EntrevistaEstudiante();

                entrevista.IntervencionRealizada = txtIntervencion.Text;
                entrevista.SituacionPresentada = txtSituacion.Text;
                entrevista.ProcesoASeguir = txtProceso.Text;
                entrevista.Recomendaciones = txtRecomendaciones.Text;
                entrevista.Motivo = (MotivoAtencion)cboMotivos.SelectedItem;

                MessageBox.Show("  Datos guardados con exito ");
                FrmExpediente.entrevistaEstudiante.Add(entrevista);
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
            txtIntervencion.Clear();
            txtNombreEstudiante.Clear();
            txtProceso.Clear();
            cboMotivos.SelectedIndex = -1;
            txtRecomendaciones.Clear();
            txtSeccion.Clear();
            txtIntervencion.Clear();
            txtSituacion.Clear();
        }

        private void cboMotivos_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void CargarComboMotivos()
        {
            // cboMotivos.DataSource = 
            cboMotivos.DataSource = logicaMotivo.SeleccionarTodas();
            cboMotivos.DisplayMember = "Descripcion";

            //refe1
           // cboMotivos.ValueMember = "NumeroMotivo";
            cboMotivos.SelectedIndex = -1;


        }

        private void FrmEntrevistaEstudiante_Load(object sender, EventArgs e)
        {
            CargarComboMotivos();
            mskFecha.Text = DateTime.Now.ToShortDateString();
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            //boton de cancelar
            try
            {
                DialogResult dialogo = MessageBox.Show("Desea cerrar la entrevista con el estudiante.", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk);
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
