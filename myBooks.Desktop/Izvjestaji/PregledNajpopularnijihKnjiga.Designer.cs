
namespace myBooks.Desktop.Izvjestaji
{
    partial class PregledNajpopularnijihKnjiga
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
            this.dsNajpopularnijeKnjige = new myBooks.Desktop.Izvjestaji.dsNajpopularnijeKnjige();
            this.DataTable1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DataTable1TableAdapter = new myBooks.Desktop.Izvjestaji.dsNajpopularnijeKnjigeTableAdapters.DataTable1TableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dsNajpopularnijeKnjige)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataTable1BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet";
            reportDataSource1.Value = this.DataTable1BindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "myBooks.Desktop.Izvjestaji.ReportNajpopularnijeKnjige.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1447, 998);
            this.reportViewer1.TabIndex = 0;
            // 
            // dsNajpopularnijeKnjige
            // 
            this.dsNajpopularnijeKnjige.DataSetName = "dsNajpopularnijeKnjige";
            this.dsNajpopularnijeKnjige.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // DataTable1BindingSource
            // 
            this.DataTable1BindingSource.DataMember = "DataTable1";
            this.DataTable1BindingSource.DataSource = this.dsNajpopularnijeKnjige;
            // 
            // DataTable1TableAdapter
            // 
            this.DataTable1TableAdapter.ClearBeforeFill = true;
            // 
            // PregledNajpopularnijihKnjiga
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1447, 998);
            this.Controls.Add(this.reportViewer1);
            this.Name = "PregledNajpopularnijihKnjiga";
            this.Text = "Najpopularnije knjige";
            this.Load += new System.EventHandler(this.PregledNajpopularnijihKnjiga_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dsNajpopularnijeKnjige)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataTable1BindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource DataTable1BindingSource;
        private dsNajpopularnijeKnjige dsNajpopularnijeKnjige;
        private dsNajpopularnijeKnjigeTableAdapters.DataTable1TableAdapter DataTable1TableAdapter;
    }
}