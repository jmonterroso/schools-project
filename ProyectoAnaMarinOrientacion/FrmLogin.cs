using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Capa.Entidades;
using log4net;

namespace ProyectoAnaMarinOrientacion
{
    public partial class FrmLogin : Form
    {
        Capa.Logica.UsuarioLN logicaUsuario;
        public FrmLogin()
        {
            logicaUsuario = new Capa.Logica.UsuarioLN();
            InitializeComponent();
            ttMensaje.SetToolTip(txtIdentificacion, "Digite una identificacion");
            ttMensaje.SetToolTip(txtContasena, "Digite una contrasena");

        }

        private void BtnIngresar_Click(object sender, EventArgs e)
        {
            //validacion
            if (txtIdentificacion.Text == "")
            {
                MessageBox.Show("Debe digitar un usuario");
                return;
            }
            if (txtContasena.Text == "")
            {
                MessageBox.Show("Debe digitar una contrasena");
                return;

            }
            string Identificacion = txtIdentificacion.Text;
            string Password = txtContasena.Text.ToString();
            Usuario usuario = new Usuario
            {
                Identificacion = Identificacion,
                Password = Password
            };
            Usuario.UsuarioActual = logicaUsuario.Login(usuario);

            if (Usuario.UsuarioActual != null)
            {
                MessageBox.Show("Bienvenido", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                ////Menus
                if (Usuario.UsuarioActual.Rol == Capa.Entidades.Enumeradores.TipoUsuario.Encargado)
                {
                    Hide();

                    FrmMenuEncargado enc = new FrmMenuEncargado();
                    enc.Show();
                }
                else
                {
                    if (Usuario.UsuarioActual.Rol == Capa.Entidades.Enumeradores.TipoUsuario.Docente)
                    {
                        //this.Hide();
                        // Dispose();
                        FrmMenuDocente menu = new FrmMenuDocente();
                        menu.Show();


                    }
                    else
                    {
                        // Hide();

                        FrmPrincipal principal = new FrmPrincipal();
                        principal.Show();




                    }
                }
            }
            else
            {
                MessageBox.Show("Vuelva a intentarlo", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }




            this.txtIdentificacion.Clear();
            this.txtContasena.Clear();

        }

        private void lblCopyRight_Click(object sender, EventArgs e)
        {

        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {
            txtIdentificacion.Focus();
            txtContasena.PasswordChar = '*';

        }

        private void txtIdentificacion_TabIndexChanged(object sender, EventArgs e)
        {
            txtContasena.Focus();
        }

        private void txtIdentificacion_Enter(object sender, EventArgs e)
        {
            //txtContasena.Focus();
        }

        private void txtContasena_Enter(object sender, EventArgs e)
        {
            //BtnIngresar.Focus();
        }

        private void FrmLogin_FormClosed(object sender, FormClosedEventArgs e)
        {
            DialogResult dialogo = MessageBox.Show("Desea cerrar la aplicacion", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk);
            if (dialogo == DialogResult.Yes)
            {
                Dispose();

            }
            else
            {
                if (dialogo == DialogResult.No)
                {
                    FrmLogin login = new FrmLogin();
                    login.Show(); ;
                }
            }
        }
    }
}
