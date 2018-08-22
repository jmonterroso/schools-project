using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Printing;
using Capa.Entidades;

namespace ProyectoAnaMarinOrientacion
{
    public partial class FrmComprobanteAsistencia : Form
    {
        public static Estudiante est;
        Capa.Logica.EstudianteLN logicaEstudiante;
        public static ExpedienteFacade expediente;
        public static Encargado encargado;


        /// <summary>
        /// 
        /// </summary>
        private Button printButton = new Button();
        //private PrintDocument printDocument1 = new PrintDocument();

        public FrmComprobanteAsistencia()
        {

            InitializeComponent();

        }

        private void FrmComprobanteAsistencia_Load(object sender, EventArgs e)
        {
            //llenarCajas();
            maskedTextBox1.Text = DateTime.Now.ToString();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void txtNombreSenor_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPersonaAtiende_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void txtProfesor_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void cboNivel_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void txtNombredEstudiante_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtMotivo_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void txtCedula_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void printDocument1_PrintPage(object sender, PrintPageEventArgs e)
        {
            Bitmap bmp = Properties.Resources._306218;

            Image newImage = bmp;
             
            e.Graphics.DrawImage(newImage, 25, 25, newImage.Width, newImage.Height);
      
            e.Graphics.DrawString("Comprobante de asistencia: " , new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(25, 180));
            e.Graphics.DrawString("El/La señor/a : "+ txtNombreSenor.Text, new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(25, 210));
            e.Graphics.DrawString("Cedula : " + txtCedula.Text, new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(25, 240));
            e.Graphics.DrawString("Se presento a : " + txtMotivo.Text, new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(25, 270));
            e.Graphics.DrawString("Del estudiante : " + txtNombredEstudiante.Text, new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(25, 310));
            e.Graphics.DrawString("Nivel : " + txtNivel.Text, new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(25, 340));
            e.Graphics.DrawString("Fecha y hora : " + maskedTextBox1, new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(25, 370));
            e.Graphics.DrawString("Profesor : ______________________________________ " , new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(25, 410));
            e.Graphics.DrawString("Personta que atiende : ______________________________________ " , new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(25, 440));
            e.Graphics.DrawString(dash.Text, new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(25, 550));

        }

        private void button1_Click(object sender, EventArgs e)
        {

            DVprintDocument1.Print();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //botn de vista previa
            DVprintPreviewDialog1.Document = DVprintDocument1;
            DVprintPreviewDialog1.ShowDialog();

        }

        private void DVprintPreviewDialog1_Load(object sender, EventArgs e)
        {
          
        }

        private void DVprintPreviewDialog1_Click(object sender, EventArgs e)
        {
          
        }

      
        private void llenarCajas()
        {
        
            txtNombredEstudiante.Text = est.NombreCompleto;
           // Capa.Logica.EncargadoLN logicaEnca = new Capa.Logica.EncargadoLN();
           // var encargado = logicaEnca.SeleccionarPorId(est.IdEncargado);
            txtNombreSenor.Text = encargado.NombreCompleto;
                //txtNombreSenor.Text = encargado.NombreCompleto;
            txtCedula.Text = est.IdEncargado;
        //  txtMotivo.Text = expediente.MotivoDescripcion;
            txtNivel.Text = (est.Seccion.Nivel).ToString();
            maskedTextBox1.Text =  DateTime.Now.ToString();


        }
    }
}
