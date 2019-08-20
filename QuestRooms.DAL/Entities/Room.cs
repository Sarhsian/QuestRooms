using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuestRooms.DAL.Entities
{
    public class Room
    {
        [Key]
        public int ID { get; set; }
        [Required]
        public string Name{ get; set; }
        [Required]
        public string Description{ get; set; }
        [Required]
        public TimeSpan TimeOfCompliting{ get; set; }
        [Required]
        public int MinCountOfPlayers{ get; set; }
        [Required]
        public int MaxCountOfPlayers{ get; set; }
        [Required]
        public int MinAgeOfPlayers{ get; set; }
        [Required]
        public string PhoneNumber{ get; set; }
        [Required]
        public string Email{ get; set; }
        [Required]
        public double Rating{ get; set; }
        [Required]
        public int LvlOfFear{ get; set; }
        [Required]
        public int LvlOfDifficulty{ get; set; }
        [Required]
        public string Logo{ get; set; }
        public virtual Adress Adress { get; set; }
        public virtual Image Images { get; set; }
    }
}
