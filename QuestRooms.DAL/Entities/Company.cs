using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuestRooms.DAL.Entities
{
   public class Company
    {
        [Key]
        public int ID { get; set; }
        [Required]
        public string CompanyName { get; set; }
        public virtual ICollection<Room> Rooms { get; set; }
    }
}
