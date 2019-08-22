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
    public class CityService:ICityService
    {
        private readonly IGenericRepository<City> cityRepos;
        private readonly IMapper mapper;

        public CityService(IGenericRepository<City> _cityRepos, IMapper _mapper)
        {
            cityRepos = _cityRepos;
            mapper = _mapper;         
        }


        public ICollection<CityDto> GetAllCities()
        {
            var cities = cityRepos.GetAll();
            return mapper.Map<IEnumerable<City>, ICollection<CityDto>>(cities);
        }

    }
}
