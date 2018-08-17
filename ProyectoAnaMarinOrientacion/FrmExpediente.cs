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
        public static List<EntrevistaEstudiante> entrevistaEstudiante;
        public static List<EntrevistaEncargado> entrevistaEncargado;
        public static List<InformeVisitaAlHogar> informe;
        public static List<Referencia> refrencia;

        Capa.Logica.SeccionesLN logicaSecciones;
        Capa.Logica.CicloLN logicaCiclo;
        Capa.Logica.NivelLN logicaNivel;



        public FrmExpediente()
        {
            InitializeComponent();
            logicaperiodos = new Capa.Logica.PeriodosLN();
           
            cargarInstrumentos();
            logicaEncargado = new Capa.Logica.EncargadoLN();
            logicaEstudiante = new Capa.Logica.EstudianteLN();
            logicaSecciones = new Capa.Logica.SeccionesLN();
            logicaCiclo = new Capa.Logica.CicloLN();
            logicaNivel = new Capa.Logica.NivelLN();

        }
        

        private void button1_Click(object sender, EventArgs e)
        {//boton para crear expediente
            try
            {
                ExpedienteFacade facade = new ExpedienteFacade();
               facade.AgregarEstudiante(est.Identificacion, est.NombreCompleto, est.Seccion, est.Sexo, est.FechaNacimiento, est.Direccion);
               facade.AgregarEncargado(encar.Identificacion,encar.NombreCompleto, encar.CorreoElectronico, encar.Ocupacion, encar.Parentesco);
               facade.AgregarCiclo( (Capa.Entidades.Ciclo) cboCiclo.SelectedItem);
               facade.AgregarPeriodo((Periodos)cboPeriodo.SelectedItem);
               facade.AgregarNivel((Capa.Entidades.Nivel)cboNivel.SelectedItem);
                //facade.AgregarInstrumento();

                logicaEstudiante.Guardar(est);
                logicaEncargado.Guardar(encar);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha ocurrido un error no controlado: " + ex.Message);
            }

        }

        private void FrmExpediente_Load(object sender, EventArgs e)
        {
            cargarComboCiclo();
            //cargarComboPeriodo();
            //cargarComboNivel();

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


    
        private void cargarComboNivel()
        {
            cboNivel.DataSource = logicaSecciones.SeleccionarTodos();
            cboNivel.SelectedIndex = -1;
        }

        private void cargarComboCiclo()
        {
            cboCiclo.DataSource = logicaCiclo.SeleccionarTodos();
            cboCiclo.ValueMember = "Nombre";
            cboCiclo.SelectedIndex = -1;
        }

        private void cargarComboPeriodo()
        {
            cboPeriodo.DataSource = logicaperiodos.SeleccionarTodos();
            cboPeriodo.DisplayMember = "Nombre";
            // cboSecciones.ValueMember = "Id";

            cboPeriodo.SelectedIndex = -1;
        }

        private void button5_Click(object sender, EventArgs e)
        {   
            //boton para crear un comprobante de asistencia
            FrmComprobanteAsistencia comproAsistencia = new FrmComprobanteAsistencia();
            comproAsistencia.Show();
        }

        private void cargarInstrumentos()
        {
            cboInstrumentos.DataSource = Enum.GetValues(typeof(Capa.Entidades.Enumeradores.Instrumentos));
            cboInstrumentos.SelectedIndex = -1;
        }

        private void btnAgregarInstrumento_Click(object sender, EventArgs e)
        {
            if (cboInstrumentos.SelectedIndex == 0)
            {
                Instrumentos.FrmEntrevistaConFuncionarioCentroEducativo funcio = new Instrumentos.FrmEntrevistaConFuncionarioCentroEducativo();
                funcio.Show();
            }
            else
            {
                if (cboInstrumentos.SelectedIndex == 1)
                {
                    Instrumentos.FrmEntrevistaPadre_Madre_Encargado enc = new Instrumentos.FrmEntrevistaPadre_Madre_Encargado();
                    enc.Show();
                }
                else
                {
                    if(cboInstrumentos.SelectedIndex == 2)
                    {
                        Instrumentos.FrmEntrevistaEstudiante est = new Instrumentos.FrmEntrevistaEstudiante();
                        est.Show();
                    }
                    else
                    {
                        if (cboInstrumentos.SelectedIndex == 3)
                        {
                            Instrumentos.FrmInformeVisitaAlHogar inf = new Instrumentos.FrmInformeVisitaAlHogar();
                            inf.Show();
                        }
                        else
                        {
                            Instrumentos.FrmReferenciaExterna ext = new Instrumentos.FrmReferenciaExterna();
                            ext.Show();
                        }
                    }
                }

            }
        }

        private void CargarComboNivel()
        {
            if (cboCiclo.SelectedItem == null)
            {
                return;
            }
            Ciclo ci = (Ciclo)cboCiclo.SelectedItem;
            cboNivel.DataSource = logicaNivel.SeleccionarNivelPorCiclo(ci.Id);
            cboNivel.ValueMember = "Nombre";
            cboNivel.SelectedIndex = -1;

        }
        private void cboCiclo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboCiclo.SelectedIndex != -1)
            {
                CargarComboNivel();
            }
        }
    }
}
