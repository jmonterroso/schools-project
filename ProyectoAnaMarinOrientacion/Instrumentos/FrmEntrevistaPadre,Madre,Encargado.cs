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
    public partial class FrmEntrevistaPadre_Madre_Encargado : Form
    {
        private List<Archivo> Archivos;
        Capa.Logica.MotivoAtencionLN logicaMotivo;

        public static EntrevistaEncargado entrevistaEncargado;
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

        private void FrmEntrevistaPadre_Madre_Encargado_Load(object sender, EventArgs e)
        {
            Archivos = new List<Archivo>();
            CargarComboMotivos();
            ValidarUsuario();
            if(entrevistaEncargado != null)
            {
                txtResumen.Text = entrevistaEncargado.Situacion;
                txtRecomendaciones.Text = entrevistaEncargado.Recomendaciones;
                cboMotivos.SelectedItem = entrevistaEncargado.Motivo.ToString();
                ckConvocadoPorEncargado.Checked = entrevistaEncargado.ConvocadoPorEncargado;
                ckConvocadoPorInstitucion.Checked = entrevistaEncargado.ConvocadoPorInstitucion;

            }
            RefrescarListBox();


        }

        private void RefrescarListBox()
        {
            listBox1.DataSource = null;
            if (entrevistaEncargado != null)
            {
                Archivos = entrevistaEncargado.Archivos;
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
                entrevista.Acciones = "";
                entrevista.Intervencion = "";
                entrevista.Situacion = txtResumen.Text;
                entrevista.Recomendaciones = txtRecomendaciones.Text;
                entrevista.Motivo = (MotivoAtencion)cboMotivos.SelectedItem;
                entrevista.TipoInstrumento = Capa.Entidades.Enumeradores.TipoInstrumentos.EntrevistaAlEncargado;
                entrevista.ConvocadoPorEncargado = ckConvocadoPorEncargado.Checked;
                entrevista.ConvocadoPorInstitucion = ckConvocadoPorInstitucion.Checked;
                entrevista.Nombre = "Entrevista Encargado";
                entrevista.Archivos = Archivos;
                MessageBox.Show("  Datos guardados con exito ");
                FrmExpediente.instrumentos.Add(entrevista);
                Limpiar();
                Dispose();
                entrevistaEncargado = null;


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
            //cboMotivos.SelectedIndex = -1;


        }

        private void Limpiar()
        {
            
            txtRecomendaciones.Clear();
            txtResumen.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AgregarArchivo();
        }

        private void listBox1_DoubleClick(object sender, EventArgs e)
        {
            DescargarArchivo();
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

        private void FrmEntrevistaPadre_Madre_Encargado_FormClosed(object sender, FormClosedEventArgs e)
        {
            entrevistaEncargado = null;
        }
    }
    }

