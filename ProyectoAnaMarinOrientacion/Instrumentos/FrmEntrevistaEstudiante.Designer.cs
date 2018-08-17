namespace ProyectoAnaMarinOrientacion.Instrumentos
{
    partial class FrmEntrevistaEstudiante
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtNombreEstudiante = new System.Windows.Forms.TextBox();
            this.txtSeccion = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtOtro = new System.Windows.Forms.TextBox();
            this.ckcOtro = new System.Windows.Forms.CheckBox();
            this.ckcSolicitudEstudiante = new System.Windows.Forms.CheckBox();
            this.ckcReferencia = new System.Windows.Forms.CheckBox();
            this.ckcDeteccionProfesional = new System.Windows.Forms.CheckBox();
            this.mskFecha = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Situacion = new System.Windows.Forms.Label();
            this.Intervencion = new System.Windows.Forms.Label();
            this.t = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtSituacion = new System.Windows.Forms.TextBox();
            this.txtIntervencion = new System.Windows.Forms.TextBox();
            this.txtProceso = new System.Windows.Forms.TextBox();
            this.txtRecomendaciones = new System.Windows.Forms.TextBox();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.BtnCancelar = new System.Windows.Forms.Button();
            this.cboMotivos = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(58, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Fecha:";
            // 
            // txtNombreEstudiante
            // 
            this.txtNombreEstudiante.Location = new System.Drawing.Point(114, 38);
            this.txtNombreEstudiante.Name = "txtNombreEstudiante";
            this.txtNombreEstudiante.Size = new System.Drawing.Size(205, 20);
            this.txtNombreEstudiante.TabIndex = 2;
            // 
            // txtSeccion
            // 
            this.txtSeccion.Location = new System.Drawing.Point(381, 38);
            this.txtSeccion.Name = "txtSeccion";
            this.txtSeccion.Size = new System.Drawing.Size(100, 20);
            this.txtSeccion.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Nombre estudiante:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(325, 45);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Seccion:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtOtro);
            this.groupBox1.Controls.Add(this.ckcOtro);
            this.groupBox1.Controls.Add(this.ckcSolicitudEstudiante);
            this.groupBox1.Controls.Add(this.ckcReferencia);
            this.groupBox1.Controls.Add(this.ckcDeteccionProfesional);
            this.groupBox1.Location = new System.Drawing.Point(13, 67);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(384, 112);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            // 
            // txtOtro
            // 
            this.txtOtro.Location = new System.Drawing.Point(57, 85);
            this.txtOtro.Name = "txtOtro";
            this.txtOtro.Size = new System.Drawing.Size(303, 20);
            this.txtOtro.TabIndex = 4;
            // 
            // ckcOtro
            // 
            this.ckcOtro.AutoSize = true;
            this.ckcOtro.Location = new System.Drawing.Point(7, 86);
            this.ckcOtro.Name = "ckcOtro";
            this.ckcOtro.Size = new System.Drawing.Size(46, 17);
            this.ckcOtro.TabIndex = 3;
            this.ckcOtro.Text = "Otro";
            this.ckcOtro.UseVisualStyleBackColor = true;
            // 
            // ckcSolicitudEstudiante
            // 
            this.ckcSolicitudEstudiante.AutoSize = true;
            this.ckcSolicitudEstudiante.Location = new System.Drawing.Point(7, 63);
            this.ckcSolicitudEstudiante.Name = "ckcSolicitudEstudiante";
            this.ckcSolicitudEstudiante.Size = new System.Drawing.Size(167, 17);
            this.ckcSolicitudEstudiante.TabIndex = 2;
            this.ckcSolicitudEstudiante.Text = "Solicitud del mismo estudiante";
            this.ckcSolicitudEstudiante.UseVisualStyleBackColor = true;
            // 
            // ckcReferencia
            // 
            this.ckcReferencia.AutoSize = true;
            this.ckcReferencia.Location = new System.Drawing.Point(7, 40);
            this.ckcReferencia.Name = "ckcReferencia";
            this.ckcReferencia.Size = new System.Drawing.Size(300, 17);
            this.ckcReferencia.TabIndex = 1;
            this.ckcReferencia.Text = "Referencia(docentes, padre, madre o persona encargada)";
            this.ckcReferencia.UseVisualStyleBackColor = true;
            // 
            // ckcDeteccionProfesional
            // 
            this.ckcDeteccionProfesional.AutoSize = true;
            this.ckcDeteccionProfesional.Location = new System.Drawing.Point(7, 16);
            this.ckcDeteccionProfesional.Name = "ckcDeteccionProfesional";
            this.ckcDeteccionProfesional.Size = new System.Drawing.Size(216, 17);
            this.ckcDeteccionProfesional.TabIndex = 0;
            this.ckcDeteccionProfesional.Text = "Deteccion del profesional de orientacion";
            this.ckcDeteccionProfesional.UseVisualStyleBackColor = true;
            // 
            // mskFecha
            // 
            this.mskFecha.Location = new System.Drawing.Point(114, 15);
            this.mskFecha.Name = "mskFecha";
            this.mskFecha.ReadOnly = true;
            this.mskFecha.Size = new System.Drawing.Size(100, 20);
            this.mskFecha.TabIndex = 8;
            this.mskFecha.ValidatingType = typeof(System.DateTime);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 195);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(213, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Motivo por el que se atiende en Orientacion";
            // 
            // Situacion
            // 
            this.Situacion.AutoSize = true;
            this.Situacion.Location = new System.Drawing.Point(25, 239);
            this.Situacion.Name = "Situacion";
            this.Situacion.Size = new System.Drawing.Size(104, 13);
            this.Situacion.TabIndex = 10;
            this.Situacion.Text = "Situacion Detectada";
            // 
            // Intervencion
            // 
            this.Intervencion.AutoSize = true;
            this.Intervencion.Location = new System.Drawing.Point(25, 285);
            this.Intervencion.Name = "Intervencion";
            this.Intervencion.Size = new System.Drawing.Size(116, 13);
            this.Intervencion.TabIndex = 11;
            this.Intervencion.Text = "Intervencion Realizada";
            // 
            // t
            // 
            this.t.AutoSize = true;
            this.t.Location = new System.Drawing.Point(25, 332);
            this.t.Name = "t";
            this.t.Size = new System.Drawing.Size(88, 13);
            this.t.TabIndex = 12;
            this.t.Text = "Proceso a Seguir";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(25, 377);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(96, 13);
            this.label8.TabIndex = 13;
            this.label8.Text = "Recomendaciones";
            // 
            // txtSituacion
            // 
            this.txtSituacion.Location = new System.Drawing.Point(240, 236);
            this.txtSituacion.Multiline = true;
            this.txtSituacion.Name = "txtSituacion";
            this.txtSituacion.Size = new System.Drawing.Size(494, 35);
            this.txtSituacion.TabIndex = 15;
            // 
            // txtIntervencion
            // 
            this.txtIntervencion.Location = new System.Drawing.Point(240, 282);
            this.txtIntervencion.Multiline = true;
            this.txtIntervencion.Name = "txtIntervencion";
            this.txtIntervencion.Size = new System.Drawing.Size(494, 35);
            this.txtIntervencion.TabIndex = 16;
            // 
            // txtProceso
            // 
            this.txtProceso.Location = new System.Drawing.Point(240, 329);
            this.txtProceso.Multiline = true;
            this.txtProceso.Name = "txtProceso";
            this.txtProceso.Size = new System.Drawing.Size(494, 35);
            this.txtProceso.TabIndex = 17;
            // 
            // txtRecomendaciones
            // 
            this.txtRecomendaciones.Location = new System.Drawing.Point(240, 374);
            this.txtRecomendaciones.Multiline = true;
            this.txtRecomendaciones.Name = "txtRecomendaciones";
            this.txtRecomendaciones.Size = new System.Drawing.Size(494, 35);
            this.txtRecomendaciones.TabIndex = 18;
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(349, 476);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(102, 23);
            this.btnAceptar.TabIndex = 21;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.Location = new System.Drawing.Point(499, 476);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(102, 23);
            this.BtnCancelar.TabIndex = 22;
            this.BtnCancelar.Text = "Cancelar";
            this.BtnCancelar.UseVisualStyleBackColor = true;
            this.BtnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
            // 
            // cboMotivos
            // 
            this.cboMotivos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboMotivos.FormattingEnabled = true;
            this.cboMotivos.Location = new System.Drawing.Point(240, 192);
            this.cboMotivos.Name = "cboMotivos";
            this.cboMotivos.Size = new System.Drawing.Size(251, 21);
            this.cboMotivos.TabIndex = 40;
            this.cboMotivos.SelectedIndexChanged += new System.EventHandler(this.cboMotivos_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(262, 442);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 13);
            this.label5.TabIndex = 41;
            this.label5.Text = "Firma Orientador";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(370, 435);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(221, 20);
            this.textBox1.TabIndex = 42;
            // 
            // FrmEntrevistaEstudiante
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(746, 532);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cboMotivos);
            this.Controls.Add(this.BtnCancelar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.txtRecomendaciones);
            this.Controls.Add(this.txtProceso);
            this.Controls.Add(this.txtIntervencion);
            this.Controls.Add(this.txtSituacion);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.t);
            this.Controls.Add(this.Intervencion);
            this.Controls.Add(this.Situacion);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.mskFecha);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtSeccion);
            this.Controls.Add(this.txtNombreEstudiante);
            this.Controls.Add(this.label1);
            this.Name = "FrmEntrevistaEstudiante";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Entrevista Estudiante";
            this.Load += new System.EventHandler(this.FrmEntrevistaEstudiante_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNombreEstudiante;
        private System.Windows.Forms.TextBox txtSeccion;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtOtro;
        private System.Windows.Forms.CheckBox ckcOtro;
        private System.Windows.Forms.CheckBox ckcSolicitudEstudiante;
        private System.Windows.Forms.CheckBox ckcReferencia;
        private System.Windows.Forms.CheckBox ckcDeteccionProfesional;
        private System.Windows.Forms.MaskedTextBox mskFecha;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label Situacion;
        private System.Windows.Forms.Label Intervencion;
        private System.Windows.Forms.Label t;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtSituacion;
        private System.Windows.Forms.TextBox txtIntervencion;
        private System.Windows.Forms.TextBox txtProceso;
        private System.Windows.Forms.TextBox txtRecomendaciones;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button BtnCancelar;
        private System.Windows.Forms.ComboBox cboMotivos;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox1;
    }
}