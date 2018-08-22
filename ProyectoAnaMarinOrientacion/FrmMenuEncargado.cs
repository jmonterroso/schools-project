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
            var listaEstudiantes = new BindingList<Estudiante>(encargado.ListaEstudiantes);
            // asignacion de datagrids

            dgvEstudiantesEncargado.DataSource = listaEstudiantes;
        }
    }
}
