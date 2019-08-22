using AutoMapper;
using QuestRooms.BLL.Services.DtoModels;
using QuestRooms.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuestRooms.BLL.Mapping
{
    public class MapperProFile : Profile
    {
        public MapperProFile()
        {
            CreateMap<City, CityDto>();
        }

    }
}
