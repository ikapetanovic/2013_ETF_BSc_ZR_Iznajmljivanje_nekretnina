using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using DBConnection;

namespace IKZavrsni
{
    public partial class VrsteRashoda : Form
    {
        public VrsteRashoda()
        {
            InitializeComponent();
        }

        private void dodaj_Click(object sender, EventArgs e)
        {
            try
            {

                DAO dao = new DAO("localhost", "ikzavrsni", "root", "");
                VrstaRashoda vr = new VrstaRashoda(nazivDodaj.Text, Convert.ToDouble(cijenaDodaj.Value));
                dao.DodajVrstuRashoda(vr);
            }
            catch (Exception izuzetak)
            {
                toolStripStatusLabel1.Text = izuzetak.Message;
            }
            
        }
    }
}
