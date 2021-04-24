
namespace myBooks.Desktop.Autori
{
    partial class PregledAutoraForm
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
            this.ImeTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.DodajButton = new System.Windows.Forms.Button();
            this.AutoriDGV = new System.Windows.Forms.DataGridView();
            this.AutorId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Prezime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DatumRodjenja = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PretragaButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.PrezimeTextBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.AutoriDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // ImeTextBox
            // 
            this.ImeTextBox.Location = new System.Drawing.Point(12, 25);
            this.ImeTextBox.Multiline = true;
            this.ImeTextBox.Name = "ImeTextBox";
            this.ImeTextBox.Size = new System.Drawing.Size(189, 21);
            this.ImeTextBox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ime";
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
            // AutoriDGV
            // 
            this.AutoriDGV.AllowUserToAddRows = false;
            this.AutoriDGV.AllowUserToDeleteRows = false;
            this.AutoriDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.AutoriDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AutoriDGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.AutorId,
            this.Ime,
            this.Prezime,
            this.DatumRodjenja});
            this.AutoriDGV.Location = new System.Drawing.Point(12, 58);
            this.AutoriDGV.Name = "AutoriDGV";
            this.AutoriDGV.ReadOnly = true;
            this.AutoriDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.AutoriDGV.Size = new System.Drawing.Size(776, 380);
            this.AutoriDGV.TabIndex = 6;
            this.AutoriDGV.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.AutoriDGV_CellDoubleClick);
            // 
            // AutorId
            // 
            this.AutorId.DataPropertyName = "AutorId";
            this.AutorId.HeaderText = "AutorId";
            this.AutorId.Name = "AutorId";
            this.AutorId.ReadOnly = true;
            this.AutorId.Visible = false;
            // 
            // Ime
            // 
            this.Ime.DataPropertyName = "Ime";
            this.Ime.HeaderText = "Ime";
            this.Ime.Name = "Ime";
            this.Ime.ReadOnly = true;
            // 
            // Prezime
            // 
            this.Prezime.DataPropertyName = "Prezime";
            this.Prezime.HeaderText = "Prezime";
            this.Prezime.Name = "Prezime";
            this.Prezime.ReadOnly = true;
            // 
            // DatumRodjenja
            // 
            this.DatumRodjenja.DataPropertyName = "DatumRodjenja";
            this.DatumRodjenja.HeaderText = "Datum rođenja";
            this.DatumRodjenja.Name = "DatumRodjenja";
            this.DatumRodjenja.ReadOnly = true;
            // 
            // PretragaButton
            // 
            this.PretragaButton.Location = new System.Drawing.Point(402, 24);
            this.PretragaButton.Name = "PretragaButton";
            this.PretragaButton.Size = new System.Drawing.Size(75, 23);
            this.PretragaButton.TabIndex = 7;
            this.PretragaButton.Text = "Pretraga";
            this.PretragaButton.UseVisualStyleBackColor = true;
            this.PretragaButton.Click += new System.EventHandler(this.PretragaButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(204, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Prezime";
            // 
            // PrezimeTextBox
            // 
            this.PrezimeTextBox.Location = new System.Drawing.Point(207, 25);
            this.PrezimeTextBox.Multiline = true;
            this.PrezimeTextBox.Name = "PrezimeTextBox";
            this.PrezimeTextBox.Size = new System.Drawing.Size(189, 21);
            this.PrezimeTextBox.TabIndex = 8;
            // 
            // PregledAutoraForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.PrezimeTextBox);
            this.Controls.Add(this.PretragaButton);
            this.Controls.Add(this.AutoriDGV);
            this.Controls.Add(this.DodajButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ImeTextBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PregledAutoraForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Autori - myBooks";
            this.Load += new System.EventHandler(this.PregledAutoraForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.AutoriDGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox ImeTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button DodajButton;
        private System.Windows.Forms.DataGridView AutoriDGV;
        private System.Windows.Forms.Button PretragaButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox PrezimeTextBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn AutorId;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ime;
        private System.Windows.Forms.DataGridViewTextBoxColumn Prezime;
        private System.Windows.Forms.DataGridViewTextBoxColumn DatumRodjenja;
    }
}