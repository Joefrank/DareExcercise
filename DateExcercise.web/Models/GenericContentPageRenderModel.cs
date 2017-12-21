using System.Globalization;
using Umbraco.Core.Models;
using Umbraco.Web.Models;
using Umbraco.Web.PublishedContentModels;


namespace DateExcercise.web.Models
{
    public class GenericContentPageRenderModel : RenderModel
    {
        public GenericContentPageRenderModel(IPublishedContent content)
            : base(content, CultureInfo.CurrentUICulture)
        {
            ContentModel = new GenericContentPage(content);
        }

        public GenericContentPageRenderModel() : this(Umbraco.Web.UmbracoContext.Current.PublishedContentRequest.PublishedContent)
        {
        }

        public string SpecialContentEffect { get; set; }

        public GenericContentPage ContentModel { get; }
    }
}