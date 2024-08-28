// premetto che ho messo tutto in un solo foglio cs per praticita di lettura, naturalmente sarebbe piu corretto separare l'oggetto dal main 
// ma essendo molto lineare e poco confuso ho preferito alla soluzione in singola pagina per facilitare la lettura. 



public class Contribuente
{
    public string Nome { get; set; }
    public string Cognome { get; set; }
    public DateTime DataNascita { get; set; }
    public string CodiceFiscale { get; set; }
    public string Sesso { get; set; }
    public string ComuneResidenza { get; set; }
    public double RedditoAnnuale { get; set; }

    // Costruttore di Contribuente
    public Contribuente(string nome, string cognome, DateTime dataNascita, string codiceFiscale, string sesso, string comuneResidenza, double redditoAnnuale)
    {
        Nome = nome;
        Cognome = cognome;
        DataNascita = dataNascita;
        CodiceFiscale = codiceFiscale;
        Sesso = sesso;
        ComuneResidenza = comuneResidenza;
        RedditoAnnuale = redditoAnnuale;
    }

    // Metodo per calcolare l'imposta, uso un else if per comodità ma anche una espressione di switch 
    // potrebbe risultare comoda, la aggiungero commentata al fondo
    public double CalcolaImposta()
    {
        double imposta = 0;
        // come if/if else potevo anche fare un controllo di comprensione, quindi dire tipo redditoannuale è compreso tra x e y
        // con un operatore logico & ma ho trovato piu chiaro e veloce fare un rapporto con minore di x... 
        // per il calcolo è chiaro che era necessario sommare l'imposta fissa al calcolo per la percentuale di riferimento, in questo caso
        // il calcolo prende in causa il redditoannuale che lo passiamo noi alla costruzione dell'oggetto, 
        // il calcolo prende il rimanente del reddito, lo sottrae al valore massimo del range di pertinenza per trovare l'eccesso dal minimo del range, 
        // il risultato poi è quello che va tassato in percentuale, quindi moltiplico tutto per 0.x dove x è la percentuale, e poi lo sommo alla imposta fissa e il gioco e fatto
        if (RedditoAnnuale <= 15000)
        {
            imposta = RedditoAnnuale * 0.23;
        }
        else if (RedditoAnnuale <= 28000)
        {
            imposta = 3450 + (RedditoAnnuale - 15000) * 0.27;
        }
        else if (RedditoAnnuale <= 55000)
        {
            imposta = 6960 + (RedditoAnnuale - 28000) * 0.38;
        }
        else if (RedditoAnnuale <= 75000)
        {
            imposta = 17220 + (RedditoAnnuale - 55000) * 0.41;
        }
        else
        {
            imposta = 25420 + (RedditoAnnuale - 75000) * 0.43;
        }

        return imposta;
    }

    // ho creato una classe di stampa per tenere piu pulito possibile il main,
    // qui semplicemente prendo l'oggetto passato e scrivo un output piu simile possibile all'esempio della consegna del compito
    public void StampaDettagliImposta()
    {
        double impostaDaPagare = CalcolaImposta();
        Console.WriteLine("CALCOLO DELL'IMPOSTA DA VERSARE:\n");
        Console.WriteLine($"Contribuente: {Nome} {Cognome},");
        Console.WriteLine($"nato il {DataNascita:dd/MM/yyyy} ({Sesso}),");
        Console.WriteLine($"residente in {ComuneResidenza},");
        Console.WriteLine($"codice fiscale: {CodiceFiscale}");
        Console.WriteLine($"\nReddito dichiarato: {RedditoAnnuale:C}");
        Console.WriteLine($"\nIMPOSTA DA VERSARE: {impostaDaPagare:C}");
        Console.WriteLine("");
        Console.WriteLine("");
    }
}




// nel main io creo l'oggetto contribuente, ho deciso di non creare input da tastiera in quanto non necessario e secondo quanto detto a lezione non useremo praticamente mai
// per praticita di veder enell'effettivo utilizzo del metodo di calcolo ho creato piu oggetti contribuente cosi da vedere i vari casi.

public class Program
{
    public static void Main()
    {
        Contribuente contribuente = new Contribuente("Mario", "Rossi", new DateTime(1961, 7, 15), "MRORSI61LIKSNNNS", "M", "Palermo", 17850);
        Contribuente contribuente2 = new Contribuente("Valerio", "Rossi", new DateTime(1961, 7, 15), "VLRRSI61LIKSNNNS", "M", "Roma", 70000);
        Contribuente contribuente3 = new Contribuente("Mario", "Bianco", new DateTime(1961, 7, 15), "MROBNC61LIKSNNNS", "M", "Torino", 80000);
        contribuente.StampaDettagliImposta();
        contribuente2.StampaDettagliImposta();
        contribuente3.StampaDettagliImposta();
    }
}


// questo è il metodo che calcolerebbe la imposta con uno switch, il calcolo matematico per farlo l'ho cercato
// in rete in quanto non sono una cima con i calcoli di una certa complessità
//public double CalcolaImposta()
//{
//    return RedditoAnnuale switch
//    {
//        <= 15000 => RedditoAnnuale * 0.23,
//        <= 28000 => 3450 + (RedditoAnnuale - 15000) * 0.27,
//        <= 55000 => 6960 + (RedditoAnnuale - 28000) * 0.38,
//        <= 75000 => 17220 + (RedditoAnnuale - 55000) * 0.41,
//        _ => 25420 + (RedditoAnnuale - 75000) * 0.43
//    };
//}