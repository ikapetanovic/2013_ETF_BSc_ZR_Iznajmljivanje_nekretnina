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
            this.label3 = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listViewKnjiga = new System.Windows.Forms.ListView();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.dodaj = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.nazivDodaj = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cijenaDodaj = new System.Windows.Forms.NumericUpDown();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cijenaPromjena = new System.Windows.Forms.NumericUpDown();
            this.nazivPromjena = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.izmijeni = new System.Windows.Forms.Button();
            this.obrisi = new System.Windows.Forms.Button();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cijenaDodaj)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cijenaPromjena)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(189, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Pregled informacija o vrstama rashoda:";
            // 
            // statusStrip1
            // 
            this.statusStrip1.BackColor = System.Drawing.Color.White;
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 339);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(507, 22);
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
            this.columnHeader1.Width = 148;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Cijena";
            this.columnHeader2.Width = 85;
            // 
            // listViewKnjiga
            // 
            this.listViewKnjiga.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.listViewKnjiga.AllowColumnReorder = true;
            this.listViewKnjiga.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.listViewKnjiga.FullRowSelect = true;
            this.listViewKnjiga.GridLines = true;
            this.listViewKnjiga.Location = new System.Drawing.Point(15, 37);
            this.listViewKnjiga.MultiSelect = false;
            this.listViewKnjiga.Name = "listViewKnjiga";
            this.listViewKnjiga.Size = new System.Drawing.Size(237, 283);
            this.listViewKnjiga.Sorting = System.Windows.Forms.SortOrder.Descending;
            this.listViewKnjiga.TabIndex = 6;
            this.listViewKnjiga.UseCompatibleStateImageBehavior = false;
            this.listViewKnjiga.View = System.Windows.Forms.View.Details;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // dodaj
            // 
            this.dodaj.Location = new System.Drawing.Point(420, 143);
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
            this.label1.Location = new System.Drawing.Point(17, 34);
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Cijena:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cijenaDodaj);
            this.groupBox1.Controls.Add(this.nazivDodaj);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(258, 37);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(237, 100);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dodaj novu vrstu rashoda";
            // 
            // cijenaDodaj
            // 
            this.cijenaDodaj.Location = new System.Drawing.Point(138, 60);
            this.cijenaDodaj.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.cijenaDodaj.Name = "cijenaDodaj";
            this.cijenaDodaj.Size = new System.Drawing.Size(83, 20);
            this.cijenaDodaj.TabIndex = 16;
            this.cijenaDodaj.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.cijenaDodaj.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cijenaPromjena);
            this.groupBox2.Controls.Add(this.nazivPromjena);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Location = new System.Drawing.Point(258, 191);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(237, 100);
            this.groupBox2.TabIndex = 17;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Izmijeni postojeću vrstu rashoda";
            // 
            // cijenaPromjena
            // 
            this.cijenaPromjena.Location = new System.Drawing.Point(138, 60);
            this.cijenaPromjena.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.cijenaPromjena.Name = "cijenaPromjena";
            this.cijenaPromjena.ReadOnly = true;
            this.cijenaPromjena.Size = new System.Drawing.Size(83, 20);
            this.cijenaPromjena.TabIndex = 16;
            this.cijenaPromjena.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.cijenaPromjena.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // nazivPromjena
            // 
            this.nazivPromjena.Location = new System.Drawing.Point(59, 34);
            this.nazivPromjena.Name = "nazivPromjena";
            this.nazivPromjena.ReadOnly = true;
            this.nazivPromjena.Size = new System.Drawing.Size(162, 20);
            this.nazivPromjena.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 65);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "Cijena:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 34);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Naziv:";
            // 
            // izmijeni
            // 
            this.izmijeni.Location = new System.Drawing.Point(420, 297);
            this.izmijeni.Name = "izmijeni";
            this.izmijeni.Size = new System.Drawing.Size(75, 23);
            this.izmijeni.TabIndex = 18;
            this.izmijeni.Text = "Izmijeni";
            this.izmijeni.UseVisualStyleBackColor = true;
            // 
            // obrisi
            // 
            this.obrisi.Location = new System.Drawing.Point(339, 297);
            this.obrisi.Name = "obrisi";
            this.obrisi.Size = new System.Drawing.Size(75, 23);
            this.obrisi.TabIndex = 19;
            this.obrisi.Text = "Obriši";
            this.obrisi.UseVisualStyleBackColor = true;
            // 
            // VrsteRashoda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(507, 361);
            this.Controls.Add(this.obrisi);
            this.Controls.Add(this.izmijeni);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dodaj);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.listViewKnjiga);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "VrsteRashoda";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Vrste rashoda";
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cijenaDodaj)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cijenaPromjena)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ListView listViewKnjiga;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Button dodaj;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox nazivDodaj;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button izmijeni;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.NumericUpDown cijenaPromjena;
        private System.Windows.Forms.TextBox nazivPromjena;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown cijenaDodaj;
        private System.Windows.Forms.Button obrisi;
    }
}