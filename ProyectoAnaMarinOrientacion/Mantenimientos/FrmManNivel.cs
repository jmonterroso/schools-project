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

namespace ProyectoAnaMarinOrientacion.Mantenimientos
{
    public partial class FrmManNivel : Form
    {
        Capa.Logica.CicloLN LogicaCiclo;
        public FrmManNivel()
        {
            InitializeComponent();
            LogicaCiclo = new Capa.Logica.CicloLN();
        }

        public void CargarCiclo()
        {
            cboCiclo.DataSource = LogicaCiclo.SeleccionarTodos();
            cboCiclo.ValueMember = "Nombre";
            cboCiclo.SelectedIndex = -1;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Nivel sec = new Nivel()
                {
                   
                    Nombre = txtNombreSeccion.Text,
                    Ciclo = (Ciclo)cboCiclo.SelectedItem
                };
                dataGridView1.DataSource = sec;

                Capa.Logica.NivelLN logica;
                logica = new Capa.Logica.NivelLN();
                logica.Guardar(sec);
                MessageBox.Show("  Datos guardados con exito ");


            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error al guardar la seccion"
                    , MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
private void FrmManNivel_Load(object sender, EventArgs e)
        {
            CargarCiclo();
        }
    }
}
   
