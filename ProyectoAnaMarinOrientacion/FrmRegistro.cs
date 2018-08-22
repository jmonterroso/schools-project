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
using Capa.Entidades;
using Capa.Entidades.Enumeradores;

namespace ProyectoAnaMarinOrientacion
{
    public partial class FrmRegistro : Form
    {

        Capa.Logica.UsuarioLN logicaUsuario;
        public FrmRegistro()
        {
            logicaUsuario = new Capa.Logica.UsuarioLN();
            InitializeComponent();
            cboRolUsuario.DataSource = Enum.GetValues(typeof(TipoUsuario));



        }

        private void BtnIngresar_Click(object sender, EventArgs e)
        {
            Logger.Info("usuario dio click en boton");
            //inicio validaciones
            if (txtIdentificacion.Text == "")
            {
                MessageBox.Show("Debe digitar una identificacion");
                return;
            }
            if (txtContasena.Text == "")
            {
                MessageBox.Show("Debe digitar una contrasena");
                return;
            }
            if (txtConfirmarContrasena.Text == "")
            {
                MessageBox.Show("Debe confirmar una contrasena");
                return;
             }
            if (cboRolUsuario.SelectedIndex == -1)
            {
                MessageBox.Show("Debe selecionar un rol de usuario");
                return;

            }
            

            if (txtContasena.Text.ToString().Trim().ToLower() == txtConfirmarContrasena.Text.ToString().Trim().ToLower())
            {
                string Identificacion = txtIdentificacion.Text;
                string Password = txtContasena.Text.ToString();
                Usuario usuario = new Usuario
                {
                    Identificacion = Identificacion,
                    Password = Password,
                    Rol= (TipoUsuario)cboRolUsuario.SelectedItem
                };
                logicaUsuario.Guardar(usuario);
            }
            else
            {
                MessageBox.Show("¡La contraseña y la contraseña de confirmación no coinciden! Por favor, compruebe ...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            
            this.txtIdentificacion.Clear();
            this.txtContasena.Clear();
            txtConfirmarContrasena.Clear();
            cboRolUsuario.SelectedIndex = -1;
            MessageBox.Show("Usuario Guardado Satisfactoriamente!", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void lblCopyRight_Click(object sender, EventArgs e)
        {

        }

        private void FrmRegistro_Load(object sender, EventArgs e)
        {
            cboRolUsuario.SelectedIndex = -1;
        }
    }
}
