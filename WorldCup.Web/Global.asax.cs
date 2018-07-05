using AutoMapper;
using System.Web.Mvc;
using System.Web.Routing;
using WorldCup.Domain.Entities;
using WorldCup.Web.Models;

namespace WorldCup.Web
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            RouteConfig.RegisterRoutes(RouteTable.Routes);

            Mapper.Initialize(x =>
            {
                x.CreateMap<Match, ModelViewMatch>();
                x.CreateMap<ModelViewMatch, Match>();
            });

        }
    }
}
