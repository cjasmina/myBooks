
namespace myBooks.Desktop.Prijedlozi
{
    partial class PregledPrijedlogaForm
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
            this.NazivTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.PrijedloziDGV = new System.Windows.Forms.DataGridView();
            this.PretragaButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.KorisnikComboBox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.AutorTextBox = new System.Windows.Forms.TextBox();
            this.PrijedlogId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Naziv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Autor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.PrijedloziDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // NazivTextBox
            // 
            this.NazivTextBox.Location = new System.Drawing.Point(12, 25);
            this.NazivTextBox.Multiline = true;
            this.NazivTextBox.Name = "NazivTextBox";
            this.NazivTextBox.Size = new System.Drawing.Size(189, 21);
            this.NazivTextBox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Naziv";
            // 
            // PrijedloziDGV
            // 
            this.PrijedloziDGV.AllowUserToAddRows = false;
            this.PrijedloziDGV.AllowUserToDeleteRows = false;
            this.PrijedloziDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.PrijedloziDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PrijedloziDGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PrijedlogId,
            this.Naziv,
            this.Autor});
            this.PrijedloziDGV.Location = new System.Drawing.Point(12, 58);
            this.PrijedloziDGV.Name = "PrijedloziDGV";
            this.PrijedloziDGV.ReadOnly = true;
            this.PrijedloziDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.PrijedloziDGV.Size = new System.Drawing.Size(776, 380);
            this.PrijedloziDGV.TabIndex = 6;
            // 
            // PretragaButton
            // 
            this.PretragaButton.Location = new System.Drawing.Point(597, 24);
            this.PretragaButton.Name = "PretragaButton";
            this.PretragaButton.Size = new System.Drawing.Size(75, 23);
            this.PretragaButton.TabIndex = 9;
            this.PretragaButton.Text = "Pretraga";
            this.PretragaButton.UseVisualStyleBackColor = true;
            this.PretragaButton.Click += new System.EventHandler(this.PretragaButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(399, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Korisnik";
            // 
            // KorisnikComboBox
            // 
            this.KorisnikComboBox.FormattingEnabled = true;
            this.KorisnikComboBox.Location = new System.Drawing.Point(402, 25);
            this.KorisnikComboBox.Name = "KorisnikComboBox";
            this.KorisnikComboBox.Size = new System.Drawing.Size(189, 21);
            this.KorisnikComboBox.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(204, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Autor";
            // 
            // AutorTextBox
            // 
            this.AutorTextBox.Location = new System.Drawing.Point(207, 25);
            this.AutorTextBox.Multiline = true;
            this.AutorTextBox.Name = "AutorTextBox";
            this.AutorTextBox.Size = new System.Drawing.Size(189, 21);
            this.AutorTextBox.TabIndex = 10;
            // 
            // PrijedlogId
            // 
            this.PrijedlogId.DataPropertyName = "PrijedlogId";
            this.PrijedlogId.HeaderText = "PrijedlogId";
            this.PrijedlogId.Name = "PrijedlogId";
            this.PrijedlogId.ReadOnly = true;
            this.PrijedlogId.Visible = false;
            // 
            // Naziv
            // 
            this.Naziv.DataPropertyName = "Naziv";
            this.Naziv.HeaderText = "Naziv";
            this.Naziv.Name = "Naziv";
            this.Naziv.ReadOnly = true;
            // 
            // Autor
            // 
            this.Autor.DataPropertyName = "Autor";
            this.Autor.HeaderText = "Autor";
            this.Autor.Name = "Autor";
            this.Autor.ReadOnly = true;
            // 
            // PregledPrijedlogaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.AutorTextBox);
            this.Controls.Add(this.PretragaButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.KorisnikComboBox);
            this.Controls.Add(this.PrijedloziDGV);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.NazivTextBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PregledPrijedlogaForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Prijedlozi - myBooks";
            this.Load += new System.EventHandler(this.PregledPrijedlogaForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PrijedloziDGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox NazivTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView PrijedloziDGV;
        private System.Windows.Forms.Button PretragaButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox KorisnikComboBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox AutorTextBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrijedlogId;
        private System.Windows.Forms.DataGridViewTextBoxColumn Naziv;
        private System.Windows.Forms.DataGridViewTextBoxColumn Autor;
    }
}

