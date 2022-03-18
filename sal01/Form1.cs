using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sal01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button2_Click(sender, e);
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            sal01.anagrafe.Nome = "Mario";
            textBox1.Text = sal01.anagrafe.Nome;
            MessageBox.Show(textBox1.Text);
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            sal02.Clienti var1 = new sal02.Clienti();
            var1.Messaggio("ciao");
            Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //sal01.Azienda.RegioneSociale = "Ciao";
            //sal01.Azienda var1 = new sal01.Azienda();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //sal01.Azienda.RegioneSociale = "Ciao";
            sal01.Azienda var1 = new sal01.Azienda("Ferrari", "Imola", 33, "0001100");
            //var1.RegioneSociale = "Moussa";
            var1.Messaggio2();
        }
    }
}
