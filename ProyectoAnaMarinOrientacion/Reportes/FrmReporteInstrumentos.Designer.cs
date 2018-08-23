namespace ProyectoAnaMarinOrientacion.Reportes
{
    partial class FrmReporteInstrumentos
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.DataSet2 = new ProyectoAnaMarinOrientacion.Reportes.DataSet2();
            this.PA_SeleccionarInstrumentosFechaReporteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.PA_SeleccionarInstrumentosFechaReporteTableAdapter = new ProyectoAnaMarinOrientacion.Reportes.DataSet2TableAdapters.PA_SeleccionarInstrumentosFechaReporteTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.DataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PA_SeleccionarInstrumentosFechaReporteBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "dataInstrumentoFecha";
            reportDataSource1.Value = this.PA_SeleccionarInstrumentosFechaReporteBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "ProyectoAnaMarinOrientacion.Reportes.Report2.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(834, 511);
            this.reportViewer1.TabIndex = 0;
            // 
            // DataSet2
            // 
            this.DataSet2.DataSetName = "DataSet2";
            this.DataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // PA_SeleccionarInstrumentosFechaReporteBindingSource
            // 
            this.PA_SeleccionarInstrumentosFechaReporteBindingSource.DataMember = "PA_SeleccionarInstrumentosFechaReporte";
            this.PA_SeleccionarInstrumentosFechaReporteBindingSource.DataSource = this.DataSet2;
            this.PA_SeleccionarInstrumentosFechaReporteBindingSource.CurrentChanged += new System.EventHandler(this.PA_SeleccionarInstrumentosFechaReporteBindingSource_CurrentChanged);
            // 
            // PA_SeleccionarInstrumentosFechaReporteTableAdapter
            // 
            this.PA_SeleccionarInstrumentosFechaReporteTableAdapter.ClearBeforeFill = true;
            // 
            // FrmReporteInstrumentos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(834, 511);
            this.Controls.Add(this.reportViewer1);
            this.Name = "FrmReporteInstrumentos";
            this.Text = "Reporte de instrumentos";
            this.Load += new System.EventHandler(this.FrmReporteInstrumentos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PA_SeleccionarInstrumentosFechaReporteBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource PA_SeleccionarInstrumentosFechaReporteBindingSource;
        private DataSet2 DataSet2;
        private DataSet2TableAdapters.PA_SeleccionarInstrumentosFechaReporteTableAdapter PA_SeleccionarInstrumentosFechaReporteTableAdapter;
    }
}