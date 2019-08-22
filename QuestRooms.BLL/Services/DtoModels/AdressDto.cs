using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuestRooms.BLL.Services.DtoModels
{
    public class AdressDto
    {
        public int ID { get; set; }
        public CountryDto Country { get; set; }
        public CityDto City { get; set; }
        public StreetDto Street { get; set; }
        string HouseNum { get; set; }
    }
}
