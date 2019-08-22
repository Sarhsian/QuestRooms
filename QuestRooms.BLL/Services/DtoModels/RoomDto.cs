using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuestRooms.BLL.Services.DtoModels
{
    public class RoomDto
    {
        public int ID { get; set; }
        public string Name { get; set; }
        
        public string Description { get; set; }
        
        public TimeSpan TimeOfCompliting { get; set; }
        
        public int MinCountOfPlayers { get; set; }
        
        public int MaxCountOfPlayers { get; set; }
        
        public int MinAgeOfPlayers { get; set; }
        
        public string PhoneNumber { get; set; }
        
        public string Email { get; set; }
        
        public double Rating { get; set; }
        
        public int LvlOfFear { get; set; }
        
        public int LvlOfDifficulty { get; set; }
        
        public string Logo { get; set; }
    }
}
