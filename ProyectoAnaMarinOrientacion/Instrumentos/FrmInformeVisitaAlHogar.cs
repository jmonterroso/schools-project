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
    public partial class FrmInformeVisitaAlHogar : Form
    {

       Capa.Logica.InstrumentosLN.InformeVisitaAlHogarLN Logica;
        Capa.Logica.MotivoAtencionLN logicaMotivo;

        public FrmInformeVisitaAlHogar()
        {
            InitializeComponent();
            Logica = new Capa.Logica.InstrumentosLN.InformeVisitaAlHogarLN();
            logicaMotivo = new Capa.Logica.MotivoAtencionLN();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            //boton de aceptar

            //if (txtNombrePadre.Text == "")
            //{
            //    MessageBox.Show("Debe digitar el nombre del padre/madre/encargado");
            //    txtNombrePadre.Focus();
            //    return;
            //}

            if (txtDireccion.Text == "")
            {
                MessageBox.Show("Debe digitar la direccion ");
                txtDireccion.Focus();
                return;
            }
            if (txtProfesionalQRealizaLaVisita.Text == "")
            {
                MessageBox.Show("Debe digitar el nombre del profesional que realiza la visita ");
                txtProfesionalQRealizaLaVisita.Focus();
                return;
            }

            if (txtCargo.Text == "")
            {
                MessageBox.Show("Debe digitar el cargo del profesional ");
                txtCargo.Focus();
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

            if (txtRecomendaciones.Text == "")
            {
                MessageBox.Show("Debe digitar las recomendaciones dadas ");
                txtRecomendaciones.Focus();
                return;
            }

            if (txtAccionesSeguimiento.Text == "")
            {
                MessageBox.Show("Debe digitar las acciones de seguimiento ");
                txtAccionesSeguimiento.Focus();
                return;
            }


           
            try
            {

                InformeVisitaAlHogar visita = new InformeVisitaAlHogar()
                {
                    Numero = (Convert.ToInt32(txtNumeroInst.Text)),
                    ProfesionaQueRealizaLaVisita = txtProfesionalQRealizaLaVisita.Text,
                    Cargo = txtCargo.Text,
                     AccionesSeguimiento= txtAccionesSeguimiento.Text,
                    SituacionObservada = txtSitucionObservada.Text,
                    Recomendaciones = txtRecomendaciones.Text,
                    Motivo = (MotivoAtencion)cboMotivos.SelectedItem,
                    Direccion= txtDireccion.Text,
                    Nombre = "Visita al Hogar"
                };
                FrmExpediente.instrumentos.Add(visita);
               // Logica.Guardar(vista);
                MessageBox.Show("  Datos guardados con exito ");
                Dispose();


            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error al ingresar el informe de visita al hogar"
                    , MessageBoxButtons.OK, MessageBoxIcon.Error);
            }




        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            //boton de cancelar
            try
            {
                DialogResult dialogo = MessageBox.Show("Desea cerrar el informe al hogar", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk);
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

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void CargarComboMotivos()
        {
            // cboMotivos.DataSource = 
            cboMotivos.DataSource = logicaMotivo.SeleccionarTodas();
            cboMotivos.DisplayMember = "Descripcion";

            //refe1
          //  cboMotivos.ValueMember = "NumeroMotivo";
            cboMotivos.SelectedIndex = -1;


        }

        private void FrmInformeVisitaAlHogar_Load(object sender, EventArgs e)
        {
            CargarComboMotivos();
            mskFecha.Text = DateTime.Now.ToShortDateString();
        }
    }
}
