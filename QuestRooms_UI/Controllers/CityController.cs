using QuestRooms.BLL.Services.Abstraction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace QuestRooms_UI.Controllers
{
    public class CityController : Controller
    {
        private readonly ICityService cityService;
        
        public CityController(ICityService _cityService)
        {
            cityService = _cityService;
        }

        public string Index()
        {
            var cities = cityService.GetAllCities();
            return "Hello";
        }
    }
}