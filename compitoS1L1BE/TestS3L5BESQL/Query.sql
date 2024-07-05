-- Esercizio 1
SELECT COUNT(*) AS SommaVerbali FROM Verbali;
-- Esercizio 2
SELECT A.Cognome, A.Nome, COUNT(V.IdVerbale) AS NumeroVerbali
FROM Verbali V
INNER JOIN Anagrafica A ON V.IdAnagraficaFK = A.IdAnagrafica
GROUP BY A.Cognome, A.Nome;
--ESERCIZIO 3
SELECT TV.Descrizione AS TipoViolazione, COUNT(VXM.IdVerbaleFK) AS NumeroVerbali
FROM ViolazioniXMulta VXM
INNER JOIN Tipo_Violazioni TV ON VXM.IdViolazioneFK = TV.IdViolazione
GROUP BY TV.Descrizione;
--Esercizio 4
SELECT A.Cognome, A.Nome, SUM(V.DecurtamentoPunti) AS TotalePuntiDecurtati
FROM Verbali V
INNER JOIN Anagrafica A ON V.IdAnagraficaFK = A.IdAnagrafica
GROUP BY A.Cognome, A.Nome;
--Esercizio 5
SELECT A.Cognome, A.Nome, V.DataViolazione, V.IndirizzoViolazione, V.Importo, V.DecurtamentoPunti
FROM Verbali V
INNER JOIN Anagrafica A ON V.IdAnagraficaFK = A.IdAnagrafica
WHERE A.Citta = 'Palermo';
--Esercizio 6
-- questa where è secondo la richiesta ma dato che le entry del mio db le ho fatte prima di vedere le domande 
-- bisognerebbe impostare per esempio la data tra il 2024-01-05 e 2024-01-15 per ottenere qualche risultato delle mie entry.
-- ovviamente se ci fossero entry in quella data darebbero quei valori,
-- l'ho testata con le mie date e le ho ripristinate al valore desiderato della consegna
SELECT A.Cognome, A.Nome, A.Indirizzo, V.DataViolazione, V.Importo, V.DecurtamentoPunti
FROM Verbali V
INNER JOIN Anagrafica A ON V.IdAnagraficaFK = A.IdAnagrafica
WHERE V.DataViolazione >= '2009-02-01' AND V.DataViolazione <= '2009-07-31';
--Esercizio 7
SELECT A.Cognome, A.Nome, SUM(V.Importo) AS TotaleImporti
FROM Verbali V
INNER JOIN Anagrafica A ON V.IdAnagraficaFK = A.IdAnagrafica
GROUP BY A.Cognome, A.Nome;
-- Esercizio 8
SELECT *
FROM Anagrafica
WHERE Citta = 'Palermo';
-- Esercizio 9
SELECT DataViolazione, Importo, DecurtamentoPunti
FROM Verbali
WHERE CONVERT(DATE, DataViolazione) = '2024-01-07';-- ho usato il convert per essere sicuro che capisse il formato DATE
-- esercizio 10
SELECT Matricola_Agente, COUNT(*) AS NumeroViolazioni
FROM Verbali
GROUP BY Matricola_Agente;
-- Esercizio 11
-- se usi i miei data entry conviene mettere maggiore di 4 senno non mostra nulla
SELECT A.Cognome, A.Nome, A.Indirizzo, V.DataViolazione, V.Importo, V.DecurtamentoPunti
FROM Verbali V
INNER JOIN Anagrafica A ON V.IdAnagraficaFK = A.IdAnagrafica
WHERE V.DecurtamentoPunti > 5;
-- Esercizio 12
-- anche qui se usi i miei data entry e meglio mettere 200 per ottenere qualche risultato
SELECT A.Cognome, A.Nome, A.Indirizzo, V.DataViolazione, V.Importo, V.DecurtamentoPunti
FROM Verbali V
INNER JOIN Anagrafica A ON V.IdAnagraficaFK = A.IdAnagrafica
WHERE V.Importo > 400;

