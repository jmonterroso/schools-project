using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoAnaMarinOrientacion
{
    public partial class FrmMenuDocente : Form
    {
        public FrmMenuDocente()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //boton de cambiar usuario. 
            //sale del menu y va al login 
            //debe volver a digitar una nueva identificaciion y contrasena
          Dispose();
          FrmLogin login = new FrmLogin();
          login.Show();
        }
    }
}
