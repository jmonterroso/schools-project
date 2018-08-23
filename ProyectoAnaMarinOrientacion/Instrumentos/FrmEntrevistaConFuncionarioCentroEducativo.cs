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
    public partial class FrmEntrevistaConFuncionarioCentroEducativo : Form
    {
        private List<Archivo> Archivos;
        Capa.Logica.InstrumentosLN.EntrevistaConFuncionarioLN logicaFuncionarios = new Capa.Logica.InstrumentosLN.EntrevistaConFuncionarioLN();

        Capa.Logica.MotivoAtencionLN logicaMotivo;
        public static EntrevistaFuncionario entrevistaFuncionario;
        public FrmEntrevistaConFuncionarioCentroEducativo()
        {
            InitializeComponent();
            
            logicaFuncionarios = new Capa.Logica.InstrumentosLN.EntrevistaConFuncionarioLN();
            //falta cargar fecha
            //DateTime dt = DateTime.Parse(mskFecha.Text);
            logicaMotivo= new Capa.Logica.MotivoAtencionLN();
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
        private void FrmEntrevistaConFuncionarioCentroEducativo_Load(object sender, EventArgs e)
        {
            Archivos = new List<Archivo>();
            CargarComboMotivos();
            ValidarUsuario();
            if (entrevistaFuncionario != null)
            {
                txtResumen.Text = entrevistaFuncionario.Situacion;
                txtRecomendaciones.Text = entrevistaFuncionario.Recomendaciones;
                txtNombreFuncionario.Text = entrevistaFuncionario.NombreFuncionario;
                txtPuesto.Text = entrevistaFuncionario.Puesto;
                cboMotivo.SelectedItem = entrevistaFuncionario.Motivo ;
                txtAcuerdos.Text = entrevistaFuncionario.Acciones;




            }
            RefrescarListBox();




        }


        private void CargarComboMotivos()
        {
           // cboMotivos.DataSource = 
            cboMotivo.DataSource = logicaMotivo.SeleccionarTodas();
            

            cboMotivo.DisplayMember = "Descripcion";

            //refe1
           // comboBox1.ValueMember = "NumeroMotivo";
            //cboMotivo.SelectedIndex = -1;


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


            if (cboMotivo.SelectedIndex == -1)
            {
                MessageBox.Show("Debe seleccionar un motivo de atencion ");
                cboMotivo.Focus();
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
                entrevista.Acciones = txtAcuerdos.Text;
                entrevista.Intervencion = "";
                entrevista.Recomendaciones = txtRecomendaciones.Text;
                entrevista.Situacion = txtResumen.Text;
                entrevista.Motivo = (MotivoAtencion)cboMotivo.SelectedItem;
                entrevista.Nombre = "Entrevista con Funcionario";
                entrevista.TipoInstrumento = Capa.Entidades.Enumeradores.TipoInstrumentos.EntrevistaAlFuncionario;
                entrevista.Archivos = Archivos;

                MessageBox.Show("  Datos guardados con exito ");
                //logicaFuncionarios.Guardar(entrevista);
                FrmExpediente.instrumentos.Add(entrevista);
                Limpiar();
                Dispose();
                entrevistaFuncionario = null;

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
            txtNombreFuncionario.Clear();
            txtPuesto.Clear();
            txtRecomendaciones.Clear();
            txtResumen.Clear();
            

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

        private void txtResumen_TextChanged(object sender, EventArgs e)
        {

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
            if (entrevistaFuncionario!= null)
            {
                Archivos = entrevistaFuncionario.Archivos;
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

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_DoubleClick(object sender, EventArgs e)
        {
            DescargarArchivo();
        }

        private void FrmEntrevistaConFuncionarioCentroEducativo_FormClosed(object sender, FormClosedEventArgs e)
        {
            entrevistaFuncionario = null;
        }
    }
}
