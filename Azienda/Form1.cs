using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Azienda
{
    public partial class frmAzienda : Form
    {
        public frmAzienda()
        {
            InitializeComponent();
        }

        private void frmAzienda_Load(object sender, EventArgs e)
        {
            string a;
            Text = "vecchio nome della form";
        }

        private void btnAzienda_Click(object sender, EventArgs e)
        {
            btnAzienda.Text = "vecchio nome della form";

        }

        private void btnClient_Click(object sender, EventArgs e)
        {

        }
    }
}
