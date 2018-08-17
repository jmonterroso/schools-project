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

namespace ProyectoAnaMarinOrientacion
{
    public partial class FrmExpediente : Form
    {

        public static Estudiante est;
        Capa.Logica.PeriodosLN logicaperiodos;
        Capa.Logica.EncargadoLN logicaEncargado;
        Capa.Logica.EstudianteLN logicaEstudiante;
        public static Encargado encar;
        public static List<EntrevistaFuncionario> entrevistasFuncionario;
        public static List<EntrevistaEstudiante> entrevistasEstudiante;
        public static List<EntrevistaEncargado> entrevistasEncargado;
        public static List<InformeVisitaAlHogar> visitaAlHogar;
        public static List<Referencia> referenciaExterna;
        public static List<ClaseInstrumento> instrumentos;

        Capa.Logica.SeccionesLN logicaSecciones;
        Capa.Logica.CicloLN logicaCiclo;
        Capa.Logica.NivelLN logicaNivel;



        public FrmExpediente()
        {
            InitializeComponent();
            logicaperiodos = new Capa.Logica.PeriodosLN();
            logicaEncargado = new Capa.Logica.EncargadoLN();
            logicaEstudiante = new Capa.Logica.EstudianteLN();
            logicaSecciones = new Capa.Logica.SeccionesLN();
            logicaCiclo = new Capa.Logica.CicloLN();
            logicaNivel = new Capa.Logica.NivelLN();
            entrevistasFuncionario = new List<EntrevistaFuncionario>();
            entrevistasEstudiante = new List<EntrevistaEstudiante>();
            entrevistasEncargado = new List<EntrevistaEncargado>();
            visitaAlHogar = new List<InformeVisitaAlHogar>();
            referenciaExterna = new List<Referencia>();
            instrumentos = new List<ClaseInstrumento>();
        }
        

        private void button1_Click(object sender, EventArgs e)
        {//boton para crear expediente
            try
            {
                ExpedienteFacade facade = new ExpedienteFacade();
               facade.AgregarEstudiante(est.Identificacion, est.NombreCompleto, est.Seccion, est.Sexo, est.FechaNacimiento, est.Direccion);
                Encargado enc = logicaEncargado.SeleccionarPorId(est.IdEncargado);
               facade.AgregarEncargado(enc.Identificacion,enc.NombreCompleto, enc.CorreoElectronico, enc.Ocupacion, enc.Parentesco);
               //facade.AgregarCiclo( (Capa.Entidades.Ciclo) cboCiclo.SelectedItem);
               //facade.AgregarPeriodo((Periodos)cboPeriodo.SelectedItem);
               //facade.AgregarNivel((Capa.Entidades.Nivel)cboNivel.SelectedItem);
                //facade.AgregarInstrumento();

                logicaEstudiante.Guardar(est);
                logicaEncargado.Guardar(encar);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha ocurrido un error no controlado: " + ex.Message);
            }

        }
        private void ValidacionDeListas()
        {
            if (entrevistasFuncionario.Count == 0)
            {
                groupBox1.Visible = false;

            }
            else
            {
                groupBox1.Visible = true;
            }
            if (entrevistasEncargado.Count == 0)
            {
                groupBox2.Visible = false;
            }
            else
            {
                groupBox2.Visible = true;
            }
            if (entrevistasEstudiante.Count == 0)
            {
                groupBox3.Visible = false;
            }
            else
            {
                groupBox3.Visible = true;
            }
            if (visitaAlHogar.Count == 0)
            {
                groupBox4.Visible = false;
            }
            else
            {
                groupBox4.Visible = true;
            }
            if (referenciaExterna.Count == 0)
            {
                groupBox5.Visible = false;
            }
            else
            {
                groupBox5.Visible = true;
            }


        }
        private void RefrescarGrids()

