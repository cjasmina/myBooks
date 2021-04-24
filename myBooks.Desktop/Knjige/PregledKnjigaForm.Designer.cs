
namespace myBooks.Desktop.Knjige
{
    partial class PregledKnjigaForm
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
            this.ISBNTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ZanrComboBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.PretragaButton = new System.Windows.Forms.Button();
            this.DodajButton = new System.Windows.Forms.Button();
            this.KnjigeDGV = new System.Windows.Forms.DataGridView();
            this.KnjigaId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Naziv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ISBN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DatumIzdavanja = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label3 = new System.Windows.Forms.Label();
            this.JezikComboBox = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.IzdavackaKucaComboBox = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.KnjigeDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // ISBNTextBox
            // 
            this.ISBNTextBox.Location = new System.Drawing.Point(12, 25);
            this.ISBNTextBox.Multiline = true;
            this.ISBNTextBox.Name = "ISBNTextBox";
            this.ISBNTextBox.Size = new System.Drawing.Size(129, 21);
            this.ISBNTextBox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "ISBN";
            // 
            // ZanrComboBox
            // 
            this.ZanrComboBox.FormattingEnabled = true;
            this.ZanrComboBox.Location = new System.Drawing.Point(147, 25);
            this.ZanrComboBox.Name = "ZanrComboBox";
            this.ZanrComboBox.Size = new System.Drawing.Size(129, 21);
            this.ZanrComboBox.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(144, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Žanr";
            // 
            // PretragaButton
            // 
            this.PretragaButton.Location = new System.Drawing.Point(552, 24);
            this.PretragaButton.Name = "PretragaButton";
            this.PretragaButton.Size = new System.Drawing.Size(75, 23);
            this.PretragaButton.TabIndex = 4;
            this.PretragaButton.Text = "Pretraga";
            this.PretragaButton.UseVisualStyleBackColor = true;
            this.PretragaButton.Click += new System.EventHandler(this.PretragaButton_Click);
            // 
            // DodajButton
            // 
            this.DodajButton.Location = new System.Drawing.Point(713, 24);
            this.DodajButton.Name = "DodajButton";
            this.DodajButton.Size = new System.Drawing.Size(75, 23);
            this.DodajButton.TabIndex = 5;
            this.DodajButton.Text = "Dodaj";
            this.DodajButton.UseVisualStyleBackColor = true;
            this.DodajButton.Click += new System.EventHandler(this.DodajButton_Click);
            // 
            // KnjigeDGV
            // 
            this.KnjigeDGV.AllowUserToAddRows = false;
            this.KnjigeDGV.AllowUserToDeleteRows = false;
            this.KnjigeDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.KnjigeDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.KnjigeDGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.KnjigaId,
            this.Naziv,
            this.ISBN,
            this.DatumIzdavanja});
            this.KnjigeDGV.Location = new System.Drawing.Point(12, 58);
            this.KnjigeDGV.Name = "KnjigeDGV";
            this.KnjigeDGV.ReadOnly = true;
            this.KnjigeDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.KnjigeDGV.Size = new System.Drawing.Size(776, 380);
            this.KnjigeDGV.TabIndex = 6;
            this.KnjigeDGV.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.KnjigeDGV_CellDoubleClick);
            // 
            // KnjigaId
            // 
            this.KnjigaId.DataPropertyName = "KnjigaId";
            this.KnjigaId.HeaderText = "KnjigaId";
            this.KnjigaId.Name = "KnjigaId";
            this.KnjigaId.ReadOnly = true;
            this.KnjigaId.Visible = false;
            // 
            // Naziv
            // 
            this.Naziv.DataPropertyName = "Naziv";
            this.Naziv.FillWeight = 40.9277F;
            this.Naziv.HeaderText = "Naziv";
            this.Naziv.Name = "Naziv";
            this.Naziv.ReadOnly = true;
            // 
            // ISBN
            // 
            this.ISBN.DataPropertyName = "ISBN";
            this.ISBN.FillWeight = 102.8143F;
            this.ISBN.HeaderText = "ISBN";
            this.ISBN.Name = "ISBN";
            this.ISBN.ReadOnly = true;
            // 
            // DatumIzdavanja
            // 
            this.DatumIzdavanja.DataPropertyName = "DatumIzdavanja";
            this.DatumIzdavanja.FillWeight = 156.258F;
            this.DatumIzdavanja.HeaderText = "Datum izdavanja";
            this.DatumIzdavanja.Name = "DatumIzdavanja";
            this.DatumIzdavanja.ReadOnly = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(279, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Izdavačka kuća";
            // 
            // JezikComboBox
            // 
            this.JezikComboBox.FormattingEnabled = true;
            this.JezikComboBox.Location = new System.Drawing.Point(282, 25);
            this.JezikComboBox.Name = "JezikComboBox";
            this.JezikComboBox.Size = new System.Drawing.Size(129, 21);
            this.JezikComboBox.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(414, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Izdavačka kuća";
            // 
            // IzdavackaKucaComboBox
            // 
            this.IzdavackaKucaComboBox.FormattingEnabled = true;
            this.IzdavackaKucaComboBox.Location = new System.Drawing.Point(417, 25);
            this.IzdavackaKucaComboBox.Name = "IzdavackaKucaComboBox";
            this.IzdavackaKucaComboBox.Size = new System.Drawing.Size(129, 21);
            this.IzdavackaKucaComboBox.TabIndex = 9;
            // 
            // PregledKnjigaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.IzdavackaKucaComboBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.JezikComboBox);
            this.Controls.Add(this.KnjigeDGV);
            this.Controls.Add(this.DodajButton);
            this.Controls.Add(this.PretragaButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ZanrComboBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ISBNTextBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PregledKnjigaForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Knjige - myBooks";
            this.Load += new System.EventHandler(this.PregledKnjigaForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.KnjigeDGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox ISBNTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox ZanrComboBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button PretragaButton;
        private System.Windows.Forms.Button DodajButton;
        private System.Windows.Forms.DataGridView KnjigeDGV;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox JezikComboBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox IzdavackaKucaComboBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn KnjigaId;
        private System.Windows.Forms.DataGridViewTextBoxColumn Naziv;
        private System.Windows.Forms.DataGridViewTextBoxColumn ISBN;
        private System.Windows.Forms.DataGridViewTextBoxColumn DatumIzdavanja;
    }
}