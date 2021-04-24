
namespace myBooks.Desktop
{
    partial class PocetnaForm
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
            this.MenuStrip = new System.Windows.Forms.MenuStrip();
            this.KnjigeMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.PrijedloziMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AutoriMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.JeziciMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ZanroviMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.IzdavackeKuceMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DrzaveMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.GradoviMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.IzvjestajiMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.najpopularnijeKnjigeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.najboljeOcjenjeneKnjigeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.najgoreOcjenjeneKnjigeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.najpopularnijiAutoriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.OdjavaMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.StatusStrip = new System.Windows.Forms.StatusStrip();
            this.PrijavljeniKorisnikLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.MenuStrip.SuspendLayout();
            this.StatusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // MenuStrip
            // 
            this.MenuStrip.ImageScalingSize = new System.Drawing.Size(28, 28);
            this.MenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.KnjigeMenuItem,
            this.PrijedloziMenuItem,
            this.AutoriMenuItem,
            this.JeziciMenuItem,
            this.ZanroviMenuItem,
            this.IzdavackeKuceMenuItem,
            this.DrzaveMenuItem,
            this.GradoviMenuItem,
            this.IzvjestajiMenuItem,
            this.OdjavaMenuItem});
            this.MenuStrip.Location = new System.Drawing.Point(0, 0);
            this.MenuStrip.Name = "MenuStrip";
            this.MenuStrip.Size = new System.Drawing.Size(1003, 24);
            this.MenuStrip.TabIndex = 0;
            this.MenuStrip.Text = "menuStrip1";
            // 
            // KnjigeMenuItem
            // 
            this.KnjigeMenuItem.Name = "KnjigeMenuItem";
            this.KnjigeMenuItem.Size = new System.Drawing.Size(52, 20);
            this.KnjigeMenuItem.Text = "Knjige";
            this.KnjigeMenuItem.Click += new System.EventHandler(this.KnjigeMenuItem_Click);
            // 
            // PrijedloziMenuItem
            // 
            this.PrijedloziMenuItem.Name = "PrijedloziMenuItem";
            this.PrijedloziMenuItem.Size = new System.Drawing.Size(67, 20);
            this.PrijedloziMenuItem.Text = "Prijedlozi";
            this.PrijedloziMenuItem.Click += new System.EventHandler(this.PrijedloziMenuItem_Click);
            // 
            // AutoriMenuItem
            // 
            this.AutoriMenuItem.Name = "AutoriMenuItem";
            this.AutoriMenuItem.Size = new System.Drawing.Size(52, 20);
            this.AutoriMenuItem.Text = "Autori";
            this.AutoriMenuItem.Click += new System.EventHandler(this.AutoriMenuItem_Click);
            // 
            // JeziciMenuItem
            // 
            this.JeziciMenuItem.Name = "JeziciMenuItem";
            this.JeziciMenuItem.Size = new System.Drawing.Size(46, 20);
            this.JeziciMenuItem.Text = "Jezici";
            this.JeziciMenuItem.Click += new System.EventHandler(this.JeziciMenuItem_Click);
            // 
            // ZanroviMenuItem
            // 
            this.ZanroviMenuItem.Name = "ZanroviMenuItem";
            this.ZanroviMenuItem.Size = new System.Drawing.Size(59, 20);
            this.ZanroviMenuItem.Text = "Žanrovi";
            this.ZanroviMenuItem.Click += new System.EventHandler(this.ZanroviMenuItem_Click);
            // 
            // IzdavackeKuceMenuItem
            // 
            this.IzdavackeKuceMenuItem.Name = "IzdavackeKuceMenuItem";
            this.IzdavackeKuceMenuItem.Size = new System.Drawing.Size(98, 20);
            this.IzdavackeKuceMenuItem.Text = "Izdavačke kuće";
            this.IzdavackeKuceMenuItem.Click += new System.EventHandler(this.IzdavackeKuceMenuItem_Click);
            // 
            // DrzaveMenuItem
            // 
            this.DrzaveMenuItem.Name = "DrzaveMenuItem";
            this.DrzaveMenuItem.Size = new System.Drawing.Size(54, 20);
            this.DrzaveMenuItem.Text = "Države";
            this.DrzaveMenuItem.Click += new System.EventHandler(this.DrzaveMenuItem_Click);
            // 
            // GradoviMenuItem
            // 
            this.GradoviMenuItem.Name = "GradoviMenuItem";
            this.GradoviMenuItem.Size = new System.Drawing.Size(60, 20);
            this.GradoviMenuItem.Text = "Gradovi";
            this.GradoviMenuItem.Click += new System.EventHandler(this.GradoviMenuItem_Click);
            // 
            // IzvjestajiMenuItem
            // 
            this.IzvjestajiMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.najpopularnijeKnjigeToolStripMenuItem,
            this.najboljeOcjenjeneKnjigeToolStripMenuItem,
            this.najgoreOcjenjeneKnjigeToolStripMenuItem,
            this.najpopularnijiAutoriToolStripMenuItem});
            this.IzvjestajiMenuItem.Name = "IzvjestajiMenuItem";
            this.IzvjestajiMenuItem.ShowShortcutKeys = false;
            this.IzvjestajiMenuItem.Size = new System.Drawing.Size(63, 20);
            this.IzvjestajiMenuItem.Text = "Izvještaji";
            // 
            // najpopularnijeKnjigeToolStripMenuItem
            // 
            this.najpopularnijeKnjigeToolStripMenuItem.Name = "najpopularnijeKnjigeToolStripMenuItem";
            this.najpopularnijeKnjigeToolStripMenuItem.Size = new System.Drawing.Size(208, 22);
            this.najpopularnijeKnjigeToolStripMenuItem.Text = "Najpopularnije knjige";
            this.najpopularnijeKnjigeToolStripMenuItem.Click += new System.EventHandler(this.NajpopularnijeKnjigeMenuItem_Click);
            // 
            // najboljeOcjenjeneKnjigeToolStripMenuItem
            // 
            this.najboljeOcjenjeneKnjigeToolStripMenuItem.Name = "najboljeOcjenjeneKnjigeToolStripMenuItem";
            this.najboljeOcjenjeneKnjigeToolStripMenuItem.Size = new System.Drawing.Size(208, 22);
            this.najboljeOcjenjeneKnjigeToolStripMenuItem.Text = "Najbolje ocjenjene knjige";
            this.najboljeOcjenjeneKnjigeToolStripMenuItem.Click += new System.EventHandler(this.NajboljeOcjenjeneKnjigeMenuItem_Click);
            // 
            // najgoreOcjenjeneKnjigeToolStripMenuItem
            // 
            this.najgoreOcjenjeneKnjigeToolStripMenuItem.Name = "najgoreOcjenjeneKnjigeToolStripMenuItem";
            this.najgoreOcjenjeneKnjigeToolStripMenuItem.Size = new System.Drawing.Size(208, 22);
            this.najgoreOcjenjeneKnjigeToolStripMenuItem.Text = "Najlošije ocjenjene knjige";
            this.najgoreOcjenjeneKnjigeToolStripMenuItem.Click += new System.EventHandler(this.NajgoreOcjenjeneKnjigeMenuItem_Click);
            // 
            // najpopularnijiAutoriToolStripMenuItem
            // 
            this.najpopularnijiAutoriToolStripMenuItem.Name = "najpopularnijiAutoriToolStripMenuItem";
            this.najpopularnijiAutoriToolStripMenuItem.Size = new System.Drawing.Size(208, 22);
            this.najpopularnijiAutoriToolStripMenuItem.Text = "Najpopularniji autori";
            this.najpopularnijiAutoriToolStripMenuItem.Click += new System.EventHandler(this.NajpopularnijiAutoriMenuItem_Click);
            // 
            // OdjavaMenuItem
            // 
            this.OdjavaMenuItem.Name = "OdjavaMenuItem";
            this.OdjavaMenuItem.Size = new System.Drawing.Size(56, 20);
            this.OdjavaMenuItem.Text = "Odjava";
            this.OdjavaMenuItem.Click += new System.EventHandler(this.OdjavaMenuItem_Click);
            // 
            // StatusStrip
            // 
            this.StatusStrip.ImageScalingSize = new System.Drawing.Size(28, 28);
            this.StatusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.PrijavljeniKorisnikLabel});
            this.StatusStrip.Location = new System.Drawing.Point(0, 519);
            this.StatusStrip.Name = "StatusStrip";
            this.StatusStrip.Size = new System.Drawing.Size(1003, 22);
            this.StatusStrip.TabIndex = 2;
            this.StatusStrip.Text = "statusStrip1";
            // 
            // PrijavljeniKorisnikLabel
            // 
            this.PrijavljeniKorisnikLabel.Name = "PrijavljeniKorisnikLabel";
            this.PrijavljeniKorisnikLabel.Size = new System.Drawing.Size(128, 17);
            this.PrijavljeniKorisnikLabel.Text = "PrijavljeniKorisnikLabel";
            // 
            // PocetnaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1003, 541);
            this.Controls.Add(this.StatusStrip);
            this.Controls.Add(this.MenuStrip);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.MenuStrip;
            this.Name = "PocetnaForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Početna - myBooks";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.PocetnaForm_Load);
            this.MenuStrip.ResumeLayout(false);
            this.MenuStrip.PerformLayout();
            this.StatusStrip.ResumeLayout(false);
            this.StatusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip MenuStrip;
        private System.Windows.Forms.ToolStripMenuItem OdjavaMenuItem;
        private System.Windows.Forms.ToolStripMenuItem DrzaveMenuItem;
        private System.Windows.Forms.ToolStripMenuItem IzvjestajiMenuItem;
        private System.Windows.Forms.ToolStripMenuItem GradoviMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AutoriMenuItem;
        private System.Windows.Forms.ToolStripMenuItem JeziciMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ZanroviMenuItem;
        private System.Windows.Forms.ToolStripMenuItem IzdavackeKuceMenuItem;
        private System.Windows.Forms.ToolStripMenuItem KnjigeMenuItem;
        private System.Windows.Forms.StatusStrip StatusStrip;
        private System.Windows.Forms.ToolStripStatusLabel PrijavljeniKorisnikLabel;
        private System.Windows.Forms.ToolStripMenuItem PrijedloziMenuItem;
        private System.Windows.Forms.ToolStripMenuItem najpopularnijeKnjigeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem najboljeOcjenjeneKnjigeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem najgoreOcjenjeneKnjigeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem najpopularnijiAutoriToolStripMenuItem;
    }
}