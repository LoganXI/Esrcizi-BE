using System;


class Program
{
    static void Main()
    {
        string[] cibi =
        {
            "Coca Cola 150 ml",
            "Insalata di pollo",
            "Pizza Margherita",
            "Pizza 4 Formaggi",
            "Pz patatine fritte",
            "Insalata di riso",
            "Frutta di stagione",
            "Pizza fritta",
            "Piadina vegetariana",
            "Panino Hamburger",

        };

        double[] prezzi = { 2.50, 5.20, 10.00, 12.50, 3.50, 8.00, 5.00, 5.00, 6.00, 7.90 };

        List<int> ordine = new List<int>();

        while (true)
        {

            StampaMenu(cibi, prezzi);   
            Console.WriteLine("\nSeleziona un oggetto dal menu (1-11):");
            if (int.TryParse(Console.ReadLine(), out int scelta))
            {
                if(scelta >=1 && scelta <=10)
                {
                    ordine.Add(scelta-1);
                    Console.WriteLine($"\nHai aggiunto {cibi[scelta-1]} al tuo ordine.");
                }
                else if(scelta == 11){
                    StampaConto(cibi, prezzi, ordine);
                    break;
                }
                else
                {
                    Console.WriteLine("\nScelta non valida");
                }
            }
            else
            {
                Console.WriteLine("\nInput non valido");
            }

            Console.WriteLine("\nPremi un tasto per continuare...");
            Console.ReadKey();
        }
    }

    static void StampaMenu(string[] cibi, double[] prezzi)
    {
        Console.WriteLine("---------------MENU---------------");
        for (int i = 0; i < cibi.Length; i++)
        {
            Console.WriteLine($"{i+1}: {cibi[i]} (Eur {prezzi[i]:F2})");
        }
        Console.WriteLine("11: Stampa il conto e conferma l'ordine");
        Console.WriteLine("---------------MENU---------------");
    }

    static void StampaConto(string[] cibi, double[] prezzi, List<int> ordine)
    {
        Console.WriteLine("---------------CONTO---------------");
        double totale = 0;
        foreach (int indice in ordine)
        {
            Console.WriteLine($"{indice + 1}: {cibi[indice]} (Eur {prezzi[indice]:F2})");
            totale += prezzi[indice];
        }
        const double servizio = 3.00;
        totale += servizio;
        Console.WriteLine("-----------------------------------");
        Console.WriteLine($"Servizio al tavolo - Eur{servizio:F2}");
        Console.WriteLine($"Totale - Eur{totale:F2}");
        Console.WriteLine("---------------CONTO---------------");
        Console.WriteLine("\nFine del servizio");
    }
}