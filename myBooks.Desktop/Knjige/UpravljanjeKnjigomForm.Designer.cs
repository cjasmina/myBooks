
namespace myBooks.Desktop.Knjige
{
    partial class UpravljanjeKnjigomForm
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
            this.NazivTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.SpremiButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.KratakOpisTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.ISBNTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.DatumIzdavanjaPicker = new System.Windows.Forms.DateTimePicker();
            this.ZanrComboBox = new System.Windows.Forms.ComboBox();
            this.JezikComboBox = new System.Windows.Forms.ComboBox();
            this.IzdavackaKucaComboBox = new System.Windows.Forms.ComboBox();
            this.AutoriListBox = new System.Windows.Forms.CheckedListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.OpisTextBox = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.NaslovnaFotografijaPictureBox = new System.Windows.Forms.PictureBox();
            this.OdaberiButton = new System.Windows.Forms.Button();
            this.OpenFileDialog = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NaslovnaFotografijaPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // NazivTextBox
            // 
            this.NazivTextBox.Location = new System.Drawing.Point(307, 59);
            this.NazivTextBox.Multiline = true;
            this.NazivTextBox.Name = "NazivTextBox";
            this.NazivTextBox.Size = new System.Drawing.Size(217, 21);
            this.NazivTextBox.TabIndex = 0;
            this.NazivTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.NazivTextBox_Validating);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(304, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Naziv";
            // 
            // ErrorProvider
            // 
            this.ErrorProvider.ContainerControl = this;
            // 
            // SpremiButton
            // 
            this.SpremiButton.Location = new System.Drawing.Point(927, 427);
            this.SpremiButton.Name = "SpremiButton";
            this.SpremiButton.Size = new System.Drawing.Size(75, 30);
            this.SpremiButton.TabIndex = 9;
            this.SpremiButton.Text = "Spremi";
            this.SpremiButton.UseVisualStyleBackColor = true;
            this.SpremiButton.Click += new System.EventHandler(this.SpremiButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(304, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Kratak opis";
            // 
            // KratakOpisTextBox
            // 
            this.KratakOpisTextBox.Location = new System.Drawing.Point(307, 111);
            this.KratakOpisTextBox.Multiline = true;
            this.KratakOpisTextBox.Name = "KratakOpisTextBox";
            this.KratakOpisTextBox.Size = new System.Drawing.Size(217, 21);
            this.KratakOpisTextBox.TabIndex = 10;
            this.KratakOpisTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.KratakOpisTextBox_Validating);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(304, 198);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "ISBN";
            // 
            // ISBNTextBox
            // 
            this.ISBNTextBox.Location = new System.Drawing.Point(307, 214);
            this.ISBNTextBox.Multiline = true;
            this.ISBNTextBox.Name = "ISBNTextBox";
            this.ISBNTextBox.Size = new System.Drawing.Size(217, 21);
            this.ISBNTextBox.TabIndex = 14;
            this.ISBNTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.ISBNTextBox_Validating);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(304, 147);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Datum izdavanja";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(304, 354);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(84, 13);
            this.label7.TabIndex = 21;
            this.label7.Text = "Izdavačka kuća";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(304, 302);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(31, 13);
            this.label8.TabIndex = 19;
            this.label8.Text = "Jezik";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(304, 250);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(29, 13);
            this.label9.TabIndex = 17;
            this.label9.Text = "Žanr";
            // 
            // DatumIzdavanjaPicker
            // 
            this.DatumIzdavanjaPicker.Location = new System.Drawing.Point(307, 163);
            this.DatumIzdavanjaPicker.Name = "DatumIzdavanjaPicker";
            this.DatumIzdavanjaPicker.Size = new System.Drawing.Size(217, 20);
            this.DatumIzdavanjaPicker.TabIndex = 22;
            // 
            // ZanrComboBox
            // 
            this.ZanrComboBox.FormattingEnabled = true;
            this.ZanrComboBox.Location = new System.Drawing.Point(307, 266);
            this.ZanrComboBox.Name = "ZanrComboBox";
            this.ZanrComboBox.Size = new System.Drawing.Size(217, 21);
            this.ZanrComboBox.TabIndex = 23;
            // 
            // JezikComboBox
            // 
            this.JezikComboBox.FormattingEnabled = true;
            this.JezikComboBox.Location = new System.Drawing.Point(307, 318);
            this.JezikComboBox.Name = "JezikComboBox";
            this.JezikComboBox.Size = new System.Drawing.Size(217, 21);
            this.JezikComboBox.TabIndex = 24;
            // 
            // IzdavackaKucaComboBox
            // 
            this.IzdavackaKucaComboBox.FormattingEnabled = true;
            this.IzdavackaKucaComboBox.Location = new System.Drawing.Point(307, 370);
            this.IzdavackaKucaComboBox.Name = "IzdavackaKucaComboBox";
            this.IzdavackaKucaComboBox.Size = new System.Drawing.Size(217, 21);
            this.IzdavackaKucaComboBox.TabIndex = 25;
            // 
            // AutoriListBox
            // 
            this.AutoriListBox.FormattingEnabled = true;
            this.AutoriListBox.Location = new System.Drawing.Point(579, 59);
            this.AutoriListBox.Name = "AutoriListBox";
            this.AutoriListBox.Size = new System.Drawing.Size(422, 139);
            this.AutoriListBox.TabIndex = 26;
            this.AutoriListBox.Validating += new System.ComponentModel.CancelEventHandler(this.AutoriListBox_Validating);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(576, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 27;
            this.label2.Text = "Autori";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(576, 213);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(28, 13);
            this.label6.TabIndex = 28;
            this.label6.Text = "Opis";
            // 
            // OpisTextBox
            // 
            this.OpisTextBox.Location = new System.Drawing.Point(579, 229);
            this.OpisTextBox.Multiline = true;
            this.OpisTextBox.Name = "OpisTextBox";
            this.OpisTextBox.Size = new System.Drawing.Size(422, 162);
            this.OpisTextBox.TabIndex = 29;
            this.OpisTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.OpisTextBox_Validating);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(54, 43);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(101, 13);
            this.label10.TabIndex = 31;
            this.label10.Text = "Naslovna fotografija";
            // 
            // NaslovnaFotografijaPictureBox
            // 
            this.NaslovnaFotografijaPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.NaslovnaFotografijaPictureBox.Location = new System.Drawing.Point(57, 59);
            this.NaslovnaFotografijaPictureBox.Name = "NaslovnaFotografijaPictureBox";
            this.NaslovnaFotografijaPictureBox.Size = new System.Drawing.Size(195, 195);
            this.NaslovnaFotografijaPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.NaslovnaFotografijaPictureBox.TabIndex = 32;
            this.NaslovnaFotografijaPictureBox.TabStop = false;
            this.NaslovnaFotografijaPictureBox.Validating += new System.ComponentModel.CancelEventHandler(this.NaslovnaFotografijaPictureBox_Validating);
            // 
            // OdaberiButton
            // 
            this.OdaberiButton.Location = new System.Drawing.Point(56, 260);
            this.OdaberiButton.Name = "OdaberiButton";
            this.OdaberiButton.Size = new System.Drawing.Size(197, 30);
            this.OdaberiButton.TabIndex = 33;
            this.OdaberiButton.Text = "Odaberi";
            this.OdaberiButton.UseVisualStyleBackColor = true;
            this.OdaberiButton.Click += new System.EventHandler(this.OdaberiButton_Click);
            // 
            // OpenFileDialog
            // 
            this.OpenFileDialog.FileName = "openFileDialog1";
            // 
            // UpravljanjeKnjigomForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1061, 510);
            this.Controls.Add(this.OdaberiButton);
            this.Controls.Add(this.NaslovnaFotografijaPictureBox);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.OpisTextBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.AutoriListBox);
            this.Controls.Add(this.IzdavackaKucaComboBox);
            this.Controls.Add(this.JezikComboBox);
            this.Controls.Add(this.ZanrComboBox);
            this.Controls.Add(this.DatumIzdavanjaPicker);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.ISBNTextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.KratakOpisTextBox);
            this.Controls.Add(this.SpremiButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.NazivTextBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "UpravljanjeKnjigomForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Knjige - myBooks";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.UpravljanjeKnjigomForm_FormClosing);
            this.Load += new System.EventHandler(this.UpravljanjeKnjigomForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NaslovnaFotografijaPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox NazivTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ErrorProvider ErrorProvider;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox ISBNTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox KratakOpisTextBox;
        private System.Windows.Forms.Button SpremiButton;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker DatumIzdavanjaPicker;
        private System.Windows.Forms.Button OdaberiButton;
        private System.Windows.Forms.PictureBox NaslovnaFotografijaPictureBox;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox OpisTextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckedListBox AutoriListBox;
        private System.Windows.Forms.ComboBox IzdavackaKucaComboBox;
        private System.Windows.Forms.ComboBox JezikComboBox;
        private System.Windows.Forms.ComboBox ZanrComboBox;
        private System.Windows.Forms.OpenFileDialog OpenFileDialog;
    }
}