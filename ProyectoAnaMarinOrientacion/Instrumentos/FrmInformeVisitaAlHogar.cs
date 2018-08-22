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
    public partial class FrmInformeVisitaAlHogar : Form
    {

       Capa.Logica.InstrumentosLN.InformeVisitaAlHogarLN Logica;
        Capa.Logica.MotivoAtencionLN logicaMotivo;
        static public InformeVisitaAlHogar informeVisitaAlHogar;

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
                    NombreFuncionario = txtProfesionalQRealizaLaVisita.Text,
                    Puesto = txtCargo.Text,
                    Acciones= txtAccionesSeguimiento.Text,
                    Situacion = txtSitucionObservada.Text,
                    Recomendaciones = txtRecomendaciones.Text,
                    Motivo = (MotivoAtencion)cboMotivos.SelectedItem,                    
                    Nombre = "Visita al Hogar",
                    Intervencion ="",                    
                    TipoInstrumento = Capa.Entidades.Enumeradores.TipoInstrumentos.InformeDeVisitaAlHogar
                };
                FrmExpediente.instrumentos.Add(visita);
               // Logica.Guardar(vista);
                MessageBox.Show("Datos guardados con exito ");
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
            //cboMotivos.SelectedIndex = -1;


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

        private void FrmInformeVisitaAlHogar_Load(object sender, EventArgs e)
        {
            ValidarUsuario();
            CargarComboMotivos();
            if(informeVisitaAlHogar!= null)
            {
                txtProfesionalQRealizaLaVisita.Text = informeVisitaAlHogar.NombreFuncionario;
                txtCargo.Text = informeVisitaAlHogar.Puesto;
                txtAccionesSeguimiento.Text = informeVisitaAlHogar.Acciones;
                txtSitucionObservada.Text = informeVisitaAlHogar.Situacion;
                txtRecomendaciones.Text = informeVisitaAlHogar.Recomendaciones;
                cboMotivos.SelectedItem = informeVisitaAlHogar.Motivo.ToString();
            }
            
        }
    }
}
