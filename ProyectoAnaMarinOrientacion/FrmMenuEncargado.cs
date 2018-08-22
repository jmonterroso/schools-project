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
    public partial class FrmMenuEncargado : Form
    {
        Capa.Logica.EncargadoLN enc;
        public FrmMenuEncargado()
        {
            enc = new Capa.Logica.EncargadoLN();
            InitializeComponent();
        }

        private void FrmMenuEncargado_Load(object sender, EventArgs e)
        {

            Encargado encargado = enc.SeleccionarPorId(Usuario.UsuarioActual.Identificacion);

            dgvEstudiantesEncargado.AutoGenerateColumns = false;

            // creacion de binding para los datagrids
            dgvEstudiantesEncargado.DataSource = null;
            if (encargado.ListaEstudiantes.Count > 0)
            {
                var listaEstudiantes = new BindingList<Estudiante>(encargado.ListaEstudiantes);
                dgvEstudiantesEncargado.DataSource = listaEstudiantes;
            }
            // asignacion de datagrids

            
        }

        private void dgvEstudiantesEncargado_DoubleClick(object sender, EventArgs e)
        {
            var Identificacion = dgvEstudiantesEncargado.CurrentRow.Cells[0].Value;
            FrmExpediente frmExpediente = new FrmExpediente();
            FrmExpediente.est = new Capa.Logica.EstudianteLN().SeleccionarPorId(Identificacion.ToString());
            frmExpediente.Show();
        }

        private void dgvEstudiantesEncargado_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
