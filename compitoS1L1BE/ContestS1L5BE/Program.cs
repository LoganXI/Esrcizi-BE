using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Diagnostics;

namespace Contest
{
    internal class Program
    {
        /// <summary>
        /// Stampa tutti i numeri primi da <strong>2</strong> fino al numero specificato nel parametro <strong>upperBound</strong>.
        /// </summary>
        /// <param name="upperBound">Limite superiore dell'intervallo da considerare per l'estrazione dei numeri primi.</param>
        private static void Primes(int upperBound)
        {
            // metto un dumb controll se il numero e inferiore a 2
            if (upperBound < 2)
            {
                Console.WriteLine("No primes available below 2.");
                return;
            }
            // faccio un arrai con dimensioni upperbound diviso 2 perche tutti i numeri pari non possono essere primi
            // è un arrai di booleani cosi utilizzo l'indice come numero primo e nella posizione dell'indice metto se e è primo o no
            bool[] primo = new bool[(upperBound / 2) + 1];

            // faccio un passaggio iniziale settando tutti i numeri dispari come veri numeri primi
            for (int i = 1; i < primo.Length; i++)
            {
                primo[i] = true;
            }

            // qui applico il teorema di Erastotene che avevo gia guardato come algoritmo nel compito di javascript
            for (int num = 3; num * num <= upperBound; num += 2)
            {
                if (primo[num / 2])
                {
                    for (int multiple = num * num; multiple <= upperBound; multiple += 2 * num)
                    {
                        primo[multiple / 2] = false;
                    }
                }
            }

            // qui giustamente faccio il write di 2 che è l'unico numero primo ad esere pari
            Console.Write(2 + " ");

            // qui faccio un ciclo che mi stampa tutti i numeri dispari e primi
            for (int i = 1; i < primo.Length; i++)
            {
                if (primo[i])
                {
                    Console.Write((2 * i + 1) + " ");
                }
            }


        }
        static void Main(string[] args)
        {
            // un cronometro
            Stopwatch sw = new Stopwatch();
            // attiva il cronometro
            sw.Start();
            // esegue il metodo da misurare
            Primes(10000);
            // ferma il cronometro
            sw.Stop();
            // stampa il tempo trascorso
            Console.WriteLine($"Execution time: {sw.ElapsedMilliseconds} ms");
        }
    }
}