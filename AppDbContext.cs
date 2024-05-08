using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Quic;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client;

namespace net_ef_videogame
{

    //Qui si ridefinisce il DBContext in modo che il sistema possa capire le relazioni tra le varie tabelle

    public class AppDbContext : DbContext
    {
        const string _connectionString = "Data Source=localhost;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False;Initial Catalog=VideogameDB;";

        public DbSet<Videogame> Videogames { get; set; }
        public DbSet<SoftwareHouse> SoftwareHouses { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(_connectionString); // Configura l'opzione di connessione
        }

        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    modelBuilder.Entity<Videogame>()
        //        .HasOne(v => v.SoftwareHouse)
        //        .WithMany(sh => sh.Videogames)
        //        .HasForeignKey(v => v.SoftwareHouseId);
        //}
    }



}
