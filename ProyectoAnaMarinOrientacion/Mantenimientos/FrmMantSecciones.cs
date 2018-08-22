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
    public partial class FrmMantSecciones : Form
    {
        Capa.Logica.SeccionesLN logica;
        private BindingSource bindingSource1 = new BindingSource();
        Capa.Logica.NivelLN logicaNivel;
        Capa.Logica.CicloLN logicaciclo;
        public FrmMantSecciones()
        {
            
            InitializeComponent();
            logica = new Capa.Logica.SeccionesLN();
            groupBox1.Visible = false;
            dgvSecciones.Visible = false;
            Refrescar();
            logicaNivel = new Capa.Logica.NivelLN();
            logicaciclo = new Capa.Logica.CicloLN();
           // dgvSecciones.AutoGenerateColumns = false;

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {//AGregar boton 
           
            CargarCiclo();
            Limpiar();
            groupBox1.Visible = true;
            dgvSecciones.Visible = true;
            dgvSecciones.ClearSelection();
            btnCancelar.Enabled = true;
            btnGuardar.Enabled = true;
            dgvSecciones.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {//BOTON GUARDAR
            btnCancelar.Enabled = true;
            btnGuardar.Enabled = true;
            try
            {

                Secciones sec = new Secciones()
                {
                   // Id = int.Parse(txtCodigo.Text),
                    Nombre = txtNombreSeccion.Text,
                    Nivel = (Capa.Entidades.Nivel)cboNivel.SelectedItem
                };
                dgvSecciones.DataSource = sec;

                logica.Guardar(sec);
                MessageBox.Show("  Datos guardados con exito ");
                bindingSource1.Add(sec.Nombre);
                dgvSecciones.DataSource = bindingSource1;
                Refrescar();
                Limpiar();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error al guardar la seccion"
                    , MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Refrescar()
        {
            dgvSecciones.DataSource = logica.SeleccionarTodos();
        
            
        }

        private void Limpiar()
        {
            txtNombreSeccion.Clear();
          
        }


        private void CargarCiclo()
        {
            cboCiclo.DataSource = logicaciclo.SeleccionarTodos();
            cboCiclo.ValueMember = "Nombre";
            cboCiclo.SelectedIndex = -1;
     
        }
        private void CargarComboNivel()
        {
            if (cboCiclo.SelectedItem == null)
            {
                return;
            }
            Ciclo  ci  = (Ciclo)cboCiclo.SelectedItem;
            cboNivel.DataSource = logicaNivel.SeleccionarNivelPorCiclo(ci.Id);
            cboNivel.ValueMember="Nombre";
            cboNivel.SelectedIndex = -1;
           
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {//boton de cancelar
            try
            {
                DialogResult dialogo = MessageBox.Show("Desea cerrar el mantenimiento de secciones", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk);
                if (dialogo == DialogResult.Yes)
                {
                    Dispose();
                }
                else
                    return;
            }
            catch { }
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            //boton de actualizar 
            groupBox1.Visible = true;
            //Actualizar

            
            btnCancelar.Enabled = true;
            btnGuardar.Enabled = true;
            //Obtener el id de la fila seleccionada
            if (dgvSecciones.SelectedRows.Count > 0)
            {
                var sec = (Secciones)dgvSecciones.SelectedRows[0].DataBoundItem;
                txtNombreSeccion.Text = sec.Nombre;
                cboNivel.SelectedValue = sec.Nivel.Nombre;
                cboCiclo.SelectedValue = sec.Nivel.Ciclo.Nombre;
               // txtCodigo.ReadOnly = true;

                groupBox1.Visible = true;
                logica.SeleccionarPorId(sec.Id);
            }
            else
            {
                MessageBox.Show("Debe seleccionar una seccion a actualizar");
            }

            

        }

        private void dgvSecciones_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvSecciones_SelectionChanged(object sender, EventArgs e)
        {
          
            if (dgvSecciones.SelectedRows.Count > 0)
            {
                //databounditem retorna el objeto que asigno en datasource
                var sec = (Secciones)dgvSecciones.SelectedRows[0].DataBoundItem;
                //txtCodigo.Text = sec.Id.ToString();
                txtNombreSeccion.Text = sec.Nombre;
                cboNivel.SelectedItem = sec.Nivel.Nombre;
                cboCiclo.SelectedItem = sec.Nivel.Ciclo.Nombre;
            }
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {

            //ELIMINAR
            btnCancelar.Enabled = false;
            btnGuardar.Enabled = false;

            string msg = "¿Desea eliminar la seccion seleccionado?";
            var resultado = MessageBox.Show(msg, "Pregunta", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
            if (resultado == DialogResult.Yes)
            {
                if (dgvSecciones.SelectedRows.Count > 0)
                {
                    //databounditem retorna el objeto que asigno en datasource
                    var sec = (Secciones)dgvSecciones.SelectedRows[0].DataBoundItem;
                    logica.Eliminar(sec);
                    Refrescar();

                }
            }
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            groupBox1.Visible = false;
            dgvSecciones.Visible = true;
            dgvSecciones.ReadOnly = true;
        }

        private void dgvSecciones_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            dgvSecciones.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        

        private void FrmMantSecciones_Load(object sender, EventArgs e)
        {
            CargarCiclo();
        }

        private void cboNivel_SelectedIndexChanged(object sender, EventArgs e)
        {
         //   CargarComboNivel();
        }

        private void cboNivel_SelectedValueChanged(object sender, EventArgs e)
        {
          //  CargarComboNivel();
        }

        private void cboCiclo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cboCiclo.SelectedIndex != -1) { 
            CargarComboNivel();
            }
        }
    }
    }

