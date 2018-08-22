using Capa.Entidades;
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

    public partial class FrmBusquedaExpedientes : Form
    {
        public static Estudiante est;
        public static ExpedienteFacade exp;

        Capa.Logica.EstudianteLN estLogica;
        Capa.Logica.EncargadoLN encLogica;
        public FrmBusquedaExpedientes()
        {
            InitializeComponent();
            estLogica = new Capa.Logica.EstudianteLN();
            encLogica = new Capa.Logica.EncargadoLN();

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void FrmBusquedaExpedientes_Load(object sender, EventArgs e)
        {
            txtIdentificacion.Visible = false;
            
            if (rdEstudiante.Checked)
                txtIdentificacion.Visible = true;

            
        }

        private void btnBuscar_Click_1(object sender, EventArgs e)
        {
            //buscar por estudiante
           
            var estudianteId= estLogica.SeleccionarPorId(txtIdentificacion.Text);
            var estudianteNombre = estLogica.SeleccionarEstudiantePorNombre(txtIdentificacion.Text);
            if (estudianteId!= null)
            {
                //dgvExpedientes.DataSource=  
                //dgvExpedientes.DataSource=  
            }
            else
            {
                MessageBox.Show("Estudiante no encontrado");
                return;
            }
           
        }
        private void RefrescarGrid(List<ExpedienteFacade> expedientes)
        {

            dgvExpedientes.AutoGenerateColumns = false;

            // creacion de binding para los datagrids
            dgvExpedientes.DataSource = null;
            var listaInstrumentos = new BindingList<ExpedienteFacade>(expedientes);
            // asignacion de datagrids

            dgvExpedientes.DataSource = listaInstrumentos;
        }
        private void btnBuscarEncargado_Click(object sender, EventArgs e)
        {

            if (rdEstudiante.Checked)
            {
                List<ExpedienteFacade> expedientesEstudiante = new Capa.Logica.ExpedienteLN().SeleccionarPorFiltro(txtIdentificacion.Text, true);
                RefrescarGrid(expedientesEstudiante);
            }
            if (rdEncargado.Checked)
            {

                List<ExpedienteFacade> expedientesEncargado = new Capa.Logica.ExpedienteLN().SeleccionarPorFiltro(txtIdentificacion.Text, false);
                RefrescarGrid(expedientesEncargado);
                
            }

            if (rdNumeroExpediente.Checked)
            {

                ExpedienteFacade expedientesEncargado = new Capa.Logica.ExpedienteLN().SeleccionarPorIdExpediente(Convert.ToInt32(txtIdentificacion.Text));
                List<ExpedienteFacade> exp = new List <ExpedienteFacade>();
                exp.Add(expedientesEncargado);
                RefrescarGrid(exp);
            }
        }


        private void dgvExpedientes_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            
            ExpedienteFacade currExp = (ExpedienteFacade)dgvExpedientes.CurrentRow.DataBoundItem;

            FrmExpediente frmExpediente = new FrmExpediente();
            FrmExpediente.est = new Capa.Logica.EstudianteLN().SeleccionarPorId(currExp.IdEstudiante);
            frmExpediente.Show();
        }

        private void dgvExpedientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtIdentificacion_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {
                btnBuscarEncargado_Click(null, null);
            }
        }
    }
}
