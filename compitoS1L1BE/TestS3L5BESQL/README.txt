Buongiorno, ti scrivo questo file di testo per praticità, per descrivere il mio ragionamento.

ho pensato che per migliorare l'efficienza del database una quarta tabella fosse una buona idea, in questo modo io posso distinguere sia i vari tipi di violazioni sia i vari verbali, essendo a conoscenza che un verbale può avere piu violazioni in esso ho deciso di fare una tabella "ViolazioniXMulta" , dove multa starebbe per verbale, per raggruppare il rapporto molti a molti, dopotutto un verbale puo avere piu violazioni e una violazione puo essere contenuta in piu verbali. la quarta tabella semplicemente ha un id suo per identificare l'entrata e poi ha semplicemente il collegamento tra IdVerbale e IdViolazione, ovviamente si vedono tutte le relazioni all'interno delle create table, inoltre ho preferito separare i file sql in 3 file, una di Create dove creo tutte le tabelle, una di Instert cosi da avere gia disponibile dei valori con i campi giusti e un file Query dove ho elencato tutte le query dell'esercizio… avrei fatto una stored procedure dove alla fine si droppavano le tabelle, solo per fini didattici ma non essendo la richiesta ho evitato. 

Ho fatto un cambiamento al DB, ho solo cambiato il Nominativo_Agente in Matricola_Agente… ho trovato piu sensato questo approccio in quanto pensando ad un progetto piu completo dove c'è una tabella degli agenti si potesse collegare con un identificativo univoco piuttosto che con un nome scritto.

Dulcis in fundo gli esercizi che ho fatto sono come richiesti dalla consegna, mi rendo conto che alcune delle mie entry sono incompatibili con filtri richiesti perciò ho scritto dei commenti nelle query interessate dove spiego cosa ho fatto per testare che fossero funzionanti. 

spero che il modo in cui ho organizzato sia facile e veloce da correggere.

Buona correzione.
