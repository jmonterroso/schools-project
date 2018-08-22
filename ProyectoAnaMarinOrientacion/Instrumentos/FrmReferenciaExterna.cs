using Capa.Entidades;
using Capa.Entidades.Enumeradores;
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
    public partial class FrmReferenciaExterna : Form
    {
        static public Referencia referencia;

        Capa.Logica.MotivoAtencionLN logicaMotivo;
        public FrmReferenciaExterna()
        {
            InitializeComponent();
            logicaMotivo = new Capa.Logica.MotivoAtencionLN();
        }

        private void txtAcuerdos_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (txtIntituciondondeserefiere.Text == "")
            {
                MessageBox.Show("Debe digitar el nombre de la institucion que refiere");
                txtIntituciondondeserefiere.Focus();
                return;
            }
           

           
            if (txtPersonaRefiere.Text == "")
            {
                MessageBox.Show("Debe digitar el nombre de la persona que refiere");
                txtPersonaRefiere.Focus();
                return;
            }
            if (txtPuesto.Text == "")
            {
                MessageBox.Show("Debe digitar el cargo/puesto del profesional ");
                txtPuesto.Focus();
                return;
            }


            if (cboMotivos.SelectedIndex == -1)
            {
                MessageBox.Show("Debe seleccionar un motivo de atencion ");
                cboMotivos.Focus();
                return;
            }

            if (txtSitucionObservada.Text == "")
            {
                MessageBox.Show("Debe digitar la situacion encontrada ");
                txtSitucionObservada.Focus();
                return;
            }

            if (txtAcuerdos.Text == "")
            {
                MessageBox.Show("Debe digitar los acuerdos que ha realizado el centro ");
                txtAcuerdos.Focus();
                return;
            }

            if (txtRecomendaciones.Text == "")
            {
                MessageBox.Show("Debe digitar las observaciones y recomendaciones dadas ");
                txtRecomendaciones.Focus();
                return;
            }


            try
            {

                Referencia entre = new Referencia()
                {
                   // Numero = (Convert.ToInt32(txtNumeroInst.Text)),
                    PersonaRefiere = txtPersonaRefiere.Text,
                    Puesto = txtPuesto.Text,
                    Situacion = txtSitucionObservada.Text,
                    Acciones = txtAcuerdos.Text,
                    Recomendaciones = txtRecomendaciones.Text,
                    Motivo = (MotivoAtencion)cboMotivos.SelectedItem,
                    InstitucionRefiere = txtIntituciondondeserefiere.Text,
                    Nombre = "Referencia Externa",
                    Intervencion="",
                    TipoInstrumento = Capa.Entidades.Enumeradores.TipoInstrumentos.ReferenciaExterna
                };
                //FrmExpediente.referenciaExterna.Add(entre);
                FrmExpediente.instrumentos.Add(entre);
                MessageBox.Show("  Datos guardados con exito ");
                Limpiar();
                Dispose();


            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error al ingresar el informe de referencia externa"
                    , MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void label23_Click(object sender, EventArgs e)
        {

        }

        private void DeshabilitarControles()
        {
            foreach (Control child in this.Controls)
            {

                child.Enabled = false;
            }
        }
        private void ValidarUsuario()
        {
            if (Usuario.UsuarioActual.Rol == TipoUsuario.Encargado)
            {
                DeshabilitarControles();
            }


        }
        private void FrmReferenciaExterna_Load(object sender, EventArgs e)
        {
            CargarComboMotivos();
            ValidarUsuario();
            if (referencia != null)
            {
                txtPersonaRefiere.Text = referencia.PersonaRefiere;
                txtPuesto.Text = referencia.Puesto;
                txtSitucionObservada.Text = referencia.Situacion;
                txtAcuerdos.Text = referencia.Acciones;
                txtRecomendaciones.Text = referencia.Recomendaciones;
                cboMotivos.SelectedItem = referencia.Motivo.ToString();               

                txtIntituciondondeserefiere.Text = referencia.InstitucionRefiere;
            }
        }
        private void CargarComboMotivos()
        {
            // cboMotivos.DataSource = 
            cboMotivos.DataSource = logicaMotivo.SeleccionarTodas();
            cboMotivos.DisplayMember = "Descripcion";

            //refe1
            //cboMotivos.ValueMember = "NumeroMotivo";
            //cboMotivos.SelectedIndex = -1;


        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            //boton de cancelar
            try
            {
                DialogResult dialogo = MessageBox.Show("Desea cerrar el informe de referencia externa", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk);
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

        private void Limpiar()
        {
            
            txtIntituciondondeserefiere.Clear();            
            txtAcuerdos.Clear();            
            txtPersonaRefiere.Clear();            
            txtPuesto.Clear();
            txtRecomendaciones.Clear();
            txtSitucionObservada.Clear();            
        }

        private void groupEstudiante_Enter(object sender, EventArgs e)
        {

        }

        private void groupEncargado_Enter(object sender, EventArgs e)
        {

        }
    }
}
