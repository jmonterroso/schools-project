﻿namespace ProyectoAnaMarinOrientacion.Instrumentos
{
    partial class FrmInformeVisitaAlHogar
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
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtProfesionalQRealizaLaVisita = new System.Windows.Forms.TextBox();
            this.txtCargo = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtSitucionObservada = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.txtRecomendaciones = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtAccionesSeguimiento = new System.Windows.Forms.TextBox();
            this.BtnCancelar = new System.Windows.Forms.Button();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.cboMotivos = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(18, 25);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(151, 13);
            this.label7.TabIndex = 31;
            this.label7.Text = "Profesional que realiza la visita";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(467, 24);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(35, 13);
            this.label8.TabIndex = 32;
            this.label8.Text = "Cargo";
            // 
            // txtProfesionalQRealizaLaVisita
            // 
            this.txtProfesionalQRealizaLaVisita.Location = new System.Drawing.Point(175, 23);
            this.txtProfesionalQRealizaLaVisita.Name = "txtProfesionalQRealizaLaVisita";
            this.txtProfesionalQRealizaLaVisita.Size = new System.Drawing.Size(237, 20);
            this.txtProfesionalQRealizaLaVisita.TabIndex = 1;
            // 
            // txtCargo
            // 
            this.txtCargo.Location = new System.Drawing.Point(508, 22);
            this.txtCargo.Name = "txtCargo";
            this.txtCargo.Size = new System.Drawing.Size(162, 20);
            this.txtCargo.TabIndex = 2;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(18, 58);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(92, 13);
            this.label9.TabIndex = 35;
            this.label9.Text = "Motivo de la visita";
            // 
            // txtSitucionObservada
            // 
            this.txtSitucionObservada.Location = new System.Drawing.Point(175, 90);
            this.txtSitucionObservada.Multiline = true;
            this.txtSitucionObservada.Name = "txtSitucionObservada";
            this.txtSitucionObservada.Size = new System.Drawing.Size(495, 20);
            this.txtSitucionObservada.TabIndex = 4;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(15, 93);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(120, 13);
            this.label21.TabIndex = 37;
            this.label21.Text = "Situaciones observadas\r\n";
            // 
            // txtRecomendaciones
            // 
            this.txtRecomendaciones.Location = new System.Drawing.Point(175, 127);
            this.txtRecomendaciones.Multiline = true;
            this.txtRecomendaciones.Name = "txtRecomendaciones";
            this.txtRecomendaciones.Size = new System.Drawing.Size(495, 20);
            this.txtRecomendaciones.TabIndex = 5;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(18, 134);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(96, 13);
            this.label10.TabIndex = 39;
            this.label10.Text = "Recomendaciones";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(18, 166);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(121, 13);
            this.label11.TabIndex = 41;
            this.label11.Text = "Acciones de siguimiento";
            // 
            // txtAccionesSeguimiento
            // 
            this.txtAccionesSeguimiento.Location = new System.Drawing.Point(175, 161);
            this.txtAccionesSeguimiento.Name = "txtAccionesSeguimiento";
            this.txtAccionesSeguimiento.Size = new System.Drawing.Size(495, 20);
            this.txtAccionesSeguimiento.TabIndex = 6;
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.Location = new System.Drawing.Point(331, 202);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(102, 23);
            this.BtnCancelar.TabIndex = 8;
            this.BtnCancelar.Text = "Cancelar";
            this.BtnCancelar.UseVisualStyleBackColor = true;
            this.BtnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(178, 202);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(102, 23);
            this.btnAceptar.TabIndex = 7;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // cboMotivos
            // 
            this.cboMotivos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboMotivos.FormattingEnabled = true;
            this.cboMotivos.Location = new System.Drawing.Point(175, 58);
            this.cboMotivos.Name = "cboMotivos";
            this.cboMotivos.Size = new System.Drawing.Size(237, 21);
            this.cboMotivos.TabIndex = 3;
            // 
            // FrmInformeVisitaAlHogar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(682, 275);
            this.Controls.Add(this.cboMotivos);
            this.Controls.Add(this.BtnCancelar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.txtAccionesSeguimiento);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtRecomendaciones);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtSitucionObservada);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtCargo);
            this.Controls.Add(this.txtProfesionalQRealizaLaVisita);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Name = "FrmInformeVisitaAlHogar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Informe de Visita Al Hogar";
            this.Load += new System.EventHandler(this.FrmInformeVisitaAlHogar_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtProfesionalQRealizaLaVisita;
        private System.Windows.Forms.TextBox txtCargo;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtSitucionObservada;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.TextBox txtRecomendaciones;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtAccionesSeguimiento;
        private System.Windows.Forms.Button BtnCancelar;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.ComboBox cboMotivos;
    }
}