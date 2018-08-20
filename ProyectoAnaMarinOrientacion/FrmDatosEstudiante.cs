using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//AForge.Video dll
using AForge.Video;
using AForge.Video.DirectShow;
using System.IO;
using System.Drawing.Imaging;
using Capa.Logica;
using Capa.Entidades;
using Capa.Entidades.Enumeradores;

namespace ProyectoAnaMarinOrientacion
{
    public partial class FrmDatosEstudiante : Form
    {
        private FilterInfoCollection Dispositivos; //LISTA DE DISPOSITIVOS
        private VideoCaptureDevice FuenteDeVideo; //DISPOSITIVO QUE USAREMOS COMO FUENT
        Capa.Logica.EstudianteLN logica;
        Capa.Logica.SeccionesLN logicasecciones;
        Capa.Logica.EncargadoLN logicaEncargado;

        private byte[] imagenEstudiante;
        public FrmDatosEstudiante()
        {
            InitializeComponent();
            logica= new Capa.Logica.EstudianteLN();
            logicasecciones = new Capa.Logica.SeccionesLN();
            logicaEncargado = new Capa.Logica.EncargadoLN();

        }

        /// <summary>
        /// boton de aceptar
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pictureBox3_DoubleClick(object sender, EventArgs e)
        {

        }


        /// <summary>
        /// Boton cancelar
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pictureBox2_DoubleClick(object sender, EventArgs e)
        {

        }

        private void FrmDatosEstudiante_Load(object sender, EventArgs e)
        {//cargar el combo sexo
            CargarSexo();
            CargarNiveles();
            //cargar provincias

            //cargar secciones

            //LISTAR DISPOSITIVOS DE ENTRADAS DE VIDEO
            Dispositivos = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            //Dispositivos tiene el array, con todos los dispositivos disponibles
            foreach (FilterInfo x in Dispositivos)
            {
                comboBox1.Items.Add(x.Name);
            }
            comboBox1.SelectedIndex = 0;
        }
        // boton para encender la camara
        private void button1_Click(object sender, EventArgs e)
        {
            //ESTABLECER EL DISPOSITIVO SELECCIONADO COMO FUENTE DE VIDEO
            FuenteDeVideo = new VideoCaptureDevice(Dispositivos[comboBox1.SelectedIndex].MonikerString);
            //INICIALIZAR EL CONTROL
            videoSourcePlayer1.VideoSource = FuenteDeVideo;
            //INICIAR LA RECEPCIÓN DE IMAGENES
            videoSourcePlayer1.Start();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //DETENER LA RECEPCIÓN DE IMAGENES
            videoSourcePlayer1.SignalToStop();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // DIALOGO PARA SELECCIONAR LA RUTA PARA GUARDAR
            SaveFileDialog sf = new SaveFileDialog();
            //FILTO DE IMAGENES JPG
            sf.Filter = "Imagenes JPG | *.jpg";
            //MOSTRAR DIALOGO
            Bitmap img = videoSourcePlayer1.GetCurrentVideoFrame();
            pictureBox4.Image = img.Clone(new Rectangle(0, 0, img.Width, img.Height),
     System.Drawing.Imaging.PixelFormat.DontCare);
            MemoryStream ms = new MemoryStream();
            img.Save(ms, ImageFormat.Jpeg);
            imagenEstudiante = ms.ToArray();

            // sf.ShowDialog();
            //ASEGURAR QUE TIENE UNA RUTA VALIDA
            //if (sf.FileName != null)
            //{
            //    //VARIBALE PARA LA IMAGEN
            //    //Bitmap img = videoSourcePlayer1.GetCurrentVideoFrame();

            //    //GUARDAR IMAGEN EN LA RUTA
            //    img.Save(sf.FileName, System.Drawing.Imaging.ImageFormat.Jpeg);

            //    //BORRAR IMAGEN DE MEMORIA
            //    MemoryStream ms = new MemoryStream();
            //    img.Save(ms, ImageFormat.Jpeg);
            //    imagenEstudiante = ms.ToArray();


            //    img.Dispose();
            //    pictureBox4.Load(sf.FileName);
            //    pictureBox4.Update();
            //    videoSourcePlayer1.SignalToStop();
            //    //PROBAR!



            //}

        }

