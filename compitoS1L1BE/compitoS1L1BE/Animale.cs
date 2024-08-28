using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace compitoS1L1BE
{
    internal class Animale
    {
        string specie;
        string colore;
        Boolean domestico;

        public string Specie
        {
            get
            {
                return specie;
            }
            set
            {
                specie = value;
            }
        }
        public bool Domestico
        {
            get
            {
                return domestico;
            }
            set
            {
                domestico = value;
            }

        }
    }
}
