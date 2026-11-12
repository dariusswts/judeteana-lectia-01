namespace ExempluMisiune
{
    partial class PanouMisiune
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PanouMisiune));
            this.picSistem = new System.Windows.Forms.PictureBox();
            this.lblEchipaj = new System.Windows.Forms.Label();
            this.lblIesire = new System.Windows.Forms.Label();
            this.btnIesire = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picSistem)).BeginInit();
            this.SuspendLayout();
            this.picSistem.Image = ((System.Drawing.Image)(resources.GetObject("picSistem.Image")));
            this.picSistem.Location = new System.Drawing.Point(24, 24);
            this.picSistem.Name = "picSistem";
            this.picSistem.Size = new System.Drawing.Size(450, 270);
            this.picSistem.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picSistem.TabStop = false;
            this.lblEchipaj.AutoSize = true;
            this.lblEchipaj.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblEchipaj.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(170)))), ((int)(((byte)(60)))));
            this.lblEchipaj.Location = new System.Drawing.Point(492, 30);
            this.lblEchipaj.Name = "lblEchipaj";
            this.lblEchipaj.Text = "La bord:";
            this.lblIesire.AutoSize = true;
            this.lblIesire.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblIesire.ForeColor = System.Drawing.Color.Silver;
            this.lblIesire.Location = new System.Drawing.Point(492, 200);
            this.lblIesire.Name = "lblIesire";
            this.lblIesire.Text = "Iesi din aplicatie oricand:\r\n  - tasta Esc\r\n  - butonul Iesire";
            this.btnIesire.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(170)))), ((int)(((byte)(60)))));
            this.btnIesire.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnIesire.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIesire.ForeColor = System.Drawing.Color.Black;
            this.btnIesire.Location = new System.Drawing.Point(496, 260);
            this.btnIesire.Name = "btnIesire";
            this.btnIesire.Size = new System.Drawing.Size(120, 34);
            this.btnIesire.TabIndex = 0;
            this.btnIesire.Text = "Iesire";
            this.btnIesire.UseVisualStyleBackColor = false;
            this.btnIesire.Click += new System.EventHandler(this.btnIesire_Click);
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(27)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(700, 318);
            this.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "PanouMisiune";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Misiune";
            this.KeyPreview = true;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.PanouMisiune_FormClosed);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.PanouMisiune_KeyDown);
            this.Controls.Add(this.picSistem);
            this.Controls.Add(this.lblEchipaj);
            this.Controls.Add(this.lblIesire);
            this.Controls.Add(this.btnIesire);
            ((System.ComponentModel.ISupportInitialize)(this.picSistem)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picSistem;
        private System.Windows.Forms.Label lblEchipaj;
        private System.Windows.Forms.Label lblIesire;
        private System.Windows.Forms.Button btnIesire;
    }
}
