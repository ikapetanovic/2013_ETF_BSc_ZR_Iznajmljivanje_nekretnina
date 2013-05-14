namespace IKZavrsni
{
    partial class Naplacivanje
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Naplacivanje));
            this.listViewKnjiga = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.atribut = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.uneseno = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listViewKnjiga
            // 
            this.listViewKnjiga.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.listViewKnjiga.AllowColumnReorder = true;
            this.listViewKnjiga.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader8,
            this.columnHeader9,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6});
            this.listViewKnjiga.FullRowSelect = true;
            this.listViewKnjiga.GridLines = true;
            this.listViewKnjiga.Location = new System.Drawing.Point(14, 112);
            this.listViewKnjiga.MultiSelect = false;
            this.listViewKnjiga.Name = "listViewKnjiga";
            this.listViewKnjiga.Size = new System.Drawing.Size(627, 227);
            this.listViewKnjiga.Sorting = System.Windows.Forms.SortOrder.Descending;
            this.listViewKnjiga.TabIndex = 7;
            this.listViewKnjiga.UseCompatibleStateImageBehavior = false;
            this.listViewKnjiga.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Nekretnina";
            this.columnHeader1.Width = 87;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Za platiti";
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Datum od";
            this.columnHeader8.Width = 107;
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "Datum do";
            this.columnHeader9.Width = 91;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Avans";
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Plaćeno";
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Datum plaćanja";
            this.columnHeader5.Width = 98;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Dug";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(487, 345);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "Spasi";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(566, 345);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 9;
            this.button2.Text = "Račun";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // statusStrip1
            // 
            this.statusStrip1.BackColor = System.Drawing.SystemColors.Window;
            this.statusStrip1.Location = new System.Drawing.Point(0, 381);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(656, 22);
            this.statusStrip1.TabIndex = 10;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Pregled informacija:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.atribut);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.uneseno);
            this.groupBox1.Location = new System.Drawing.Point(14, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(627, 62);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Pretraživanje";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(312, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Unesi:";
            // 
            // atribut
            // 
            this.atribut.BackColor = System.Drawing.SystemColors.Control;
            this.atribut.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.atribut.FormattingEnabled = true;
            this.atribut.Items.AddRange(new object[] {
            "Nazivu",
            "Adresi",
            "Lokaciji",
            "Vrsti"});
            this.atribut.Location = new System.Drawing.Point(106, 21);
            this.atribut.Name = "atribut";
            this.atribut.Size = new System.Drawing.Size(181, 21);
            this.atribut.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Pretraživanje po:";
            // 
            // uneseno
            // 
            this.uneseno.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.uneseno.Location = new System.Drawing.Point(355, 22);
            this.uneseno.Name = "uneseno";
            this.uneseno.Size = new System.Drawing.Size(193, 20);
            this.uneseno.TabIndex = 3;
            // 
            // Naplacivanje
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(656, 403);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.listViewKnjiga);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Naplacivanje";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Naplaćivanje";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listViewKnjiga;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox atribut;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox uneseno;

    }
}