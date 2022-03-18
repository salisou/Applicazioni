namespace tuto
{
    partial class frmProfilo
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
            this.groupBoxProfli = new System.Windows.Forms.GroupBox();
            this.lbGenere = new System.Windows.Forms.Label();
            this.lbNome = new System.Windows.Forms.Label();
            this.btnInDietero = new System.Windows.Forms.Button();
            this.lbEta = new System.Windows.Forms.Label();
            this.lbCognome = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBoxProfli.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxProfli
            // 
            this.groupBoxProfli.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBoxProfli.Controls.Add(this.lbGenere);
            this.groupBoxProfli.Controls.Add(this.lbNome);
            this.groupBoxProfli.Controls.Add(this.btnInDietero);
            this.groupBoxProfli.Controls.Add(this.lbEta);
            this.groupBoxProfli.Controls.Add(this.lbCognome);
            this.groupBoxProfli.Controls.Add(this.label4);
            this.groupBoxProfli.Controls.Add(this.label3);
            this.groupBoxProfli.Controls.Add(this.label2);
            this.groupBoxProfli.Controls.Add(this.label1);
            this.groupBoxProfli.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxProfli.Location = new System.Drawing.Point(0, 0);
            this.groupBoxProfli.Name = "groupBoxProfli";
            this.groupBoxProfli.Size = new System.Drawing.Size(458, 305);
            this.groupBoxProfli.TabIndex = 0;
            this.groupBoxProfli.TabStop = false;
            this.groupBoxProfli.Text = "Profil";
            // 
            // lbGenere
            // 
            this.lbGenere.AutoSize = true;
            this.lbGenere.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lbGenere.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lbGenere.Location = new System.Drawing.Point(191, 159);
            this.lbGenere.Name = "lbGenere";
            this.lbGenere.Size = new System.Drawing.Size(116, 24);
            this.lbGenere.TabIndex = 9;
            this.lbGenere.Text = "< Genere >";
            // 
            // lbNome
            // 
            this.lbNome.AutoSize = true;
            this.lbNome.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lbNome.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lbNome.Location = new System.Drawing.Point(191, 67);
            this.lbNome.Name = "lbNome";
            this.lbNome.Size = new System.Drawing.Size(102, 24);
            this.lbNome.TabIndex = 8;
            this.lbNome.Text = "< Nome >";
            // 
            // btnInDietero
            // 
            this.btnInDietero.Location = new System.Drawing.Point(325, 261);
            this.btnInDietero.Name = "btnInDietero";
            this.btnInDietero.Size = new System.Drawing.Size(127, 38);
            this.btnInDietero.TabIndex = 1;
            this.btnInDietero.Text = "In dietero";
            this.btnInDietero.UseVisualStyleBackColor = true;
            this.btnInDietero.Click += new System.EventHandler(this.btnInDietero_Click);
            // 
            // lbEta
            // 
            this.lbEta.AutoSize = true;
            this.lbEta.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lbEta.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lbEta.Location = new System.Drawing.Point(191, 203);
            this.lbEta.Name = "lbEta";
            this.lbEta.Size = new System.Drawing.Size(76, 24);
            this.lbEta.TabIndex = 7;
            this.lbEta.Text = "< Eta >";
            // 
            // lbCognome
            // 
            this.lbCognome.AutoSize = true;
            this.lbCognome.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lbCognome.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lbCognome.Location = new System.Drawing.Point(191, 112);
            this.lbCognome.Name = "lbCognome";
            this.lbCognome.Size = new System.Drawing.Size(137, 24);
            this.lbCognome.TabIndex = 5;
            this.lbCognome.Text = "< Cognome >";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(76, 203);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 24);
            this.label4.TabIndex = 3;
            this.label4.Text = "Età :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 159);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 24);
            this.label3.TabIndex = 2;
            this.label3.Text = "Genere :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Cognome :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(49, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome : ";
            // 
            // frmProfilo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(465, 311);
            this.Controls.Add(this.groupBoxProfli);
            this.Name = "frmProfilo";
            this.Text = "frmProfilo";
            this.Load += new System.EventHandler(this.frmProfilo_Load);
            this.groupBoxProfli.ResumeLayout(false);
            this.groupBoxProfli.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxProfli;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnInDietero;
        public System.Windows.Forms.Label lbEta;
        public System.Windows.Forms.Label lbCognome;
        public System.Windows.Forms.Label lbNome;
        public System.Windows.Forms.Label lbGenere;
    }
}