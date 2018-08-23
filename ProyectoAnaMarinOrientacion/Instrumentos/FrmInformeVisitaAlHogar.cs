using Capa.Entidades;
using Capa.Entidades.Enumeradores;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoAnaMarinOrientacion.Instrumentos
{
    public partial class FrmInformeVisitaAlHogar : Form
    {
        private List<Archivo> Archivos;
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
                    TipoInstrumento = Capa.Entidades.Enumeradores.TipoInstrumentos.InformeDeVisitaAlHogar,
                    Archivos = Archivos

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
                    informeVisitaAlHogar = null;
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
            Archivos = new List<Archivo>();
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

            RefrescarListBox();
        }
        private void DescargarArchivo()
        {
            Archivo currArchivo = (Archivo)listBox1.SelectedItem;
            SaveFileDialog folderBrowser = new SaveFileDialog();

            folderBrowser.FileName = currArchivo.Nombre;
            folderBrowser.ShowDialog();

            if (folderBrowser.FileName != "")
            {

                File.WriteAllBytes(folderBrowser.FileName, currArchivo.ArchivoBytes);
                MessageBox.Show("Archivo descargado");
            }

        }
        private void RefrescarListBox()
        {
            listBox1.DataSource = null;
            if (informeVisitaAlHogar != null)
            {
                Archivos = informeVisitaAlHogar.Archivos;
            }

            listBox1.DataSource = Archivos;
        }

        private void AgregarArchivo()
        {
            System.IO.Stream myStream;

            OpenFileDialog thisDialog = new OpenFileDialog();

            thisDialog.InitialDirectory = "c:\\";
            thisDialog.Filter = "All files (*.*)|*.*";
            thisDialog.FilterIndex = 2;
            thisDialog.RestoreDirectory = true;
            thisDialog.Multiselect = true;
            thisDialog.Title = "Please Select Source File(s) for Conversion";

            if (thisDialog.ShowDialog() == DialogResult.OK)
            {
                foreach (String file in thisDialog.FileNames)
                {
                    try
                    {
                        if ((myStream = thisDialog.OpenFile()) != null)
                        {
                            using (myStream)
                            {

                                Archivo archivo = new Archivo();
                                archivo.Nombre = thisDialog.SafeFileName;
                                archivo.ArchivoBytes = File.ReadAllBytes(file);
                                Archivos.Add(archivo);
                                RefrescarListBox();
                            }
                        }
                    }

                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: Could not read file from disk. Original error: " + ex.Message);
                    }
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AgregarArchivo();
        }

        private void listBox1_DoubleClick(object sender, EventArgs e)
        {
            DescargarArchivo();
        }

        private void FrmInformeVisitaAlHogar_FormClosed(object sender, FormClosedEventArgs e)
        {
            informeVisitaAlHogar = null;
        }
    }
}
