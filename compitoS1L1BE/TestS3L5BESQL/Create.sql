CREATE TABLE [dbo].[Verbali] (
    [IdVerbale]               INT            IDENTITY (1, 1) NOT NULL,
    [DataViolazione]          DATETIME2 (0)  NOT NULL,
    [IndirizzoViolazione]     NVARCHAR (MAX) NOT NULL,
    [Matricola_Agente]        INT            NOT NULL, -- ho cambiato da nominativo agente a matricola.. sono pignolo ma i verbali hanno la matricola non il nome 
    [DataTrascrizioneVerbale] DATETIME2 (0)  NOT NULL,
    [Importo]                 MONEY          NOT NULL,
    [DecurtamentoPunti]       INT            NOT NULL,
    [IdAnagraficaFK]          INT            NOT NULL,
    PRIMARY KEY CLUSTERED ([IdVerbale] ASC),
    CONSTRAINT [FK_Verbali_ToAnagrafica] FOREIGN KEY ([IdAnagraficaFK]) REFERENCES [dbo].[Anagrafica] ([IdAnagrafica]),
    CHECK ([Importo]>(0))
);



CREATE TABLE [dbo].[Anagrafica]
(
	[IdAnagrafica] INT IDENTITY(1,1) NOT NULL PRIMARY KEY,
	[Cognome] NVARCHAR(50) NOT NULL,
	[Nome] NVARCHAR(50) NOT NULL, 
    [Indirizzo] NVARCHAR(255) NOT NULL,
	[Citta] NVARCHAR(30) NOT NULL,
	[CAP] INT NOT NULL,
	[Cod_Fisc] CHAR(11) NOT NULL
)
CREATE TABLE [dbo].[Tipo_Violazioni]
(
	[IdViolazione] INT IDENTITY(1,1) NOT NULL PRIMARY KEY, 
    [Descrizione] NVARCHAR(MAX) NULL

)
CREATE TABLE [dbo].[ViolazioniXMulta]
(
	[IdViolazXMulta] INT IDENTITY(1,1) NOT NULL PRIMARY KEY, 
    [IdVerbaleFK] INT NOT NULL,
	[IdViolazioneFK] INT NOT NULL, 
    CONSTRAINT [FK_ViolazioniXMulta_ToVerbali] FOREIGN KEY ([IdVerbaleFK]) REFERENCES [Verbali]([IdVerbale]), 
    CONSTRAINT [FK_ViolazioniXMulta_ToViolazioni] FOREIGN KEY ([IdViolazioneFK]) REFERENCES [Tipo_Violazioni]([IdViolazione])
)
