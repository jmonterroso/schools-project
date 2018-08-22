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
            txtEncargado.Visible = false;
            if (radioButton1.Checked)
                txtIdentificacion.Visible = true;

            if (radioButton2.Checked)
                txtEncargado.Visible = true;
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
    }
}
