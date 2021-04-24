
namespace myBooks.Desktop
{
    partial class PrijavaForm
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.KorisnickoImeTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.LozinkaTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.PrijavaButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::myBooks.Desktop.Properties.Resources.Logo;
            this.pictureBox1.Location = new System.Drawing.Point(56, 36);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(217, 57);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // KorisnickoImeTextBox
            // 
            this.KorisnickoImeTextBox.Location = new System.Drawing.Point(56, 165);
            this.KorisnickoImeTextBox.Name = "KorisnickoImeTextBox";
            this.KorisnickoImeTextBox.Size = new System.Drawing.Size(217, 20);
            this.KorisnickoImeTextBox.TabIndex = 1;
            this.KorisnickoImeTextBox.Text = "administrator1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(53, 149);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Korisničko ime";
            // 
            // LozinkaTextBox
            // 
            this.LozinkaTextBox.Location = new System.Drawing.Point(56, 216);
            this.LozinkaTextBox.Name = "LozinkaTextBox";
            this.LozinkaTextBox.Size = new System.Drawing.Size(217, 20);
            this.LozinkaTextBox.TabIndex = 3;
            this.LozinkaTextBox.Text = "test";
            this.LozinkaTextBox.UseSystemPasswordChar = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(53, 200);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Lozinka";
            // 
            // PrijavaButton
            // 
            this.PrijavaButton.Location = new System.Drawing.Point(199, 272);
            this.PrijavaButton.Name = "PrijavaButton";
            this.PrijavaButton.Size = new System.Drawing.Size(75, 30);
            this.PrijavaButton.TabIndex = 5;
            this.PrijavaButton.Text = "Prijava";
            this.PrijavaButton.UseVisualStyleBackColor = true;
            this.PrijavaButton.Click += new System.EventHandler(this.PrijavaButton_Click);
            // 
            // PrijavaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(328, 359);
            this.Controls.Add(this.PrijavaButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.LozinkaTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.KorisnickoImeTextBox);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "PrijavaForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Prijava - myBooks";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox KorisnickoImeTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox LozinkaTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button PrijavaButton;
    }
}

