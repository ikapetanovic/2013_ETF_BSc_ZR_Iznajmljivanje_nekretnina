namespace IKZavrsni
{
    partial class PregledNekretnina
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PregledNekretnina));
            this.atributPretrazivanjaComboBox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.nekretnineListView = new System.Windows.Forms.ListView();
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pretraziButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.unesenoTextBox = new System.Windows.Forms.TextBox();
            this.izmijeniButton1 = new System.Windows.Forms.Button();
            this.dodajDioZaIznajmljivanje = new System.Windows.Forms.Button();
            this.brisiNekretninuButton = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.brisi2 = new System.Windows.Forms.Button();
            this.izmijeniButton2 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // atributPretrazivanjaComboBox
            // 
            this.atributPretrazivanjaComboBox.BackColor = System.Drawing.SystemColors.Control;
            this.atributPretrazivanjaComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.atributPretrazivanjaComboBox.FormattingEnabled = true;
            this.atributPretrazivanjaComboBox.Items.AddRange(new object[] {
            "Adresi",
            "Nazivu",
            "Lokaciji",
            "Vrsti"});
            this.atributPretrazivanjaComboBox.Location = new System.Drawing.Point(106, 22);
            this.atributPretrazivanjaComboBox.Name = "atributPretrazivanjaComboBox";
            this.atributPretrazivanjaComboBox.Size = new System.Drawing.Size(151, 21);
            this.atributPretrazivanjaComboBox.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(175, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Pregled informacija o nekretninama:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Pretraživanje po:";
            // 
            // statusStrip1
            // 
            this.statusStrip1.BackColor = System.Drawing.Color.Transparent;
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 546);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(625, 22);
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
            this.columnHeader1.Width = 147;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Adresa";
            this.columnHeader2.Width = 137;
            // 
            // nekretnineListView
            // 
            this.nekretnineListView.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.nekretnineListView.AllowColumnReorder = true;
            this.nekretnineListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader6});
            this.nekretnineListView.FullRowSelect = true;
            this.nekretnineListView.GridLines = true;
            this.nekretnineListView.Location = new System.Drawing.Point(15, 100);
            this.nekretnineListView.MultiSelect = false;
            this.nekretnineListView.Name = "nekretnineListView";
            this.nekretnineListView.Size = new System.Drawing.Size(598, 172);
            this.nekretnineListView.Sorting = System.Windows.Forms.SortOrder.Descending;
            this.nekretnineListView.TabIndex = 6;
            this.nekretnineListView.UseCompatibleStateImageBehavior = false;
            this.nekretnineListView.View = System.Windows.Forms.View.Details;
            this.nekretnineListView.ItemActivate += new System.EventHandler(this.nekretnineListView_ItemActivate);
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Lokacija";
            this.columnHeader3.Width = 175;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Vrsta";
            this.columnHeader6.Width = 135;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pretraziButton);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.atributPretrazivanjaComboBox);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.unesenoTextBox);
            this.groupBox1.Location = new System.Drawing.Point(15, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(598, 59);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Pretraživanje";
            // 
            // pretraziButton
            // 
            this.pretraziButton.Location = new System.Drawing.Point(507, 22);
            this.pretraziButton.Name = "pretraziButton";
            this.pretraziButton.Size = new System.Drawing.Size(75, 23);
            this.pretraziButton.TabIndex = 10;
            this.pretraziButton.Text = "Pretraži";
            this.pretraziButton.UseVisualStyleBackColor = true;
            this.pretraziButton.Click += new System.EventHandler(this.pretraziButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(285, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Unesi:";
            // 
            // unesenoTextBox
            // 
            this.unesenoTextBox.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.unesenoTextBox.Location = new System.Drawing.Point(328, 23);
            this.unesenoTextBox.Name = "unesenoTextBox";
            this.unesenoTextBox.Size = new System.Drawing.Size(147, 20);
            this.unesenoTextBox.TabIndex = 3;
            // 
            // izmijeniButton1
            // 
            this.izmijeniButton1.Location = new System.Drawing.Point(15, 278);
            this.izmijeniButton1.Name = "izmijeniButton1";
            this.izmijeniButton1.Size = new System.Drawing.Size(75, 23);
            this.izmijeniButton1.TabIndex = 15;
            this.izmijeniButton1.Text = "Izmijeni";
            this.izmijeniButton1.UseVisualStyleBackColor = true;
            this.izmijeniButton1.Click += new System.EventHandler(this.izmijeniButton1_Click);
            // 
            // dodajDioZaIznajmljivanje
            // 
            this.dodajDioZaIznajmljivanje.Location = new System.Drawing.Point(474, 278);
            this.dodajDioZaIznajmljivanje.Name = "dodajDioZaIznajmljivanje";
            this.dodajDioZaIznajmljivanje.Size = new System.Drawing.Size(139, 23);
            this.dodajDioZaIznajmljivanje.TabIndex = 28;
            this.dodajDioZaIznajmljivanje.Text = "Dodaj dio za iznajmljivanje";
            this.dodajDioZaIznajmljivanje.UseVisualStyleBackColor = true;
            this.dodajDioZaIznajmljivanje.Click += new System.EventHandler(this.dodajDio_Click);
            // 
            // brisiNekretninuButton
            // 
            this.brisiNekretninuButton.Location = new System.Drawing.Point(97, 278);
            this.brisiNekretninuButton.Name = "brisiNekretninuButton";
            this.brisiNekretninuButton.Size = new System.Drawing.Size(75, 23);
            this.brisiNekretninuButton.TabIndex = 29;
            this.brisiNekretninuButton.Text = "Briši";
            this.brisiNekretninuButton.UseVisualStyleBackColor = true;
            this.brisiNekretninuButton.Click += new System.EventHandler(this.brisiNekretninuButton_Click);
            // 
            // listView1
            // 
            this.listView1.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.listView1.AllowColumnReorder = true;
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader7});
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.Location = new System.Drawing.Point(15, 331);
            this.listView1.MultiSelect = false;
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(598, 172);
            this.listView1.Sorting = System.Windows.Forms.SortOrder.Descending;
            this.listView1.TabIndex = 30;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Naziv";
            this.columnHeader4.Width = 243;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Status";
            this.columnHeader5.Width = 192;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Iznos najma";
            this.columnHeader7.Width = 159;
            // 
            // brisi2
            // 
            this.brisi2.Location = new System.Drawing.Point(97, 509);
            this.brisi2.Name = "brisi2";
            this.brisi2.Size = new System.Drawing.Size(75, 23);
            this.brisi2.TabIndex = 32;
            this.brisi2.Text = "Briši";
            this.brisi2.UseVisualStyleBackColor = true;
            // 
            // izmijeniButton2
            // 
            this.izmijeniButton2.Location = new System.Drawing.Point(15, 509);
            this.izmijeniButton2.Name = "izmijeniButton2";
            this.izmijeniButton2.Size = new System.Drawing.Size(75, 23);
            this.izmijeniButton2.TabIndex = 31;
            this.izmijeniButton2.Text = "Izmijeni";
            this.izmijeniButton2.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 315);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(210, 13);
            this.label4.TabIndex = 33;
            this.label4.Text = "Pregled informacija o dijelovima nekretnine:";
            // 
            // PregledNekretnina
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(625, 568);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.brisi2);
            this.Controls.Add(this.izmijeniButton2);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.brisiNekretninuButton);
            this.Controls.Add(this.dodajDioZaIznajmljivanje);
            this.Controls.Add(this.izmijeniButton1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.nekretnineListView);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "PregledNekretnina";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pregled nekretnina";
            this.Load += new System.EventHandler(this.PregledNekretnina_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox atributPretrazivanjaComboBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ListView nekretnineListView;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox unesenoTextBox;
        private System.Windows.Forms.Button izmijeniButton1;
        private System.Windows.Forms.Button dodajDioZaIznajmljivanje;
        private System.Windows.Forms.Button brisiNekretninuButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button brisi2;
        private System.Windows.Forms.Button izmijeniButton2;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.Button pretraziButton;
    }
}