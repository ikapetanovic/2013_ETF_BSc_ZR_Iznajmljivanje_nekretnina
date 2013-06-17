namespace IKZavrsni
{
    partial class BackupRestore
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BackupRestore));
            this.label1 = new System.Windows.Forms.Label();
            this.backupTextBox = new System.Windows.Forms.TextBox();
            this.browse1 = new System.Windows.Forms.Button();
            this.backup = new System.Windows.Forms.Button();
            this.restore = new System.Windows.Forms.Button();
            this.browse2 = new System.Windows.Forms.Button();
            this.restoreTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(100, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Export baze u:";
            // 
            // backupTextBox
            // 
            this.backupTextBox.Location = new System.Drawing.Point(100, 31);
            this.backupTextBox.Name = "backupTextBox";
            this.backupTextBox.Size = new System.Drawing.Size(315, 20);
            this.backupTextBox.TabIndex = 1;
            // 
            // browse1
            // 
            this.browse1.Location = new System.Drawing.Point(421, 31);
            this.browse1.Name = "browse1";
            this.browse1.Size = new System.Drawing.Size(75, 23);
            this.browse1.TabIndex = 2;
            this.browse1.Text = "Pregledaj...";
            this.browse1.UseVisualStyleBackColor = true;
            this.browse1.Click += new System.EventHandler(this.browse1_Click);
            // 
            // backup
            // 
            this.backup.Location = new System.Drawing.Point(99, 79);
            this.backup.Name = "backup";
            this.backup.Size = new System.Drawing.Size(75, 23);
            this.backup.TabIndex = 3;
            this.backup.Text = "Export";
            this.backup.UseVisualStyleBackColor = true;
            this.backup.Click += new System.EventHandler(this.backup_Click);
            // 
            // restore
            // 
            this.restore.Location = new System.Drawing.Point(100, 79);
            this.restore.Name = "restore";
            this.restore.Size = new System.Drawing.Size(75, 23);
            this.restore.TabIndex = 7;
            this.restore.Text = "Import";
            this.restore.UseVisualStyleBackColor = true;
            this.restore.Click += new System.EventHandler(this.restore_Click);
            // 
            // browse2
            // 
            this.browse2.Location = new System.Drawing.Point(422, 37);
            this.browse2.Name = "browse2";
            this.browse2.Size = new System.Drawing.Size(75, 23);
            this.browse2.TabIndex = 6;
            this.browse2.Text = "Pregledaj...";
            this.browse2.UseVisualStyleBackColor = true;
            this.browse2.Click += new System.EventHandler(this.browse2_Click);
            // 
            // restoreTextBox
            // 
            this.restoreTextBox.Location = new System.Drawing.Point(100, 40);
            this.restoreTextBox.Name = "restoreTextBox";
            this.restoreTextBox.Size = new System.Drawing.Size(316, 20);
            this.restoreTextBox.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(101, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Import baze iz:";
            // 
            // statusStrip1
            // 
            this.statusStrip1.BackColor = System.Drawing.SystemColors.Window;
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 185);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(551, 22);
            this.statusStrip1.TabIndex = 8;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(0, 17);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::IKZavrsni.Properties.Resources.backup;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox1.Location = new System.Drawing.Point(12, 15);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(82, 87);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = global::IKZavrsni.Properties.Resources.restore;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox2.Location = new System.Drawing.Point(13, 15);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(82, 87);
            this.pictureBox2.TabIndex = 8;
            this.pictureBox2.TabStop = false;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(530, 152);
            this.tabControl1.TabIndex = 11;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage1.Controls.Add(this.pictureBox1);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.backup);
            this.tabPage1.Controls.Add(this.browse1);
            this.tabPage1.Controls.Add(this.backupTextBox);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(522, 126);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Backup";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage2.Controls.Add(this.pictureBox2);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.restore);
            this.tabPage2.Controls.Add(this.browse2);
            this.tabPage2.Controls.Add(this.restoreTextBox);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(522, 126);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Restore";
            // 
            // BackupRestore
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(551, 207);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.statusStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "BackupRestore";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Backup i restore";
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox backupTextBox;
        private System.Windows.Forms.Button browse1;
        private System.Windows.Forms.Button backup;
        private System.Windows.Forms.Button restore;
        private System.Windows.Forms.Button browse2;
        private System.Windows.Forms.TextBox restoreTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
    }
}