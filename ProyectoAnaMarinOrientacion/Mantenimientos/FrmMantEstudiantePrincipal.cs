using AForge.Video.DirectShow;
using Capa.Entidades;
using Capa.Entidades.Enumeradores;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoAnaMarinOrientacion.Mantenimientos
{
    public partial class FrmMantEstudiantePrincipal : Form
    {

        private FilterInfoCollection Dispositivos; //LISTA DE DISPOSITIVOS
        private VideoCaptureDevice FuenteDeVideo; //DISPOSITIVO QUE USAREMOS COMO FUENT
        Capa.Logica.EstudianteLN logica;
        Capa.Logica.SeccionesLN logicasecciones;
        Capa.Logica.EncargadoLN logicaencargado;
        Capa.Logica.NivelLN logicaNivel;
        Capa.Logica.CicloLN logicaCiclo;
        private byte[] imagenEstudiante;
        Encargado encargado;
        public FrmMantEstudiantePrincipal()
        {
            InitializeComponent();

            logica = new Capa.Logica.EstudianteLN();
            logicasecciones = new Capa.Logica.SeccionesLN();
            logicaencargado = new Capa.Logica.EncargadoLN();
            logicaNivel = new Capa.Logica.NivelLN();
            logicaCiclo = new Capa.Logica.CicloLN();
            Refrescar();

        }

        private void CargarSexo()
        {
            cboSexo.DataSource = Enum.GetValues(typeof(Sexo));
            cboSexo.SelectedIndex = -1;
        }

        private void CargarSecciones()
        {
            if (cboNivel.SelectedItem == null)
            {
                return;
            }
            Nivel seleccionNivel = (Nivel)cboNivel.SelectedItem;
            cboSeccion.DataSource = logicasecciones.SeleccionarSeccionPorNivel(seleccionNivel.IdNivel);
            cboSeccion.DisplayMember = "Nombre";
            cboSeccion.ValueMember = "Id";
            cboSeccion.SelectedIndex = -1;
            

        }

       
        private void toolStripButton1_Click(object sender, EventArgs e)
        {//boton para insertar

            dgvEstudiantes.Visible = true;
            dgvEstudiantes.ReadOnly = true;
            dgvEstudiantes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            groupBox1.Visible = true;
            groupBox2.Visible = true;
            pictureBox1.Visible = true;
            Refrescar();

        }


        private void Refrescar()
        {

            dgvEstudiantes.AutoGenerateColumns = false;

            // creacion de binding para los datagrids
            dgvEstudiantes.DataSource = null;
            var listaEstudiantes = new BindingList<Estudiante>(logica.SeleccionarTodos());
            // asignacion de datagrids
            
            dgvEstudiantes.AutoGenerateColumns = false;
            dgvEstudiantes.DataSource = listaEstudiantes;

        }
        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            ///sumary
            ///Metodo para actualizar un estudiante
            ///sumary
            ///
            groupBox1.Visible = true;
            groupBox2.Visible = true;
            //Actualizar
            //  Refrescar();
            txtIdentificacion.ReadOnly = true;
            dgvEstudiantes.Visible = true;
            btnCancelar.Enabled = true;
            btnGuardar.Enabled = true;
            //Obtener el id de la fila seleccionada
            if (dgvEstudiantes.SelectedRows.Count > 0)
            {
                var estud = (Estudiante)dgvEstudiantes.SelectedRows[0].DataBoundItem;
                txtIdentificacion.Text = estud.Identificacion.ToString();
                txtNombreCompleto.Text = estud.NombreCompleto;
                txtDireccion.Text = estud.Direccion;
                //cboProvincia.SelectedItem = estud.;
                cboCiclo.SelectedItem = estud.Seccion;
                cboSexo.SelectedItem = estud.Sexo;

                groupBox1.Visible = true;
                logica.SeleccionarPorId(estud.Identificacion);
            }
            else
            {
                MessageBox.Show("Debe seleccionar un estudiante a actualizar");
            }

        }

        private void FrmMantEstudiantePrincipal_Load(object sender, EventArgs e)
        {
            dgvEstudiantes.Visible = false;
            dgvEstudiantes.ReadOnly = true;
            dgvEstudiantes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            groupBox1.Visible = false;
            groupBox2.Visible = false;
            pictureBox1.Visible = false;

            //cargar el combo sexo
            CargarSexo();

            CargarCiclo();

               //cargar secciones
               //CargarSecciones();

               //LISTAR DISPOSITIVOS DE ENTRADAS DE VIDEO
               Dispositivos = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            //Dispositivos tiene el array, con todos los dispositivos disponibles
            foreach (FilterInfo x in Dispositivos)
            {
                comboBox1.Items.Add(x.Name);
            }
            //comboBox1.SelectedIndex = 0;
        }

        private void button4_Click(object sender, EventArgs e)
        {

            // validaciones
            if (txtIdentificacion.Text == "")
            {
                MessageBox.Show("Debe digitar la identificacion del estudiante");
                return;
            }

            if (txtNombreCompleto.Text == "")
            {
                MessageBox.Show("Debe digitar el nombre del estudiante");
                return;
            }

            if (cboCiclo.SelectedIndex == -1)
            {
                MessageBox.Show("Debe digitar el nivel del estudiante");
                return;
            }

            if (cboNivel.SelectedIndex == -1)
            {
                MessageBox.Show("Debe digitar el ciclo del estudiante");
                return;
            }

            if (cboSeccion.SelectedIndex == -1)
            {
                MessageBox.Show("Debe digitar la seccion del estudiante");
                return;
            }

            if (cboSexo.SelectedIndex == -1)
            {
                MessageBox.Show("Debe digitar el sexo del estudiante");
                return;
            }

            if (mskFechaNacimiento.Text == "") { 
                MessageBox.Show("Debe digitar la fecha de nacimiento del estudiante");
            return;
             }

            if (txtDireccion.Text == "")
            {
                MessageBox.Show("Debe digitar la direccion del estudiante");
                return;
            }
            if (txtIdentificadorEnc.Text == "")
            {
                MessageBox.Show("Debe digitar la identificacion del encargado del estudiante");
                return;
            }

            //if (btnSubirFot == null)
            //{
            //    MessageBox.Show("Debe  agregar una foto estudiante");
            //    return;
            //}
           // if(comboBox1.SelectedIndex == -1)
            //{
            //    MessageBox.Show("Debe  seleccionar una camara para la foto estudiante");
              //  return;
        //    }

            //boton de aceptar

            try
            {
                if(encargado == null)
                {
                    MessageBox.Show("Debe seleccionar a un encargado para el estudiante");
                    return;
                }

                Estudiante est = new Estudiante()
                {
                    Identificacion = txtIdentificacion.Text,
                    NombreCompleto = txtNombreCompleto.Text,
                    Seccion = (Secciones)cboSeccion.SelectedItem,
                    Sexo = (Sexo)cboSexo.SelectedItem,
                    FechaNacimiento = (DateTime.Parse(mskFechaNacimiento.Text)),
                    Direccion = txtDireccion.Text,
                    Foto = imagenEstudiante,
                    IdEncargado = encargado.Identificacion
                };
                logica.Guardar(est);
                MessageBox.Show("  Datos guardados con exito ");


            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error al ingresar el estudiante"
                    , MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void button5_Click(object sender, EventArgs e)
        {
            //boton para cancelar
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



        private void button3_Click(object sender, EventArgs e)
        {
            //boton de capturar
            //if (FuenteDeVideo == null)
            //{
            //    MessageBox.Show("Debe seleccionar una camara para tomar la foto ");
            //    return;
            //}
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

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //boton de enceder camara
            //if (FuenteDeVideo == null)
            // //   if (comboBox1.SelectedIndex == -1)
            //{
            //    MessageBox.Show("Debe seleccionar una camara para tomar la foto ");
            //    return;
            //}
                //ESTABLECER EL DISPOSITIVO SELECCIONADO COMO FUENTE DE VIDEO
            FuenteDeVideo = new VideoCaptureDevice(Dispositivos[comboBox1.SelectedIndex].MonikerString);
            //INICIALIZAR EL CONTROL
            videoSourcePlayer1.VideoSource = FuenteDeVideo;
            //INICIAR LA RECEPCIÓN DE IMAGENES
            videoSourcePlayer1.Start();
        }

        private void button2_Click(object sender, EventArgs e)
        {//boton de detener camara
            //if(FuenteDeVideo == null)
            ////if (button1.Text == null)
            //{
            //    MessageBox.Show("Debe encender la camara primero");
            //    return;
            //}
            //DETENER LA RECEPCIÓN DE IMAGENES
            videoSourcePlayer1.SignalToStop();
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
                    pictureBox4.Image = new Bitmap(openFileDialog1.FileName);
                    imagenEstudiante = File.ReadAllBytes(filename);

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: Could not read file from disk. Original error: " + ex.Message);
                }
            }
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {//boton para eliminar
            btnCancelar.Enabled = false;
            btnGuardar.Enabled = false;


            string msg = "¿Desea eliminar el estudiante seleccionado?";
            var resultado = MessageBox.Show(msg, "Pregunta", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
            if (resultado == DialogResult.Yes)
            {
                if (dgvEstudiantes.SelectedRows.Count > 0)
                {
                    //databounditem retorna el objeto que asigno en datasource
                    var est = (Estudiante)dgvEstudiantes.SelectedRows[0].DataBoundItem;
                    logica.Eliminar(est);
                    Refrescar();

                }
            }
        }

        private void dgvEstudiantes_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (dgvEstudiantes.SelectedRows.Count > 0)
            {
                //databounditem retorna el objeto que asigno en datasource
                var est = (Estudiante)dgvEstudiantes.SelectedRows[0].DataBoundItem;
                txtIdentificacion.Text = est.Identificacion.ToString();
                txtNombreCompleto.Text = est.NombreCompleto;
                txtDireccion.Text = est.Direccion;
                cboSeccion.SelectedItem = (Secciones)est.Seccion;
                cboSexo.SelectedItem = est.Sexo;

            }
        }

        private void btnBuscarEncargado_Click(object sender, EventArgs e)
        {
            string identificadorEncargado = txtIdentificadorEnc.Text.ToString();
            encargado = logicaencargado.SeleccionarPorId(identificadorEncargado);
            if (encargado != null)
            {

                txtEncargadoResultado.Text = encargado.NombreCompleto;

            }
            else
            {
                txtEncargadoResultado.Text = "El Id del encargado no fue encontrado";
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void cboNivel_SelectedIndexChanged(object sender, EventArgs e)
        {
            CargarSecciones();
            cboSeccion.SelectedIndex = -1;
        }
        private void CargarCiclo()
        {
            cboCiclo.ValueMember = "Nombre";
            //cboCiclo.SelectedIndex = -1;


            cboCiclo.DataSource = logicaCiclo.SeleccionarTodos();
            
        }
        private void CargarComboNivel()
        {
            if (cboCiclo.SelectedItem == null)
            {
                return;
            }
            Ciclo ci = (Ciclo)cboCiclo.SelectedItem;
            cboNivel.ValueMember = "Nombre";
            //cboNivel.SelectedIndex = -1;
            cboNivel.DataSource = logicaNivel.SeleccionarNivelPorCiclo(ci.Id);
            //CargarCiclo();


        }
        private void cboCiclo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cboCiclo.SelectedIndex != -1)
            {
                CargarComboNivel();
                cboSeccion.SelectedIndex = -1;
                cboSeccion.SelectedItem = null;
                cboNivel.SelectedIndex = -1;
            }
        }
    }
}
