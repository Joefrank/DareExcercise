
using System.Web.Mvc;
using DateExcercise.web.Models;
using Umbraco.Web.Models;

namespace DateExcercise.web.Controllers
{
    public class HomePageController : Umbraco.Web.Mvc.RenderMvcController
    {
        public override ActionResult Index(RenderModel model)
        {
            //Do some stuff here, then return the base method
            var pageModel = new HomeRenderModel()
            {
               SpecialEffect = "This is just some special effect"
            };
            return base.Index(pageModel);
        }
      
    }
}