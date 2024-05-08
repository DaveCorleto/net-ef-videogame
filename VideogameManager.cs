
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace net_ef_videogame
{

    public static class VideogameManager
    {
        public const string STRINGA_DI_CONNESSIONE = "Data Source=localhost;Initial Catalog=serverDiProva;Integrated Security=True";

        public static void Insert(Videogame game)
        {
            using (SqlConnection connection = new SqlConnection(STRINGA_DI_CONNESSIONE))
            {
                try
                {
                    connection.Open();
                    string query = @"INSERT INTO videogames (name, overview, release_date ,created_at, updated_at, software_house_id)
                                     VALUES (@name, @overview, @release_date, @created_at, @updated_at, @sh_id)";

                    using (SqlCommand cmd = new SqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@name", game.Name);
                        cmd.Parameters.AddWithValue("@overview", game.Overview);
                        cmd.Parameters.AddWithValue("@release_date", game.Release_date);
                        cmd.Parameters.AddWithValue("@created_at", game.CreatedAt);
                        cmd.Parameters.AddWithValue("@updated_at", game.UpdatedAt);
                        cmd.Parameters.AddWithValue("@sh_id", game.SoftwareHouseId);

                        int rowsAffected = cmd.ExecuteNonQuery(); // Inserimento nel DB

                        Console.WriteLine($"Inserimento completato con successo. Righe inserite: {rowsAffected}");
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Si è verificato un errore durante l'inserimento: {ex.Message}");
                    throw;
                }
            }
        }

        public static Videogame GetVideogameById(long id)
        {
            using (SqlConnection connection = new SqlConnection(STRINGA_DI_CONNESSIONE))
            {
                try
                {
                    connection.Open();
                    string query = "SELECT * FROM videogames WHERE id = @id";

                    using (SqlCommand cmd = new SqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@id", id);

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                return new Videogame
                                {


                                    Id = Convert.ToInt64(reader["id"]),
                                    Name = (string)reader["name"],
                                    Overview = (string)reader["overview"],
                                    Release_date = (DateTime)reader["release_date"],
                                    CreatedAt = (DateTime)reader["created_at"],
                                    UpdatedAt = (DateTime)reader["updated_at"],
                                    SoftwareHouseId = (int)reader["software_house_id"]
                                };
                            }
                            else
                            {
                                throw new Exception($"Videogioco con ID {id} non trovato.");
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Si è verificato un errore durante la ricerca: {ex.Message}");
                    throw;
                }
            }
        }
        public static List<Videogame> SearchVideogamesByName(string partialName)
        {
            List<Videogame> games = new List<Videogame>();

            using (SqlConnection connection = new SqlConnection(STRINGA_DI_CONNESSIONE))
            {
                try
                {
                    connection.Open();
                    string query = "SELECT * FROM videogames WHERE name LIKE @partialName";

                    using (SqlCommand cmd = new SqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@partialName", $"%{partialName}%");

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                games.Add(new Videogame
                                {
                                    Id = (int)reader["id"],
                                    Name = (string)reader["name"],
                                    Overview = (string)reader["overview"],
                                    Release_date = (DateTime)reader["release_date"],
                                    CreatedAt = (DateTime)reader["created_at"],
                                    UpdatedAt = (DateTime)reader["updated_at"],
                                    SoftwareHouseId = (int)reader["software_house_id"]
                                });
                            }
                        }
                    }

                    return games;
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Errore durante la ricerca: {ex.Message}");
                    throw;
                }
            }
        }

        public static void DeleteVideogame(long id)
        {
            using (SqlConnection connection = new SqlConnection(STRINGA_DI_CONNESSIONE))
            {
                try
                {
                    connection.Open();
                    string query = "DELETE FROM videogames WHERE id = @id";

                    using (SqlCommand cmd = new SqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@id", id);

                        int rowsAffected = cmd.ExecuteNonQuery(); // Cancella nel database

                        Console.WriteLine($"Cancellazione completata con successo. Righe cancellate: {rowsAffected}");
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Si è verificato un errore durante la cancellazione: {ex.Message}");
                    throw;
                }
            }
        }
    }
}
