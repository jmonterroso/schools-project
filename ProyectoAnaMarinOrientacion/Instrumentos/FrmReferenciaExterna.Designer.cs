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
            this.label2 = new System.Windows.Forms.Label();
            this.txtIntituciondondeserefiere = new System.Windows.Forms.TextBox();
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
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(32, 78);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(99, 13);
            this.label17.TabIndex = 18;
            this.label17.Text = "Persona que refiere";
            // 
            // txtPersonaRefiere
            // 
            this.txtPersonaRefiere.Location = new System.Drawing.Point(149, 75);
            this.txtPersonaRefiere.Name = "txtPersonaRefiere";
            this.txtPersonaRefiere.Size = new System.Drawing.Size(198, 20);
            this.txtPersonaRefiere.TabIndex = 19;
            this.txtPersonaRefiere.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // txtPuesto
            // 
            this.txtPuesto.Location = new System.Drawing.Point(423, 75);
            this.txtPuesto.Name = "txtPuesto";
            this.txtPuesto.Size = new System.Drawing.Size(191, 20);
            this.txtPuesto.TabIndex = 24;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(361, 82);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(40, 13);
            this.label18.TabIndex = 23;
            this.label18.Text = "Puesto";
            // 
            // txtRecomendaciones
            // 
            this.txtRecomendaciones.Location = new System.Drawing.Point(188, 280);
            this.txtRecomendaciones.Multiline = true;
            this.txtRecomendaciones.Name = "txtRecomendaciones";
            this.txtRecomendaciones.Size = new System.Drawing.Size(484, 20);
            this.txtRecomendaciones.TabIndex = 38;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(4, 283);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(178, 13);
            this.label19.TabIndex = 37;
            this.label19.Text = "Observaciones y Recomendaciones";
            // 
            // txtAcuerdos
            // 
            this.txtAcuerdos.Location = new System.Drawing.Point(186, 233);
            this.txtAcuerdos.Multiline = true;
            this.txtAcuerdos.Name = "txtAcuerdos";
            this.txtAcuerdos.Size = new System.Drawing.Size(488, 20);
            this.txtAcuerdos.TabIndex = 36;
            this.txtAcuerdos.TextChanged += new System.EventHandler(this.txtAcuerdos_TextChanged);
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(4, 233);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(180, 13);
            this.label20.TabIndex = 35;
            this.label20.Text = "Acuerdos que ha realizado el centro ";
            // 
            // txtSitucionObservada
            // 
            this.txtSitucionObservada.Location = new System.Drawing.Point(186, 178);
            this.txtSitucionObservada.Multiline = true;
            this.txtSitucionObservada.Name = "txtSitucionObservada";
            this.txtSitucionObservada.Size = new System.Drawing.Size(488, 20);
            this.txtSitucionObservada.TabIndex = 34;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(18, 185);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(107, 13);
            this.label21.TabIndex = 33;
            this.label21.Text = "Situacion presentada";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(29, 136);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(104, 13);
            this.label22.TabIndex = 31;
            this.label22.Text = "Motivo de referencia\r\n";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(4, 246);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(176, 13);
            this.label23.TabIndex = 39;
            this.label23.Text = "educativo para apoyar al estudiante";
            this.label23.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label23.Click += new System.EventHandler(this.label23_Click);
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.Location = new System.Drawing.Point(423, 393);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(102, 23);
            this.BtnCancelar.TabIndex = 48;
            this.BtnCancelar.Text = "Cancelar";
            this.BtnCancelar.UseVisualStyleBackColor = true;
            this.BtnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(269, 393);
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
            this.cboMotivos.Location = new System.Drawing.Point(186, 128);
            this.cboMotivos.Name = "cboMotivos";
            this.cboMotivos.Size = new System.Drawing.Size(237, 21);
            this.cboMotivos.TabIndex = 52;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(405, 317);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(221, 20);
            this.textBox2.TabIndex = 54;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(304, 320);
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
            this.Controls.Add(this.txtIntituciondondeserefiere);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.mskFecha);
            this.Controls.Add(this.label1);
            this.Name = "FrmReferenciaExterna";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Recibido por";
            this.Load += new System.EventHandler(this.FrmReferenciaExterna_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox mskFecha;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtIntituciondondeserefiere;
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
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label4;
    }
}