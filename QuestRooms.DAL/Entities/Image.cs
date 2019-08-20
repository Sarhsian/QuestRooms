using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuestRooms.DAL.Entities
{
    public class Image
    {
        [Key]
        public int ID { get; set; }
        public string Name { get; set; }
        public ICollection<Room> Rooms { get; set; }
        public string Path { get; set; }
    }
}
