
namespace myBooks.Desktop.IzdavackeKuce
{
    partial class UpravljanjeIzdavackomKucomForm
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
            this.GradComboBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SpremiButton = new System.Windows.Forms.Button();
            this.ErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // NazivTextBox
            // 
            this.NazivTextBox.Location = new System.Drawing.Point(57, 59);
            this.NazivTextBox.Multiline = true;
            this.NazivTextBox.Name = "NazivTextBox";
            this.NazivTextBox.Size = new System.Drawing.Size(217, 21);
            this.NazivTextBox.TabIndex = 0;
            this.NazivTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.NazivTextBox_Validating);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(54, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Naziv";
            // 
            // GradComboBox
            // 
            this.GradComboBox.FormattingEnabled = true;
            this.GradComboBox.Location = new System.Drawing.Point(57, 110);
            this.GradComboBox.Name = "GradComboBox";
            this.GradComboBox.Size = new System.Drawing.Size(217, 21);
            this.GradComboBox.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(54, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Grad";
            // 
            // SpremiButton
            // 
            this.SpremiButton.Location = new System.Drawing.Point(200, 167);
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
            // UpravljanjeIzdavackomKucomForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(328, 245);
            this.Controls.Add(this.SpremiButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.GradComboBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.NazivTextBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "UpravljanjeIzdavackomKucomForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Izdavačke kuće - myBooks";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.UpravljanjeIzdavackomKucomForm_FormClosing);
            this.Load += new System.EventHandler(this.UpravljanjeIzdavackomKucomForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox NazivTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox GradComboBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button SpremiButton;
        private System.Windows.Forms.ErrorProvider ErrorProvider;
    }
}