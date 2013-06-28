namespace IKZavrsni
{
    partial class PregledZakupaca
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PregledZakupaca));
            this.atribut = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.uneseno = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label3 = new System.Windows.Forms.Label();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listViewKnjiga = new System.Windows.Forms.ListView();
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.pretraziButton = new System.Windows.Forms.Button();
            this.iznajmiButton1 = new System.Windows.Forms.Button();
            this.iznajmiButton2 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // atribut
            // 
            this.atribut.BackColor = System.Drawing.SystemColors.Control;
            this.atribut.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.atribut.FormattingEnabled = true;
            this.atribut.Items.AddRange(new object[] {
            "Imenu",
            "Prezimenu",
            "Nazivu firme",
            "Fakultetu"});
            this.atribut.Location = new System.Drawing.Point(106, 26);
            this.atribut.Name = "atribut";
            this.atribut.Size = new System.Drawing.Size(164, 21);
            this.atribut.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 495);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 25;
            this.button1.Text = "Izmijeni";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(12, 275);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 24;
            this.button2.Text = "Izmijeni";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // uneseno
            // 
            this.uneseno.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.uneseno.Location = new System.Drawing.Point(336, 27);
            this.uneseno.Name = "uneseno";
            this.uneseno.Size = new System.Drawing.Size(136, 20);
            this.uneseno.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 312);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(177, 13);
            this.label4.TabIndex = 22;
            this.label4.Text = "Pregled informacija o pravnim licima:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(293, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Unesi:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pretraziButton);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.atribut);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.uneseno);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(600, 68);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Pretraživanje";
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
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // statusStrip1
            // 
            this.statusStrip1.BackColor = System.Drawing.Color.White;
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 527);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(624, 22);
            this.statusStrip1.TabIndex = 20;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.ForeColor = System.Drawing.Color.Red;
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(0, 17);
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Naziv firme";
            this.columnHeader6.Width = 120;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(174, 13);
            this.label3.TabIndex = 18;
            this.label3.Text = "Pregled informacija o fizičkim licima:";
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Ime";
            this.columnHeader1.Width = 108;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Fakultet";
            this.columnHeader5.Width = 137;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Prezime";
            this.columnHeader2.Width = 108;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Grad";
            this.columnHeader3.Width = 122;
            // 
            // listViewKnjiga
            // 
            this.listViewKnjiga.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.listViewKnjiga.AllowColumnReorder = true;
            this.listViewKnjiga.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader5,
            this.columnHeader6});
            this.listViewKnjiga.FullRowSelect = true;
            this.listViewKnjiga.GridLines = true;
            this.listViewKnjiga.Location = new System.Drawing.Point(12, 108);
            this.listViewKnjiga.MultiSelect = false;
            this.listViewKnjiga.Name = "listViewKnjiga";
            this.listViewKnjiga.Size = new System.Drawing.Size(600, 161);
            this.listViewKnjiga.Sorting = System.Windows.Forms.SortOrder.Descending;
            this.listViewKnjiga.TabIndex = 19;
            this.listViewKnjiga.UseCompatibleStateImageBehavior = false;
            this.listViewKnjiga.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Naziv firme";
            this.columnHeader4.Width = 200;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Adresa";
            this.columnHeader7.Width = 135;
            // 
            // listView1
            // 
            this.listView1.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.listView1.AllowColumnReorder = true;
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader4,
            this.columnHeader7,
            this.columnHeader8,
            this.columnHeader9});
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.Location = new System.Drawing.Point(12, 328);
            this.listView1.MultiSelect = false;
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(600, 161);
            this.listView1.Sorting = System.Windows.Forms.SortOrder.Descending;
            this.listView1.TabIndex = 23;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Ovlaštena osoba";
            this.columnHeader8.Width = 150;
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "Telefon";
            this.columnHeader9.Width = 111;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(93, 275);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 30;
            this.button4.Text = "Briši";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(93, 495);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 31;
            this.button3.Text = "Briši";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // pretraziButton
            // 
            this.pretraziButton.Location = new System.Drawing.Point(501, 27);
            this.pretraziButton.Name = "pretraziButton";
            this.pretraziButton.Size = new System.Drawing.Size(75, 23);
            this.pretraziButton.TabIndex = 10;
            this.pretraziButton.Text = "Pretraži";
            this.pretraziButton.UseVisualStyleBackColor = true;
            // 
            // iznajmiButton1
            // 
            this.iznajmiButton1.Location = new System.Drawing.Point(537, 275);
            this.iznajmiButton1.Name = "iznajmiButton1";
            this.iznajmiButton1.Size = new System.Drawing.Size(75, 23);
            this.iznajmiButton1.TabIndex = 32;
            this.iznajmiButton1.Text = "Iznajmi";
            this.iznajmiButton1.UseVisualStyleBackColor = true;
            // 
            // iznajmiButton2
            // 
            this.iznajmiButton2.Location = new System.Drawing.Point(537, 495);
            this.iznajmiButton2.Name = "iznajmiButton2";
            this.iznajmiButton2.Size = new System.Drawing.Size(75, 23);
            this.iznajmiButton2.TabIndex = 33;
            this.iznajmiButton2.Text = "Iznajmi";
            this.iznajmiButton2.UseVisualStyleBackColor = true;
            // 
            // PregledZakupaca
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 549);
            this.Controls.Add(this.iznajmiButton2);
            this.Controls.Add(this.iznajmiButton1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.listViewKnjiga);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "PregledZakupaca";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pregled zakupaca";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox atribut;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox uneseno;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListView listViewKnjiga;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button pretraziButton;
        private System.Windows.Forms.Button iznajmiButton2;
        private System.Windows.Forms.Button iznajmiButton1;
    }
}