        {
            ValidacionDeListas();
            // configuracion de propiedades del grid
            dgvInstrumentoFuncionario.AutoGenerateColumns = false;
            dgvEncargado.AutoGenerateColumns = false;
            dgvEstudiante.AutoGenerateColumns = false;
            dgvInstrumentoFuncionario.AutoGenerateColumns = false;
            dgvVisitaAlHogar.AutoGenerateColumns = false;
            dgvReferenciaExterna.AutoGenerateColumns = false;
            dgvInstrumentos.AutoGenerateColumns = false;

            // creacion de binding para los datagrids
            var listaFuncionario = new BindingList<EntrevistaFuncionario>(entrevistasFuncionario);
            var listaEncargado = new BindingList<EntrevistaEncargado>(entrevistasEncargado);
            var listaEstudiante = new BindingList<EntrevistaEstudiante>(entrevistasEstudiante);
            var listaVisitaAlHogar = new BindingList<InformeVisitaAlHogar>(visitaAlHogar);
            var listaReferenciaExterna = new BindingList<Referencia>(referenciaExterna);
            var listaInstrumentos = new BindingList<ClaseInstrumento>(instrumentos);
            // asignacion de datagrids
            dgvInstrumentoFuncionario.DataSource = listaFuncionario; 
            dgvEncargado.DataSource = listaEncargado;
            dgvEstudiante.DataSource = listaEstudiante;
            dgvVisitaAlHogar.DataSource = listaVisitaAlHogar;
            dgvReferenciaExterna.DataSource = listaReferenciaExterna;
            dgvInstrumentos.DataSource = listaInstrumentos;


        }

        private void FrmExpediente_Load(object sender, EventArgs e)
        {
            RefrescarGrids();

        }

        private void btnQRCode_Click(object sender, EventArgs e)
        {
            Zen.Barcode.CodeQrBarcodeDraw qrcode = Zen.Barcode.BarcodeDrawFactory.CodeQr;
            pbQRCODE.Image = qrcode.Draw(txtNumeroExpediente.Text, 50);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void button3_Click(object sender, EventArgs e)
        { //boton para agregar los datos del estudiante

            FrmDatosEstudiante est = new FrmDatosEstudiante();
            est.Show();
            if( est==null)
            {
                MessageBox.Show("Debe agregar los datos del estudiante", "Aviso");
                return;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //boton para agregar los datos del encargado
            FrmDatosEncargado encargado = new FrmDatosEncargado();
            encargado.Show();
        }


    
     

        
        private void button5_Click(object sender, EventArgs e)
        {   
            //boton para crear un comprobante de asistencia
            FrmComprobanteAsistencia comproAsistencia = new FrmComprobanteAsistencia();
            comproAsistencia.Show();
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(txtIdentificacionEstudiante.Text == "")
            {
                MessageBox.Show("Debe ingresar la  identificacion del estudiante");
                return;
            }
            est = logicaEstudiante.SeleccionarPorId(txtIdentificacionEstudiante.Text);
            if(est == null)
            {
                MessageBox.Show("No se encontro el estudiante con el id proporcionado");
                return;
            }
            LblEstSeleccionado.Text = est.NombreCompleto;
            

        }

        private void FrmExpediente_Activated(object sender, EventArgs e)
        {
            RefrescarGrids();
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            Instrumentos.FrmEntrevistaConFuncionarioCentroEducativo funcio = new Instrumentos.FrmEntrevistaConFuncionarioCentroEducativo();
            funcio.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Instrumentos.FrmEntrevistaPadre_Madre_Encargado enc = new Instrumentos.FrmEntrevistaPadre_Madre_Encargado();
            enc.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Instrumentos.FrmEntrevistaEstudiante est = new Instrumentos.FrmEntrevistaEstudiante();
            est.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Instrumentos.FrmInformeVisitaAlHogar inf = new Instrumentos.FrmInformeVisitaAlHogar();
            inf.Show();
        }

        private void txtIdentificacionEstudiante_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {
                button2_Click(null, null);
            }
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            Instrumentos.FrmReferenciaExterna inf = new Instrumentos.FrmReferenciaExterna();
            inf.Show();
        }
    }
}
