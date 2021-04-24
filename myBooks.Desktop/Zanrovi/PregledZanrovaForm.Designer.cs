
namespace myBooks.Desktop.Zanrovi
{
    partial class PregledZanrovaForm
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
            this.DodajButton = new System.Windows.Forms.Button();
            this.ZanroviDGV = new System.Windows.Forms.DataGridView();
            this.ZanrId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Naziv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PretragaButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ZanroviDGV)).BeginInit();
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
            // ZanroviDGV
            // 
            this.ZanroviDGV.AllowUserToAddRows = false;
            this.ZanroviDGV.AllowUserToDeleteRows = false;
            this.ZanroviDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ZanroviDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ZanroviDGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ZanrId,
            this.Naziv});
            this.ZanroviDGV.Location = new System.Drawing.Point(12, 58);
            this.ZanroviDGV.Name = "ZanroviDGV";
            this.ZanroviDGV.ReadOnly = true;
            this.ZanroviDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ZanroviDGV.Size = new System.Drawing.Size(776, 380);
            this.ZanroviDGV.TabIndex = 6;
            this.ZanroviDGV.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ZanroviDGV_CellDoubleClick);
            // 
            // ZanrId
            // 
            this.ZanrId.DataPropertyName = "ZanrId";
            this.ZanrId.HeaderText = "ZanrId";
            this.ZanrId.Name = "ZanrId";
            this.ZanrId.ReadOnly = true;
            this.ZanrId.Visible = false;
            // 
            // Naziv
            // 
            this.Naziv.DataPropertyName = "Naziv";
            this.Naziv.HeaderText = "Naziv";
            this.Naziv.Name = "Naziv";
            this.Naziv.ReadOnly = true;
            // 
            // PretragaButton
            // 
            this.PretragaButton.Location = new System.Drawing.Point(207, 24);
            this.PretragaButton.Name = "PretragaButton";
            this.PretragaButton.Size = new System.Drawing.Size(75, 23);
            this.PretragaButton.TabIndex = 7;
            this.PretragaButton.Text = "Pretraga";
            this.PretragaButton.UseVisualStyleBackColor = true;
            this.PretragaButton.Click += new System.EventHandler(this.PretragaButton_Click);
            // 
            // PregledZanrovaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.PretragaButton);
            this.Controls.Add(this.ZanroviDGV);
            this.Controls.Add(this.DodajButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.NazivTextBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PregledZanrovaForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Žanrovi - myBooks";
            this.Load += new System.EventHandler(this.PregledZanrovaForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ZanroviDGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox NazivTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button DodajButton;
        private System.Windows.Forms.DataGridView ZanroviDGV;
        private System.Windows.Forms.Button PretragaButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn ZanrId;
        private System.Windows.Forms.DataGridViewTextBoxColumn Naziv;
    
    }
}

