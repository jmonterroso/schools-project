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
            this.button1 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.pbQRCODE = new System.Windows.Forms.PictureBox();
            this.btnQRCode = new System.Windows.Forms.Button();
            this.txtNumeroExpediente = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.dgvInstrumentoFuncionario = new System.Windows.Forms.DataGridView();
            this.NombreFuncionario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Puesto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Resumen = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvEncargado = new System.Windows.Forms.DataGridView();
            this.ResumenSituacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Recomendacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dgvEstudiante = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.dgvVisitaAlHogar = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button3 = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.dgvReferenciaExterna = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.dgvInstrumentos = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Acciones = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.pbQRCODE)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInstrumentoFuncionario)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEncargado)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEstudiante)).BeginInit();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVisitaAlHogar)).BeginInit();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReferenciaExterna)).BeginInit();
            this.groupBox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInstrumentos)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.ImageIndex = 0;
            this.button1.Location = new System.Drawing.Point(728, 139);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(131, 36);
            this.button1.TabIndex = 0;
            this.button1.Text = "Crear Expediente";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Location = new System.Drawing.Point(958, 139);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(181, 36);
            this.button5.TabIndex = 21;
            this.button5.Text = "Crear comprobante de asistencia";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.Location = new System.Drawing.Point(877, 139);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 36);
            this.button6.TabIndex = 25;
            this.button6.Text = "Cancelar";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // pbQRCODE
            // 
            this.pbQRCODE.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pbQRCODE.Location = new System.Drawing.Point(462, 12);
            this.pbQRCODE.Name = "pbQRCODE";
            this.pbQRCODE.Size = new System.Drawing.Size(209, 139);
            this.pbQRCODE.TabIndex = 26;
            this.pbQRCODE.TabStop = false;
            // 
            // btnQRCode
            // 
            this.btnQRCode.Location = new System.Drawing.Point(785, 40);
            this.btnQRCode.Name = "btnQRCode";
            this.btnQRCode.Size = new System.Drawing.Size(100, 23);
            this.btnQRCode.TabIndex = 27;
            this.btnQRCode.Text = "Generar QRCode";
            this.btnQRCode.UseVisualStyleBackColor = true;
            this.btnQRCode.Click += new System.EventHandler(this.btnQRCode_Click);
            // 
            // txtNumeroExpediente
            // 
            this.txtNumeroExpediente.Location = new System.Drawing.Point(679, 42);
            this.txtNumeroExpediente.Name = "txtNumeroExpediente";
            this.txtNumeroExpediente.Size = new System.Drawing.Size(100, 20);
            this.txtNumeroExpediente.TabIndex = 28;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(677, 12);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(114, 13);
            this.label9.TabIndex = 29;
            this.label9.Text = "Numero de expediente";
            // 
            // dgvInstrumentoFuncionario
            // 
            this.dgvInstrumentoFuncionario.AllowUserToAddRows = false;
            this.dgvInstrumentoFuncionario.AllowUserToDeleteRows = false;
            this.dgvInstrumentoFuncionario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInstrumentoFuncionario.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NombreFuncionario,
            this.Puesto,
            this.Resumen});
            this.dgvInstrumentoFuncionario.Location = new System.Drawing.Point(12, 29);
            this.dgvInstrumentoFuncionario.Name = "dgvInstrumentoFuncionario";
            this.dgvInstrumentoFuncionario.ReadOnly = true;
            this.dgvInstrumentoFuncionario.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvInstrumentoFuncionario.Size = new System.Drawing.Size(383, 108);
            this.dgvInstrumentoFuncionario.TabIndex = 32;
            // 
            // NombreFuncionario
            // 
            this.NombreFuncionario.DataPropertyName = "NombreFuncionario";
            this.NombreFuncionario.HeaderText = "Nombre Funcionario";
            this.NombreFuncionario.Name = "NombreFuncionario";
            this.NombreFuncionario.ReadOnly = true;
            // 
            // Puesto
            // 
            this.Puesto.DataPropertyName = "Puesto";
            this.Puesto.HeaderText = "Puesto";
            this.Puesto.Name = "Puesto";
            this.Puesto.ReadOnly = true;
            // 
            // Resumen
            // 
            this.Resumen.DataPropertyName = "Resumen";
            this.Resumen.HeaderText = "Resumen";
            this.Resumen.Name = "Resumen";
            this.Resumen.ReadOnly = true;
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
            this.button2.Location = new System.Drawing.Point(285, 48);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 36;
            this.button2.Text = "Buscar";
            this.button2.UseVisualStyleBackColor = true;
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
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(34, 171);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(94, 72);
            this.button4.TabIndex = 40;
            this.button4.Text = "Entrevista con funcionario";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click_1);
            // 
            // button7
            // 
            this.button7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.Location = new System.Drawing.Point(151, 171);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(94, 72);
            this.button7.TabIndex = 41;
            this.button7.Text = "Entrevista con encargado";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button8
            // 
            this.button8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button8.Location = new System.Drawing.Point(262, 171);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(94, 72);
            this.button8.TabIndex = 42;
            this.button8.Text = "Entrevista con Estudiante";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button9
            // 
            this.button9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button9.Location = new System.Drawing.Point(362, 171);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(94, 72);
            this.button9.TabIndex = 43;
            this.button9.Text = "Informe de Visita al Hogar";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(38, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(156, 20);
            this.label3.TabIndex = 44;
            this.label3.Text = "Agregar Instrumento";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvInstrumentoFuncionario);
            this.groupBox1.Location = new System.Drawing.Point(38, 249);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(358, 164);
            this.groupBox1.TabIndex = 48;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Entrevista con funcionario";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvEncargado);
            this.groupBox2.Location = new System.Drawing.Point(421, 249);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(358, 164);
            this.groupBox2.TabIndex = 49;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Entrevista con Encargado";
            // 
            // dgvEncargado
            // 
            this.dgvEncargado.AllowUserToAddRows = false;
            this.dgvEncargado.AllowUserToDeleteRows = false;
            this.dgvEncargado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEncargado.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ResumenSituacion,
            this.Recomendacion});
            this.dgvEncargado.Location = new System.Drawing.Point(12, 29);
            this.dgvEncargado.Name = "dgvEncargado";
            this.dgvEncargado.ReadOnly = true;
            this.dgvEncargado.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvEncargado.Size = new System.Drawing.Size(340, 108);
            this.dgvEncargado.TabIndex = 32;
            // 
            // ResumenSituacion
            // 
            this.ResumenSituacion.DataPropertyName = "ResumenSituacion";
            this.ResumenSituacion.HeaderText = "Resumen Situacion";
            this.ResumenSituacion.Name = "ResumenSituacion";
            this.ResumenSituacion.ReadOnly = true;
            // 
            // Recomendacion
            // 
            this.Recomendacion.DataPropertyName = "Recomendaciones";
            this.Recomendacion.HeaderText = "Recomendaciones";
            this.Recomendacion.Name = "Recomendacion";
            this.Recomendacion.ReadOnly = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dgvEstudiante);
            this.groupBox3.Location = new System.Drawing.Point(38, 434);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(358, 164);
            this.groupBox3.TabIndex = 50;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Entrevista con Estudiante";
            // 
            // dgvEstudiante
            // 
            this.dgvEstudiante.AllowUserToAddRows = false;
            this.dgvEstudiante.AllowUserToDeleteRows = false;
            this.dgvEstudiante.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEstudiante.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.dgvEstudiante.Location = new System.Drawing.Point(0, 29);
            this.dgvEstudiante.Name = "dgvEstudiante";
            this.dgvEstudiante.ReadOnly = true;
            this.dgvEstudiante.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvEstudiante.Size = new System.Drawing.Size(340, 108);
            this.dgvEstudiante.TabIndex = 32;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "SituacionPresentada";
            this.dataGridViewTextBoxColumn1.HeaderText = "Resumen Situacion";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Recomendaciones";
            this.dataGridViewTextBoxColumn2.HeaderText = "Recomendaciones";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.dgvVisitaAlHogar);
            this.groupBox4.Location = new System.Drawing.Point(421, 434);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(358, 164);
            this.groupBox4.TabIndex = 51;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Informe de Visita Al Hogar";
            // 
            // dgvVisitaAlHogar
            // 
            this.dgvVisitaAlHogar.AllowUserToAddRows = false;
            this.dgvVisitaAlHogar.AllowUserToDeleteRows = false;
            this.dgvVisitaAlHogar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVisitaAlHogar.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.dgvVisitaAlHogar.Location = new System.Drawing.Point(12, 29);
            this.dgvVisitaAlHogar.Name = "dgvVisitaAlHogar";
            this.dgvVisitaAlHogar.ReadOnly = true;
            this.dgvVisitaAlHogar.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvVisitaAlHogar.Size = new System.Drawing.Size(340, 108);
            this.dgvVisitaAlHogar.TabIndex = 32;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "ProfesionaQueRealizaLaVisita";
            this.dataGridViewTextBoxColumn3.HeaderText = "Persona que realiza la visita";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Recomendaciones";
            this.dataGridViewTextBoxColumn4.HeaderText = "Recomendaciones";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(462, 171);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(94, 72);
            this.button3.TabIndex = 52;
            this.button3.Text = "Referencia Externa";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.dgvReferenciaExterna);
            this.groupBox5.Location = new System.Drawing.Point(804, 249);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(358, 164);
            this.groupBox5.TabIndex = 53;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Referencia Externa";
            // 
            // dgvReferenciaExterna
            // 
            this.dgvReferenciaExterna.AllowUserToAddRows = false;
            this.dgvReferenciaExterna.AllowUserToDeleteRows = false;
            this.dgvReferenciaExterna.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReferenciaExterna.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            this.dgvReferenciaExterna.Location = new System.Drawing.Point(12, 29);
            this.dgvReferenciaExterna.Name = "dgvReferenciaExterna";
            this.dgvReferenciaExterna.ReadOnly = true;
            this.dgvReferenciaExterna.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvReferenciaExterna.Size = new System.Drawing.Size(340, 108);
            this.dgvReferenciaExterna.TabIndex = 32;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "AccionesQueHaRealizadoElCentroEducativo";
            this.dataGridViewTextBoxColumn5.HeaderText = "Acciones que se han realizado";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "PersonaqueRefiere";
            this.dataGridViewTextBoxColumn6.HeaderText = "Persona que refiere";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.dgvInstrumentos);
            this.groupBox6.Location = new System.Drawing.Point(817, 434);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(358, 164);
            this.groupBox6.TabIndex = 50;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Instrumentos";
            // 
            // dgvInstrumentos
            // 
            this.dgvInstrumentos.AllowUserToAddRows = false;
            this.dgvInstrumentos.AllowUserToDeleteRows = false;
            this.dgvInstrumentos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInstrumentos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn8,
            this.Nombre,
            this.Acciones});
            this.dgvInstrumentos.Location = new System.Drawing.Point(12, 29);
            this.dgvInstrumentos.Name = "dgvInstrumentos";
            this.dgvInstrumentos.ReadOnly = true;
            this.dgvInstrumentos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvInstrumentos.Size = new System.Drawing.Size(340, 108);
            this.dgvInstrumentos.TabIndex = 32;
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
            this.Nombre.DataPropertyName = "Nombre";
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
            // 
            // FrmExpediente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(1187, 648);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button4);
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
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button1);
            this.Name = "FrmExpediente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "displ";
            this.Activated += new System.EventHandler(this.FrmExpediente_Activated);
            this.Load += new System.EventHandler(this.FrmExpediente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbQRCODE)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInstrumentoFuncionario)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEncargado)).EndInit();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEstudiante)).EndInit();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvVisitaAlHogar)).EndInit();
            this.groupBox5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvReferenciaExterna)).EndInit();
            this.groupBox6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvInstrumentos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.PictureBox pbQRCODE;
        private System.Windows.Forms.Button btnQRCode;
        private System.Windows.Forms.TextBox txtNumeroExpediente;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridView dgvInstrumentoFuncionario;
        private System.Windows.Forms.TextBox txtIdentificacionEstudiante;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label LblEstSeleccionado;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreFuncionario;
        private System.Windows.Forms.DataGridViewTextBoxColumn Puesto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Resumen;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgvEncargado;
        private System.Windows.Forms.DataGridViewTextBoxColumn ResumenSituacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Recomendacion;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dgvEstudiante;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DataGridView dgvVisitaAlHogar;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.DataGridView dgvReferenciaExterna;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.DataGridView dgvInstrumentos;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Acciones;
    }
}