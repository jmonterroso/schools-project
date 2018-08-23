using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoAnaMarinOrientacion.Reportes { 
public partial class FrmReportesMenu : Form
    {
      public static string desde;
      public static string hasta;
        public FrmReportesMenu()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            
           var  desde1 = dateTimePicker1.Text;
              var hasta1 = dateTimePicker2.Text;
            FrmReportesMenu.desde = desde1;
            FrmReportesMenu.hasta = hasta1;
            Reportes.FrmReporteInstrumentos inst = new FrmReporteInstrumentos();
            inst.Show();
        }
    }
}
