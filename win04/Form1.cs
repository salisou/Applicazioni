using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace win04
{
    public partial class Form1 : Form
    {
        win04.esempio globale = new win04.esempio;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            /*
                se dichiare una variabile è meglio dichiarala prima 
                int a;
                se definisco una variabile ho 2 possibilità
                int a = 100;
                int a = < un metodo o un'altra variabile >

             */

            int minus = 10;
            //int a; 
            int b;

            win04.esempio f = new esempio();
            f.var1 = 400;

            win04.esempio g = f;
            MessageBox.Show(g.var1.ToString());

            g.funct2();
            g.var1 = g.var1 - minus;

            b = f.funct3();
            MessageBox.Show(g.var1.ToString());

            MessageBox.Show(globale.var1.ToString());
            globale.var1 = globale.var1 + 100;
        }
    }
}
