namespace Azienda
{
    partial class frmAzienda
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnClient = new System.Windows.Forms.Button();
            this.btnAzienda = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnClient
            // 
            this.btnClient.Location = new System.Drawing.Point(412, 143);
            this.btnClient.Name = "btnClient";
            this.btnClient.Size = new System.Drawing.Size(75, 23);
            this.btnClient.TabIndex = 0;
            this.btnClient.Text = "Client";
            this.btnClient.UseVisualStyleBackColor = true;
            this.btnClient.Click += new System.EventHandler(this.btnClient_Click);
            // 
            // btnAzienda
            // 
            this.btnAzienda.Location = new System.Drawing.Point(250, 143);
            this.btnAzienda.Name = "btnAzienda";
            this.btnAzienda.Size = new System.Drawing.Size(75, 23);
            this.btnAzienda.TabIndex = 1;
            this.btnAzienda.Text = "Azienda";
            this.btnAzienda.UseVisualStyleBackColor = true;
            this.btnAzienda.Click += new System.EventHandler(this.btnAzienda_Click);
            // 
            // frmAzienda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnAzienda);
            this.Controls.Add(this.btnClient);
            this.Name = "frmAzienda";
            this.Text = "Multi Azienda";
            this.Load += new System.EventHandler(this.frmAzienda_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnClient;
        private System.Windows.Forms.Button btnAzienda;
    }
}

