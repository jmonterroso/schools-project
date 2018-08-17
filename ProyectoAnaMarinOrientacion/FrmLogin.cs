using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using log4net;

namespace ProyectoAnaMarinOrientacion
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
           
    } 

        private void BtnIngresar_Click(object sender, EventArgs e)
        {
            Logger.Info("usuario dio click en boto");
            
            if(mtbId.Text== txtContasena.Text)
            {
                Logger.Info("usuario loggeado");
                FrmPrincipal frmain = new FrmPrincipal();
                frmain.Owner = this;
                frmain.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Nombre de Usuario o contraseña incorrecta ");
            }
            this.mtbId.Clear();
            this.txtContasena.Clear();
        }

        private void lblCopyRight_Click(object sender, EventArgs e)
        {

        }
    }
}
