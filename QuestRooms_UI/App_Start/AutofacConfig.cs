using Autofac;
using Autofac.Integration.Mvc;
using AutoMapper;
using DAL.Repository;
using QuestRooms.BLL.Mapping;
using QuestRooms.BLL.Services.Abstraction;
using QuestRooms.BLL.Services.Implementation;
using QuestRooms.DAL;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace QuestRooms_UI.App_Start
{
    public static class AutofacConfig
    {
        public static void ConfigureAutofac()
        {
            var builder = new ContainerBuilder();
            builder.RegisterControllers(typeof(MvcApplication).Assembly);
            RegisterTypes(builder);
            DependencyResolver.SetResolver(new AutofacDependencyResolver(builder.Build()));
        }
        private static void RegisterTypes(ContainerBuilder builder)
        {
            var mapperConfig = new MapperConfiguration(cfg => cfg.AddProfile<MapperProFile>());
            var mapper = new Mapper(mapperConfig);

            builder.RegisterInstance(mapper).As<IMapper>();
            builder.RegisterType<RoomsContext>().As<DbContext>();
            builder.RegisterGeneric(typeof(GenericRepository<>)).As(typeof(IGenericRepository<>));
            builder.RegisterType<CityService>().As<ICityService>();

            builder.RegisterType<RoomService>().As<IRoomService>();
        }
    }
}