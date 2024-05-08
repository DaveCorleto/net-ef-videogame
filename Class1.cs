using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Quic;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace net_ef_videogame
{
    
    //Qui si ridefinisce il DBContext in modo che il sistema possa capire le relazioni tra le varie tabelle
    public class AppDbContext : DbContext
    {
        public DbSet<Videogame> Videogames { get; set; }
        public DbSet<SoftwareHouse> SoftwareHouses { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Videogame>()
                .HasOne(v => v.SoftwareHouse)
                .WithMany(s => s.Videogames)
                .HasForeignKey(v => v.SoftwareHouseId);

            
        }
        //Qui definisco la connessione al mio DB
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=localhost;Initial Catalog=VideogameDB;Integrated Security=True;Trust Server Certificate=True");
        }
    }

}
