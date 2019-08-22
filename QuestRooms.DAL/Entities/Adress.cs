using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuestRooms.DAL.Entities
{
   
    public class Adress
    {
        [Key]
        public int ID { get; set; }
        [Required]
        public virtual Country Country { get; set; }
        [Required]
        public virtual City City { get; set; }
        [Required]
        public virtual Street Street { get; set; }
        public string HouseNum { get; set; }
        public virtual ICollection<Room> Rooms { get; set; }

    }
}
