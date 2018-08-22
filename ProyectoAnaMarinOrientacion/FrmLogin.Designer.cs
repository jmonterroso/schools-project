namespace ProyectoAnaMarinOrientacion
{
    partial class FrmLogin
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtIdentificacion = new System.Windows.Forms.MaskedTextBox();
            this.BtnIngresar = new System.Windows.Forms.Button();
            this.txtContasena = new System.Windows.Forms.TextBox();
            this.lblCopyRight = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ttMensaje = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Myanmar Text", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(164, 180);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "Identificador";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Myanmar Text", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(173, 215);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 27);
            this.label2.TabIndex = 1;
            this.label2.Text = "Contrasena";
            // 
            // txtIdentificacion
            // 
            this.txtIdentificacion.Location = new System.Drawing.Point(325, 180);
            this.txtIdentificacion.Name = "txtIdentificacion";
            this.txtIdentificacion.Size = new System.Drawing.Size(179, 20);
            this.txtIdentificacion.TabIndex = 2;
            // 
            // BtnIngresar
            // 
            this.BtnIngresar.BackColor = System.Drawing.Color.YellowGreen;
            this.BtnIngresar.Font = new System.Drawing.Font("Constantia", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnIngresar.Location = new System.Drawing.Point(359, 258);
            this.BtnIngresar.Name = "BtnIngresar";
            this.BtnIngresar.Size = new System.Drawing.Size(109, 42);
            this.BtnIngresar.TabIndex = 4;
            this.BtnIngresar.Text = "Ingresar";
            this.BtnIngresar.UseVisualStyleBackColor = false;
            this.BtnIngresar.Click += new System.EventHandler(this.BtnIngresar_Click);
            // 
            // txtContasena
            // 
            this.txtContasena.Location = new System.Drawing.Point(325, 221);
            this.txtContasena.Name = "txtContasena";
            this.txtContasena.Size = new System.Drawing.Size(179, 20);
            this.txtContasena.TabIndex = 5;
            // 
            // lblCopyRight
            // 
            this.lblCopyRight.AutoSize = true;
            this.lblCopyRight.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCopyRight.Location = new System.Drawing.Point(741, 479);
            this.lblCopyRight.Name = "lblCopyRight";
            this.lblCopyRight.Size = new System.Drawing.Size(74, 13);
            this.lblCopyRight.TabIndex = 7;
            this.lblCopyRight.Text = "AnaMarin ©";
            this.lblCopyRight.Click += new System.EventHandler(this.lblCopyRight_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ProyectoAnaMarinOrientacion.Properties.Resources.icono_login;
            this.pictureBox1.Location = new System.Drawing.Point(359, 49);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(109, 98);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // FrmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.BackgroundImage = global::ProyectoAnaMarinOrientacion.Properties.Resources._19820_blue_vintage_wallpaper_background;
            this.ClientSize = new System.Drawing.Size(834, 511);
            this.Controls.Add(this.lblCopyRight);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtContasena);
            this.Controls.Add(this.BtnIngresar);
            this.Controls.Add(this.txtIdentificacion);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FrmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.FrmLogin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox txtIdentificacion;
        private System.Windows.Forms.Button BtnIngresar;
        private System.Windows.Forms.TextBox txtContasena;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblCopyRight;
        private System.Windows.Forms.ToolTip ttMensaje;
    }
}