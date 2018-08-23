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
    public partial class FrmEntrevistaEstudiante : Form
    {

        Capa.Logica.MotivoAtencionLN logicaMotivo;
        public static EntrevistaEstudiante entrevistaEstudiante;
        private List<Archivo> Archivos;
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

                entrevista.Intervencion = txtIntervencion.Text;
                entrevista.Situacion = txtSituacion.Text;
                entrevista.Acciones = txtProceso.Text;
                entrevista.Recomendaciones = txtRecomendaciones.Text;
                entrevista.Motivo = (MotivoAtencion)cboMotivos.SelectedItem;
                entrevista.Nombre = "Entrevista a Estudiante";
                entrevista.DetecciondelProfesional = ckcDeteccionProfesional.Checked;
                entrevista.Referencia = ckcReferencia.Checked;
                entrevista.Solicitud = ckcReferencia.Checked;
                entrevista.Otros = ckcOtro.Checked;
                entrevista.OtrosExplicacion = txtOtro.Text;
                entrevista.TipoInstrumento = TipoInstrumentos.EntrevistaEstudiante;
                // Agregar Entrevista
                entrevista.Archivos = Archivos;
                FrmExpediente.instrumentos.Add(entrevista);
                MessageBox.Show("  Datos guardados con exito ");
                Limpiar();
                Dispose();
                entrevistaEstudiante = null;


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
            
            txtProceso.Clear();
            cboMotivos.SelectedIndex = -1;
            txtRecomendaciones.Clear();
            
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
            if(Usuario.UsuarioActual.Rol == TipoUsuario.Encargado)
            {
                DeshabilitarControles();
            }


        }
        private void FrmEntrevistaEstudiante_Load(object sender, EventArgs e)
        {
            CargarComboMotivos();
            ValidarUsuario();
            Archivos = new List<Archivo>();
            if (entrevistaEstudiante != null)
            {
                txtIntervencion.Text = entrevistaEstudiante.Intervencion;
                txtSituacion.Text = entrevistaEstudiante.Situacion;
                txtProceso.Text = entrevistaEstudiante.Acciones;
                txtRecomendaciones.Text = entrevistaEstudiante.Recomendaciones;
                cboMotivos.SelectedItem = entrevistaEstudiante.Motivo.ToString() ;
                ckcDeteccionProfesional.Checked = entrevistaEstudiante.DetecciondelProfesional;
                ckcReferencia.Checked = entrevistaEstudiante.Referencia;
                ckcReferencia.Checked = entrevistaEstudiante.Solicitud;
                ckcOtro.Checked = entrevistaEstudiante.Otros;
                txtOtro.Text = entrevistaEstudiante.OtrosExplicacion;
                List<Archivo> listaArchivos = new List<Archivo>();
                listaArchivos = entrevistaEstudiante.Archivos;
                listBox1.DataSource = listaArchivos;
                
            }
            RefrescarListBox();

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
                    entrevistaEstudiante = null;

                }
                else
                    return;
            }
            catch
            {
            }

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
            if (entrevistaEstudiante != null)
            {
                Archivos = entrevistaEstudiante.Archivos;
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

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void FrmEntrevistaEstudiante_FormClosed(object sender, FormClosedEventArgs e)
        {
            entrevistaEstudiante = null;
        }
    }
}
