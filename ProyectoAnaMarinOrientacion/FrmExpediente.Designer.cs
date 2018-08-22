namespace ProyectoAnaMarinOrientacion
{
    partial class FrmExpediente
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
            this.btnGuardarExpediente = new System.Windows.Forms.Button();
            this.btnComprobante = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.pbQRCODE = new System.Windows.Forms.PictureBox();
            this.btnQRCode = new System.Windows.Forms.Button();
            this.txtNumeroExpediente = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtIdentificacionEstudiante = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.LblEstSeleccionado = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.dgvInstrumentos = new System.Windows.Forms.DataGridView();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.gpboxAgregarInstrumento = new System.Windows.Forms.GroupBox();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Acciones = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Motivo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.pbQRCODE)).BeginInit();
            this.groupBox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInstrumentos)).BeginInit();
            this.gpboxAgregarInstrumento.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnGuardarExpediente
            // 
            this.btnGuardarExpediente.BackColor = System.Drawing.Color.YellowGreen;
            this.btnGuardarExpediente.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardarExpediente.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGuardarExpediente.ImageIndex = 0;
            this.btnGuardarExpediente.Location = new System.Drawing.Point(645, 540);
            this.btnGuardarExpediente.Name = "btnGuardarExpediente";
            this.btnGuardarExpediente.Size = new System.Drawing.Size(134, 58);
            this.btnGuardarExpediente.TabIndex = 0;
            this.btnGuardarExpediente.Text = "Guardar Expediente";
            this.btnGuardarExpediente.UseVisualStyleBackColor = false;
            this.btnGuardarExpediente.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnComprobante
            // 
            this.btnComprobante.BackColor = System.Drawing.Color.YellowGreen;
            this.btnComprobante.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnComprobante.Location = new System.Drawing.Point(958, 139);
            this.btnComprobante.Name = "btnComprobante";
            this.btnComprobante.Size = new System.Drawing.Size(181, 36);
            this.btnComprobante.TabIndex = 21;
            this.btnComprobante.Text = "Crear comprobante de asistencia";
            this.btnComprobante.UseVisualStyleBackColor = false;
            this.btnComprobante.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.Red;
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.Location = new System.Drawing.Point(799, 540);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(108, 58);
            this.button6.TabIndex = 25;
            this.button6.Text = "Cancelar";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // pbQRCODE
            // 
            this.pbQRCODE.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pbQRCODE.Location = new System.Drawing.Point(712, 12);
            this.pbQRCODE.Name = "pbQRCODE";
            this.pbQRCODE.Size = new System.Drawing.Size(211, 163);
            this.pbQRCODE.TabIndex = 26;
            this.pbQRCODE.TabStop = false;
            this.pbQRCODE.Click += new System.EventHandler(this.pbQRCODE_Click);
            // 
            // btnQRCode
            // 
            this.btnQRCode.BackColor = System.Drawing.Color.YellowGreen;
            this.btnQRCode.Location = new System.Drawing.Point(823, 204);
            this.btnQRCode.Name = "btnQRCode";
            this.btnQRCode.Size = new System.Drawing.Size(100, 37);
            this.btnQRCode.TabIndex = 27;
            this.btnQRCode.Text = "Generar QRCode";
            this.btnQRCode.UseVisualStyleBackColor = false;
            this.btnQRCode.Click += new System.EventHandler(this.btnQRCode_Click);
            // 
            // txtNumeroExpediente
            // 
            this.txtNumeroExpediente.Location = new System.Drawing.Point(717, 213);
            this.txtNumeroExpediente.Name = "txtNumeroExpediente";
            this.txtNumeroExpediente.Size = new System.Drawing.Size(100, 20);
            this.txtNumeroExpediente.TabIndex = 28;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(715, 183);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(114, 13);
            this.label9.TabIndex = 29;
            this.label9.Text = "Numero de expediente";
            // 
            // txtIdentificacionEstudiante
            // 
            this.txtIdentificacionEstudiante.Location = new System.Drawing.Point(179, 50);
            this.txtIdentificacionEstudiante.Name = "txtIdentificacionEstudiante";
            this.txtIdentificacionEstudiante.Size = new System.Drawing.Size(100, 20);
            this.txtIdentificacionEstudiante.TabIndex = 34;
            this.txtIdentificacionEstudiante.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtIdentificacionEstudiante_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 13);
            this.label1.TabIndex = 35;
            this.label1.Text = "Identificacion de Estudiante";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.YellowGreen;
            this.button2.Location = new System.Drawing.Point(285, 48);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 36;
            this.button2.Text = "Buscar";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 13);
            this.label2.TabIndex = 37;
            this.label2.Text = "Estudiante Seleccionado:";
            // 
            // LblEstSeleccionado
            // 
            this.LblEstSeleccionado.AutoSize = true;
            this.LblEstSeleccionado.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblEstSeleccionado.Location = new System.Drawing.Point(169, 83);
            this.LblEstSeleccionado.Name = "LblEstSeleccionado";
            this.LblEstSeleccionado.Size = new System.Drawing.Size(0, 26);
            this.LblEstSeleccionado.TabIndex = 38;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.LightSkyBlue;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(10, 47);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(94, 72);
            this.button4.TabIndex = 40;
            this.button4.Text = "Entrevista con funcionario";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click_1);
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.SkyBlue;
            this.button7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.Location = new System.Drawing.Point(110, 47);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(94, 72);
            this.button7.TabIndex = 41;
            this.button7.Text = "Entrevista con encargado";
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.Color.PowderBlue;
            this.button8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button8.Location = new System.Drawing.Point(210, 47);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(94, 72);
            this.button8.TabIndex = 42;
            this.button8.Text = "Entrevista con Estudiante";
            this.button8.UseVisualStyleBackColor = false;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button9
            // 
            this.button9.BackColor = System.Drawing.Color.DarkTurquoise;
            this.button9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button9.Location = new System.Drawing.Point(310, 47);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(94, 72);
            this.button9.TabIndex = 43;
            this.button9.Text = "Informe de Visita al Hogar";
            this.button9.UseVisualStyleBackColor = false;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(10, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(156, 20);
            this.label3.TabIndex = 44;
            this.label3.Text = "Agregar Instrumento";
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.LightCyan;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(410, 47);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(94, 72);
            this.button3.TabIndex = 52;
            this.button3.Text = "Referencia Externa";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.dgvInstrumentos);
            this.groupBox6.Location = new System.Drawing.Point(34, 307);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(570, 329);
            this.groupBox6.TabIndex = 50;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "TipoInstrumentos";
            // 
            // dgvInstrumentos
            // 
            this.dgvInstrumentos.AllowUserToAddRows = false;
            this.dgvInstrumentos.AllowUserToDeleteRows = false;
            this.dgvInstrumentos.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvInstrumentos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInstrumentos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.dataGridViewTextBoxColumn8,
            this.Nombre,
            this.Acciones,
            this.Motivo});
            this.dgvInstrumentos.Location = new System.Drawing.Point(12, 29);
            this.dgvInstrumentos.Name = "dgvInstrumentos";
            this.dgvInstrumentos.ReadOnly = true;
            this.dgvInstrumentos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvInstrumentos.Size = new System.Drawing.Size(494, 262);
            this.dgvInstrumentos.TabIndex = 32;
            this.dgvInstrumentos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvInstrumentos_CellContentClick_1);
            this.dgvInstrumentos.DoubleClick += new System.EventHandler(this.dgvInstrumentos_DoubleClick);
            // 
            // gpboxAgregarInstrumento
            // 
            this.gpboxAgregarInstrumento.Controls.Add(this.button7);
            this.gpboxAgregarInstrumento.Controls.Add(this.button3);
            this.gpboxAgregarInstrumento.Controls.Add(this.button4);
            this.gpboxAgregarInstrumento.Controls.Add(this.label3);
            this.gpboxAgregarInstrumento.Controls.Add(this.button8);
            this.gpboxAgregarInstrumento.Controls.Add(this.button9);
            this.gpboxAgregarInstrumento.Location = new System.Drawing.Point(34, 139);
            this.gpboxAgregarInstrumento.Name = "gpboxAgregarInstrumento";
            this.gpboxAgregarInstrumento.Size = new System.Drawing.Size(528, 147);
            this.gpboxAgregarInstrumento.TabIndex = 53;
            this.gpboxAgregarInstrumento.TabStop = false;
            this.gpboxAgregarInstrumento.Text = "groupBox1";
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "Situacion";
            this.dataGridViewTextBoxColumn8.HeaderText = "Situacion";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            // 
            // Nombre
            // 
            this.Nombre.DataPropertyName = "TipoInstrumento";
            this.Nombre.HeaderText = "Tipo";
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            // 
            // Acciones
            // 
            this.Acciones.DataPropertyName = "Acciones";
            this.Acciones.HeaderText = "Acciones";
            this.Acciones.Name = "Acciones";
            this.Acciones.ReadOnly = true;
            this.Acciones.Width = 150;
            // 
            // Motivo
            // 
            this.Motivo.DataPropertyName = "Motivo";
            this.Motivo.HeaderText = "Motivo";
            this.Motivo.Name = "Motivo";
            this.Motivo.ReadOnly = true;
            // 
            // FrmExpediente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(1187, 648);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.LblEstSeleccionado);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtIdentificacionEstudiante);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtNumeroExpediente);
            this.Controls.Add(this.btnQRCode);
            this.Controls.Add(this.pbQRCODE);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.btnComprobante);
            this.Controls.Add(this.btnGuardarExpediente);
            this.Controls.Add(this.gpboxAgregarInstrumento);
            this.Name = "FrmExpediente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Expediente de Estudiantes";
            this.Activated += new System.EventHandler(this.FrmExpediente_Activated);
            this.Load += new System.EventHandler(this.FrmExpediente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbQRCODE)).EndInit();
            this.groupBox6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvInstrumentos)).EndInit();
            this.gpboxAgregarInstrumento.ResumeLayout(false);
            this.gpboxAgregarInstrumento.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGuardarExpediente;
        private System.Windows.Forms.Button btnComprobante;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.PictureBox pbQRCODE;
        private System.Windows.Forms.Button btnQRCode;
        private System.Windows.Forms.TextBox txtNumeroExpediente;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtIdentificacionEstudiante;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label LblEstSeleccionado;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.DataGridView dgvInstrumentos;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.GroupBox gpboxAgregarInstrumento;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Acciones;
        private System.Windows.Forms.DataGridViewTextBoxColumn Motivo;
    }
}