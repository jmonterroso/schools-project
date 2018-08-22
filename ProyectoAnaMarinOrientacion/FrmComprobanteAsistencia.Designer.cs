namespace ProyectoAnaMarinOrientacion
{
    partial class FrmComprobanteAsistencia
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmComprobanteAsistencia));
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.txtNombreSenor = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.txtCedula = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNombredEstudiante = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.DVprintDocument1 = new System.Drawing.Printing.PrintDocument();
            this.DVprintPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.button2 = new System.Windows.Forms.Button();
            this.dash = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnSalir = new System.Windows.Forms.Button();
            this.txtMotivo = new System.Windows.Forms.TextBox();
            this.txtNivel = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "Imprimir.png");
            this.imageList1.Images.SetKeyName(1, "Salir.png");
            this.imageList1.Images.SetKeyName(2, "Icono_Control_de_Asistencia.jpg");
            this.imageList1.Images.SetKeyName(3, "imprimirrr.jpg");
            this.imageList1.Images.SetKeyName(4, "vista previa.jpg");
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(99, 186);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "El/La señor/a ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtNombreSenor
            // 
            this.txtNombreSenor.Location = new System.Drawing.Point(207, 179);
            this.txtNombreSenor.Name = "txtNombreSenor";
            this.txtNombreSenor.Size = new System.Drawing.Size(220, 20);
            this.txtNombreSenor.TabIndex = 1;
            this.txtNombreSenor.TextChanged += new System.EventHandler(this.txtNombreSenor_TextChanged);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(464, 186);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(40, 13);
            this.label15.TabIndex = 42;
            this.label15.Text = "Cedula";
            this.label15.Click += new System.EventHandler(this.label15_Click);
            // 
            // txtCedula
            // 
            this.txtCedula.Location = new System.Drawing.Point(523, 179);
            this.txtCedula.Name = "txtCedula";
            this.txtCedula.Size = new System.Drawing.Size(115, 20);
            this.txtCedula.TabIndex = 41;
            this.txtCedula.TextChanged += new System.EventHandler(this.txtCedula_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(99, 214);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 43;
            this.label2.Text = "se presento a";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtNombredEstudiante
            // 
            this.txtNombredEstudiante.Location = new System.Drawing.Point(207, 245);
            this.txtNombredEstudiante.Name = "txtNombredEstudiante";
            this.txtNombredEstudiante.Size = new System.Drawing.Size(220, 20);
            this.txtNombredEstudiante.TabIndex = 45;
            this.txtNombredEstudiante.TextChanged += new System.EventHandler(this.txtNombredEstudiante_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(99, 248);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 13);
            this.label3.TabIndex = 46;
            this.label3.Text = "del estudiante";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(464, 248);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 47;
            this.label4.Text = "Nivel";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(99, 284);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 13);
            this.label5.TabIndex = 49;
            this.label5.Text = "Fecha y hora";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Location = new System.Drawing.Point(208, 281);
            this.maskedTextBox1.Mask = "00/00/0000 90:00";
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(219, 20);
            this.maskedTextBox1.TabIndex = 50;
            this.maskedTextBox1.ValidatingType = typeof(System.DateTime);
            this.maskedTextBox1.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.maskedTextBox1_MaskInputRejected);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(210, 90);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(199, 16);
            this.label8.TabIndex = 55;
            this.label8.Text = "Comprobante de Asistencia";
            // 
            // DVprintDocument1
            // 
            this.DVprintDocument1.DocumentName = "comprobante";
            this.DVprintDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // DVprintPreviewDialog1
            // 
            this.DVprintPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.DVprintPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.DVprintPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.DVprintPreviewDialog1.Document = this.DVprintDocument1;
            this.DVprintPreviewDialog1.Enabled = true;
            this.DVprintPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("DVprintPreviewDialog1.Icon")));
            this.DVprintPreviewDialog1.Name = "DVprintPreviewDialog1";
            this.DVprintPreviewDialog1.Visible = false;
            this.DVprintPreviewDialog1.Load += new System.EventHandler(this.DVprintPreviewDialog1_Load);
            this.DVprintPreviewDialog1.Click += new System.EventHandler(this.DVprintPreviewDialog1_Click);
            // 
            // button2
            // 
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.ImageIndex = 4;
            this.button2.ImageList = this.imageList1;
            this.button2.Location = new System.Drawing.Point(223, 389);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(110, 23);
            this.button2.TabIndex = 60;
            this.button2.Text = "Vista previa";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // dash
            // 
            this.dash.AutoSize = true;
            this.dash.Location = new System.Drawing.Point(224, 501);
            this.dash.Name = "dash";
            this.dash.Size = new System.Drawing.Size(349, 13);
            this.dash.TabIndex = 62;
            this.dash.Text = "---------------------------------------------------------------------------------" +
    "---------------------------------";
            // 
            // button1
            // 
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.ImageIndex = 3;
            this.button1.ImageList = this.imageList1;
            this.button1.Location = new System.Drawing.Point(339, 389);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(109, 23);
            this.button1.TabIndex = 59;
            this.button1.Text = "Imprimir";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox1.Image = global::ProyectoAnaMarinOrientacion.Properties.Resources._306218;
            this.pictureBox1.Location = new System.Drawing.Point(65, 24);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(139, 132);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 58;
            this.pictureBox1.TabStop = false;
            // 
            // btnSalir
            // 
            this.btnSalir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSalir.ImageIndex = 1;
            this.btnSalir.ImageList = this.imageList1;
            this.btnSalir.Location = new System.Drawing.Point(454, 389);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(103, 23);
            this.btnSalir.TabIndex = 57;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // txtMotivo
            // 
            this.txtMotivo.Location = new System.Drawing.Point(208, 214);
            this.txtMotivo.Name = "txtMotivo";
            this.txtMotivo.Size = new System.Drawing.Size(219, 20);
            this.txtMotivo.TabIndex = 64;
            // 
            // txtNivel
            // 
            this.txtNivel.Location = new System.Drawing.Point(523, 245);
            this.txtNivel.Name = "txtNivel";
            this.txtNivel.Size = new System.Drawing.Size(115, 20);
            this.txtNivel.TabIndex = 65;
            // 
            // FrmComprobanteAsistencia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(834, 511);
            this.Controls.Add(this.txtNivel);
            this.Controls.Add(this.txtMotivo);
            this.Controls.Add(this.dash);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.maskedTextBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtNombredEstudiante);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.txtCedula);
            this.Controls.Add(this.txtNombreSenor);
            this.Controls.Add(this.label1);
            this.Name = "FrmComprobanteAsistencia";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "c";
            this.Load += new System.EventHandler(this.FrmComprobanteAsistencia_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNombreSenor;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtCedula;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNombredEstudiante;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
        private System.Drawing.Printing.PrintDocument DVprintDocument1;
        private System.Windows.Forms.PrintPreviewDialog DVprintPreviewDialog1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label dash;
        private System.Windows.Forms.TextBox txtMotivo;
        private System.Windows.Forms.TextBox txtNivel;
    }
}