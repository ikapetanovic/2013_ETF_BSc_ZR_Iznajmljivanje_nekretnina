using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using MySql.Data.MySqlClient;
using System.Diagnostics; // process
using System.IO; // stream

namespace IKZavrsni
{
    public partial class BackupRestore : Form
    {
        
        public BackupRestore()
        {
            InitializeComponent();
        }

        private void browse1_Click(object sender, EventArgs e)
        {
            try
            {
                SaveFileDialog save = new SaveFileDialog();
                save.Filter = "SQL files|*.sql";
                if (save.ShowDialog() == DialogResult.OK)
                {
                    backupTextBox.Text = save.FileName;
                }
            }
            catch (Exception)
            {
                throw new ApplicationException("Greška!");
            }
            
        }

        private void browse2_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog open = new OpenFileDialog();
                open.Filter = "SQL files|*.sql";
                if (open.ShowDialog() == DialogResult.OK)
                {
                    restoreTextBox.Text = open.FileName;
                }
            }
            catch (Exception)
            {
                throw new ApplicationException("Greška!");
            }
        }

        private void backup_Click(object sender, EventArgs e)
        {
            try
            {
                string PutanjaDoMySqla = @"C:\wamp\bin\mysql\mysql5.5.24\bin"; // TODO
                string dbUserName = "root";
                string dbPassword = "root";
                string dbName = "ikzavrsni";
                string path = @backupTextBox.Text;

                Process myProcess = new Process();
                myProcess.StartInfo.FileName = @PutanjaDoMySqla + @"\mysqldump.exe";
                myProcess.StartInfo.WindowStyle = ProcessWindowStyle.Hidden; // dodala
                myProcess.StartInfo.UseShellExecute = true; // bilo je false
                myProcess.StartInfo.WorkingDirectory = @PutanjaDoMySqla + @"\";
                myProcess.StartInfo.Arguments = "-u " + dbUserName + " -p" + dbPassword + " --add-drop-database -B " + dbName + " -r " + path;

                myProcess.StartInfo.RedirectStandardInput = false; 
                myProcess.StartInfo.RedirectStandardOutput = false;
                myProcess.Start(); 
                myProcess.WaitForExit();
                myProcess.Close();
                

                toolStripStatusLabel1.Text = "Uspješno spašeni podaci.";
                toolStripStatusLabel1.ForeColor = Color.Green;               

            }
            catch (Exception izuzetak)
            {
                MessageBox.Show(izuzetak.Message);
            }
        }


        private void restore_Click(object sender, EventArgs e)
        {
            try
            {
                
                string PutanjaDoMySqla = @"C:\wamp\bin\mysql\mysql5.5.24\bin"; // TODO
                string dbUserName = "root";
                string dbPassword = "root";
                string dbName = "ikzavrsni";
                string path = @restoreTextBox.Text;

                //Process.Start(@"C:\wamp\bin\mysql\mysql5.5.24\bin\mysql.exe", ("-u root -proot < \"" + path + "\""));

                Process myProcess = new Process();
                myProcess.StartInfo.FileName = @PutanjaDoMySqla + @"\mysql.exe";
                myProcess.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
                myProcess.StartInfo.UseShellExecute = true;
                myProcess.StartInfo.WorkingDirectory = @PutanjaDoMySqla + @"\";

                myProcess.StartInfo.Arguments = "--user=" + dbUserName + " --password=" + dbPassword + " < " + path;

                //myProcess.StartInfo.Arguments = "--user=" + dbUserName + " --password=" + dbPassword + " < " + path;
                //C:\wamp\bin\mysql\mysql5.5.24\bin\mysql --user=root --password=root < C:\Users\batoshi\Desktop\baza.sql // radi iz command prompta

                //myProcess.StartInfo.Arguments =  "--user=" + dbUserName + " --password=" + dbPassword + " -e source " + path;               
                //C:\wamp\bin\mysql\mysql5.5.24\bin\mysql --user=root --password=root -e source C:\Users\batoshi\Desktop\baza.sql; //unknown database C:\Users\batoshi\Desktop\baza.sql

                //myProcess.StartInfo.Arguments = "--user=" + dbUserName + " --password=" + dbPassword + " -r " + path;                

                myProcess.StartInfo.RedirectStandardInput = false;
                myProcess.StartInfo.RedirectStandardOutput = false;
                myProcess.Start();
                myProcess.WaitForExit();
                myProcess.Close();

                toolStripStatusLabel1.Text = "Uspješno vraćeni podaci.";
                toolStripStatusLabel1.ForeColor = Color.Green;                

            }
            catch (Exception izuzetak)
            {
                MessageBox.Show(izuzetak.Message);
            }
        }


    }
}
