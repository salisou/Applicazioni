using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tuto
{
    public partial class registrazione : Form
    {
        string nome_cognome;
        string eta;
        string genere;
        public registrazione()
        {
            InitializeComponent();
        }


        private void groupBox1_Enter(object sender, EventArgs e)
        {
            for (int i = 0; i < 100; i++)
            {
                comboBoxEta.Items.Add(i.ToString());
            }
        }

        private void btnSalva_Click(object sender, EventArgs e)
        {

            nome_cognome = this.textBoxNomeCognome.Text.ToString();
            eta = comboBoxEta.SelectedItem.ToString();


            if (radioButtonM.Checked)
            {
                genere = "M";
            }
            else if (radioButtonF.Checked)
            {
                genere = "F";
            }

            frmProfilo f2 = new frmProfilo();

            f2.lbNome.Text = nome_cognome;
            f2.lbEta.Text = genere;

            f2.Show();
            this.Visible = false;
        }
    }
}
