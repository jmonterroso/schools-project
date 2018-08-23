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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(76, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Institucion donde se refiere";
            // 
            // txtIntituciondondeserefiere
            // 
            this.txtIntituciondondeserefiere.Location = new System.Drawing.Point(258, 38);
            this.txtIntituciondondeserefiere.Name = "txtIntituciondondeserefiere";
            this.txtIntituciondondeserefiere.Size = new System.Drawing.Size(225, 20);
            this.txtIntituciondondeserefiere.TabIndex = 1;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(76, 80);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(99, 13);
            this.label17.TabIndex = 18;
            this.label17.Text = "Persona que refiere";
            // 
            // txtPersonaRefiere
            // 
            this.txtPersonaRefiere.Location = new System.Drawing.Point(258, 77);
            this.txtPersonaRefiere.Name = "txtPersonaRefiere";
            this.txtPersonaRefiere.Size = new System.Drawing.Size(225, 20);
            this.txtPersonaRefiere.TabIndex = 2;
            this.txtPersonaRefiere.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // txtPuesto
            // 
            this.txtPuesto.Location = new System.Drawing.Point(563, 77);
            this.txtPuesto.Name = "txtPuesto";
            this.txtPuesto.Size = new System.Drawing.Size(191, 20);
            this.txtPuesto.TabIndex = 3;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(517, 80);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(40, 13);
            this.label18.TabIndex = 23;
            this.label18.Text = "Puesto";
            // 
            // txtRecomendaciones
            // 
            this.txtRecomendaciones.Location = new System.Drawing.Point(260, 285);
            this.txtRecomendaciones.Multiline = true;
            this.txtRecomendaciones.Name = "txtRecomendaciones";
            this.txtRecomendaciones.Size = new System.Drawing.Size(494, 20);
            this.txtRecomendaciones.TabIndex = 7;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(76, 288);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(178, 13);
            this.label19.TabIndex = 37;
            this.label19.Text = "Observaciones y Recomendaciones";
            // 
            // txtAcuerdos
            // 
            this.txtAcuerdos.Location = new System.Drawing.Point(258, 238);
            this.txtAcuerdos.Multiline = true;
            this.txtAcuerdos.Name = "txtAcuerdos";
            this.txtAcuerdos.Size = new System.Drawing.Size(496, 20);
            this.txtAcuerdos.TabIndex = 6;
            this.txtAcuerdos.TextChanged += new System.EventHandler(this.txtAcuerdos_TextChanged);
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(76, 238);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(180, 13);
            this.label20.TabIndex = 35;
            this.label20.Text = "Acuerdos que ha realizado el centro ";
            // 
            // txtSitucionObservada
            // 
            this.txtSitucionObservada.Location = new System.Drawing.Point(258, 183);
            this.txtSitucionObservada.Multiline = true;
            this.txtSitucionObservada.Name = "txtSitucionObservada";
            this.txtSitucionObservada.Size = new System.Drawing.Size(496, 20);
            this.txtSitucionObservada.TabIndex = 5;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(76, 190);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(107, 13);
            this.label21.TabIndex = 33;
            this.label21.Text = "Situacion presentada";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(76, 141);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(104, 13);
            this.label22.TabIndex = 31;
            this.label22.Text = "Motivo de referencia\r\n";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(76, 251);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(176, 13);
            this.label23.TabIndex = 39;
            this.label23.Text = "educativo para apoyar al estudiante";
            this.label23.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label23.Click += new System.EventHandler(this.label23_Click);
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.BackColor = System.Drawing.Color.Red;
            this.BtnCancelar.Location = new System.Drawing.Point(535, 363);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(108, 39);
            this.BtnCancelar.TabIndex = 9;
            this.BtnCancelar.Text = "Cancelar";
            this.BtnCancelar.UseVisualStyleBackColor = false;
            this.BtnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
            // 
            // btnAceptar
            // 
            this.btnAceptar.BackColor = System.Drawing.Color.YellowGreen;
            this.btnAceptar.Location = new System.Drawing.Point(384, 363);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(108, 39);
            this.btnAceptar.TabIndex = 8;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = false;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // cboMotivos
            // 
            this.cboMotivos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboMotivos.FormattingEnabled = true;
            this.cboMotivos.Location = new System.Drawing.Point(258, 133);
            this.cboMotivos.Name = "cboMotivos";
            this.cboMotivos.Size = new System.Drawing.Size(225, 21);
            this.cboMotivos.TabIndex = 4;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(90, 335);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(120, 95);
            this.listBox1.TabIndex = 45;
            this.listBox1.DoubleClick += new System.EventHandler(this.listBox1_DoubleClick_1);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(236, 375);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(118, 23);
            this.button1.TabIndex = 44;
            this.button1.Text = "Agregar Archivo";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // FrmReferenciaExterna
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(834, 511);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.button1);
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
            this.Name = "FrmReferenciaExterna";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Recibido por";
            this.Load += new System.EventHandler(this.FrmReferenciaExterna_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
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
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button button1;
    }
}