using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;


namespace net_ef_videogame
{           
            //Comunico all'orm che la Tabel si chiama videogames e che deve tenere 
            //"pronto" Name perchè è una properties importante

            [Table("videogames")]
            [Index(nameof(Name), IsUnique = true)]
    public class Videogame
        {   
            //comunico all'ORM che Id è la Key 
            [Key] public int Id { get; set; }
            public string Name { get; set; }
            public string Overview { get; set; }
            public DateTime ReleaseDate { get; set; }
            public DateTime CreatedAt { get; set; }
            public DateTime UpdatedAt { get; set; }

            
            // Vincolo 1:N
            public int SoftwareHouseId { get; set; }
            [ForeignKey("SoftwareHouseId")]
            public SoftwareHouse SoftwareHouse { get; set; }

     



        public Videogame()
            {

                CreatedAt = DateTime.Now;
                UpdatedAt = DateTime.Now;
            }

        }

    }

