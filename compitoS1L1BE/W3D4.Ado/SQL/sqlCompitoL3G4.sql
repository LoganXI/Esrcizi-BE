select * from Impiegati where Eta>30

select * from Impiegati where RedditoMensile>=1800

select * from Impiegati where DetrazioneFiscale!=0

select * from Impiegati where DetrazioneFiscale!=1

select * from Impiegati where Cognome LIKE 'B%' ORDER BY Cognome ASC

SELECT COUNT(*) as totImpiegati FROM Impiegati 

select SUM(redditoMensile) as sommareddito, AVG(redditoMensile) as mediareddito, MAX(redditoMensile) as massimoReddito, 
MIN(redditoMensile) as Minimoreddito from Impiegati

select i.*, p.Assunzione from Impiegati i
join impiego p on i.IdImpiegoFK = IdImpiego
where p.Assunzione between 01/01/2007 and 01/01/2020