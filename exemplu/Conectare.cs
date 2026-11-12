using System;
using System.Windows.Forms;

namespace ExempluMisiune
{
    public partial class Conectare : Form
    {
        private const string EmailCorect = "comandant@misiune.ro";
        private const string ParolaCorecta = "Luna2024";

        public Conectare()
        {
            InitializeComponent();
        }

        private void btnLansare_Click(object sender, EventArgs e)
        {
            if (txtEmail.Text == EmailCorect && txtParola.Text == ParolaCorecta)
            {
                Echipaj echipaj = new Echipaj();
                echipaj.Show();
                Hide();
                return;
            }

            MessageBox.Show("Date de acces gresite, mai incearca!", "Conectare",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
            txtEmail.Clear();
            txtParola.Clear();
            txtEmail.Focus();
        }
    }
}
