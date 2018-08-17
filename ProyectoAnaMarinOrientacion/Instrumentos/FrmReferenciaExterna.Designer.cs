namespace ProyectoAnaMarinOrientacion.Instrumentos
{
    partial class FrmReferenciaExterna
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.mskFecha = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupEstudiante = new System.Windows.Forms.GroupBox();
            this.txtProvincia = new System.Windows.Forms.TextBox();
            this.txtOtrasSenas = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtDistrito = new System.Windows.Forms.TextBox();
            this.txtCanton = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.cboNivel = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtAnnosCumplidos = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtNIdentificacion = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNombreCompleto = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtIntituciondondeserefiere = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtCorreoElectronico = new System.Windows.Forms.TextBox();
            this.groupEncargado = new System.Windows.Forms.GroupBox();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.txtCedula = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.txtPersonaRefiere = new System.Windows.Forms.TextBox();
            this.txtPuesto = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.txtRecomendaciones = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.txtAcuerdos = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.txtSitucionObservada = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.BtnCancelar = new System.Windows.Forms.Button();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.cboMotivos = new System.Windows.Forms.ComboBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupEstudiante.SuspendLayout();
            this.groupEncargado.SuspendLayout();
            this.SuspendLayout();
            // 
            // mskFecha
            // 
            this.mskFecha.Location = new System.Drawing.Point(68, 6);
            this.mskFecha.Name = "mskFecha";
            this.mskFecha.ReadOnly = true;
            this.mskFecha.Size = new System.Drawing.Size(100, 20);
            this.mskFecha.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Fecha:";
            // 
            // groupEstudiante
            // 
            this.groupEstudiante.Controls.Add(this.txtProvincia);
            this.groupEstudiante.Controls.Add(this.txtOtrasSenas);
            this.groupEstudiante.Controls.Add(this.label13);
            this.groupEstudiante.Controls.Add(this.txtDistrito);
            this.groupEstudiante.Controls.Add(this.txtCanton);
            this.groupEstudiante.Controls.Add(this.label12);
            this.groupEstudiante.Controls.Add(this.label11);
            this.groupEstudiante.Controls.Add(this.label10);
            this.groupEstudiante.Controls.Add(this.label9);
            this.groupEstudiante.Controls.Add(this.cboNivel);
            this.groupEstudiante.Controls.Add(this.label8);
            this.groupEstudiante.Controls.Add(this.txtAnnosCumplidos);
            this.groupEstudiante.Controls.Add(this.label7);
            this.groupEstudiante.Controls.Add(this.txtNIdentificacion);
            this.groupEstudiante.Controls.Add(this.label6);
            this.groupEstudiante.Controls.Add(this.label3);
            this.groupEstudiante.Controls.Add(this.txtNombreCompleto);
            this.groupEstudiante.Location = new System.Drawing.Point(15, 38);
            this.groupEstudiante.Name = "groupEstudiante";
            this.groupEstudiante.Size = new System.Drawing.Size(682, 198);
            this.groupEstudiante.TabIndex = 15;
            this.groupEstudiante.TabStop = false;
            this.groupEstudiante.Text = "Datos del o la estudiante";
            this.groupEstudiante.Enter += new System.EventHandler(this.groupEstudiante_Enter);
            // 
            // txtProvincia
            // 
            this.txtProvincia.Location = new System.Drawing.Point(92, 118);
            this.txtProvincia.Name = "txtProvincia";
            this.txtProvincia.Size = new System.Drawing.Size(140, 20);
            this.txtProvincia.TabIndex = 21;
            // 
            // txtOtrasSenas
            // 
            this.txtOtrasSenas.Location = new System.Drawing.Point(91, 144);
            this.txtOtrasSenas.Multiline = true;
            this.txtOtrasSenas.Name = "txtOtrasSenas";
            this.txtOtrasSenas.Size = new System.Drawing.Size(535, 29);
            this.txtOtrasSenas.TabIndex = 20;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(25, 158);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(63, 13);
            this.label13.TabIndex = 19;
            this.label13.Text = "Otras señas";
            // 
            // txtDistrito
            // 
            this.txtDistrito.Location = new System.Drawing.Point(487, 118);
            this.txtDistrito.Name = "txtDistrito";
            this.txtDistrito.Size = new System.Drawing.Size(139, 20);
            this.txtDistrito.TabIndex = 18;
            // 
            // txtCanton
            // 
            this.txtCanton.Location = new System.Drawing.Point(285, 118);
            this.txtCanton.Name = "txtCanton";
            this.txtCanton.Size = new System.Drawing.Size(140, 20);
            this.txtCanton.TabIndex = 17;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(436, 125);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(39, 13);
            this.label12.TabIndex = 15;
            this.label12.Text = "Distrito";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(238, 125);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(41, 13);
            this.label11.TabIndex = 14;
            this.label11.Text = "Canton";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(25, 125);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(51, 13);
            this.label10.TabIndex = 13;
            this.label10.Text = "Provincia";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(7, 91);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(112, 13);
            this.label9.TabIndex = 12;
            this.label9.Text = "Direccion del domicilio";
            // 
            // cboNivel
            // 
            this.cboNivel.FormattingEnabled = true;
            this.cboNivel.Location = new System.Drawing.Point(481, 53);
            this.cboNivel.Name = "cboNivel";
            this.cboNivel.Size = new System.Drawing.Size(135, 21);
            this.cboNivel.TabIndex = 11;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(394, 56);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(81, 13);
            this.label8.TabIndex = 10;
            this.label8.Text = "Nivel que cursa";
            // 
            // txtAnnosCumplidos
            // 
            this.txtAnnosCumplidos.Location = new System.Drawing.Point(130, 56);
            this.txtAnnosCumplidos.Name = "txtAnnosCumplidos";
            this.txtAnnosCumplidos.Size = new System.Drawing.Size(55, 20);
            this.txtAnnosCumplidos.TabIndex = 9;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(25, 59);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(81, 13);
            this.label7.TabIndex = 8;
            this.label7.Text = "Años cumplidos";
            // 
            // txtNIdentificacion
            // 
            this.txtNIdentificacion.Location = new System.Drawing.Point(481, 23);
            this.txtNIdentificacion.Name = "txtNIdentificacion";
            this.txtNIdentificacion.Size = new System.Drawing.Size(135, 20);
            this.txtNIdentificacion.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(394, 26);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "N.Identificacion";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Nombre completo";
            // 
            // txtNombreCompleto
            // 
            this.txtNombreCompleto.Location = new System.Drawing.Point(132, 19);
            this.txtNombreCompleto.Name = "txtNombreCompleto";
            this.txtNombreCompleto.Size = new System.Drawing.Size(228, 20);
            this.txtNombreCompleto.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(191, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Institucion donde se refiere";
            // 
            // txtIntituciondondeserefiere
            // 
            this.txtIntituciondondeserefiere.Location = new System.Drawing.Point(340, 12);
            this.txtIntituciondondeserefiere.Name = "txtIntituciondondeserefiere";
            this.txtIntituciondondeserefiere.Size = new System.Drawing.Size(225, 20);
            this.txtIntituciondondeserefiere.TabIndex = 16;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(273, 52);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Correo Electronico";
            // 
            // txtCorreoElectronico
            // 
            this.txtCorreoElectronico.Location = new System.Drawing.Point(380, 50);
            this.txtCorreoElectronico.Name = "txtCorreoElectronico";
            this.txtCorreoElectronico.Size = new System.Drawing.Size(227, 20);
            this.txtCorreoElectronico.TabIndex = 5;
            // 
            // groupEncargado
            // 
            this.groupEncargado.Controls.Add(this.maskedTextBox1);
            this.groupEncargado.Controls.Add(this.label16);
            this.groupEncargado.Controls.Add(this.label15);
            this.groupEncargado.Controls.Add(this.txtCedula);
            this.groupEncargado.Controls.Add(this.label14);
            this.groupEncargado.Controls.Add(this.textBox1);
            this.groupEncargado.Controls.Add(this.txtCorreoElectronico);
            this.groupEncargado.Controls.Add(this.label5);
            this.groupEncargado.Location = new System.Drawing.Point(19, 248);
            this.groupEncargado.Name = "groupEncargado";
            this.groupEncargado.Size = new System.Drawing.Size(678, 84);
            this.groupEncargado.TabIndex = 17;
            this.groupEncargado.TabStop = false;
            this.groupEncargado.Text = "Datos del padre, madre o persona encargada";
            this.groupEncargado.Enter += new System.EventHandler(this.groupEncargado_Enter);
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Location = new System.Drawing.Point(126, 47);
            this.maskedTextBox1.Mask = "00000000";
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(135, 20);
            this.maskedTextBox1.TabIndex = 42;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(21, 53);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(49, 13);
            this.label16.TabIndex = 41;
            this.label16.Text = "Telefono";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(405, 26);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(40, 13);
            this.label15.TabIndex = 40;
            this.label15.Text = "Cedula";
            // 
            // txtCedula
            // 
            this.txtCedula.Location = new System.Drawing.Point(467, 23);
            this.txtCedula.Name = "txtCedula";
            this.txtCedula.Size = new System.Drawing.Size(100, 20);
            this.txtCedula.TabIndex = 39;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(21, 26);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(90, 13);
            this.label14.TabIndex = 3;
            this.label14.Text = "Nombre completo";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(128, 19);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(228, 20);
            this.textBox1.TabIndex = 2;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(36, 344);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(99, 13);
            this.label17.TabIndex = 18;
            this.label17.Text = "Persona que refiere";
            // 
            // txtPersonaRefiere
            // 
            this.txtPersonaRefiere.Location = new System.Drawing.Point(153, 341);
            this.txtPersonaRefiere.Name = "txtPersonaRefiere";
            this.txtPersonaRefiere.Size = new System.Drawing.Size(198, 20);
            this.txtPersonaRefiere.TabIndex = 19;
            this.txtPersonaRefiere.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // txtPuesto
            // 
            this.txtPuesto.Location = new System.Drawing.Point(427, 341);
            this.txtPuesto.Name = "txtPuesto";
            this.txtPuesto.Size = new System.Drawing.Size(191, 20);
            this.txtPuesto.TabIndex = 24;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(365, 348);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(40, 13);
            this.label18.TabIndex = 23;
            this.label18.Text = "Puesto";
            // 
            // txtRecomendaciones
            // 
            this.txtRecomendaciones.Location = new System.Drawing.Point(192, 546);
            this.txtRecomendaciones.Multiline = true;
            this.txtRecomendaciones.Name = "txtRecomendaciones";
            this.txtRecomendaciones.Size = new System.Drawing.Size(484, 20);
            this.txtRecomendaciones.TabIndex = 38;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(8, 549);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(178, 13);
            this.label19.TabIndex = 37;
            this.label19.Text = "Observaciones y Recomendaciones";
            // 
            // txtAcuerdos
            // 
            this.txtAcuerdos.Location = new System.Drawing.Point(190, 499);
            this.txtAcuerdos.Multiline = true;
            this.txtAcuerdos.Name = "txtAcuerdos";
            this.txtAcuerdos.Size = new System.Drawing.Size(488, 20);
            this.txtAcuerdos.TabIndex = 36;
            this.txtAcuerdos.TextChanged += new System.EventHandler(this.txtAcuerdos_TextChanged);
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(8, 499);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(180, 13);
            this.label20.TabIndex = 35;
            this.label20.Text = "Acuerdos que ha realizado el centro ";
            // 
            // txtSitucionObservada
            // 
            this.txtSitucionObservada.Location = new System.Drawing.Point(190, 444);
            this.txtSitucionObservada.Multiline = true;
            this.txtSitucionObservada.Name = "txtSitucionObservada";
            this.txtSitucionObservada.Size = new System.Drawing.Size(488, 20);
            this.txtSitucionObservada.TabIndex = 34;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(22, 451);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(107, 13);
            this.label21.TabIndex = 33;
            this.label21.Text = "Situacion presentada";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(33, 402);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(104, 13);
            this.label22.TabIndex = 31;
            this.label22.Text = "Motivo de referencia\r\n";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(8, 512);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(176, 13);
            this.label23.TabIndex = 39;
            this.label23.Text = "educativo para apoyar al estudiante";
            this.label23.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label23.Click += new System.EventHandler(this.label23_Click);
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.Location = new System.Drawing.Point(427, 630);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(102, 23);
            this.BtnCancelar.TabIndex = 48;
            this.BtnCancelar.Text = "Cancelar";
            this.BtnCancelar.UseVisualStyleBackColor = true;
            this.BtnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(273, 630);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(102, 23);
            this.btnAceptar.TabIndex = 47;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // cboMotivos
            // 
            this.cboMotivos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboMotivos.FormattingEnabled = true;
            this.cboMotivos.Location = new System.Drawing.Point(190, 394);
            this.cboMotivos.Name = "cboMotivos";
            this.cboMotivos.Size = new System.Drawing.Size(237, 21);
            this.cboMotivos.TabIndex = 52;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(409, 583);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(221, 20);
            this.textBox2.TabIndex = 54;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(308, 586);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 13);
            this.label4.TabIndex = 53;
            this.label4.Text = "Recibido por";
            // 
            // FrmReferenciaExterna
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(748, 665);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cboMotivos);
            this.Controls.Add(this.BtnCancelar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.label23);
            this.Controls.Add(this.txtRecomendaciones);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.txtAcuerdos);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.txtSitucionObservada);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.txtPuesto);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.txtPersonaRefiere);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.groupEncargado);
            this.Controls.Add(this.txtIntituciondondeserefiere);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupEstudiante);
            this.Controls.Add(this.mskFecha);
            this.Controls.Add(this.label1);
            this.Name = "FrmReferenciaExterna";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Recibido por";
            this.Load += new System.EventHandler(this.FrmReferenciaExterna_Load);
            this.groupEstudiante.ResumeLayout(false);
            this.groupEstudiante.PerformLayout();
            this.groupEncargado.ResumeLayout(false);
            this.groupEncargado.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox mskFecha;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupEstudiante;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cboNivel;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtAnnosCumplidos;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtNIdentificacion;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtCorreoElectronico;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNombreCompleto;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtIntituciondondeserefiere;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtDistrito;
        private System.Windows.Forms.TextBox txtCanton;
        private System.Windows.Forms.TextBox txtOtrasSenas;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.GroupBox groupEncargado;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtCedula;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox txtPersonaRefiere;
        private System.Windows.Forms.TextBox txtPuesto;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox txtRecomendaciones;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox txtAcuerdos;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox txtSitucionObservada;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Button BtnCancelar;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.ComboBox cboMotivos;
        private System.Windows.Forms.TextBox txtProvincia;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label4;
    }
}