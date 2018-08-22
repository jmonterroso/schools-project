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

namespace ProyectoAnaMarinOrientacion.Mantenimientos
{
    public partial class FrmMantPeriodos : Form
    {

        Capa.Logica.PeriodosLN logica;
        private BindingSource bindingSource1 = new BindingSource();

        public FrmMantPeriodos()
        {
            InitializeComponent();
            logica = new Capa.Logica.PeriodosLN();
            groupBox1.Visible = false;
            btnCancelar.Visible = false;
            btnGuardar.Visible = false;
            dgvPeriodos.Visible = false;
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            ///sumary
            ///Metodo para actualizar un periodo
            ///sumary
            ///
            groupBox1.Visible = true;
            //Actualizar
            //  Refrescar();
            //txtCodigo.ReadOnly = true;
            //txtCodigo.Enabled = false;
            dgvPeriodos.Visible = true;
            btnCancelar.Enabled = true;
            btnGuardar.Enabled = true;
            //Obtener el id de la fila seleccionada
            if (dgvPeriodos.SelectedRows.Count > 0)
            {
                var periodos = (Periodos)dgvPeriodos.SelectedRows[0].DataBoundItem;
               // txtCodigo.Text = periodos.Codigo.ToString();
               // txtCodigo.ReadOnly = true;
               // txtCodigo.Enabled = false;
                txtNombre.Text = periodos.Nombre;
                dtpInicio.Value = periodos.FechaInicio;
                dtpFinal.Value = periodos.FechaFinal;

                groupBox1.Visible = true;
                logica.SeleccionarPorId(periodos.Codigo);
            }
            else
            {
                MessageBox.Show("Debe seleccionar un periodo a actualizar");
            }




        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            ///
            /// Metodo para insertar un periodos
            ///

            groupBox1.Visible = true;
            btnGuardar.Visible = true;
            btnCancelar.Visible = true;
            dgvPeriodos.Visible = true;
            Refrescar();
            dgvPeriodos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            //metodo para guardar los periodos
            btnCancelar.Enabled = true;
            btnGuardar.Enabled = true;
            try
            {

                Periodos peri = new Periodos()
                {
                    Codigo = int.Parse(txtCodigo.Text),
                    Nombre = txtNombre.Text,
                    FechaInicio = (DateTime)dtpInicio.Value,
                    FechaFinal = (DateTime)dtpFinal.Value,
                };
                dgvPeriodos.DataSource = peri;

                logica.Guardar(peri);
                MessageBox.Show("  Datos guardados con exito ");
                bindingSource1.Add(peri);
                dgvPeriodos.DataSource = bindingSource1;
                Refrescar();
                Limpiar();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error al guardar la seccion"
                    , MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
            private void Limpiar()
            {
            Refrescar();
            txtCodigo.Clear();
            txtNombre.Clear();
            dtpInicio.Value= DateTime.Now;
            dtpFinal.Value = DateTime.Now;
            dgvPeriodos.Visible = true;
            }
        private void Refrescar()
        {
            dgvPeriodos.DataSource = logica.SeleccionarTodos();

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult dialogo = MessageBox.Show("Desea cerrar el mantenimiento de periodos", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk);
                if (dialogo == DialogResult.Yes)
                {
                    Dispose();
                }
                else
                    return;
            }
            catch { }
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            //boton para eliminar un periodo
            btnCancelar.Enabled = false;
            btnGuardar.Enabled = false;


            string msg = "¿Desea eliminar el periodo seleccionado?";
            var resultado = MessageBox.Show(msg, "Pregunta", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
            if (resultado == DialogResult.Yes)
            {
                if (dgvPeriodos.SelectedRows.Count > 0)
                {
                    //databounditem retorna el objeto que asigno en datasource
                    var peri = (Periodos)dgvPeriodos.SelectedRows[0].DataBoundItem;
                    logica.Eliminar(peri);
                    Refrescar();

                }
            }
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            //boton para consultar los periodos existentes
            dgvPeriodos.Visible = true;
            groupBox1.Visible = false;
            btnCancelar.Visible = true;
            btnGuardar.Visible = false;
        }

        private void dgvPeriodos_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvPeriodos.SelectedRows.Count > 0)
            {
                //databounditem retorna el objeto que asigno en datasource
                var peri = (Periodos)dgvPeriodos.SelectedRows[0].DataBoundItem;
             //   txtCodigo.Text = peri.Codigo.ToString();
                txtCodigo.ReadOnly = true;
                txtCodigo.Enabled = false;
                txtNombre.Text = peri.Nombre;
                dtpInicio.Value = peri.FechaInicio;
                dtpFinal.Value = peri.FechaFinal;

            }
        }

        private void dgvPeriodos_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            dgvPeriodos.SelectionMode= DataGridViewSelectionMode.FullRowSelect;

        }

        private void FrmMantPeriodos_Load(object sender, EventArgs e)
        {
            label1.Visible = false;
            txtCodigo.Visible = false;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
   
}
