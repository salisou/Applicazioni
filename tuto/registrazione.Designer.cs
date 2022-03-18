namespace tuto
{
    partial class registrazione
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnChiudi = new System.Windows.Forms.Button();
            this.btnSalva = new System.Windows.Forms.Button();
            this.radioButtonF = new System.Windows.Forms.RadioButton();
            this.radioButtonM = new System.Windows.Forms.RadioButton();
            this.comboBoxEta = new System.Windows.Forms.ComboBox();
            this.textBoxNomeCognome = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lbEta = new System.Windows.Forms.Label();
            this.lbNomeCognome = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.groupBox1.Controls.Add(this.btnChiudi);
            this.groupBox1.Controls.Add(this.btnSalva);
            this.groupBox1.Controls.Add(this.radioButtonF);
            this.groupBox1.Controls.Add(this.radioButtonM);
            this.groupBox1.Controls.Add(this.comboBoxEta);
            this.groupBox1.Controls.Add(this.textBoxNomeCognome);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.lbEta);
            this.groupBox1.Controls.Add(this.lbNomeCognome);
            this.groupBox1.Font = new System.Drawing.Font("Bookman Old Style", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(627, 266);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Registrazione ";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // btnChiudi
            // 
            this.btnChiudi.Location = new System.Drawing.Point(406, 186);
            this.btnChiudi.Name = "btnChiudi";
            this.btnChiudi.Size = new System.Drawing.Size(167, 36);
            this.btnChiudi.TabIndex = 7;
            this.btnChiudi.Text = "Chiudi";
            this.btnChiudi.UseVisualStyleBackColor = true;
            // 
            // btnSalva
            // 
            this.btnSalva.Location = new System.Drawing.Point(232, 186);
            this.btnSalva.Name = "btnSalva";
            this.btnSalva.Size = new System.Drawing.Size(168, 36);
            this.btnSalva.TabIndex = 1;
            this.btnSalva.Text = "Salve";
            this.btnSalva.UseVisualStyleBackColor = true;
            this.btnSalva.Click += new System.EventHandler(this.btnSalva_Click);
            // 
            // radioButtonF
            // 
            this.radioButtonF.AutoSize = true;
            this.radioButtonF.Location = new System.Drawing.Point(532, 137);
            this.radioButtonF.Name = "radioButtonF";
            this.radioButtonF.Size = new System.Drawing.Size(41, 26);
            this.radioButtonF.TabIndex = 6;
            this.radioButtonF.TabStop = true;
            this.radioButtonF.Text = "F";
            this.radioButtonF.UseVisualStyleBackColor = true;
            // 
            // radioButtonM
            // 
            this.radioButtonM.AutoSize = true;
            this.radioButtonM.Location = new System.Drawing.Point(469, 138);
            this.radioButtonM.Name = "radioButtonM";
            this.radioButtonM.Size = new System.Drawing.Size(45, 26);
            this.radioButtonM.TabIndex = 5;
            this.radioButtonM.TabStop = true;
            this.radioButtonM.Text = "M";
            this.radioButtonM.UseVisualStyleBackColor = true;
            // 
            // comboBoxEta
            // 
            this.comboBoxEta.FormattingEnabled = true;
            this.comboBoxEta.Location = new System.Drawing.Point(232, 135);
            this.comboBoxEta.Name = "comboBoxEta";
            this.comboBoxEta.Size = new System.Drawing.Size(114, 30);
            this.comboBoxEta.TabIndex = 4;
            // 
            // textBoxNomeCognome
            // 
            this.textBoxNomeCognome.Location = new System.Drawing.Point(232, 62);
            this.textBoxNomeCognome.Name = "textBoxNomeCognome";
            this.textBoxNomeCognome.Size = new System.Drawing.Size(341, 30);
            this.textBoxNomeCognome.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(362, 140);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 22);
            this.label3.TabIndex = 2;
            this.label3.Text = "Genere :";
            // 
            // lbEta
            // 
            this.lbEta.AutoSize = true;
            this.lbEta.Location = new System.Drawing.Point(161, 143);
            this.lbEta.Name = "lbEta";
            this.lbEta.Size = new System.Drawing.Size(56, 22);
            this.lbEta.TabIndex = 1;
            this.lbEta.Text = "Età :";
            // 
            // lbNomeCognome
            // 
            this.lbNomeCognome.AutoSize = true;
            this.lbNomeCognome.Location = new System.Drawing.Point(28, 70);
            this.lbNomeCognome.Name = "lbNomeCognome";
            this.lbNomeCognome.Size = new System.Drawing.Size(189, 22);
            this.lbNomeCognome.TabIndex = 0;
            this.lbNomeCognome.Text = "Nome e Cognome :";
            // 
            // registrazione
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(636, 274);
            this.Controls.Add(this.groupBox1);
            this.Name = "registrazione";
            this.Text = "registrazione";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbEta;
        private System.Windows.Forms.Label lbNomeCognome;
        private System.Windows.Forms.TextBox textBoxNomeCognome;
        private System.Windows.Forms.RadioButton radioButtonF;
        private System.Windows.Forms.RadioButton radioButtonM;
        private System.Windows.Forms.ComboBox comboBoxEta;
        private System.Windows.Forms.Button btnChiudi;
        private System.Windows.Forms.Button btnSalva;
    }
}