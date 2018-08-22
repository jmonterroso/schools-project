using Capa.Entidades;
using Capa.Logica;
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
    public partial class FrmMantMotivoAtencion : Form
    {
         Capa.Logica.MotivoAtencionLN  logica;
        private BindingSource bindingSource1 = new BindingSource();
        

        public FrmMantMotivoAtencion()
        {
            
            InitializeComponent();
            //DgvMotivos.AutoGenerateColumns = false;
            logica = new Capa.Logica.MotivoAtencionLN();
            Refrescar();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }


    
        private void toolStripButton1_Click(object sender, EventArgs e)
        {    //Boton para agregar un nuevo motivo
            Refrescar();
            groupBox2.Visible = true;
            groupBox1.Visible = true;
            DgvMotivos.ReadOnly = true;
            btnCancelarMotivo.Enabled = true;
            btnGuardarMotivo.Enabled = true;
            txtCodigoMotivo.Enabled = true;
            txtCodigoMotivo.ReadOnly = false;
            txtCodigoMotivo.Clear();
            txtDescripcionMotivo.Clear();
            DgvMotivos.ClearSelection();
            DgvMotivos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

        }

        private void FrmMantMotivoAtencion_Load(object sender, EventArgs e)
        {
            groupBox1.Visible = false;
            groupBox2.Visible = false;

        }

        private void btnCancelarMotivo_Click(object sender, EventArgs e)
        {

            try
            {
                DialogResult dialogo = MessageBox.Show("Desea cerrar el mantenimiento de Motivos", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk);
                if (dialogo == DialogResult.Yes)
                {
                    Dispose();
                }
                else
                    return;
            }
            catch { }
        }

        private void btnAgregarMotivo_Click(object sender, EventArgs e)
        {
            btnCancelarMotivo.Enabled = true;
            btnGuardarMotivo.Enabled = true;
            try
            {
                
                MotivoAtencion mot = new MotivoAtencion()
                {
                    IdMotivo = int.Parse(txtCodigoMotivo.Text),
                    Descripcion = txtDescripcionMotivo.Text
                };
                DgvMotivos.DataSource = mot;
                
                logica.Guardar(mot);
                MessageBox.Show("  Datos guardados con exito ");
                DgvMotivos.AutoGenerateColumns = false;
                bindingSource1.Add(mot.Descripcion);
                DgvMotivos.DataSource = bindingSource1;
                Refrescar();
                Limpiar();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error al guardar el motivo"
                    , MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Refrescar()
        {
            DgvMotivos.AutoGenerateColumns = false;
            DgvMotivos.DataSource = logica.SeleccionarTodas();
        }

        private void DgvMotivos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void DgvMotivos_SelectionChanged(object sender, EventArgs e)
        {
            DgvMotivos.AutoGenerateColumns = false;

            if (DgvMotivos.SelectedRows.Count > 0)
            {
                //databounditem retorna el objeto que asigno en datasource
                var mot = (MotivoAtencion)DgvMotivos.SelectedRows[0].DataBoundItem;
                txtCodigoMotivo.Text = mot.IdMotivo.ToString();
                txtDescripcionMotivo.Text = mot.Descripcion;
               
            }
        }


        private void Limpiar()
        {
            txtCodigoMotivo.Clear();
            txtDescripcionMotivo.Clear();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            groupBox2.Visible = true;
            //Actualizar

            
            btnCancelarMotivo.Enabled = true;
            btnGuardarMotivo.Enabled = true;
            //Obtener el id de la fila seleccionada
            if (DgvMotivos.SelectedRows.Count > 0)
            {
                var moti = (MotivoAtencion)DgvMotivos.SelectedRows[0].DataBoundItem;
                txtCodigoMotivo.Text = moti.IdMotivo.ToString();
                txtCodigoMotivo.ReadOnly = true;
                txtDescripcionMotivo.Text = moti.Descripcion;
                logica.SeleccionarPorId(moti.IdMotivo);
                groupBox1.Visible = true;
            }
            else
            {
                MessageBox.Show("Debe seleccionar un motivo a actualizar");
            }
            
            

            }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            //ELIMINAR
            btnCancelarMotivo.Enabled=false;
            btnGuardarMotivo.Enabled = false;

            string msg = "¿Desea eliminar el motivo seleccionado?";
            var resultado = MessageBox.Show(msg, "Pregunta", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
            if (resultado == DialogResult.Yes)
            {
                if (DgvMotivos.SelectedRows.Count > 0)
                {
                    //databounditem retorna el objeto que asigno en datasource
                    var moti   = (MotivoAtencion)DgvMotivos.SelectedRows[0].DataBoundItem;
                    logica.Eliminar(moti);
                    Refrescar();

                }
            }
        }

        private void toolStripButton1_DoubleClick(object sender, EventArgs e)
        {
            groupBox2.Visible = true;
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            //boton para consultar la lista
            Refrescar();
            groupBox2.Visible = true;
            groupBox1.Visible = false;
        }

        private void toolStripButton1_Click_1(object sender, EventArgs e)
        {
            //Boton para agregar un nuevo motivo
            Refrescar();
            groupBox2.Visible = true;
            groupBox1.Visible = true;
            DgvMotivos.ReadOnly = true;
            btnCancelarMotivo.Enabled = true;
            btnGuardarMotivo.Enabled = true;
            txtCodigoMotivo.Enabled = true;
            txtCodigoMotivo.ReadOnly = false;
            txtCodigoMotivo.Clear();
            txtDescripcionMotivo.Clear();
            DgvMotivos.ClearSelection();

        }

        private void toolStripButton2_Click_1(object sender, EventArgs e)
        {
            //actualizar
            groupBox2.Visible = true;
            //Actualizar


            btnCancelarMotivo.Enabled = true;
            btnGuardarMotivo.Enabled = true;
            //Obtener el id de la fila seleccionada
            if (DgvMotivos.SelectedRows.Count > 0)
            {
                var moti = (MotivoAtencion)DgvMotivos.SelectedRows[0].DataBoundItem;
                txtCodigoMotivo.Text = moti.IdMotivo.ToString();
                txtCodigoMotivo.ReadOnly = true;
                txtDescripcionMotivo.Text = moti.Descripcion;
                logica.SeleccionarPorId(moti.IdMotivo);
                groupBox1.Visible = true;
            }
            else
            {
                MessageBox.Show("Debe seleccionar un motivo a actualizar");
            }

        }

        private void toolStripButton3_Click_1(object sender, EventArgs e)
        {
            //ELIMINAR
            btnCancelarMotivo.Enabled = false;
            btnGuardarMotivo.Enabled = false;

            string msg = "¿Desea eliminar el motivo seleccionado?";
            var resultado = MessageBox.Show(msg, "Pregunta", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
            if (resultado == DialogResult.Yes)
            {
                if (DgvMotivos.SelectedRows.Count > 0)
                {
                    //databounditem retorna el objeto que asigno en datasource
                    var moti = (MotivoAtencion)DgvMotivos.SelectedRows[0].DataBoundItem;
                    logica.Eliminar(moti);
                    Refrescar();

                }
            }
        }

        private void toolStripButton4_Click_1(object sender, EventArgs e)
        {
            //consultar

            Refrescar();
            groupBox2.Visible = true;
            groupBox1.Visible = false; ;
            DgvMotivos.ReadOnly = true;
            btnCancelarMotivo.Enabled = true;
            btnGuardarMotivo.Enabled = true;
            txtCodigoMotivo.Enabled = true;
            txtCodigoMotivo.ReadOnly = false;
            txtCodigoMotivo.Clear();
            txtDescripcionMotivo.Clear();
            DgvMotivos.ClearSelection();
        }
    }
    }
    
