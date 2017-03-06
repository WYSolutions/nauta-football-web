using Microsoft.Practices.Unity;
using System.Web.Http;
using NautaFootball.Data.Repositories;
using NautaFootball.Emails;
using Unity.WebApi;

namespace NautaFootball
{
    public static class UnityConfig
    {
        public static void RegisterComponents()
        {
			var container = new UnityContainer();
            
            // register all your components with the container here
            // it is NOT necessary to register your controllers
            
            container.RegisterType<IEmailsRepository, EmailsRepository>();
            container.RegisterType<IScoreBoardService, ScoreboardService>();
            
            GlobalConfiguration.Configuration.DependencyResolver = new UnityDependencyResolver(container);
        }
    }
}