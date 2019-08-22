using AutoMapper;
using DAL.Repository;
using QuestRooms.BLL.Services.Abstraction;
using QuestRooms.BLL.Services.DtoModels;
using QuestRooms.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuestRooms.BLL.Services.Implementation
{
    public class RoomService : IRoomService
    {
        private readonly IGenericRepository<Room> roomRepos;
        private readonly IMapper mapper;

        public RoomService(IGenericRepository<Room> _roomRepos, IMapper _mapper)
        {
            roomRepos = _roomRepos;
            mapper = _mapper;
        }

        public ICollection<RoomDto> GetAllCities()
        {
            var rooms = roomRepos.GetAll();
            return mapper.Map<IEnumerable<Room>, ICollection<RoomDto>>(rooms);
        }
    }
}
