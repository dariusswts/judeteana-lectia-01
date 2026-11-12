using System;
using System.Windows.Forms;

namespace ExempluMisiune
{
    public partial class PanouMisiune : Form
    {
        public PanouMisiune(int astronauti)
        {
            InitializeComponent();
            lblEchipaj.Text = "La bord: " + astronauti + " astronauti";
        }

        private void btnIesire_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void PanouMisiune_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                Application.Exit();
            }
        }

        private void PanouMisiune_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                Application.Exit();
            }
        }
    }
}
