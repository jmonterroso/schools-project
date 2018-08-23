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
    public partial class FrmMantEncargado : Form
    {
        Capa.Logica.EncargadoLN logica;
        public FrmMantEncargado()
        {
           // Refrescar();

            InitializeComponent();
            logica = new Capa.Logica.EncargadoLN();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {

            if (txtIdentificacion.Text == "")
            {
                MessageBox.Show("Debe digitar la identificacion del encargado");
                return;
            }

            if (txtNombreCompleto.Text == "")
            {
                MessageBox.Show("Debe digitar el nombre del encargado");
                return;
            }
            if (txtCorreoElectronico.Text == "")
            {
                MessageBox.Show("Debe digitar el correo electronico del encargado");
                return;
            }
            if (txtParentesco.Text == "")
            {
                MessageBox.Show("Debe digitar el parentesco del encargado");
                return;
            }
            if (txtOcupacion.Text == "")
            {
                MessageBox.Show("Debe digitar la ocupacion del encargado");
                return;
            }
            //boton de guardar
            try
            {

                Encargado est = new Encargado()
                {
                    Identificacion = txtIdentificacion.Text,
                    NombreCompleto = txtNombreCompleto.Text,
                    CorreoElectronico = txtCorreoElectronico.Text,
                    Parentesco = txtParentesco.Text,
                    Ocupacion = txtOcupacion.Text,

                };
                logica.Guardar(est);
                MessageBox.Show("  Datos guardados con exito ");
                txtIdentificacion.Clear();
                txtNombreCompleto.Clear();
                txtOcupacion.Clear();
                txtCorreoElectronico.Clear();
                txtParentesco.Clear();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error al ingresar el encargado"
                    , MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {

            //boton para cancelar
            try
            {
                DialogResult dialogo = MessageBox.Show("Desea cerrar la ventada de datos del encargado", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk);
                if (dialogo == DialogResult.Yes)
                {
                    Dispose();
                }
                else
                    return;
            }
            catch
            {
            }
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            //boton de agregar
            txtIdentificacion.Visible = true;
            txtNombreCompleto.Visible = true;
            txtCorreoElectronico.Visible = true;
            txtOcupacion.Visible = true;
            txtParentesco.Visible = true;
            btnAceptar.Visible = true;
            btnCancelar.Visible = true;
            label1.Visible = true;
            label2.Visible = true;
            label3.Visible = true;
            label5.Visible = true;
            label6.Visible = true;
            label7.Visible = true;
            Refrescar();



        }

        private void FrmMantEncargado_Load(object sender, EventArgs e)
        {
            label1.Visible = false;
            label2.Visible = false;
            label3.Visible = false;
            label5.Visible = false;
            label6.Visible = false;
            label7.Visible = false;
            txtIdentificacion.Visible = false;
            txtNombreCompleto.Visible = false;
            txtCorreoElectronico.Visible = false;
            txtOcupacion.Visible = false;
            txtParentesco.Visible = false;
            btnAceptar.Visible = false;
            btnCancelar.Visible = false;
            groupBox1.Visible = false;
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            //boton de eliminar
            btnCancelar.Enabled = false;
            btnAceptar.Enabled = false;


            string msg = "¿Desea eliminar el encargado seleccionado?";
            var resultado = MessageBox.Show(msg, "Pregunta", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
            if (resultado == DialogResult.Yes)
            {
                if (dgvEncargado.SelectedRows.Count > 0)
                {
                    //databounditem retorna el objeto que asigno en datasource
                    var enc = (Encargado)dgvEncargado.SelectedRows[0].DataBoundItem;
                    logica.Eliminar(enc);
                    Refrescar();

                }
            }
        }

            private void Refrescar()
        {
            dgvEncargado.DataSource = logica.SeleccionarTodos();

        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            ///sumary
            ///Metodo para actualizar un encardado
            ///sumary
            ///

            //validaciones
            //if (txtIdentificacion.Text == "")
            //{
            //    MessageBox.Show("Debe digitar la identificacion del estudiante");
            //    return;
            //}

            txtIdentificacion.ReadOnly = true;
            txtIdentificacion.Enabled = true;
            if (txtNombreCompleto.Text == "")
            {
                MessageBox.Show("Debe digitar el nombre del encargado");
                return;
            }
            if (txtCorreoElectronico.Text == "")
            {
                MessageBox.Show("Debe digitar el correo electronico del encargado");
                return;
            }
            if (txtParentesco.Text == "")
            {
                MessageBox.Show("Debe digitar el parentesco del encargado");
                return;
            }
            if (txtOcupacion.Text == "")
            {
                MessageBox.Show("Debe digitar la ocupacion del encargado");
                return;
            }


            groupBox1.Visible = true;
            //Actualizar
            Refrescar();
            groupBox1.Visible = false;
            txtIdentificacion.ReadOnly = true;
            dgvEncargado.Visible = true;
            btnCancelar.Enabled = true;
            btnAceptar.Enabled = true;
            //Obtener el id de la fila seleccionada
            if (dgvEncargado.SelectedRows.Count > 0)
            {
                var encargado = (Encargado)dgvEncargado.SelectedRows[0].DataBoundItem;
                txtIdentificacion.Text = encargado.Identificacion.ToString();
                txtNombreCompleto.Text = encargado.NombreCompleto;
                txtOcupacion.Text = encargado.Ocupacion;
                txtParentesco.Text = encargado.Parentesco;
                txtCorreoElectronico.Text = encargado.CorreoElectronico;


                // groupBox1.Visible = true;
                logica.SeleccionarPorId(encargado.Identificacion);
            }
            else
            {
                MessageBox.Show("Debe seleccionar un encargado a actualizar");
            }
        }

        private void dgvEncargado_SelectionChanged(object sender, EventArgs e)
        {

        }

        private void dgvEncargado_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (dgvEncargado.SelectedRows.Count > 0)
            {
                //databounditem retorna el objeto que asigno en datasource
                var encar = (Encargado)dgvEncargado.SelectedRows[0].DataBoundItem;
                txtIdentificacion.Text = encar.Identificacion.ToString();
                txtNombreCompleto.Text = encar.NombreCompleto;
                txtCorreoElectronico.Text = encar.CorreoElectronico;
                txtOcupacion.Text= encar.Ocupacion;
                txtParentesco.Text = encar.Parentesco;

            }
        }
    }
}

