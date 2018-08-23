using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoAnaMarinOrientacion.Reportes
{
    public partial class FrmReporteInstrumentos : Form
    {
        public static string desde;
        public static string hasta;
        public FrmReporteInstrumentos()
        {
            InitializeComponent();
        }

        private void FrmReporteInstrumentos_Load(object sender, EventArgs e)
        {
            //this.PA_SeleccionarInstrumentosFechaReporteTableAdapter.GetData( Convert.ToDateTime( desde), Convert.ToDateTime(hasta));
            //// TODO: This line of code loads data into the 'DataSet2.PA_SeleccionarInstrumentosFechaReporte' table. You can move, or remove it, as needed.
            //this.PA_SeleccionarInstrumentosFechaReporteTableAdapter.Fill(this.DataSet2.PA_SeleccionarInstrumentosFechaReporte);

            //this.reportViewer1.RefreshReport();
        }

        private void PA_SeleccionarInstrumentosFechaReporteBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }
    }
}
