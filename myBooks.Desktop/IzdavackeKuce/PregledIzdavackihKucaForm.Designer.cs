
namespace myBooks.Desktop.IzdavackeKuce
{
    partial class PregledIzdavackihKucaForm
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
            this.GradComboBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.PretragaButton = new System.Windows.Forms.Button();
            this.DodajButton = new System.Windows.Forms.Button();
            this.IzdavackeKuceDGV = new System.Windows.Forms.DataGridView();
            this.IzdavackaKucaId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Naziv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.IzdavackeKuceDGV)).BeginInit();
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
            // GradComboBox
            // 
            this.GradComboBox.FormattingEnabled = true;
            this.GradComboBox.Location = new System.Drawing.Point(207, 25);
            this.GradComboBox.Name = "GradComboBox";
            this.GradComboBox.Size = new System.Drawing.Size(189, 21);
            this.GradComboBox.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(204, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Grad";
            // 
            // PretragaButton
            // 
            this.PretragaButton.Location = new System.Drawing.Point(402, 24);
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
            // IzdavackeKuceDGV
            // 
            this.IzdavackeKuceDGV.AllowUserToAddRows = false;
            this.IzdavackeKuceDGV.AllowUserToDeleteRows = false;
            this.IzdavackeKuceDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.IzdavackeKuceDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.IzdavackeKuceDGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IzdavackaKucaId,
            this.Naziv});
            this.IzdavackeKuceDGV.Location = new System.Drawing.Point(12, 58);
            this.IzdavackeKuceDGV.Name = "IzdavackeKuceDGV";
            this.IzdavackeKuceDGV.ReadOnly = true;
            this.IzdavackeKuceDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.IzdavackeKuceDGV.Size = new System.Drawing.Size(776, 380);
            this.IzdavackeKuceDGV.TabIndex = 6;
            this.IzdavackeKuceDGV.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.IzdavackeKuceDGV_CellDoubleClick);
            // 
            // IzdavackaKucaId
            // 
            this.IzdavackaKucaId.DataPropertyName = "IzdavackaKucaId";
            this.IzdavackaKucaId.HeaderText = "IzdavackaKucaId";
            this.IzdavackaKucaId.Name = "IzdavackaKucaId";
            this.IzdavackaKucaId.ReadOnly = true;
            this.IzdavackaKucaId.Visible = false;
            // 
            // Naziv
            // 
            this.Naziv.DataPropertyName = "Naziv";
            this.Naziv.HeaderText = "Naziv";
            this.Naziv.Name = "Naziv";
            this.Naziv.ReadOnly = true;
            // 
            // PregledIzdavackihKucaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.IzdavackeKuceDGV);
            this.Controls.Add(this.DodajButton);
            this.Controls.Add(this.PretragaButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.GradComboBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.NazivTextBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PregledIzdavackihKucaForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Izdavačke kuće - myBooks";
            this.Load += new System.EventHandler(this.PregledIzdavackihKucaForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.IzdavackeKuceDGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox NazivTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox GradComboBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button PretragaButton;
        private System.Windows.Forms.Button DodajButton;
        private System.Windows.Forms.DataGridView IzdavackeKuceDGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn IzdavackaKucaId;
        private System.Windows.Forms.DataGridViewTextBoxColumn Naziv;
    }
}