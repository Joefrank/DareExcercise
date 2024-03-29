//------------------------------------------------------------------------------
// <auto-generated>
//   This code was generated by a tool.
//
//    Umbraco.ModelsBuilder v3.0.7.99
//
//   Changes to this file will be lost if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Web;
using Umbraco.Core.Models;
using Umbraco.Core.Models.PublishedContent;
using Umbraco.Web;
using Umbraco.ModelsBuilder;
using Umbraco.ModelsBuilder.Umbraco;

namespace Umbraco.Web.PublishedContentModels
{
	/// <summary>Home Page</summary>
	[PublishedContentModel("homePage")]
	public partial class HomePage : PublishedContentModel, IPage
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "homePage";
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
#pragma warning restore 0109

		public HomePage(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<HomePage, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}

		///<summary>
		/// Home Background Img
		///</summary>
		[ImplementPropertyType("homeBackgroundImg")]
		public IPublishedContent HomeBackgroundImg
		{
			get { return this.GetPropertyValue<IPublishedContent>("homeBackgroundImg"); }
		}

		///<summary>
		/// Home Signature
		///</summary>
		[ImplementPropertyType("homeSignature")]
		public IHtmlString HomeSignature
		{
			get { return this.GetPropertyValue<IHtmlString>("homeSignature"); }
		}

		///<summary>
		/// Page Main Text
		///</summary>
		[ImplementPropertyType("pageMainText")]
		public IHtmlString PageMainText
		{
			get { return Umbraco.Web.PublishedContentModels.Page.GetPageMainText(this); }
		}

		///<summary>
		/// Page Title
		///</summary>
		[ImplementPropertyType("pageTitle")]
		public string PageTitle
		{
			get { return Umbraco.Web.PublishedContentModels.Page.GetPageTitle(this); }
		}
	}
}
