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
using Capa.Entidades.Enumeradores;

namespace ProyectoAnaMarinOrientacion
{
    public partial class FrmExpediente : Form
    {

        public static Estudiante est;
        Capa.Logica.PeriodosLN logicaperiodos;
        Capa.Logica.EncargadoLN logicaEncargado;
        Capa.Logica.EstudianteLN logicaEstudiante;
        Capa.Logica.InstrumentosLN.EntrevistaEstudianteLN logicaEntrevistaEstudiante;
        Capa.Logica.InstrumentosLN.EntrevistaConFuncionarioLN logicaEntrevistaConFuncionario;
        Capa.Logica.InstrumentosLN.EntrevistaEncargadoLN logicaEntrevistaConEncargado;
        Capa.Logica.InstrumentosLN.InformeVisitaAlHogarLN logicaInformeVisitaAlHogar;
        Capa.Logica.InstrumentosLN.ReferenciaLN logicaReferenciaExterna;
        Capa.Logica.ExpedienteLN logicaExpediente;
        public static Encargado encar;
        public static List<EntrevistaFuncionario> entrevistasFuncionario;
        public static List<EntrevistaEstudiante> entrevistasEstudiante;
        public static List<EntrevistaEncargado> entrevistasEncargado;
        public static List<InformeVisitaAlHogar> visitaAlHogar;
        public static List<Referencia> referenciaExterna;
        public static List<ClaseInstrumento> instrumentos;
        public ExpedienteFacade facade;

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
            logicaEntrevistaEstudiante = new Capa.Logica.InstrumentosLN.EntrevistaEstudianteLN();
            logicaEntrevistaConFuncionario = new Capa.Logica.InstrumentosLN.EntrevistaConFuncionarioLN();
            logicaEntrevistaConEncargado = new Capa.Logica.InstrumentosLN.EntrevistaEncargadoLN();
            logicaInformeVisitaAlHogar = new Capa.Logica.InstrumentosLN.InformeVisitaAlHogarLN();
            logicaReferenciaExterna = new Capa.Logica.InstrumentosLN.ReferenciaLN();
            logicaExpediente = new Capa.Logica.ExpedienteLN();
            entrevistasFuncionario = new List<EntrevistaFuncionario>();
            entrevistasEstudiante = new List<EntrevistaEstudiante>();
            entrevistasEncargado = new List<EntrevistaEncargado>();
            visitaAlHogar = new List<InformeVisitaAlHogar>();
            referenciaExterna = new List<Referencia>();
            instrumentos = new List<ClaseInstrumento>();
            facade = new ExpedienteFacade();
        }
        

        private void button1_Click(object sender, EventArgs e)
        {//boton para crear expediente
            try
            {
                
               facade.AgregarEstudiante(est.Identificacion, est.NombreCompleto, est.Seccion, est.Sexo, est.FechaNacimiento, est.Direccion);
                Encargado enc = logicaEncargado.SeleccionarPorId(est.IdEncargado);
               facade.AgregarEncargado(enc.Identificacion,enc.NombreCompleto, enc.CorreoElectronico, enc.Ocupacion, enc.Parentesco);
                //facade.AgregarCiclo( (Capa.Entidades.Ciclo) cboCiclo.SelectedItem);
                //facade.AgregarPeriodo((Periodos)cboPeriodo.SelectedItem);
                //facade.AgregarNivel((Capa.Entidades.Nivel)cboNivel.SelectedItem);
                //facade.AgregarInstrumento();

                facade.IdEstudiante = est.Identificacion;
                facade.Id = logicaExpediente.Guardar(facade).Id;
                txtNumeroExpediente.Text = facade.Id.ToString();
                if(instrumentos.Count > 0)
                {
                    foreach(var instrumento in instrumentos)
                    {
                        if (instrumento.Id  == 0) {
                            instrumento.IdExpediente = facade.Id;
                            switch (instrumento.TipoInstrumento) {
                                case TipoInstrumentos.EntrevistaEstudiante:
                                    logicaEntrevistaEstudiante.Guardar((EntrevistaEstudiante)instrumento);
                                    break;
                                case TipoInstrumentos.EntrevistaAlFuncionario:
                                    logicaEntrevistaConFuncionario.Guardar((EntrevistaFuncionario)instrumento);
                                    break;
                                case TipoInstrumentos.EntrevistaAlEncargado:
                                    logicaEntrevistaConEncargado.Guardar((EntrevistaEncargado)instrumento);
                                    break;
                                case TipoInstrumentos.InformeDeVisitaAlHogar:
                                    logicaInformeVisitaAlHogar.Guardar((InformeVisitaAlHogar)instrumento);
                                    break;
                                case TipoInstrumentos.ReferenciaExterna:
                                    logicaReferenciaExterna.Guardar((Referencia)instrumento);
                                    break;

                            }
                        }
                        

                    }
                    
                }
                MessageBox.Show("Expediente Guardado Correctamente");
                CargarInstrumentos();



                //logicaEstudiante.Guardar(est);
                //logicaEncargado.Guardar(encar);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha ocurrido un error no controlado: " + ex.Message);
            }

        }
        
