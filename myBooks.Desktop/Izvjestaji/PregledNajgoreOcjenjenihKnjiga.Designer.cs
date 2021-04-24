
namespace myBooks.Desktop.Izvjestaji
{
    partial class PregledNajgoreOcjenjenihKnjiga
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
            this.dsKnjigeOcjene_najgore = new myBooks.Desktop.Izvjestaji.dsKnjigeOcjene_najgore();
            this.KnjigeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.KnjigeTableAdapter = new myBooks.Desktop.Izvjestaji.dsKnjigeOcjene_najgoreTableAdapters.KnjigeTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dsKnjigeOcjene_najgore)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.KnjigeBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.KnjigeBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "myBooks.Desktop.Izvjestaji.ReportNajgoreOcjenjeneKnjige.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1491, 1164);
            this.reportViewer1.TabIndex = 0;
            // 
            // dsKnjigeOcjene_najgore
            // 
            this.dsKnjigeOcjene_najgore.DataSetName = "dsKnjigeOcjene_najgore";
            this.dsKnjigeOcjene_najgore.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // KnjigeBindingSource
            // 
            this.KnjigeBindingSource.DataMember = "Knjige";
            this.KnjigeBindingSource.DataSource = this.dsKnjigeOcjene_najgore;
            // 
            // KnjigeTableAdapter
            // 
            this.KnjigeTableAdapter.ClearBeforeFill = true;
            // 
            // PregledNajgoreOcjenjenihKnjiga
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1491, 1164);
            this.Controls.Add(this.reportViewer1);
            this.Name = "PregledNajgoreOcjenjenihKnjiga";
            this.Text = "Najlošije ocjenjene knjige";
            this.Load += new System.EventHandler(this.PregledNajgoreOcjenjenihKnjiga_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dsKnjigeOcjene_najgore)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.KnjigeBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource KnjigeBindingSource;
        private dsKnjigeOcjene_najgore dsKnjigeOcjene_najgore;
        private dsKnjigeOcjene_najgoreTableAdapters.KnjigeTableAdapter KnjigeTableAdapter;
    }
}