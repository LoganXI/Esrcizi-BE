using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace compitoS1L1BE
{
    internal class Veicolo
    {
        int velocita;
        string targa;
        string colore;
        string anno;

        public string Velocita
        {
            get
            {
                return velocita;
            }
            set
            {
                velocita = value;
            }
        }
        public string Colore
        {
            get
            {
                return colore;
            }
            set
            {
                colore = value;
            }

        }
    }
}
