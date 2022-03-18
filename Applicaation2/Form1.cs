using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Applicaation2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSalva_Click(object sender, EventArgs e)
        {
            frmUtenti u = new frmUtenti();
            txtNome.Text = u.Nome;
            txtCognome.Text = u.Cognome;   
            txtGenere.Text = u.Genere;
            txtCodicefiscale.Text = u.CodiceFiscale.ToString();

            listBoxUtenti.Items.Add(txtNome.Text);
            listBoxUtenti.Items.Add(txtCognome.Text);
            listBoxUtenti.Items.Add(txtGenere.Text);
            listBoxUtenti.Items.Add(txtCodicefiscale.Text);
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < 100; i++)
            {
                comboBoxEta.Items.Add(i.ToString());
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
