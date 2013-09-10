using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace IKZavrsni
{
    public partial class Naplacivanje : Form
    {
        public Naplacivanje()
        {
            InitializeComponent();
        }

        private void racunButton_Click(object sender, EventArgs e)
        {
            // prvo da odabereš datum kada je plaćeno, pa onda generisati račun
        }

        private void Naplacivanje_Load(object sender, EventArgs e)
        {
            doDatumaDateTimePicker.Value = DateTime.Today.AddMonths(1);
        }
    }
}
