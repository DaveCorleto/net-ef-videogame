using Microsoft.EntityFrameworkCore;
using System;
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
        public string EstablishedYear { get; set; }

        // Indico che per ogni SoftwareHouse ci sono molti
        //videogiochi: questo fa capire al sistema la relazione di 1:N tra Videogiochi e 
        //SoftwareHouse

        public ICollection<Videogame> Videogames { get; set; }


    }

}
