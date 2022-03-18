using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinAzienda
{
    public partial class frmClienti : Form
    {
        string getragioneSociale;
        public frmClienti()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
        }

        public string getRagioneSociale()
        {
            return getragioneSociale;
        }

        private void frmClienti_Load(object sender, EventArgs e)
        {

        }
    }
}
