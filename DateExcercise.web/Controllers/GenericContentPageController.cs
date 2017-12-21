
using System.Web.Mvc;
using DateExcercise.web.Models;
using Umbraco.Web.Models;

namespace DateExcercise.web.Controllers
{
    public class GenericContentPageController : Umbraco.Web.Mvc.RenderMvcController
    {
        public override ActionResult Index(RenderModel model)
        {
            var pageModel = new GenericContentPageRenderModel()
            {
                SpecialContentEffect = "This is just some special effect"
            };
            return base.Index(pageModel);
        }

    }
}