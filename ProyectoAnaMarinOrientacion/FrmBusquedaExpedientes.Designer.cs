namespace ProyectoAnaMarinOrientacion
{
    partial class FrmBusquedaExpedientes
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
            this.txtIdentificacion = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.rdEstudiante = new System.Windows.Forms.RadioButton();
            this.rdEncargado = new System.Windows.Forms.RadioButton();
            this.dgvExpedientes = new System.Windows.Forms.DataGridView();
            this.btnBuscarEncargado = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.rdNumeroExpediente = new System.Windows.Forms.RadioButton();
            this.IdExpediente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estudiante = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvExpedientes)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(144, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Busqueda de expedientes";
            // 
            // txtIdentificacion
            // 
            this.txtIdentificacion.Location = new System.Drawing.Point(147, 140);
            this.txtIdentificacion.Name = "txtIdentificacion";
            this.txtIdentificacion.Size = new System.Drawing.Size(246, 20);
            this.txtIdentificacion.TabIndex = 1;
            this.txtIdentificacion.Visible = false;
            this.txtIdentificacion.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtIdentificacion_KeyDown);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ProyectoAnaMarinOrientacion.Properties.Resources.lupa_e_tablet_318_39283;
            this.pictureBox1.Location = new System.Drawing.Point(26, 30);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 69);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(230, 180);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 11;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // rdEstudiante
            // 
            this.rdEstudiante.AutoSize = true;
            this.rdEstudiante.Checked = true;
            this.rdEstudiante.Location = new System.Drawing.Point(147, 82);
            this.rdEstudiante.Name = "rdEstudiante";
            this.rdEstudiante.Size = new System.Drawing.Size(94, 17);
            this.rdEstudiante.TabIndex = 13;
            this.rdEstudiante.TabStop = true;
            this.rdEstudiante.Text = "Por Estudiante";
            this.rdEstudiante.UseVisualStyleBackColor = true;
            // 
            // rdEncargado
            // 
            this.rdEncargado.AutoSize = true;
            this.rdEncargado.Location = new System.Drawing.Point(247, 82);
            this.rdEncargado.Name = "rdEncargado";
            this.rdEncargado.Size = new System.Drawing.Size(95, 17);
            this.rdEncargado.TabIndex = 14;
            this.rdEncargado.Text = "Por encargado";
            this.rdEncargado.UseVisualStyleBackColor = true;
            this.rdEncargado.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // dgvExpedientes
            // 
            this.dgvExpedientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvExpedientes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdExpediente,
            this.Estudiante});
            this.dgvExpedientes.Location = new System.Drawing.Point(61, 238);
            this.dgvExpedientes.Name = "dgvExpedientes";
            this.dgvExpedientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvExpedientes.Size = new System.Drawing.Size(644, 261);
            this.dgvExpedientes.TabIndex = 16;
            this.dgvExpedientes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvExpedientes_CellContentClick);
            this.dgvExpedientes.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvExpedientes_CellContentDoubleClick);
            // 
            // btnBuscarEncargado
            // 
            this.btnBuscarEncargado.Location = new System.Drawing.Point(149, 180);
            this.btnBuscarEncargado.Name = "btnBuscarEncargado";
            this.btnBuscarEncargado.Size = new System.Drawing.Size(75, 23);
            this.btnBuscarEncargado.TabIndex = 17;
            this.btnBuscarEncargado.Text = "Buscar";
            this.btnBuscarEncargado.UseVisualStyleBackColor = true;
            this.btnBuscarEncargado.Click += new System.EventHandler(this.btnBuscarEncargado_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(144, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "Criterio";
            // 
            // rdNumeroExpediente
            // 
            this.rdNumeroExpediente.AutoSize = true;
            this.rdNumeroExpediente.Location = new System.Drawing.Point(348, 82);
            this.rdNumeroExpediente.Name = "rdNumeroExpediente";
            this.rdNumeroExpediente.Size = new System.Drawing.Size(132, 17);
            this.rdNumeroExpediente.TabIndex = 19;
            this.rdNumeroExpediente.Text = "Numero de expediente";
            this.rdNumeroExpediente.UseVisualStyleBackColor = true;
            // 
            // IdExpediente
            // 
            this.IdExpediente.DataPropertyName = "Id";
            this.IdExpediente.HeaderText = "Numero de Expediente";
            this.IdExpediente.Name = "IdExpediente";
            // 
            // Estudiante
            // 
            this.Estudiante.DataPropertyName = "estudiante";
            this.Estudiante.HeaderText = "Estudiante";
            this.Estudiante.Name = "Estudiante";
            this.Estudiante.Width = 500;
            // 
            // FrmBusquedaExpedientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(834, 511);
            this.Controls.Add(this.rdNumeroExpediente);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnBuscarEncargado);
            this.Controls.Add(this.dgvExpedientes);
            this.Controls.Add(this.rdEncargado);
            this.Controls.Add(this.rdEstudiante);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtIdentificacion);
            this.Controls.Add(this.label1);
            this.Name = "FrmBusquedaExpedientes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Busqueda de Expedientes";
            this.Load += new System.EventHandler(this.FrmBusquedaExpedientes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvExpedientes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtIdentificacion;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.RadioButton rdEstudiante;
        private System.Windows.Forms.RadioButton rdEncargado;
        private System.Windows.Forms.DataGridView dgvExpedientes;
        private System.Windows.Forms.Button btnBuscarEncargado;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton rdNumeroExpediente;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdExpediente;
        private System.Windows.Forms.DataGridViewTextBoxColumn Estudiante;
    }
}