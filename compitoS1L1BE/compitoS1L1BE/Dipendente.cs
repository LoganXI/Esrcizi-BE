using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace compitoS1L1BE
{
    internal class Dipendente
    {
        int anni;
        string societa;
        string nome;
        string cognome;
        string professione;
    }

    public string Cognome
    {
        get
        {
            return cognome;
        }
        set
        {
            cognome = value;
        }
    }
    public string Nome
    {
        get
        {
            return nome;
        }
        set
        {
            nome = value;
        }

    }
}
