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
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void crearExpedienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmExpediente frmexp = new FrmExpediente();
            frmexp.Show();
        }

        private void expedienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmExpediente frmexp = new FrmExpediente();
            frmexp.Show();
        }

        private void busquedaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmBusquedaExpedientes bus = new FrmBusquedaExpedientes();
            bus.Show();
        }

        private void estudianteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //FrmDatosEstudiante est = new FrmDatosEstudiante();
            //est.Show();
        }

        private void encargadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmDatosEncargado enc = new FrmDatosEncargado();
            enc.Show();
        }

        private void encargadoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Mantenimientos.FrmMantEncargado frmEnc = new Mantenimientos.FrmMantEncargado();
            frmEnc.Show();
        }

        private void motivoATencionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Mantenimientos.FrmMantMotivoAtencion mant = new Mantenimientos.FrmMantMotivoAtencion();
            mant.Show();
        }

        private void seccionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Mantenimientos.FrmMantSecciones sec = new Mantenimientos.FrmMantSecciones();
            sec.Show();
        }

        private void periodosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Mantenimientos.FrmMantPeriodos per = new Mantenimientos.FrmMantPeriodos();
            per.Show();
        }

        private void loginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmLogin log = new FrmLogin();
            log.Show();

        }

        private void comprobanteAsistenciaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmComprobanteAsistencia comp = new FrmComprobanteAsistencia();
            comp.Show();
        }

        private void usuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void visitaAlHogarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Instrumentos.FrmInformeVisitaAlHogar visita = new Instrumentos.FrmInformeVisitaAlHogar();
            visita.Show();
        }

        private void estudiantesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Mantenimientos.FrmMantEstudiantePrincipal prin = new Mantenimientos.FrmMantEstudiantePrincipal();
            prin.Show();
        }

        private void entrevistaConFuncionarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Instrumentos.FrmEntrevistaConFuncionarioCentroEducativo entre = new Instrumentos.FrmEntrevistaConFuncionarioCentroEducativo();
            entre.Show();
        }

        private void entrevistaConEncargadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Instrumentos.FrmEntrevistaPadre_Madre_Encargado entre = new Instrumentos.FrmEntrevistaPadre_Madre_Encargado();
            entre.Show();
        }

        private void entrevistaConEstudianteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Instrumentos.FrmEntrevistaEstudiante entre = new Instrumentos.FrmEntrevistaEstudiante();
                            entre.Show();

        }

        private void informeDeVisitaAlHogarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Instrumentos.FrmInformeVisitaAlHogar entre = new Instrumentos.FrmInformeVisitaAlHogar();
            entre.Show();
        }

        private void referenciaExternaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Instrumentos.FrmReferenciaExterna entre = new Instrumentos.FrmReferenciaExterna();
            entre.Show();
        }

        private void nivelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Mantenimientos.FrmManNivel nivel = new Mantenimientos.FrmManNivel();
            nivel.Show();
        }

        private void usuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void agregarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmRegistro registro = new FrmRegistro();
            registro.Show();
        }

        private void cambiarDeUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void cambiarDeUsuarioToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Dispose();
            FrmLogin login = new FrmLogin();
            login.Show();
        }

        private void FrmPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                DialogResult dialogo = MessageBox.Show("Desea cerrar el menu del administrador", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk);
                if (dialogo == DialogResult.Yes)
                {
                    Dispose();

                }
                else
                {
                    FrmLogin login = new FrmLogin();
                    login.Show();
                }
            }
            catch { }
        }

        private void FrmPrincipal_FormClosed(object sender, FormClosedEventArgs e)
        {
        //    try
        //    {
        //        DialogResult dialogo = MessageBox.Show("Desea cerrar el menu del administrador", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk);
        //        if (dialogo == DialogResult.Yes)
        //        {
        //            Dispose();
        //            FrmLogin login = new FrmLogin();
        //            login.Show();
        //        }
        //        else
        //            return;
        //    }
        //    catch { }
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void porFechaToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void enviadosPorCorreoElectronicoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
