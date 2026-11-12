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
    public partial class Exploratori : Form
    {
        public Exploratori()
        {
            InitializeComponent();
        }

        private void btnSet_Click(object sender, EventArgs e)
        {
            int exploratori;
            bool esteNumar =int.TryParse(txtExploratori.Text, out exploratori);
            if(!esteNumar|| exploratori < 30 || exploratori > 200)
            {
                MessageBox.Show("Numarul trebuie sa fie intre 30 si 200!","Echipaj",MessageBoxButtons.OK,MessageBoxIcon.Error);
                txtExploratori.Clear();
                txtExploratori.Focus();
                return;
            }
            Expeditie F = new Expeditie(exploratori);
            F.Show();
            Hide();

        }
    }
}
