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
    public partial class Autentificare : Form
    {
        public Autentificare()
        {
            InitializeComponent();
        }

        private void Autentificare_Load(object sender, EventArgs e)
        {

        }
        private const string EmailCorect = "ojti@csharp.ro";
        private const string ParolaCorecta = "Ojti2025";
        private void btnAcces_Click(object sender, EventArgs e)
        {
           

            if (txtEmail.Text==EmailCorect && txtParola.Text == ParolaCorecta)
            {
                Exploratori f=new Exploratori();
                f.Show();
                Hide();
                return;
            }

            MessageBox.Show("Ceva nu a mers bine ,mai incercati!", "Conectare",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            txtEmail.Clear();
            txtParola.Clear();
            txtEmail.Focus();

        }
    }
}
