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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnNuovaForm_Click(object sender, EventArgs e)
        {
            // chiama la seconda forma frmClient 
            frmClienti myFrom = new frmClienti();
            myFrom.Show();
        }

        private void frmFornitori_Click(object sender, EventArgs e)
        {
            frmaction f = new frmaction();
            f.MdiParent = this;            
            f.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        //C:\progetti\WinAzienda\bin\Debug\WinAzienda.exe
    }
}
