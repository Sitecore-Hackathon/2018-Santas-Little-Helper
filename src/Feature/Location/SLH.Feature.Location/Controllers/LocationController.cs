using System.Web.Mvc;
using Sitecore.Mvc.Presentation;

namespace SLH.Feature.Location.Controllers
{
    public class LocationController : Controller
    {
        public ActionResult LocationMap()
        {
            var model = RenderingContext.Current.Rendering.Item;
            return View(model);
        }
    }
}