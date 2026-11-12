namespace DESCOPERIRI
{
    partial class Expeditie
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Expeditie));
            this.pctHarta = new System.Windows.Forms.PictureBox();
            this.lblExploratori = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pctHarta)).BeginInit();
            this.SuspendLayout();
            // 
            // pctHarta
            // 
            this.pctHarta.Image = ((System.Drawing.Image)(resources.GetObject("pctHarta.Image")));
            this.pctHarta.Location = new System.Drawing.Point(0, 0);
            this.pctHarta.Name = "pctHarta";
            this.pctHarta.Size = new System.Drawing.Size(900, 600);
            this.pctHarta.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pctHarta.TabIndex = 1;
            this.pctHarta.TabStop = false;
            // 
            // lblExploratori
            // 
            this.lblExploratori.AutoSize = true;
            this.lblExploratori.Location = new System.Drawing.Point(421, 9);
            this.lblExploratori.Name = "lblExploratori";
            this.lblExploratori.Size = new System.Drawing.Size(62, 13);
            this.lblExploratori.TabIndex = 2;
            this.lblExploratori.Text = "Exploratori :";
            this.lblExploratori.Click += new System.EventHandler(this.label1_Click);
            // 
            // Expeditie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblExploratori);
            this.Controls.Add(this.pctHarta);
            this.Name = "Expeditie";
            this.Text = "Expeditie";
            ((System.ComponentModel.ISupportInitialize)(this.pctHarta)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pctHarta;
        private System.Windows.Forms.Label lblExploratori;
    }
}