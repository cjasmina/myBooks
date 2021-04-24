
namespace myBooks.Desktop.Izvjestaji
{
    partial class PregledNajpopularnijihAutora
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
            this.dsNajpopularnijiAutori = new myBooks.Desktop.Izvjestaji.dsNajpopularnijiAutori();
            this.OcjeneBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.OcjeneTableAdapter = new myBooks.Desktop.Izvjestaji.dsNajpopularnijiAutoriTableAdapters.OcjeneTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dsNajpopularnijiAutori)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.OcjeneBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet";
            reportDataSource1.Value = this.OcjeneBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "myBooks.Desktop.Izvjestaji.ReportNajpopularnijiAutori.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1417, 1145);
            this.reportViewer1.TabIndex = 0;
            // 
            // dsNajpopularnijiAutori
            // 
            this.dsNajpopularnijiAutori.DataSetName = "dsNajpopularnijiAutori";
            this.dsNajpopularnijiAutori.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // OcjeneBindingSource
            // 
            this.OcjeneBindingSource.DataMember = "Ocjene";
            this.OcjeneBindingSource.DataSource = this.dsNajpopularnijiAutori;
            // 
            // OcjeneTableAdapter
            // 
            this.OcjeneTableAdapter.ClearBeforeFill = true;
            // 
            // PregledNajpopularnijihAutora
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1417, 1145);
            this.Controls.Add(this.reportViewer1);
            this.Name = "PregledNajpopularnijihAutora";
            this.Text = "Najpopularniji autori";
            this.Load += new System.EventHandler(this.PregledNajpopularnijihAutora_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dsNajpopularnijiAutori)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.OcjeneBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource OcjeneBindingSource;
        private dsNajpopularnijiAutori dsNajpopularnijiAutori;
        private dsNajpopularnijiAutoriTableAdapters.OcjeneTableAdapter OcjeneTableAdapter;
    }
}