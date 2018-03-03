using System.Web.Routing;
using Sitecore.Pipelines;
using System.Web.Http;
using System.Web.Mvc;

namespace SLH.Feature.Location
{
    public class RegisterApiRoutes : Sitecore.Mvc.Pipelines.Loader.InitializeRoutes
    {
        public override void Process(PipelineArgs args)
        {
            //Register Custom Routes
            RouteConfig.RegisterRoutes(RouteTable.Routes);
        }
    }
}