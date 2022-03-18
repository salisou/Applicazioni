using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinApplication01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lblHello.Text = "Questa è la Main from";
               
        }

        private void btnSet_Click(object sender, EventArgs e)
        {
            lblHello.Text = "Hai cambiato il testo";
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            lblHello.Text = "          ";
        }
    }
}
