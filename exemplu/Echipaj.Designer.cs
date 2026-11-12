namespace ExempluMisiune
{
    partial class Echipaj
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Echipaj));
            this.picLuna = new System.Windows.Forms.PictureBox();
            this.lblIntrebare = new System.Windows.Forms.Label();
            this.txtAstronauti = new System.Windows.Forms.TextBox();
            this.btnPleaca = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picLuna)).BeginInit();
            this.SuspendLayout();
            this.picLuna.Image = ((System.Drawing.Image)(resources.GetObject("picLuna.Image")));
            this.picLuna.Location = new System.Drawing.Point(24, 24);
            this.picLuna.Name = "picLuna";
            this.picLuna.Size = new System.Drawing.Size(150, 150);
            this.picLuna.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picLuna.TabStop = false;
            this.lblIntrebare.AutoSize = true;
            this.lblIntrebare.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblIntrebare.ForeColor = System.Drawing.Color.White;
            this.lblIntrebare.Location = new System.Drawing.Point(196, 40);
            this.lblIntrebare.Name = "lblIntrebare";
            this.lblIntrebare.Text = "Cati astronauti pleaca? (2-8)";
            this.txtAstronauti.Location = new System.Drawing.Point(200, 76);
            this.txtAstronauti.Name = "txtAstronauti";
            this.txtAstronauti.Size = new System.Drawing.Size(120, 25);
            this.txtAstronauti.TabIndex = 0;
            this.btnPleaca.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(170)))), ((int)(((byte)(60)))));
            this.btnPleaca.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPleaca.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPleaca.ForeColor = System.Drawing.Color.Black;
            this.btnPleaca.Location = new System.Drawing.Point(200, 120);
            this.btnPleaca.Name = "btnPleaca";
            this.btnPleaca.Size = new System.Drawing.Size(120, 34);
            this.btnPleaca.TabIndex = 1;
            this.btnPleaca.Text = "Pleaca";
            this.btnPleaca.UseVisualStyleBackColor = false;
            this.btnPleaca.Click += new System.EventHandler(this.btnPleaca_Click);
            this.AcceptButton = this.btnPleaca;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(27)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(420, 200);
            this.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Echipaj";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Echipaj";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Echipaj_FormClosed);
            this.Controls.Add(this.picLuna);
            this.Controls.Add(this.lblIntrebare);
            this.Controls.Add(this.txtAstronauti);
            this.Controls.Add(this.btnPleaca);
            ((System.ComponentModel.ISupportInitialize)(this.picLuna)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picLuna;
        private System.Windows.Forms.Label lblIntrebare;
        private System.Windows.Forms.TextBox txtAstronauti;
        private System.Windows.Forms.Button btnPleaca;
    }
}
