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
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dodajDioButton = new System.Windows.Forms.Button();
            this.brisiNekretninuButton = new System.Windows.Forms.Button();
            this.izmijeniButton1 = new System.Windows.Forms.Button();
            this.nekretnineListView = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.pretraziButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.unesenoTextBox = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.brisiDioNekretnineButton = new System.Windows.Forms.Button();
            this.izmijeniButton2 = new System.Windows.Forms.Button();
            this.dijeloviNekretnineListView = new System.Windows.Forms.ListView();
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // atributPretrazivanjaComboBox
            // 
            this.atributPretrazivanjaComboBox.BackColor = System.Drawing.SystemColors.Control;
            this.atributPretrazivanjaComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.atributPretrazivanjaComboBox.FormattingEnabled = true;
            this.atributPretrazivanjaComboBox.Items.AddRange(new object[] {
            "Adresa",
            "Naziv",
            "Lokacija"});
            this.atributPretrazivanjaComboBox.Location = new System.Drawing.Point(12, 31);
            this.atributPretrazivanjaComboBox.Name = "atributPretrazivanjaComboBox";
            this.atributPretrazivanjaComboBox.Size = new System.Drawing.Size(171, 21);
            this.atributPretrazivanjaComboBox.TabIndex = 2;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dodajDioButton);
            this.groupBox1.Controls.Add(this.brisiNekretninuButton);
            this.groupBox1.Controls.Add(this.izmijeniButton1);
            this.groupBox1.Controls.Add(this.nekretnineListView);
            this.groupBox1.Location = new System.Drawing.Point(15, 87);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(598, 256);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Nekretnine";
            // 
            // dodajDioButton
            // 
            this.dodajDioButton.Location = new System.Drawing.Point(9, 227);
            this.dodajDioButton.Name = "dodajDioButton";
            this.dodajDioButton.Size = new System.Drawing.Size(174, 23);
            this.dodajDioButton.TabIndex = 35;
            this.dodajDioButton.Text = "Dodaj dio za iznajmljivanje";
            this.dodajDioButton.UseVisualStyleBackColor = true;
            this.dodajDioButton.Click += new System.EventHandler(this.dodajDioButton_Click);
            // 
            // brisiNekretninuButton
            // 
            this.brisiNekretninuButton.Location = new System.Drawing.Point(507, 227);
            this.brisiNekretninuButton.Name = "brisiNekretninuButton";
            this.brisiNekretninuButton.Size = new System.Drawing.Size(75, 23);
            this.brisiNekretninuButton.TabIndex = 33;
            this.brisiNekretninuButton.Text = "Briši";
            this.brisiNekretninuButton.UseVisualStyleBackColor = true;
            this.brisiNekretninuButton.Click += new System.EventHandler(this.brisiNekretninuButton_Click_1);
            // 
            // izmijeniButton1
            // 
            this.izmijeniButton1.Location = new System.Drawing.Point(428, 227);
            this.izmijeniButton1.Name = "izmijeniButton1";
            this.izmijeniButton1.Size = new System.Drawing.Size(75, 23);
            this.izmijeniButton1.TabIndex = 32;
            this.izmijeniButton1.Text = "Izmijeni";
            this.izmijeniButton1.UseVisualStyleBackColor = true;
            this.izmijeniButton1.Click += new System.EventHandler(this.izmijeniButton1_Click_1);
            // 
            // nekretnineListView
            // 
            this.nekretnineListView.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.nekretnineListView.AllowColumnReorder = true;
            this.nekretnineListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.nekretnineListView.FullRowSelect = true;
            this.nekretnineListView.GridLines = true;
            this.nekretnineListView.Location = new System.Drawing.Point(9, 19);
            this.nekretnineListView.MultiSelect = false;
            this.nekretnineListView.Name = "nekretnineListView";
            this.nekretnineListView.Size = new System.Drawing.Size(573, 200);
            this.nekretnineListView.Sorting = System.Windows.Forms.SortOrder.Descending;
            this.nekretnineListView.TabIndex = 31;
            this.nekretnineListView.UseCompatibleStateImageBehavior = false;
            this.nekretnineListView.View = System.Windows.Forms.View.Details;
            this.nekretnineListView.ItemActivate += new System.EventHandler(this.nekretnineListView_ItemActivate_1);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Naziv";
            this.columnHeader1.Width = 171;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Adresa";
            this.columnHeader2.Width = 242;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Lokacija";
            this.columnHeader3.Width = 154;
            // 
            // pretraziButton
            // 
            this.pretraziButton.Location = new System.Drawing.Point(507, 29);
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
            this.label2.Location = new System.Drawing.Point(215, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Unesi:";
            // 
            // unesenoTextBox
            // 
            this.unesenoTextBox.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.unesenoTextBox.Location = new System.Drawing.Point(258, 32);
            this.unesenoTextBox.Name = "unesenoTextBox";
            this.unesenoTextBox.Size = new System.Drawing.Size(212, 20);
            this.unesenoTextBox.TabIndex = 3;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.brisiDioNekretnineButton);
            this.groupBox2.Controls.Add(this.izmijeniButton2);
            this.groupBox2.Controls.Add(this.dijeloviNekretnineListView);
            this.groupBox2.Location = new System.Drawing.Point(15, 349);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(598, 287);
            this.groupBox2.TabIndex = 34;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Dijelovi odabrane nekretnine";
            // 
            // brisiDioNekretnineButton
            // 
            this.brisiDioNekretnineButton.Location = new System.Drawing.Point(507, 253);
            this.brisiDioNekretnineButton.Name = "brisiDioNekretnineButton";
            this.brisiDioNekretnineButton.Size = new System.Drawing.Size(75, 23);
            this.brisiDioNekretnineButton.TabIndex = 42;
            this.brisiDioNekretnineButton.Text = "Briši";
            this.brisiDioNekretnineButton.UseVisualStyleBackColor = true;
            this.brisiDioNekretnineButton.Click += new System.EventHandler(this.brisiDioNekretnineButton_Click);
            // 
            // izmijeniButton2
            // 
            this.izmijeniButton2.Location = new System.Drawing.Point(428, 253);
            this.izmijeniButton2.Name = "izmijeniButton2";
            this.izmijeniButton2.Size = new System.Drawing.Size(75, 23);
            this.izmijeniButton2.TabIndex = 41;
            this.izmijeniButton2.Text = "Izmijeni";
            this.izmijeniButton2.UseVisualStyleBackColor = true;
            this.izmijeniButton2.Click += new System.EventHandler(this.izmijeniButton2_Click);
            // 
            // dijeloviNekretnineListView
            // 
            this.dijeloviNekretnineListView.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.dijeloviNekretnineListView.AllowColumnReorder = true;
            this.dijeloviNekretnineListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader7});
            this.dijeloviNekretnineListView.FullRowSelect = true;
            this.dijeloviNekretnineListView.GridLines = true;
            this.dijeloviNekretnineListView.Location = new System.Drawing.Point(12, 19);
            this.dijeloviNekretnineListView.MultiSelect = false;
            this.dijeloviNekretnineListView.Name = "dijeloviNekretnineListView";
            this.dijeloviNekretnineListView.Size = new System.Drawing.Size(573, 228);
            this.dijeloviNekretnineListView.Sorting = System.Windows.Forms.SortOrder.Descending;
            this.dijeloviNekretnineListView.TabIndex = 40;
            this.dijeloviNekretnineListView.UseCompatibleStateImageBehavior = false;
            this.dijeloviNekretnineListView.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Naziv";
            this.columnHeader4.Width = 243;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Status";
            this.columnHeader5.Width = 167;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Iznos najma";
            this.columnHeader7.Width = 159;
            // 
            // statusStrip1
            // 
            this.statusStrip1.BackColor = System.Drawing.Color.Transparent;
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 642);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(625, 22);
            this.statusStrip1.TabIndex = 35;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.ForeColor = System.Drawing.Color.Red;
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(0, 17);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.atributPretrazivanjaComboBox);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.unesenoTextBox);
            this.groupBox3.Controls.Add(this.pretraziButton);
            this.groupBox3.Location = new System.Drawing.Point(15, 15);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(598, 66);
            this.groupBox3.TabIndex = 36;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Pretraživanje";
            // 
            // PregledNekretnina
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(625, 664);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "PregledNekretnina";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pregled nekretnina";
            this.Load += new System.EventHandler(this.PregledNekretnina_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox atributPretrazivanjaComboBox;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox unesenoTextBox;
        private System.Windows.Forms.Button pretraziButton;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button brisiDioNekretnineButton;
        private System.Windows.Forms.Button izmijeniButton2;
        private System.Windows.Forms.ListView dijeloviNekretnineListView;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.Button brisiNekretninuButton;
        private System.Windows.Forms.Button izmijeniButton1;
        private System.Windows.Forms.ListView nekretnineListView;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button dodajDioButton;
    }
}