namespace ProyectoAnaMarinOrientacion.Instrumentos
{
    partial class FrmEntrevistaConFuncionarioCentroEducativo
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
            this.txtNombreFuncionario = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPuesto = new System.Windows.Forms.TextBox();
            this.txtResumen = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtAcuerdos = new System.Windows.Forms.TextBox();
            this.txtRecomendaciones = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.BtnCancelar = new System.Windows.Forms.Button();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.cboMotivo = new System.Windows.Forms.ComboBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtNombreFuncionario
            // 
            this.txtNombreFuncionario.Location = new System.Drawing.Point(246, 66);
            this.txtNombreFuncionario.Name = "txtNombreFuncionario";
            this.txtNombreFuncionario.Size = new System.Drawing.Size(216, 20);
            this.txtNombreFuncionario.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(83, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 13);
            this.label2.TabIndex = 17;
            this.label2.Text = "Nombre del funcionario(a)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(83, 111);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 21;
            this.label4.Text = "Puesto";
            // 
            // txtPuesto
            // 
            this.txtPuesto.Location = new System.Drawing.Point(246, 108);
            this.txtPuesto.Name = "txtPuesto";
            this.txtPuesto.Size = new System.Drawing.Size(216, 20);
            this.txtPuesto.TabIndex = 2;
            // 
            // txtResumen
            // 
            this.txtResumen.Location = new System.Drawing.Point(246, 199);
            this.txtResumen.Multiline = true;
            this.txtResumen.Name = "txtResumen";
            this.txtResumen.Size = new System.Drawing.Size(487, 20);
            this.txtResumen.TabIndex = 5;
            this.txtResumen.TextChanged += new System.EventHandler(this.txtResumen_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(83, 202);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(123, 13);
            this.label5.TabIndex = 25;
            this.label5.Text = "Resumen de la situacion";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(83, 157);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(114, 13);
            this.label6.TabIndex = 23;
            this.label6.Text = "Motivo de la entrevista";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(83, 246);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(140, 13);
            this.label7.TabIndex = 27;
            this.label7.Text = "Acuerdos/acciones a seguir";
            // 
            // txtAcuerdos
            // 
            this.txtAcuerdos.Location = new System.Drawing.Point(246, 239);
            this.txtAcuerdos.Multiline = true;
            this.txtAcuerdos.Name = "txtAcuerdos";
            this.txtAcuerdos.Size = new System.Drawing.Size(487, 20);
            this.txtAcuerdos.TabIndex = 6;
            // 
            // txtRecomendaciones
            // 
            this.txtRecomendaciones.Location = new System.Drawing.Point(246, 281);
            this.txtRecomendaciones.Multiline = true;
            this.txtRecomendaciones.Name = "txtRecomendaciones";
            this.txtRecomendaciones.Size = new System.Drawing.Size(487, 20);
            this.txtRecomendaciones.TabIndex = 7;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(83, 284);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(96, 13);
            this.label8.TabIndex = 29;
            this.label8.Text = "Recomendaciones";
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.BackColor = System.Drawing.Color.Red;
            this.BtnCancelar.Location = new System.Drawing.Point(483, 358);
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
            this.btnAceptar.Location = new System.Drawing.Point(360, 358);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(108, 39);
            this.btnAceptar.TabIndex = 8;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = false;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // cboMotivo
            // 
            this.cboMotivo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboMotivo.FormattingEnabled = true;
            this.cboMotivo.Location = new System.Drawing.Point(246, 149);
            this.cboMotivo.Name = "cboMotivo";
            this.cboMotivo.Size = new System.Drawing.Size(216, 21);
            this.cboMotivo.TabIndex = 4;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(483, 47);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(120, 95);
            this.listBox1.TabIndex = 31;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            this.listBox1.DoubleClick += new System.EventHandler(this.listBox1_DoubleClick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(629, 87);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(118, 23);
            this.button1.TabIndex = 30;
            this.button1.Text = "Agregar Archivo";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FrmEntrevistaConFuncionarioCentroEducativo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(834, 511);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cboMotivo);
            this.Controls.Add(this.BtnCancelar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.txtRecomendaciones);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtAcuerdos);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtResumen);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtPuesto);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtNombreFuncionario);
            this.Controls.Add(this.label2);
            this.Name = "FrmEntrevistaConFuncionarioCentroEducativo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Entrevista Con Funcionario(a) del Centro Educativo";
            this.Load += new System.EventHandler(this.FrmEntrevistaConFuncionarioCentroEducativo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtNombreFuncionario;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPuesto;
        private System.Windows.Forms.TextBox txtResumen;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtAcuerdos;
        private System.Windows.Forms.TextBox txtRecomendaciones;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button BtnCancelar;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.ComboBox cboMotivo;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button button1;
    }
}