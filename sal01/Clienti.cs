using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sal02
{
    internal class Clienti
    {
        string RegioneSociale;
        
        string Indirizzo;

        string Cap;

        int Eta;

        public Clienti(string _ReggioneSociale, string _Indirizzo, int _Eta, string _Cap)
        {
            RegioneSociale = _ReggioneSociale;
            Indirizzo = _Indirizzo;
            Eta = _Eta;
            Cap = _Cap;
        }

        public Clienti()
        {
        }
        public void Messaggio(string _RegioneSociale)
        {
            RegioneSociale = _RegioneSociale;
            MessageBox.Show(RegioneSociale);
        }
        public void Messaggio2(string _RegioneSociale)
        {
            RegioneSociale = _RegioneSociale;
            MessageBox.Show(RegioneSociale);
        }


    }
}
