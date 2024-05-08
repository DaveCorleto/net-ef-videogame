using Microsoft.EntityFrameworkCore;
using System;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace net_ef_videogame
{
    [Table("SoftwareHouse")]
    [Index(nameof(Name), IsUnique = true)]
    public class SoftwareHouse
    {
        [Key]
        public int Id { get; set; }

        public string Name { get; set; }
        public string Description { get; set; }
        public int EstablishedYear { get; set; } 

        public List<Videogame> Videogames { get; set; }

        public SoftwareHouse()
        {
            Name = string.Empty;
            Description = string.Empty;
            EstablishedYear = 0;  
            Videogames = new List<Videogame>();
        }
        
    }


}
