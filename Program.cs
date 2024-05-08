using System.Data.SqlClient;

namespace net_ef_videogame
{
    public class Program
    {
        public const string _connectionString = "Data Source=localhost;Initial Catalog=serverDiProva;Integrated Security=True";
        
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Menu:");
                Console.WriteLine("1. Inserire un nuovo videogioco");
                Console.WriteLine("2. Ricercare un videogioco per ID");
                Console.WriteLine("3. Ricercare tutti i videogiochi aventi il nome contenente una determinata stringa");
                Console.WriteLine("4. Cancellare un videogioco");
                Console.WriteLine("5. Chiudere il programma");

                Console.Write("Inserisci la tua scelta (1-5): ");
                string choice = Console.ReadLine();

                //switch (choice)
                //{
                //    case "1":
                //        // Inserire un nuovo videogioco
                //        Videogame newGame = new Videogame();
                //        Console.Write("Nome del videogioco: ");
                //        newGame.Name = Console.ReadLine();
                //        Console.Write("Descrizione: ");
                //        newGame.Overview = Console.ReadLine();
                //        Console.Write("ID della software house: ");

                //        long id_sh = Convert.ToInt64(Console.ReadLine());


                //        newGame.SoftwareHouseId = id_sh;

                //        VideogameManager.Insert(newGame);
                //        break;

                //    case "2":
                //        // Ricercare un videogioco per ID
                //        Console.Write("Inserisci l'ID del videogioco da cercare: ");
                //        if (int.TryParse(Console.ReadLine(), out int gameId))
                //        {
                //            Videogame game = VideogameManager.GetVideogameById(gameId);
                //            if (game != null)
                //            {
                //                Console.WriteLine($"Videogioco trovato: {game.Name}");
                //            }
                //            else
                //            {
                //                Console.WriteLine($"Nessun videogioco trovato con ID {gameId}.");
                //            }
                //        }
                //        break;

                //    case "3":
                //        // Ricercare tutti i videogiochi per nome parziale
                //        Console.Write("Inserisci parte del nome da cercare: ");
                //        string partialName = Console.ReadLine();
                //        List<Videogame> foundGames = VideogameManager.SearchVideogamesByName(partialName);
                //        if (foundGames.Any())
                //        {
                //            Console.WriteLine("Videogiochi trovati:");
                //            foreach (var game in foundGames)
                //            {
                //                Console.WriteLine($"ID: {game.Id}, Nome: {game.Name}");
                //            }
                //        }
                //        else
                //        {
                //            Console.WriteLine($"Nessun videogioco trovato con nome contenente '{partialName}'.");
                //        }
                //        break;

                //    case "4":
                //        // Cancellare un videogioco per ID
                //        Console.Write("Inserisci l'ID del videogioco da cancellare: ");
                //        if (long.TryParse(Console.ReadLine(), out long deleteId))
                //        {
                //            VideogameManager.DeleteVideogame(deleteId);
                //        }
                //        break;

                //    case "5":
                //        // Chiudere il programma
                //        Console.WriteLine("Arrivederci!");
                //        return;

                //    default:
                //        Console.WriteLine("Scelta non valida. Riprova.");
                //        break;
                //}

                //Console.WriteLine();
            }
        }


    }
}