namespace WinAzienda
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
            this.btnNuovaForm = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.frmFornitori = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnNuovaForm
            // 
            this.btnNuovaForm.Location = new System.Drawing.Point(350, 197);
            this.btnNuovaForm.Name = "btnNuovaForm";
            this.btnNuovaForm.Size = new System.Drawing.Size(201, 32);
            this.btnNuovaForm.TabIndex = 2;
            this.btnNuovaForm.Text = "Clienti";
            this.btnNuovaForm.UseVisualStyleBackColor = true;
            this.btnNuovaForm.Click += new System.EventHandler(this.btnNuovaForm_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(438, 134);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(270, 39);
            this.label1.TabIndex = 5;
            this.label1.Text = "Form Principale ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmFornitori
            // 
            this.frmFornitori.Location = new System.Drawing.Point(597, 197);
            this.frmFornitori.Name = "frmFornitori";
            this.frmFornitori.Size = new System.Drawing.Size(214, 32);
            this.frmFornitori.TabIndex = 6;
            this.frmFornitori.Text = "Fornitori";
            this.frmFornitori.UseVisualStyleBackColor = true;
            this.frmFornitori.Click += new System.EventHandler(this.frmFornitori_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1117, 525);
            this.Controls.Add(this.frmFornitori);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnNuovaForm);
            this.IsMdiContainer = true;
            this.Name = "Form1";
            this.Text = "Principale";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnNuovaForm;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button frmFornitori;
    }
}

