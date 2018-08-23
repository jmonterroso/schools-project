namespace ProyectoAnaMarinOrientacion.Instrumentos
{
    partial class FrmEntrevistaPadre_Madre_Encargado
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ckConvocadoPorEncargado = new System.Windows.Forms.CheckBox();
            this.ckConvocadoPorInstitucion = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtResumen = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtRecomendaciones = new System.Windows.Forms.TextBox();
            this.BtnCancelar = new System.Windows.Forms.Button();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.cboMotivos = new System.Windows.Forms.ComboBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.MenuBar;
            this.groupBox1.Controls.Add(this.ckConvocadoPorEncargado);
            this.groupBox1.Controls.Add(this.ckConvocadoPorInstitucion);
            this.groupBox1.Location = new System.Drawing.Point(584, 114);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(201, 192);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Fue convocado(a)  por: ";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // ckConvocadoPorEncargado
            // 
            this.ckConvocadoPorEncargado.AutoSize = true;
            this.ckConvocadoPorEncargado.Location = new System.Drawing.Point(24, 42);
            this.ckConvocadoPorEncargado.Name = "ckConvocadoPorEncargado";
            this.ckConvocadoPorEncargado.Size = new System.Drawing.Size(140, 17);
            this.ckConvocadoPorEncargado.TabIndex = 5;
            this.ckConvocadoPorEncargado.Text = "Iniciativo del Encargado";
            this.ckConvocadoPorEncargado.UseVisualStyleBackColor = true;
            // 
            // ckConvocadoPorInstitucion
            // 
            this.ckConvocadoPorInstitucion.AutoSize = true;
            this.ckConvocadoPorInstitucion.Location = new System.Drawing.Point(24, 19);
            this.ckConvocadoPorInstitucion.Name = "ckConvocadoPorInstitucion";
            this.ckConvocadoPorInstitucion.Size = new System.Drawing.Size(168, 17);
            this.ckConvocadoPorInstitucion.TabIndex = 4;
            this.ckConvocadoPorInstitucion.Text = "Fue convocado o Convocada";
            this.ckConvocadoPorInstitucion.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.MenuBar;
            this.label4.Location = new System.Drawing.Point(62, 133);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 13);
            this.label4.TabIndex = 17;
            this.label4.Text = "Motivo de la entrevista";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.MenuBar;
            this.label5.Location = new System.Drawing.Point(60, 192);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(123, 13);
            this.label5.TabIndex = 19;
            this.label5.Text = "Resumen de la situacion";
            // 
            // txtResumen
            // 
            this.txtResumen.BackColor = System.Drawing.SystemColors.MenuBar;
            this.txtResumen.Location = new System.Drawing.Point(195, 185);
            this.txtResumen.Multiline = true;
            this.txtResumen.Name = "txtResumen";
            this.txtResumen.Size = new System.Drawing.Size(314, 20);
            this.txtResumen.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.MenuBar;
            this.label6.Location = new System.Drawing.Point(62, 245);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(96, 13);
            this.label6.TabIndex = 21;
            this.label6.Text = "Recomendaciones";
            // 
            // txtRecomendaciones
            // 
            this.txtRecomendaciones.BackColor = System.Drawing.SystemColors.MenuBar;
            this.txtRecomendaciones.Location = new System.Drawing.Point(195, 238);
            this.txtRecomendaciones.Multiline = true;
            this.txtRecomendaciones.Name = "txtRecomendaciones";
            this.txtRecomendaciones.Size = new System.Drawing.Size(314, 20);
            this.txtRecomendaciones.TabIndex = 3;
            this.txtRecomendaciones.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.BackColor = System.Drawing.Color.Red;
            this.BtnCancelar.Location = new System.Drawing.Point(382, 332);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(108, 39);
            this.BtnCancelar.TabIndex = 26;
            this.BtnCancelar.Text = "Cancelar";
            this.BtnCancelar.UseVisualStyleBackColor = false;
            // 
            // btnAceptar
            // 
            this.btnAceptar.BackColor = System.Drawing.Color.YellowGreen;
            this.btnAceptar.Location = new System.Drawing.Point(229, 332);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(108, 39);
            this.btnAceptar.TabIndex = 25;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = false;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // cboMotivos
            // 
            this.cboMotivos.BackColor = System.Drawing.SystemColors.MenuBar;
            this.cboMotivos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboMotivos.FormattingEnabled = true;
            this.cboMotivos.Location = new System.Drawing.Point(195, 133);
            this.cboMotivos.Name = "cboMotivos";
            this.cboMotivos.Size = new System.Drawing.Size(169, 21);
            this.cboMotivos.TabIndex = 1;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(65, 12);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(120, 95);
            this.listBox1.TabIndex = 33;
            this.listBox1.DoubleClick += new System.EventHandler(this.listBox1_DoubleClick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(211, 52);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(118, 23);
            this.button1.TabIndex = 32;
            this.button1.Text = "Agregar Archivo";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FrmEntrevistaPadre_Madre_Encargado
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
            this.Controls.Add(this.txtRecomendaciones);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtResumen);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmEntrevistaPadre_Madre_Encargado";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.FrmEntrevistaPadre_Madre_Encargado_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox ckConvocadoPorEncargado;
        private System.Windows.Forms.CheckBox ckConvocadoPorInstitucion;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtResumen;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtRecomendaciones;
        private System.Windows.Forms.Button BtnCancelar;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.ComboBox cboMotivos;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button button1;
    }
}