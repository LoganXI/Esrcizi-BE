using TestS4L5BEAppPolizia.Models;
using System.Data;
using System.Data.SqlClient;

namespace TestS4L5BEAppPolizia.Services
{
    public class DatabaseHelper
    {
        private readonly string _connectionString;

        public DatabaseHelper(string connectionString)
        {
            _connectionString = connectionString;
        }

        // Anagrafiche CRUD
        public List<Anagrafica> GetAnagrafiche()
        {
            var result = new List<Anagrafica>();
            using (var connection = new SqlConnection(_connectionString))
            {
                var command = new SqlCommand("SELECT * FROM Anagrafica", connection);
                connection.Open();
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        result.Add(new Anagrafica
                        {
                            IdAnagrafica = (int)reader["IdAnagrafica"],
                            Cognome = (string)reader["Cognome"],
                            Nome = (string)reader["Nome"],
                            Indirizzo = (string)reader["Indirizzo"],
                            Citta = (string)reader["Citta"],
                            CAP = (int)reader["CAP"],
                            Cod_Fisc = (string)reader["Cod_Fisc"]
                        });
                    }
                }
            }
            return result;
        }

        public void AddAnagrafica(Anagrafica anagrafica)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                var command = new SqlCommand("INSERT INTO Anagrafica (Cognome, Nome, Indirizzo, Citta, CAP, Cod_Fisc) VALUES (@Cognome, @Nome, @Indirizzo, @Citta, @CAP, @Cod_Fisc)", connection);
                command.Parameters.AddWithValue("@Cognome", anagrafica.Cognome);
                command.Parameters.AddWithValue("@Nome", anagrafica.Nome);
                command.Parameters.AddWithValue("@Indirizzo", anagrafica.Indirizzo);
                command.Parameters.AddWithValue("@Citta", anagrafica.Citta);
                command.Parameters.AddWithValue("@CAP", anagrafica.CAP);
                command.Parameters.AddWithValue("@Cod_Fisc", anagrafica.Cod_Fisc);
                connection.Open();
                command.ExecuteNonQuery();
            }
        }

        public void UpdateAnagrafica(Anagrafica anagrafica)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                var command = new SqlCommand("UPDATE Anagrafica SET Cognome = @Cognome, Nome = @Nome, Indirizzo = @Indirizzo, Citta = @Citta, CAP = @CAP, Cod_Fisc = @Cod_Fisc WHERE IdAnagrafica = @IdAnagrafica", connection);
                command.Parameters.AddWithValue("@Cognome", anagrafica.Cognome);
                command.Parameters.AddWithValue("@Nome", anagrafica.Nome);
                command.Parameters.AddWithValue("@Indirizzo", anagrafica.Indirizzo);
                command.Parameters.AddWithValue("@Citta", anagrafica.Citta);
                command.Parameters.AddWithValue("@CAP", anagrafica.CAP);
                command.Parameters.AddWithValue("@Cod_Fisc", anagrafica.Cod_Fisc);
                command.Parameters.AddWithValue("@IdAnagrafica", anagrafica.IdAnagrafica);
                connection.Open();
                command.ExecuteNonQuery();
            }
        }

        public void DeleteAnagrafica(int id)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                var command = new SqlCommand("DELETE FROM Anagrafica WHERE IdAnagrafica = @Id", connection);
                command.Parameters.AddWithValue("@Id", id);
                connection.Open();
                command.ExecuteNonQuery();
            }
        }

        // Verbali CRUD
        public List<Verbale> GetVerbali()
        {
            var result = new List<Verbale>();
            using (var connection = new SqlConnection(_connectionString))
            {
                var command = new SqlCommand("SELECT * FROM Verbali", connection);
                connection.Open();
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        result.Add(new Verbale
                        {
                            IdVerbale = (int)reader["IdVerbale"],
                            DataViolazione = (DateTime)reader["DataViolazione"],
                            IndirizzoViolazione = (string)reader["IndirizzoViolazione"],
                            Matricola_Agente = (int)reader["Matricola_Agente"],
                            DataTrascrizioneVerbale = (DateTime)reader["DataTrascrizioneVerbale"],
                            Importo = (decimal)reader["Importo"],
                            DecurtamentoPunti = (int)reader["DecurtamentoPunti"],
                            IdAnagraficaFK = (int)reader["IdAnagraficaFK"]
                        });
                    }
                }
            }
            return result;
        }

        public void AddVerbale(Verbale verbale)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                var command = new SqlCommand("INSERT INTO Verbali (DataViolazione, IndirizzoViolazione, Matricola_Agente, DataTrascrizioneVerbale, Importo, DecurtamentoPunti, IdAnagraficaFK) VALUES (@DataViolazione, @IndirizzoViolazione, @Matricola_Agente, @DataTrascrizioneVerbale, @Importo, @DecurtamentoPunti, @IdAnagraficaFK)", connection);
                command.Parameters.AddWithValue("@DataViolazione", verbale.DataViolazione);
                command.Parameters.AddWithValue("@IndirizzoViolazione", verbale.IndirizzoViolazione);
                command.Parameters.AddWithValue("@Matricola_Agente", verbale.Matricola_Agente);
                command.Parameters.AddWithValue("@DataTrascrizioneVerbale", verbale.DataTrascrizioneVerbale);
                command.Parameters.AddWithValue("@Importo", verbale.Importo);
                command.Parameters.AddWithValue("@DecurtamentoPunti", verbale.DecurtamentoPunti);
                command.Parameters.AddWithValue("@IdAnagraficaFK", verbale.IdAnagraficaFK);
                connection.Open();
                command.ExecuteNonQuery();
            }
        }

        public void UpdateVerbale(Verbale verbale)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                var command = new SqlCommand("UPDATE Verbali SET DataViolazione = @DataViolazione, IndirizzoViolazione = @IndirizzoViolazione, Matricola_Agente = @Matricola_Agente, DataTrascrizioneVerbale = @DataTrascrizioneVerbale, Importo = @Importo, DecurtamentoPunti = @DecurtamentoPunti, IdAnagraficaFK = @IdAnagraficaFK WHERE IdVerbale = @IdVerbale", connection);
                command.Parameters.AddWithValue("@DataViolazione", verbale.DataViolazione);
                command.Parameters.AddWithValue("@IndirizzoViolazione", verbale.IndirizzoViolazione);
                command.Parameters.AddWithValue("@Matricola_Agente", verbale.Matricola_Agente);
                command.Parameters.AddWithValue("@DataTrascrizioneVerbale", verbale.DataTrascrizioneVerbale);
                command.Parameters.AddWithValue("@Importo", verbale.Importo);
                command.Parameters.AddWithValue("@DecurtamentoPunti", verbale.DecurtamentoPunti);
                command.Parameters.AddWithValue("@IdAnagraficaFK", verbale.IdAnagraficaFK);
                command.Parameters.AddWithValue("@IdVerbale", verbale.IdVerbale);
                connection.Open();
                command.ExecuteNonQuery();
            }
        }

        public void DeleteVerbale(int id)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                var command = new SqlCommand("DELETE FROM Verbali WHERE IdVerbale = @Id", connection);
                command.Parameters.AddWithValue("@Id", id);
                connection.Open();
                command.ExecuteNonQuery();
            }
        }

        // Tipo Violazioni CRUD
        public List<TipoViolazione> GetTipoViolazioni()
        {
            var result = new List<TipoViolazione>();
            using (var connection = new SqlConnection(_connectionString))
            {
                var command = new SqlCommand("SELECT * FROM Tipo_Violazioni", connection);
                connection.Open();
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        result.Add(new TipoViolazione
                        {
                            IdViolazione = (int)reader["IdViolazione"],
                            Descrizione = (string)reader["Descrizione"]
                        });
                    }
                }
            }
            return result;
        }

        public void AddTipoViolazione(TipoViolazione tipoViolazione)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                var command = new SqlCommand("INSERT INTO Tipo_Violazioni (Descrizione) VALUES (@Descrizione)", connection);
                command.Parameters.AddWithValue("@Descrizione", tipoViolazione.Descrizione);
                connection.Open();
                command.ExecuteNonQuery();
            }
        }

        public void UpdateTipoViolazione(TipoViolazione tipoViolazione)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                var command = new SqlCommand("UPDATE Tipo_Violazioni SET Descrizione = @Descrizione WHERE IdViolazione = @IdViolazione", connection);
                command.Parameters.AddWithValue("@Descrizione", tipoViolazione.Descrizione);
                command.Parameters.AddWithValue("@IdViolazione", tipoViolazione.IdViolazione);
                connection.Open();
                command.ExecuteNonQuery();
            }
        }

        public void DeleteTipoViolazione(int id)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                var command = new SqlCommand("DELETE FROM Tipo_Violazioni WHERE IdViolazione = @Id", connection);
                command.Parameters.AddWithValue("@Id", id);
                connection.Open();
                command.ExecuteNonQuery();
            }
        }

        // Statistiche
        public List<TotaleVerbali> GetTotaleVerbaliPerTrasgressore()
        {
            var result = new List<TotaleVerbali>();
            using (var connection = new SqlConnection(_connectionString))
            {
                var command = new SqlCommand(@"
                SELECT a.Cognome, a.Nome, COUNT(v.IdVerbale) AS TotaleVerbali
                FROM Verbali v
                JOIN Anagrafica a ON v.IdAnagraficaFK = a.IdAnagrafica
                GROUP BY a.Cognome, a.Nome", connection);
                connection.Open();
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        result.Add(new TotaleVerbali
                        {
                            Trasgressore = reader["Cognome"] + " " + reader["Nome"],
                            TotVerbali = (int)reader["TotaleVerbali"]
                        });
                    }
                }
            }
            return result;
        }

        public List<TotalePuntiDecurtati> GetTotalePuntiDecurtatiPerTrasgressore()
        {
            var result = new List<TotalePuntiDecurtati>();
            using (var connection = new SqlConnection(_connectionString))
            {
                var command = new SqlCommand(@"
                SELECT a.Cognome, a.Nome, SUM(v.DecurtamentoPunti) AS TotalePunti
                FROM Verbali v
                JOIN Anagrafica a ON v.IdAnagraficaFK = a.IdAnagrafica
                GROUP BY a.Cognome, a.Nome", connection);
                connection.Open();
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        result.Add(new TotalePuntiDecurtati
                        {
                            Trasgressore = reader["Cognome"] + " " + reader["Nome"],
                            TotalePunti = (int)reader["TotalePunti"]
                        });
                    }
                }
            }
            return result;
        }

        public List<Violazioni> GetViolazioniConPiuDi10Punti()
        {
            var result = new List<Violazioni>();
            using (var connection = new SqlConnection(_connectionString))
            {
                var command = new SqlCommand(@"
                SELECT 
                    a.Cognome, 
                    a.Nome, 
                    v.Importo, 
                    v.DataViolazione, 
                    v.DecurtamentoPunti
                FROM 
                    Verbali v
                JOIN 
                    Anagrafica a ON v.IdAnagraficaFK = a.IdAnagrafica
                WHERE 
                    v.DecurtamentoPunti > 10", connection);
                connection.Open();
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        result.Add(new Violazioni
                        {
                            Cognome = reader.GetString(0),
                            Nome = reader.GetString(1),
                            Importo = reader.GetDecimal(2),
                            DataViolazione = reader.GetDateTime(3),
                            DecurtamentoPunti = reader.GetInt32(4)
                        });
                    }
                }
            }
            return result;
        }

        public List<Violazioni> GetViolazioniConImportoMaggioreDi400()
        {
            
                var result = new List<Violazioni>();
                using (var connection = new SqlConnection(_connectionString))
                {
                    var command = new SqlCommand(@"
                SELECT 
                    a.Cognome, 
                    a.Nome, 
                    v.Importo, 
                    v.DataViolazione, 
                    v.DecurtamentoPunti
                FROM 
                    Verbali v
                JOIN 
                    Anagrafica a ON v.IdAnagraficaFK = a.IdAnagrafica
                WHERE 
                    v.Importo > 400", connection);
                    connection.Open();
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            result.Add(new Violazioni
                            {
                                Cognome = reader["Cognome"].ToString(),
                                Nome = reader["Nome"].ToString(),
                                Importo = (decimal)reader["Importo"],
                                DataViolazione = (DateTime)reader["DataViolazione"],
                                DecurtamentoPunti = (int)reader["DecurtamentoPunti"]
                            });
                        }
                    }
                }
                return result;
            }
    }
}

