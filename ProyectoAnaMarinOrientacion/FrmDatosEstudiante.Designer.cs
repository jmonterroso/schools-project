namespace ProyectoAnaMarinOrientacion
{
    partial class FrmDatosEstudiante
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDatosEstudiante));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtIdentificacion = new System.Windows.Forms.TextBox();
            this.txtNombreCompleto = new System.Windows.Forms.TextBox();
            this.cboSexo = new System.Windows.Forms.ComboBox();
            this.mskFechaNacimiento = new System.Windows.Forms.MaskedTextBox();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.label7 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.videoSourcePlayer1 = new AForge.Controls.VideoSourcePlayer();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.label8 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.btnSubirFot = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.cboSecciones = new System.Windows.Forms.ComboBox();
            this.cboNivel = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtIdentificadorEncargado = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.btnBuscarEncargado = new System.Windows.Forms.Button();
            this.txtEncargadoResultado = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.Name = "label5";
            // 
            // label6
            // 
            resources.ApplyResources(this.label6, "label6");
            this.label6.Name = "label6";
            // 
            // txtIdentificacion
            // 
            resources.ApplyResources(this.txtIdentificacion, "txtIdentificacion");
            this.txtIdentificacion.Name = "txtIdentificacion";
            // 
            // txtNombreCompleto
            // 
            resources.ApplyResources(this.txtNombreCompleto, "txtNombreCompleto");
            this.txtNombreCompleto.Name = "txtNombreCompleto";
            // 
            // cboSexo
            // 
            this.cboSexo.AutoCompleteCustomSource.AddRange(new string[] {
            resources.GetString("cboSexo.AutoCompleteCustomSource"),
            resources.GetString("cboSexo.AutoCompleteCustomSource1")});
            this.cboSexo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cboSexo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.cboSexo.FormattingEnabled = true;
            resources.ApplyResources(this.cboSexo, "cboSexo");
            this.cboSexo.Name = "cboSexo";
            // 
            // mskFechaNacimiento
            // 
            resources.ApplyResources(this.mskFechaNacimiento, "mskFechaNacimiento");
            this.mskFechaNacimiento.Name = "mskFechaNacimiento";
            this.mskFechaNacimiento.ValidatingType = typeof(System.DateTime);
            // 
            // txtDireccion
            // 
            resources.ApplyResources(this.txtDireccion, "txtDireccion");
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.TextChanged += new System.EventHandler(this.txtDireccion_TextChanged);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "aCEPTARC.png");
            this.imageList1.Images.SetKeyName(1, "cancel_icon.png");
            this.imageList1.Images.SetKeyName(2, "ACEP.jpg");
            this.imageList1.Images.SetKeyName(3, "cANCE.jpg");
            this.imageList1.Images.SetKeyName(4, "camara.png");
            // 
            // label7
            // 
            resources.ApplyResources(this.label7, "label7");
            this.label7.Name = "label7";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            resources.ApplyResources(this.comboBox1, "comboBox1");
            this.comboBox1.Name = "comboBox1";
            // 
            // button1
            // 
            resources.ApplyResources(this.button1, "button1");
            this.button1.Name = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // videoSourcePlayer1
            // 
            resources.ApplyResources(this.videoSourcePlayer1, "videoSourcePlayer1");
            this.videoSourcePlayer1.Name = "videoSourcePlayer1";
            this.videoSourcePlayer1.VideoSource = null;
            // 
            // button2
            // 
            resources.ApplyResources(this.button2, "button2");
            this.button2.Name = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            resources.ApplyResources(this.button3, "button3");
            this.button3.Name = "button3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // pictureBox4
            // 
            resources.ApplyResources(this.pictureBox4, "pictureBox4");
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.TabStop = false;
            // 
            // label8
            // 
            resources.ApplyResources(this.label8, "label8");
            this.label8.Name = "label8";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // btnSubirFot
            // 
            resources.ApplyResources(this.btnSubirFot, "btnSubirFot");
            this.btnSubirFot.Name = "btnSubirFot";
            this.btnSubirFot.UseVisualStyleBackColor = true;
            this.btnSubirFot.Click += new System.EventHandler(this.btnSubirFot_Click);
            // 
            // button4
            // 
            resources.ApplyResources(this.button4, "button4");
            this.button4.Name = "button4";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            resources.ApplyResources(this.button5, "button5");
            this.button5.Name = "button5";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // cboSecciones
            // 
            this.cboSecciones.FormattingEnabled = true;
            resources.ApplyResources(this.cboSecciones, "cboSecciones");
            this.cboSecciones.Name = "cboSecciones";
            // 
            // cboNivel
            // 
            this.cboNivel.AutoCompleteCustomSource.AddRange(new string[] {
            resources.GetString("cboNivel.AutoCompleteCustomSource"),
            resources.GetString("cboNivel.AutoCompleteCustomSource1")});
            this.cboNivel.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cboNivel.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.cboNivel.FormattingEnabled = true;
            resources.ApplyResources(this.cboNivel, "cboNivel");
            this.cboNivel.Name = "cboNivel";
            this.cboNivel.SelectedIndexChanged += new System.EventHandler(this.cboNivel_SelectedIndexChanged);
            // 
            // label9
            // 
            resources.ApplyResources(this.label9, "label9");
            this.label9.Name = "label9";
            // 
            // txtIdentificadorEncargado
            // 
            resources.ApplyResources(this.txtIdentificadorEncargado, "txtIdentificadorEncargado");
            this.txtIdentificadorEncargado.Name = "txtIdentificadorEncargado";
            this.txtIdentificadorEncargado.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label10
            // 
            resources.ApplyResources(this.label10, "label10");
            this.label10.Name = "label10";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // btnBuscarEncargado
            // 
            resources.ApplyResources(this.btnBuscarEncargado, "btnBuscarEncargado");
            this.btnBuscarEncargado.Name = "btnBuscarEncargado";
            this.btnBuscarEncargado.UseVisualStyleBackColor = true;
            this.btnBuscarEncargado.Click += new System.EventHandler(this.btnBuscarEncargado_Click);
            // 
            // txtEncargadoResultado
            // 
            resources.ApplyResources(this.txtEncargadoResultado, "txtEncargadoResultado");
            this.txtEncargadoResultado.Name = "txtEncargadoResultado";
            // 
            // FrmDatosEstudiante
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.Controls.Add(this.txtEncargadoResultado);
            this.Controls.Add(this.btnBuscarEncargado);
            this.Controls.Add(this.txtIdentificadorEncargado);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.cboNivel);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.cboSecciones);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.btnSubirFot);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.videoSourcePlayer1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtDireccion);
            this.Controls.Add(this.mskFechaNacimiento);
            this.Controls.Add(this.cboSexo);
            this.Controls.Add(this.txtNombreCompleto);
            this.Controls.Add(this.txtIdentificacion);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FrmDatosEstudiante";
            this.Load += new System.EventHandler(this.FrmDatosEstudiante_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtIdentificacion;
        private System.Windows.Forms.TextBox txtNombreCompleto;
        private System.Windows.Forms.ComboBox cboSexo;
        private System.Windows.Forms.MaskedTextBox mskFechaNacimiento;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button1;
        private AForge.Controls.VideoSourcePlayer videoSourcePlayer1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button btnSubirFot;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.ComboBox cboSecciones;
        private System.Windows.Forms.ComboBox cboNivel;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtIdentificadorEncargado;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnBuscarEncargado;
        private System.Windows.Forms.TextBox txtEncargadoResultado;
    }
}