        private void RefrescarGrids()

        {
          
            // configuracion de propiedades del grid
          
            dgvInstrumentos.AutoGenerateColumns = false;

            // creacion de binding para los datagrids
            dgvInstrumentos.DataSource = null;
            var listaInstrumentos = new BindingList<ClaseInstrumento>(instrumentos);
            // asignacion de datagrids
           
            dgvInstrumentos.DataSource = listaInstrumentos;


        }

        private void ValidarControles()
        {
            switch (Usuario.UsuarioActual.Rol) {
                case TipoUsuario.Encargado:
                    gpboxAgregarInstrumento.Visible = false;
                    btnComprobante.Visible = false;
                    btnGuardarExpediente.Visible = false;
                    //btnCancelar.Visible = false;
                    break;

            }

        }

        private void FrmExpediente_Load(object sender, EventArgs e)
        {
            RefrescarGrids();
            if(est != null)
            {
                txtIdentificacionEstudiante.Text = est.Identificacion;
                LblEstSeleccionado.Text = est.NombreCompleto;
                CargarInstrumentos();
            }
            ValidarControles();


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

        private void CargarInstrumentos()
        {
            ExpedienteFacade fac = new ExpedienteFacade();
            fac = logicaExpediente.SeleccionarPorId(est.Identificacion);
            if (fac != null)
            {
                facade = fac;
                txtNumeroExpediente.Text = facade.Id.ToString();
                instrumentos = facade.Instrumentos;
                RefrescarGrids();
            }
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

            CargarInstrumentos();




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

        private void pbQRCODE_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void dgvInstrumentos_DoubleClick(object sender, EventArgs e)
        {
            var Id = dgvInstrumentos.CurrentRow.Cells[0].Value;            

            TipoInstrumentos tipoInstrumentos = (TipoInstrumentos)Enum.Parse(typeof(TipoInstrumentos), dgvInstrumentos.CurrentRow.Cells[2].Value.ToString());
            switch (tipoInstrumentos)
            {
                case TipoInstrumentos.EntrevistaAlEncargado:
                    EntrevistaEncargado entrevistaEncargado = new Capa.Logica.InstrumentosLN.EntrevistaEncargadoLN().SeleccionarPorId(Convert.ToInt32(Id));
                    Instrumentos.FrmEntrevistaPadre_Madre_Encargado.entrevistaEncargado = entrevistaEncargado;
                    Instrumentos.FrmEntrevistaPadre_Madre_Encargado enc = new Instrumentos.FrmEntrevistaPadre_Madre_Encargado();
                    enc.Show();
                    break;
                case TipoInstrumentos.EntrevistaAlFuncionario:
                    EntrevistaFuncionario entrevistaFuncionario = new Capa.Logica.InstrumentosLN.EntrevistaConFuncionarioLN().SeleccionarPorId(Convert.ToInt32(Id));
                    Instrumentos.FrmEntrevistaConFuncionarioCentroEducativo.entrevistaFuncionario= entrevistaFuncionario;
                    Instrumentos.FrmEntrevistaConFuncionarioCentroEducativo fun = new Instrumentos.FrmEntrevistaConFuncionarioCentroEducativo();
                    fun.Show();
                    break;
                case TipoInstrumentos.EntrevistaEstudiante:
                    EntrevistaEstudiante entrevistaEstudiante = new Capa.Logica.InstrumentosLN.EntrevistaEstudianteLN().SeleccionarPorId(Convert.ToInt32(Id));
                    Instrumentos.FrmEntrevistaEstudiante.entrevistaEstudiante = entrevistaEstudiante;
                    Instrumentos.FrmEntrevistaEstudiante entEst = new Instrumentos.FrmEntrevistaEstudiante();
                    entEst.Show();
                    break;
                case TipoInstrumentos.ReferenciaExterna:
                    Referencia referencia = new Capa.Logica.InstrumentosLN.ReferenciaLN().SeleccionarPorId(Convert.ToInt32(Id));
                    Instrumentos.FrmReferenciaExterna.referencia = referencia;
                    Instrumentos.FrmReferenciaExterna refe = new Instrumentos.FrmReferenciaExterna();
                    refe.Show();
                    break;
                case TipoInstrumentos.InformeDeVisitaAlHogar:
                    InformeVisitaAlHogar informeVisitAlHogar = new Capa.Logica.InstrumentosLN.InformeVisitaAlHogarLN().SeleccionarPorId(Convert.ToInt32(Id));
                    Instrumentos.FrmInformeVisitaAlHogar.informeVisitaAlHogar = informeVisitAlHogar;
                    Instrumentos.FrmInformeVisitaAlHogar visita = new Instrumentos.FrmInformeVisitaAlHogar();
                    visita.Show();
                    break;

                

            }

            

            //FrmExpediente.est = new Capa.Logica.InstrumentosLN.EntrevistaEncargadoLN()
            
        }

        private void dgvInstrumentos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
