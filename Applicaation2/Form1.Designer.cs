namespace Applicaation2
{
    partial class Form1
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
            this.lblNome = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.btnSalva = new System.Windows.Forms.Button();
            this.lblCognome = new System.Windows.Forms.Label();
            this.txtCognome = new System.Windows.Forms.TextBox();
            this.lblGenere = new System.Windows.Forms.Label();
            this.txtGenere = new System.Windows.Forms.TextBox();
            this.lblEta = new System.Windows.Forms.Label();
            this.lblCodiceFiscale = new System.Windows.Forms.Label();
            this.txtCodicefiscale = new System.Windows.Forms.TextBox();
            this.comboBoxEta = new System.Windows.Forms.ComboBox();
            this.lblAnni = new System.Windows.Forms.Label();
            this.listBoxUtenti = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(14, 23);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(35, 13);
            this.lblNome.TabIndex = 0;
            this.lblNome.Text = "Nome";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(123, 16);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(236, 20);
            this.txtNome.TabIndex = 1;
            // 
            // btnSalva
            // 
            this.btnSalva.Location = new System.Drawing.Point(17, 209);
            this.btnSalva.Name = "btnSalva";
            this.btnSalva.Size = new System.Drawing.Size(75, 23);
            this.btnSalva.TabIndex = 2;
            this.btnSalva.Text = "Salva";
            this.btnSalva.UseVisualStyleBackColor = true;
            this.btnSalva.Click += new System.EventHandler(this.btnSalva_Click);
            // 
            // lblCognome
            // 
            this.lblCognome.AutoSize = true;
            this.lblCognome.Location = new System.Drawing.Point(14, 64);
            this.lblCognome.Name = "lblCognome";
            this.lblCognome.Size = new System.Drawing.Size(52, 13);
            this.lblCognome.TabIndex = 3;
            this.lblCognome.Text = "Cognome";
            // 
            // txtCognome
            // 
            this.txtCognome.Location = new System.Drawing.Point(123, 57);
            this.txtCognome.Name = "txtCognome";
            this.txtCognome.Size = new System.Drawing.Size(236, 20);
            this.txtCognome.TabIndex = 4;
            // 
            // lblGenere
            // 
            this.lblGenere.AutoSize = true;
            this.lblGenere.Location = new System.Drawing.Point(14, 102);
            this.lblGenere.Name = "lblGenere";
            this.lblGenere.Size = new System.Drawing.Size(42, 13);
            this.lblGenere.TabIndex = 5;
            this.lblGenere.Text = "Genere";
            // 
            // txtGenere
            // 
            this.txtGenere.Location = new System.Drawing.Point(123, 95);
            this.txtGenere.Name = "txtGenere";
            this.txtGenere.Size = new System.Drawing.Size(236, 20);
            this.txtGenere.TabIndex = 6;
            // 
            // lblEta
            // 
            this.lblEta.AutoSize = true;
            this.lblEta.Location = new System.Drawing.Point(14, 147);
            this.lblEta.Name = "lblEta";
            this.lblEta.Size = new System.Drawing.Size(23, 13);
            this.lblEta.TabIndex = 7;
            this.lblEta.Text = "Età";
            // 
            // lblCodiceFiscale
            // 
            this.lblCodiceFiscale.AutoSize = true;
            this.lblCodiceFiscale.Location = new System.Drawing.Point(14, 181);
            this.lblCodiceFiscale.Name = "lblCodiceFiscale";
            this.lblCodiceFiscale.Size = new System.Drawing.Size(73, 13);
            this.lblCodiceFiscale.TabIndex = 9;
            this.lblCodiceFiscale.Text = "Codice fiscale";
            // 
            // txtCodicefiscale
            // 
            this.txtCodicefiscale.Location = new System.Drawing.Point(123, 174);
            this.txtCodicefiscale.Name = "txtCodicefiscale";
            this.txtCodicefiscale.Size = new System.Drawing.Size(236, 20);
            this.txtCodicefiscale.TabIndex = 10;
            // 
            // comboBoxEta
            // 
            this.comboBoxEta.FormattingEnabled = true;
            this.comboBoxEta.Location = new System.Drawing.Point(123, 139);
            this.comboBoxEta.Name = "comboBoxEta";
            this.comboBoxEta.Size = new System.Drawing.Size(49, 21);
            this.comboBoxEta.TabIndex = 11;
            // 
            // lblAnni
            // 
            this.lblAnni.AutoSize = true;
            this.lblAnni.Location = new System.Drawing.Point(237, 142);
            this.lblAnni.Name = "lblAnni";
            this.lblAnni.Size = new System.Drawing.Size(0, 13);
            this.lblAnni.TabIndex = 12;
            // 
            // listBoxUtenti
            // 
            this.listBoxUtenti.FormattingEnabled = true;
            this.listBoxUtenti.Location = new System.Drawing.Point(17, 238);
            this.listBoxUtenti.Name = "listBoxUtenti";
            this.listBoxUtenti.Size = new System.Drawing.Size(342, 199);
            this.listBoxUtenti.TabIndex = 13;
            this.listBoxUtenti.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listBoxUtenti);
            this.Controls.Add(this.lblAnni);
            this.Controls.Add(this.comboBoxEta);
            this.Controls.Add(this.txtCodicefiscale);
            this.Controls.Add(this.lblCodiceFiscale);
            this.Controls.Add(this.lblEta);
            this.Controls.Add(this.txtGenere);
            this.Controls.Add(this.lblGenere);
            this.Controls.Add(this.txtCognome);
            this.Controls.Add(this.lblCognome);
            this.Controls.Add(this.btnSalva);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.lblNome);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Button btnSalva;
        private System.Windows.Forms.Label lblCognome;
        private System.Windows.Forms.TextBox txtCognome;
        private System.Windows.Forms.Label lblGenere;
        private System.Windows.Forms.TextBox txtGenere;
        private System.Windows.Forms.Label lblEta;
        private System.Windows.Forms.Label lblCodiceFiscale;
        private System.Windows.Forms.TextBox txtCodicefiscale;
        private System.Windows.Forms.ComboBox comboBoxEta;
        private System.Windows.Forms.Label lblAnni;
        private System.Windows.Forms.ListBox listBoxUtenti;
    }
}

