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
using Capa.Logica;


namespace ProyectoAnaMarinOrientacion
{

    public partial class FrmDatosEncargado : Form
    {
        Capa.Logica.EncargadoLN Logica;
        

        // Encargado encargado = new Encargado();
        //encargado.listaTelefonos = new List<Telefono>()

        public FrmDatosEncargado()
        {
            
            InitializeComponent();
            Logica =  new Capa.Logica.EncargadoLN();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void txtOcupacion_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void txtCorreoElectronico_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNombreCompleto_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtIdentificacion_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txtParentesco_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void FrmDatosEncargado_Load(object sender, EventArgs e)
        {
            //Encargado encargado = new Encargado();
           // encargado.listaTelefonos = new List<Telefono>();
        }
        //boton de aceptar
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                

                Encargado enc = new Encargado()
                {
                    Identificacion = txtIdentificacion.Text,
                    NombreCompleto = txtNombreCompleto.Text,
                    CorreoElectronico = txtCorreoElectronico.Text,
                    Ocupacion = txtOcupacion.Text,
                    Parentesco = txtParentesco.Text,
                };
                //Logica.Guardar(enc);
                FrmExpediente.encar = enc;

                MessageBox.Show("  Datos guardados con exito ");
                Dispose();



            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error al ingresar el encargado"
                    , MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //List<string> ListaTelefonos = new List<string>();
        private void btnAgregarTelefono_Click(object sender, EventArgs e)
        {
        //    Telefono telefono = new Telefono();
        //    telefono.NumeroTelefono = mskTelefono.Text;

        //    encargado.listaTelefonos.Add(telefono);
        //    dgvTelefonos.DataSource = encargado.listaTelefonos;
        //    dgvTelefonos.DataSource = (from a in ListaTelefonos select new { Telefonos = a }).ToList();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {

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
            catch { }
        }

    
        
    }
}
