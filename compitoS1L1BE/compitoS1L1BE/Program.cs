namespace compitoS1L1BE
{

internal class Program
    {
        static void Main(string[] args)
        {


            Veicolo fiat = new Veicolo();
            Dipendente rai = new Dipendente();
            Atleta nuoto = new Atleta();
            Animale ragno = new Animale();

            fiat.Velocita = 50;
            fiat.Colore = "Brutto";
            
            ragno.Domestico = false;
            ragno.Specie = "aracnide";

            rai.Nome = "stanco";
            rai.Cognome = "morto";

            nuoto.Sport = "nuoto";
            nuoto.Nome = "squalo";

            Console.WriteLine(fiat.Velocita);
            Console.WriteLine(fiat.Colore);
            Console.WriteLine(ragno.Domestico);
            Console.WriteLine(ragno.Specie);
            Console.WriteLine(rai.Nome);
            Console.WriteLine(rai.Cognome);
            Console.WriteLine(nuoto.Sport);
            Console.WriteLine(nuoto.Nome);
        }
    }

}