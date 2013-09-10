namespace IKZavrsni
{
    partial class VrsteRashoda
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VrsteRashoda));
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listViewVrsteRashoda = new System.Windows.Forms.ListView();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.dodaj = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.nazivDodaj = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.nazivPromjena = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.izmijeni = new System.Windows.Forms.Button();
            this.obrisi = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.BackColor = System.Drawing.Color.White;
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 329);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(500, 22);
            this.statusStrip1.TabIndex = 7;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.ForeColor = System.Drawing.Color.Red;
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(0, 17);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Naziv";
            this.columnHeader1.Width = 206;
            // 
            // listViewVrsteRashoda
            // 
            this.listViewVrsteRashoda.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.listViewVrsteRashoda.AllowColumnReorder = true;
            this.listViewVrsteRashoda.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1});
            this.listViewVrsteRashoda.FullRowSelect = true;
            this.listViewVrsteRashoda.GridLines = true;
            this.listViewVrsteRashoda.Location = new System.Drawing.Point(10, 19);
            this.listViewVrsteRashoda.MultiSelect = false;
            this.listViewVrsteRashoda.Name = "listViewVrsteRashoda";
            this.listViewVrsteRashoda.Size = new System.Drawing.Size(211, 283);
            this.listViewVrsteRashoda.Sorting = System.Windows.Forms.SortOrder.Descending;
            this.listViewVrsteRashoda.TabIndex = 6;
            this.listViewVrsteRashoda.UseCompatibleStateImageBehavior = false;
            this.listViewVrsteRashoda.View = System.Windows.Forms.View.Details;
            this.listViewVrsteRashoda.ItemActivate += new System.EventHandler(this.listViewVrsteRashoda_ItemActivate);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // dodaj
            // 
            this.dodaj.Location = new System.Drawing.Point(146, 60);
            this.dodaj.Name = "dodaj";
            this.dodaj.Size = new System.Drawing.Size(75, 23);
            this.dodaj.TabIndex = 11;
            this.dodaj.Text = "Dodaj";
            this.dodaj.UseVisualStyleBackColor = true;
            this.dodaj.Click += new System.EventHandler(this.dodaj_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Naziv:";
            // 
            // nazivDodaj
            // 
            this.nazivDodaj.Location = new System.Drawing.Point(59, 34);
            this.nazivDodaj.Name = "nazivDodaj";
            this.nazivDodaj.Size = new System.Drawing.Size(162, 20);
            this.nazivDodaj.TabIndex = 14;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.nazivDodaj);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.dodaj);
            this.groupBox1.Location = new System.Drawing.Point(251, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(237, 92);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dodaj novu vrstu rashoda";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.obrisi);
            this.groupBox2.Controls.Add(this.izmijeni);
            this.groupBox2.Controls.Add(this.nazivPromjena);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Location = new System.Drawing.Point(250, 110);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(238, 107);
            this.groupBox2.TabIndex = 17;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Izmijeni postojeću vrstu rashoda";
            // 
            // nazivPromjena
            // 
            this.nazivPromjena.Location = new System.Drawing.Point(59, 34);
            this.nazivPromjena.Name = "nazivPromjena";
            this.nazivPromjena.Size = new System.Drawing.Size(162, 20);
            this.nazivPromjena.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 37);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Naziv:";
            // 
            // izmijeni
            // 
            this.izmijeni.Location = new System.Drawing.Point(146, 60);
            this.izmijeni.Name = "izmijeni";
            this.izmijeni.Size = new System.Drawing.Size(75, 23);
            this.izmijeni.TabIndex = 18;
            this.izmijeni.Text = "Izmijeni";
            this.izmijeni.UseVisualStyleBackColor = true;
            this.izmijeni.Click += new System.EventHandler(this.izmijeni_Click);
            // 
            // obrisi
            // 
            this.obrisi.Location = new System.Drawing.Point(65, 60);
            this.obrisi.Name = "obrisi";
            this.obrisi.Size = new System.Drawing.Size(75, 23);
            this.obrisi.TabIndex = 19;
            this.obrisi.Text = "Izbriši";
            this.obrisi.UseVisualStyleBackColor = true;
            this.obrisi.Click += new System.EventHandler(this.obrisi_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.listViewVrsteRashoda);
            this.groupBox3.Location = new System.Drawing.Point(12, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(232, 312);
            this.groupBox3.TabIndex = 18;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Rashodi";
            // 
            // VrsteRashoda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 351);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.statusStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "VrsteRashoda";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Vrste rashoda";
            this.Load += new System.EventHandler(this.VrsteRashoda_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ListView listViewVrsteRashoda;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Button dodaj;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox nazivDodaj;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button izmijeni;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox nazivPromjena;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button obrisi;
        private System.Windows.Forms.GroupBox groupBox3;
    }
}