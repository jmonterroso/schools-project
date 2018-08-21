﻿using System;
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
           
    } 

        private void BtnIngresar_Click(object sender, EventArgs e)
        {
           
                string Identificacion = txtIdentificacion.Text;
                string Password = txtContasena.Text.ToString();
                Usuario usuario = new Usuario
                {
                    Identificacion = Identificacion,
                    Password = Password
                };
                Usuario.UsuarioActual = logicaUsuario.Login(usuario);
            
                if(Usuario.UsuarioActual != null)
            {
                MessageBox.Show("Bienvenido", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }



            this.txtIdentificacion.Clear();
            this.txtContasena.Clear();
            
        }

        private void lblCopyRight_Click(object sender, EventArgs e)
        {

        }
    }
}
