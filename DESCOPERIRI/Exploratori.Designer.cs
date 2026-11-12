namespace DESCOPERIRI
{
    partial class Exploratori
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Exploratori));
            this.picExplorator = new System.Windows.Forms.PictureBox();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.lblExploratori = new System.Windows.Forms.Label();
            this.txtExploratori = new System.Windows.Forms.TextBox();
            this.btnSet = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picExplorator)).BeginInit();
            this.SuspendLayout();
            // 
            // picExplorator
            // 
            this.picExplorator.Image = ((System.Drawing.Image)(resources.GetObject("picExplorator.Image")));
            this.picExplorator.Location = new System.Drawing.Point(-20, 59);
            this.picExplorator.Name = "picExplorator";
            this.picExplorator.Size = new System.Drawing.Size(416, 332);
            this.picExplorator.TabIndex = 0;
            this.picExplorator.TabStop = false;
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            // 
            // lblExploratori
            // 
            this.lblExploratori.AutoSize = true;
            this.lblExploratori.Location = new System.Drawing.Point(422, 73);
            this.lblExploratori.Name = "lblExploratori";
            this.lblExploratori.Size = new System.Drawing.Size(111, 13);
            this.lblExploratori.TabIndex = 1;
            this.lblExploratori.Text = "Cati exploratori pleca?";
            // 
            // txtExploratori
            // 
            this.txtExploratori.Location = new System.Drawing.Point(470, 134);
            this.txtExploratori.Name = "txtExploratori";
            this.txtExploratori.Size = new System.Drawing.Size(100, 20);
            this.txtExploratori.TabIndex = 2;
            // 
            // btnSet
            // 
            this.btnSet.Location = new System.Drawing.Point(594, 131);
            this.btnSet.Name = "btnSet";
            this.btnSet.Size = new System.Drawing.Size(75, 23);
            this.btnSet.TabIndex = 3;
            this.btnSet.Text = "Set";
            this.btnSet.UseVisualStyleBackColor = true;
            this.btnSet.Click += new System.EventHandler(this.btnSet_Click);
            // 
            // Exploratori
            // 
            this.AcceptButton = this.btnSet;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSet);
            this.Controls.Add(this.txtExploratori);
            this.Controls.Add(this.lblExploratori);
            this.Controls.Add(this.picExplorator);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Exploratori";
            this.Text = "Exploratori";
            ((System.ComponentModel.ISupportInitialize)(this.picExplorator)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picExplorator;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.Label lblExploratori;
        private System.Windows.Forms.TextBox txtExploratori;
        private System.Windows.Forms.Button btnSet;
    }
}