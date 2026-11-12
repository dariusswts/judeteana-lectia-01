using System;
using System.Windows.Forms;

namespace ExempluMisiune
{
    public partial class Echipaj : Form
    {
        public Echipaj()
        {
            InitializeComponent();
        }

        private void btnPleaca_Click(object sender, EventArgs e)
        {
            int astronauti;
            bool esteNumar = int.TryParse(txtAstronauti.Text, out astronauti);
            if (!esteNumar || astronauti < 2 || astronauti > 8)
            {
                MessageBox.Show("Echipajul are intre 2 si 8 astronauti.", "Echipaj",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtAstronauti.Clear();
                txtAstronauti.Focus();
                return;
            }

            PanouMisiune panou = new PanouMisiune(astronauti);
            panou.Show();
            Hide();
        }

        private void Echipaj_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                Application.Exit();
            }
        }
    }
}
