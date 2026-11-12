using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DESCOPERIRI
{
    public partial class Expeditie : Form
    {
        public Expeditie(int exploratori)
        {
            InitializeComponent();
            lblExploratori.Text = "Exploratori: " + exploratori;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
