﻿namespace IKZavrsni
{
    partial class MojProfil
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MojProfil));
            this.izadji = new System.Windows.Forms.Button();
            this.spasi = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.grad = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.adresa = new System.Windows.Forms.TextBox();
            this.mobilniTelefon = new System.Windows.Forms.MaskedTextBox();
            this.fiksniTelefon = new System.Windows.Forms.MaskedTextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.email = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.prezime = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.ime = new System.Windows.Forms.TextBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lozinka = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.korisnickoIme = new System.Windows.Forms.TextBox();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // izadji
            // 
            this.izadji.Location = new System.Drawing.Point(221, 345);
            this.izadji.Name = "izadji";
            this.izadji.Size = new System.Drawing.Size(75, 23);
            this.izadji.TabIndex = 22;
            this.izadji.Text = "Izađi";
            this.izadji.UseVisualStyleBackColor = true;
            this.izadji.Click += new System.EventHandler(this.izadji_Click);
            // 
            // spasi
            // 
            this.spasi.Location = new System.Drawing.Point(140, 345);
            this.spasi.Name = "spasi";
            this.spasi.Size = new System.Drawing.Size(75, 23);
            this.spasi.TabIndex = 21;
            this.spasi.Text = "Spasi";
            this.spasi.UseVisualStyleBackColor = true;
            this.spasi.Click += new System.EventHandler(this.spasi_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.grad);
            this.groupBox5.Controls.Add(this.label9);
            this.groupBox5.Controls.Add(this.label10);
            this.groupBox5.Controls.Add(this.adresa);
            this.groupBox5.Controls.Add(this.mobilniTelefon);
            this.groupBox5.Controls.Add(this.fiksniTelefon);
            this.groupBox5.Controls.Add(this.label12);
            this.groupBox5.Controls.Add(this.email);
            this.groupBox5.Controls.Add(this.label13);
            this.groupBox5.Controls.Add(this.label14);
            this.groupBox5.Location = new System.Drawing.Point(12, 96);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(284, 159);
            this.groupBox5.TabIndex = 19;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Kontaktni podaci";
            // 
            // grad
            // 
            this.grad.Location = new System.Drawing.Point(97, 127);
            this.grad.Name = "grad";
            this.grad.Size = new System.Drawing.Size(165, 20);
            this.grad.TabIndex = 19;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(48, 104);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(43, 13);
            this.label9.TabIndex = 16;
            this.label9.Text = "Adresa:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(58, 130);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(33, 13);
            this.label10.TabIndex = 17;
            this.label10.Text = "Grad:";
            // 
            // adresa
            // 
            this.adresa.Location = new System.Drawing.Point(97, 97);
            this.adresa.Name = "adresa";
            this.adresa.Size = new System.Drawing.Size(165, 20);
            this.adresa.TabIndex = 18;
            // 
            // mobilniTelefon
            // 
            this.mobilniTelefon.Location = new System.Drawing.Point(97, 71);
            this.mobilniTelefon.Mask = "(999) 000-0000";
            this.mobilniTelefon.Name = "mobilniTelefon";
            this.mobilniTelefon.Size = new System.Drawing.Size(78, 20);
            this.mobilniTelefon.TabIndex = 15;
            this.mobilniTelefon.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // fiksniTelefon
            // 
            this.fiksniTelefon.Location = new System.Drawing.Point(97, 45);
            this.fiksniTelefon.Mask = "(999) 000-0000";
            this.fiksniTelefon.Name = "fiksniTelefon";
            this.fiksniTelefon.Size = new System.Drawing.Size(78, 20);
            this.fiksniTelefon.TabIndex = 14;
            this.fiksniTelefon.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(19, 48);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(72, 13);
            this.label12.TabIndex = 5;
            this.label12.Text = "Fiksni telefon:";
            // 
            // email
            // 
            this.email.Location = new System.Drawing.Point(97, 19);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(165, 20);
            this.email.TabIndex = 13;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(13, 74);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(78, 13);
            this.label13.TabIndex = 6;
            this.label13.Text = "Mobilni telefon:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(56, 22);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(35, 13);
            this.label14.TabIndex = 7;
            this.label14.Text = "Email:";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.prezime);
            this.groupBox6.Controls.Add(this.label15);
            this.groupBox6.Controls.Add(this.label16);
            this.groupBox6.Controls.Add(this.ime);
            this.groupBox6.Location = new System.Drawing.Point(12, 12);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(284, 78);
            this.groupBox6.TabIndex = 18;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Lični podaci";
            // 
            // prezime
            // 
            this.prezime.Location = new System.Drawing.Point(97, 45);
            this.prezime.Name = "prezime";
            this.prezime.Size = new System.Drawing.Size(165, 20);
            this.prezime.TabIndex = 3;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(44, 48);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(47, 13);
            this.label15.TabIndex = 2;
            this.label15.Text = "Prezime:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(64, 22);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(27, 13);
            this.label16.TabIndex = 1;
            this.label16.Text = "Ime:";
            // 
            // ime
            // 
            this.ime.Location = new System.Drawing.Point(97, 19);
            this.ime.Name = "ime";
            this.ime.Size = new System.Drawing.Size(165, 20);
            this.ime.TabIndex = 0;
            // 
            // statusStrip1
            // 
            this.statusStrip1.BackColor = System.Drawing.Color.Transparent;
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 377);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(307, 22);
            this.statusStrip1.TabIndex = 23;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(0, 17);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lozinka);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.korisnickoIme);
            this.groupBox1.Location = new System.Drawing.Point(12, 261);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(284, 78);
            this.groupBox1.TabIndex = 24;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Pristupni podaci";
            // 
            // lozinka
            // 
            this.lozinka.Location = new System.Drawing.Point(97, 45);
            this.lozinka.Name = "lozinka";
            this.lozinka.PasswordChar = '*';
            this.lozinka.Size = new System.Drawing.Size(165, 20);
            this.lozinka.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Lozinka:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Korisničko ime:";
            // 
            // korisnickoIme
            // 
            this.korisnickoIme.Location = new System.Drawing.Point(97, 19);
            this.korisnickoIme.Name = "korisnickoIme";
            this.korisnickoIme.Size = new System.Drawing.Size(165, 20);
            this.korisnickoIme.TabIndex = 0;
            // 
            // MojProfil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(307, 399);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.izadji);
            this.Controls.Add(this.spasi);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox6);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MojProfil";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Moj profil";
            this.Load += new System.EventHandler(this.MojiPodaci_Load);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button izadji;
        private System.Windows.Forms.Button spasi;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox email;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.TextBox prezime;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox ime;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox lozinka;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox korisnickoIme;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.MaskedTextBox mobilniTelefon;
        private System.Windows.Forms.MaskedTextBox fiksniTelefon;
        private System.Windows.Forms.TextBox grad;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox adresa;

    }
}