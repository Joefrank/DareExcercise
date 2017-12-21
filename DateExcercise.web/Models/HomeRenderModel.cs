
using System.Globalization;
using Umbraco.Core.Models;
using Umbraco.Web.Models;
using Umbraco.Web.PublishedContentModels;

namespace DateExcercise.web.Models
{
    public class HomeRenderModel : RenderModel
    {
        /// <summary>
        /// HomeModel Constructor
        /// </summary>
        /// <param name="content">Umbraco Published Content</param>
        public HomeRenderModel(IPublishedContent content)
            : base(content, CultureInfo.CurrentUICulture)
        {
            ContentModel = new HomePage(content);
        }

        public HomeRenderModel() : this(Umbraco.Web.UmbracoContext.Current.PublishedContentRequest.PublishedContent)
        {
        }

        public string SpecialEffect { get; set; }

        public HomePage ContentModel { get; }
    }
   
}