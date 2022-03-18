using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sal01
{
    internal class Azienda
    {
        public string RegioneSociale;

        // variabili
        string Indirizzo;
        int Eta;
        string Cap;

        public Azienda()
        {

        }
        public Azienda(string _RegioneSociale, string _Indirizzo, int _Eta, string _Cap)
        {
            RegioneSociale = _RegioneSociale;
            Indirizzo = _Indirizzo;
            Eta = _Eta;
            Cap = _Cap;
        }
        public void Messaggio()
        {
            MessageBox.Show(RegioneSociale);
        }

        public void Messaggio2()
        {
            MessageBox.Show(RegioneSociale + "," + Indirizzo + "," + Eta.ToString() + "," + Cap);
        }
    }
}
