
using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace net_ef_videogame
{
    public static class VideogameManager
    {
        private static readonly string ConnectionString = "Data Source=localhost;Initial Catalog=VideogameDB;Integrated Security=True;Trust Server Certificate=True";

        public static void Insert(Videogame game)
        {
            using (var dbContext = new AppDbContext())
            {
                try
                {
                    dbContext.Videogames.Add(game);
                    dbContext.SaveChanges();
                    Console.WriteLine("Inserimento completato con successo.");
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
            using (var dbContext = new AppDbContext())
            {
                try
                {
                    return dbContext.Videogames.FirstOrDefault(v => v.Id == id)
                        ?? throw new Exception($"Videogioco con ID {id} non trovato.");
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
            using (var dbContext = new AppDbContext())
            {
                try
                {
                    return dbContext.Videogames
                        .Where(v => EF.Functions.Like(v.Name, $"%{partialName}%"))
                        .ToList();
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
            using (var dbContext = new AppDbContext())
            {
                try
                {
                    var gameToDelete = dbContext.Videogames.FirstOrDefault(v => v.Id == id);
                    if (gameToDelete != null)
                    {
                        dbContext.Videogames.Remove(gameToDelete);
                        dbContext.SaveChanges();
                        Console.WriteLine($"Cancellazione completata con successo.");
                    }
                    else
                    {
                        throw new Exception($"Videogioco con ID {id} non trovato.");
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
