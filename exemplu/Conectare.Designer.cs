namespace ExempluMisiune
{
    partial class Conectare
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Conectare));
            this.lblTitlu = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblParola = new System.Windows.Forms.Label();
            this.txtParola = new System.Windows.Forms.TextBox();
            this.btnLansare = new System.Windows.Forms.Button();
            this.lblIndemn = new System.Windows.Forms.Label();
            this.SuspendLayout();
            this.lblTitlu.AutoSize = true;
            this.lblTitlu.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblTitlu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(170)))), ((int)(((byte)(60)))));
            this.lblTitlu.Location = new System.Drawing.Point(24, 18);
            this.lblTitlu.Name = "lblTitlu";
            this.lblTitlu.Text = "Centrul de comanda";
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblEmail.ForeColor = System.Drawing.Color.White;
            this.lblEmail.Location = new System.Drawing.Point(24, 72);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Text = "Email";
            this.txtEmail.Location = new System.Drawing.Point(100, 69);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(230, 25);
            this.txtEmail.TabIndex = 0;
            this.lblParola.AutoSize = true;
            this.lblParola.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblParola.ForeColor = System.Drawing.Color.White;
            this.lblParola.Location = new System.Drawing.Point(24, 112);
            this.lblParola.Name = "lblParola";
            this.lblParola.Text = "Parola";
            this.txtParola.Location = new System.Drawing.Point(100, 109);
            this.txtParola.Name = "txtParola";
            this.txtParola.Size = new System.Drawing.Size(230, 25);
            this.txtParola.TabIndex = 1;
            this.txtParola.PasswordChar = '*';
            this.btnLansare.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLansare.FlatAppearance.BorderSize = 0;
            this.btnLansare.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLansare.Image = ((System.Drawing.Image)(resources.GetObject("btnLansare.Image")));
            this.btnLansare.Location = new System.Drawing.Point(350, 66);
            this.btnLansare.Name = "btnLansare";
            this.btnLansare.Size = new System.Drawing.Size(75, 75);
            this.btnLansare.TabIndex = 2;
            this.btnLansare.UseVisualStyleBackColor = false;
            this.btnLansare.Click += new System.EventHandler(this.btnLansare_Click);
            this.lblIndemn.AutoSize = true;
            this.lblIndemn.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.lblIndemn.ForeColor = System.Drawing.Color.Silver;
            this.lblIndemn.Location = new System.Drawing.Point(335, 146);
            this.lblIndemn.Name = "lblIndemn";
            this.lblIndemn.Text = "Apasa pe Start sau Enter";
            this.AcceptButton = this.btnLansare;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(27)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(460, 190);
            this.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Conectare";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Conectare";
            this.Controls.Add(this.lblTitlu);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.lblParola);
            this.Controls.Add(this.txtParola);
            this.Controls.Add(this.btnLansare);
            this.Controls.Add(this.lblIndemn);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitlu;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblParola;
        private System.Windows.Forms.TextBox txtParola;
        private System.Windows.Forms.Button btnLansare;
        private System.Windows.Forms.Label lblIndemn;
    }
}
