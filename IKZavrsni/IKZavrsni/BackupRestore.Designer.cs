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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.statusStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(94, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Export baze u:";
            // 
            // backupTextBox
            // 
            this.backupTextBox.Location = new System.Drawing.Point(94, 35);
            this.backupTextBox.Name = "backupTextBox";
            this.backupTextBox.Size = new System.Drawing.Size(351, 20);
            this.backupTextBox.TabIndex = 1;
            // 
            // browse1
            // 
            this.browse1.Location = new System.Drawing.Point(451, 35);
            this.browse1.Name = "browse1";
            this.browse1.Size = new System.Drawing.Size(75, 23);
            this.browse1.TabIndex = 2;
            this.browse1.Text = "Pregledaj...";
            this.browse1.UseVisualStyleBackColor = true;
            this.browse1.Click += new System.EventHandler(this.browse1_Click);
            // 
            // backup
            // 
            this.backup.Location = new System.Drawing.Point(93, 83);
            this.backup.Name = "backup";
            this.backup.Size = new System.Drawing.Size(75, 23);
            this.backup.TabIndex = 3;
            this.backup.Text = "Export";
            this.backup.UseVisualStyleBackColor = true;
            this.backup.Click += new System.EventHandler(this.backup_Click);
            // 
            // restore
            // 
            this.restore.Location = new System.Drawing.Point(93, 83);
            this.restore.Name = "restore";
            this.restore.Size = new System.Drawing.Size(75, 23);
            this.restore.TabIndex = 7;
            this.restore.Text = "Import";
            this.restore.UseVisualStyleBackColor = true;
            this.restore.Click += new System.EventHandler(this.restore_Click);
            // 
            // browse2
            // 
            this.browse2.Location = new System.Drawing.Point(451, 35);
            this.browse2.Name = "browse2";
            this.browse2.Size = new System.Drawing.Size(75, 23);
            this.browse2.TabIndex = 6;
            this.browse2.Text = "Pregledaj...";
            this.browse2.UseVisualStyleBackColor = true;
            this.browse2.Click += new System.EventHandler(this.browse2_Click);
            // 
            // restoreTextBox
            // 
            this.restoreTextBox.Location = new System.Drawing.Point(93, 35);
            this.restoreTextBox.Name = "restoreTextBox";
            this.restoreTextBox.Size = new System.Drawing.Size(352, 20);
            this.restoreTextBox.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(90, 19);
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
            this.statusStrip1.Location = new System.Drawing.Point(0, 279);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(569, 22);
            this.statusStrip1.TabIndex = 8;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(0, 17);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.backupTextBox);
            this.groupBox1.Controls.Add(this.backup);
            this.groupBox1.Controls.Add(this.browse1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(545, 121);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Backup";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.pictureBox2);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.restoreTextBox);
            this.groupBox2.Controls.Add(this.restore);
            this.groupBox2.Controls.Add(this.browse2);
            this.groupBox2.Location = new System.Drawing.Point(12, 139);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(545, 121);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Restore";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = global::IKZavrsni.Properties.Resources.restoreDB;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox2.Location = new System.Drawing.Point(6, 19);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(82, 87);
            this.pictureBox2.TabIndex = 8;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::IKZavrsni.Properties.Resources.backupDB;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox1.Location = new System.Drawing.Point(6, 19);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(82, 87);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // BackupRestore
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(569, 301);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.statusStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "BackupRestore";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Backup i restore";
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
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
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}