        private void btnSubirFot_Click(object sender, EventArgs e)
        {
            Stream myStream = null;
            OpenFileDialog openFileDialog1 = new OpenFileDialog();

            openFileDialog1.InitialDirectory = "c:\\";
            openFileDialog1.Filter = "Image files (*.jpg, *.jpeg, *.jpe, *.jfif, *.png) | *.jpg; *.jpeg; *.jpe; *.jfif; *.png";
            openFileDialog1.FilterIndex = 2;
            openFileDialog1.RestoreDirectory = true;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    string filename = openFileDialog1.FileName;
                    pictureBox4.Image= new Bitmap(openFileDialog1.FileName);
                    imagenEstudiante = File.ReadAllBytes(filename);

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: Could not read file from disk. Original error: " + ex.Message);
                }
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {//boton de aceptar// guarda un estudiante

            try
            {

                Estudiante est = new Estudiante()
                {
                    Identificacion = txtIdentificacion.Text,
                    NombreCompleto = txtNombreCompleto.Text,
                    Seccion = (Secciones) cboSecciones.SelectedItem,
                    Sexo = (Sexo)cboSexo.SelectedItem,
                    FechaNacimiento =(DateTime.Parse( mskFechaNacimiento.Text)),
                    Direccion= txtDireccion.Text,
                    Foto= imagenEstudiante,
                };
                logica.Guardar(est);
                MessageBox.Show("  Datos guardados con exito ");
                FrmExpediente.est = est;
                Dispose();
                
                Limpiar();



            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error al ingresar el estudiante"
                    , MessageBoxButtons.OK, MessageBoxIcon.Error);
            }



        }

        private void button5_Click(object sender, EventArgs e)
        {//boton para cancelar
            try
            {
                DialogResult dialogo = MessageBox.Show("Desea cerrar la ventada de datos de estudiante", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk);
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

        private void CargarSexo()
        {
            cboSexo.DataSource = Enum.GetValues(typeof(Sexo));
            cboSexo.SelectedIndex = -1;
        }


        private void CargarNiveles()
        {
            cboNivel.DataSource = logicasecciones.SeleccionarTodos();
            cboNivel.SelectedIndex = -1;
        }
        private void CargarSecciones()
        {
            Capa.Entidades.Nivel nivel = (Capa.Entidades.Nivel)cboNivel.SelectedItem;

            cboSecciones.DataSource = logicasecciones.SeleccionarSeccionPorNivel(nivel.IdNivel);
            
            cboSecciones.ValueMember = "Id";
            cboSecciones.DisplayMember = "Display";
            cboSecciones.SelectedIndex = -1;

        }

      

        private void txtDireccion_TextChanged(object sender, EventArgs e)
        {

        }

        private void Limpiar()
            {
            txtDireccion.Clear();
            txtIdentificacion.Clear();
            txtNombreCompleto.Clear();
            cboSecciones.SelectedIndex = -1;
            cboSexo.SelectedIndex = -1;
            mskFechaNacimiento.Clear();
            pictureBox4.Image = null;



            }

        private void cboNivel_SelectedIndexChanged(object sender, EventArgs e)
        {
            CargarSecciones();
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnBuscarEncargado_Click(object sender, EventArgs e)
        {
            string identificadorEncargado = txtIdentificadorEncargado.Text;
            Encargado encargado = logicaEncargado.SeleccionarPorId(identificadorEncargado);
            if(encargado!= null)
            {

                txtEncargadoResultado.Text = encargado.NombreCompleto;
            }
            else
            {
                txtEncargadoResultado.Text = "El Id del encargado no fue encontrado";
            }
        }
    }
    }

