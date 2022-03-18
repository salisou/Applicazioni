namespace WinAzienda
{
    partial class frmaction
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
            this.btnFornitori = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnFornitori
            // 
            this.btnFornitori.Location = new System.Drawing.Point(432, 219);
            this.btnFornitori.Name = "btnFornitori";
            this.btnFornitori.Size = new System.Drawing.Size(169, 40);
            this.btnFornitori.TabIndex = 0;
            this.btnFornitori.Text = "Form Principale";
            this.btnFornitori.UseVisualStyleBackColor = true;
            this.btnFornitori.Click += new System.EventHandler(this.btnFornitori_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(409, 159);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(245, 39);
            this.label1.TabIndex = 1;
            this.label1.Text = "Form Fornitori ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmaction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1121, 649);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnFornitori);
            this.Name = "frmaction";
            this.Text = "frmFornitori";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnFornitori;
        private System.Windows.Forms.Label label1;
    }
}