
namespace myBooks.Desktop.Autori
{
    partial class UpravljanjeAutoromForm
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
            this.ImeTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SpremiButton = new System.Windows.Forms.Button();
            this.ErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.PrezimeTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.BiografijaTextBox = new System.Windows.Forms.TextBox();
            this.DatumRodjenjaPicker = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // ImeTextBox
            // 
            this.ImeTextBox.Location = new System.Drawing.Point(57, 59);
            this.ImeTextBox.Multiline = true;
            this.ImeTextBox.Name = "ImeTextBox";
            this.ImeTextBox.Size = new System.Drawing.Size(217, 21);
            this.ImeTextBox.TabIndex = 0;
            this.ImeTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.ImeTextBox_Validating);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(54, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ime";
            // 
            // SpremiButton
            // 
            this.SpremiButton.Location = new System.Drawing.Point(200, 349);
            this.SpremiButton.Name = "SpremiButton";
            this.SpremiButton.Size = new System.Drawing.Size(75, 30);
            this.SpremiButton.TabIndex = 6;
            this.SpremiButton.Text = "Spremi";
            this.SpremiButton.UseVisualStyleBackColor = true;
            this.SpremiButton.Click += new System.EventHandler(this.SpremiButton_Click);
            // 
            // ErrorProvider
            // 
            this.ErrorProvider.ContainerControl = this;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(54, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Prezime";
            // 
            // PrezimeTextBox
            // 
            this.PrezimeTextBox.Location = new System.Drawing.Point(57, 111);
            this.PrezimeTextBox.Multiline = true;
            this.PrezimeTextBox.Name = "PrezimeTextBox";
            this.PrezimeTextBox.Size = new System.Drawing.Size(217, 21);
            this.PrezimeTextBox.TabIndex = 7;
            this.PrezimeTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.PrezimeTextBox_Validating);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(54, 147);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Datum rođenja";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(54, 198);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Biografija";
            // 
            // BiografijaTextBox
            // 
            this.BiografijaTextBox.Location = new System.Drawing.Point(57, 214);
            this.BiografijaTextBox.Multiline = true;
            this.BiografijaTextBox.Name = "BiografijaTextBox";
            this.BiografijaTextBox.Size = new System.Drawing.Size(217, 99);
            this.BiografijaTextBox.TabIndex = 11;
            // 
            // DatumRodjenjaPicker
            // 
            this.DatumRodjenjaPicker.Location = new System.Drawing.Point(57, 163);
            this.DatumRodjenjaPicker.Name = "DatumRodjenjaPicker";
            this.DatumRodjenjaPicker.Size = new System.Drawing.Size(217, 20);
            this.DatumRodjenjaPicker.TabIndex = 13;
            // 
            // UpravljanjeAutoromForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(328, 435);
            this.Controls.Add(this.DatumRodjenjaPicker);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.BiografijaTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.PrezimeTextBox);
            this.Controls.Add(this.SpremiButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ImeTextBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "UpravljanjeAutoromForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Autori - myBooks";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.UpravljanjeAutoromForm_FormClosing);
            this.Load += new System.EventHandler(this.UpravljanjeAutoromForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox ImeTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button SpremiButton;
        private System.Windows.Forms.ErrorProvider ErrorProvider;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox PrezimeTextBox;
        private System.Windows.Forms.DateTimePicker DatumRodjenjaPicker;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox BiografijaTextBox;
        private System.Windows.Forms.Label label3;
    }
}