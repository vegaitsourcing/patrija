//------------------------------------------------------------------------------
// <auto-generated>
//   This code was generated by a tool.
//
//    Umbraco.ModelsBuilder v8.1.0
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

namespace Patrija.Models.Generated
{
	/// <summary>Support Us</summary>
	[PublishedModel("supportUs")]
	public partial class SupportUs : PublishedContentModel, IPage
	{
		// helpers
#pragma warning disable 0109 // new is redundant
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.0")]
		public new const string ModelTypeAlias = "supportUs";
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.0")]
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.0")]
		public new static IPublishedContentType GetModelContentType()
			=> PublishedModelUtility.GetModelContentType(ModelItemType, ModelTypeAlias);
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.0")]
		public static IPublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<SupportUs, TValue>> selector)
			=> PublishedModelUtility.GetModelPropertyType(GetModelContentType(), selector);
#pragma warning restore 0109

		// ctor
		public SupportUs(IPublishedContent content)
			: base(content)
		{ }

		// properties

		///<summary>
		/// Donation Form: Donation form on support us page
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.0")]
		[ImplementPropertyType("supportUsDonationForm")]
		public IEnumerable<SimpleFormContent> SupportUsDonationForm => this.Value<IEnumerable<SimpleFormContent>>("supportUsDonationForm");

		///<summary>
		/// Testimonials: Container with included users testimonials
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.0")]
		[ImplementPropertyType("supportUsTestimonials")]
		public IEnumerable<TestimonialsContainer> SupportUsTestimonials => this.Value<IEnumerable<TestimonialsContainer>>("supportUsTestimonials");

		///<summary>
		/// Alternate Languages: Language codes (en-US, en-GB etc).
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.0")]
		[ImplementPropertyType("alternateLanguages")]
		public IEnumerable<string> AlternateLanguages => Page.GetAlternateLanguages(this);

		///<summary>
		/// Canonical Link: The page canonical link.
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.0")]
		[ImplementPropertyType("canonicalLink")]
		public Umbraco.Web.Models.Link CanonicalLink => Page.GetCanonicalLink(this);

		///<summary>
		/// External Redirect: Redirects to provided external URL.
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.0")]
		[ImplementPropertyType("externalRedirect")]
		public string ExternalRedirect => Page.GetExternalRedirect(this);

		///<summary>
		/// Hide From Search Engines: Hides page from search engines like Google, Yahoo etc.
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.0")]
		[ImplementPropertyType("hideFromSearchEngines")]
		public bool HideFromSearchEngines => Page.GetHideFromSearchEngines(this);

		///<summary>
		/// Hide From Sitemap: If selected, the node will be hidden from the sitemap.
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.0")]
		[ImplementPropertyType("hideFromSitemap")]
		public bool HideFromSitemap => Page.GetHideFromSitemap(this);

		///<summary>
		/// Hide From Site Search: Hides page from the site search.
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.0")]
		[ImplementPropertyType("hideFromSiteSearch")]
		public bool HideFromSiteSearch => Page.GetHideFromSiteSearch(this);

		///<summary>
		/// Page Title: The page title.
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.0")]
		[ImplementPropertyType("pageTitle")]
		public string PageTitle => Page.GetPageTitle(this);

		///<summary>
		/// Seo Description: The page SEO description.
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.0")]
		[ImplementPropertyType("seoDescription")]
		public string SeoDescription => Page.GetSeoDescription(this);

		///<summary>
		/// Seo Keywords: The page SEO keywords.
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.0")]
		[ImplementPropertyType("seoKeywords")]
		public string SeoKeywords => Page.GetSeoKeywords(this);

		///<summary>
		/// Seo Title: The page SEO title.
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.0")]
		[ImplementPropertyType("seoTitle")]
		public string SeoTitle => Page.GetSeoTitle(this);

		///<summary>
		/// Sitemap Change Frequency: The expected change frequency of the page, associated with the sitemap used by search engines.
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.0")]
		[ImplementPropertyType("sitemapChangeFrequency")]
		public string SitemapChangeFrequency => Page.GetSitemapChangeFrequency(this);

		///<summary>
		/// Sitemap Priority: Priority of the page, associated with the sitemap used by search engines.
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.0")]
		[ImplementPropertyType("sitemapPriority")]
		public string SitemapPriority => Page.GetSitemapPriority(this);

		///<summary>
		/// Hide From Site Navigation: If selected, the node will be hidden from site navigation.
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.0")]
		[ImplementPropertyType("umbracoNaviHide")]
		public bool UmbracoNaviHide => Page.GetUmbracoNaviHide(this);

		///<summary>
		/// Internal Redirect: Redirects to selected Umbraco node.
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.0")]
		[ImplementPropertyType("umbracoRedirect")]
		public IPublishedContent UmbracoRedirect => Page.GetUmbracoRedirect(this);

		///<summary>
		/// URL Alias: Alternative URLs of the node. Separate with commas.
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.0")]
		[ImplementPropertyType("umbracoUrlAlias")]
		public string UmbracoUrlAlias => Page.GetUmbracoUrlAlias(this);

		///<summary>
		/// URL Name: Enables overriding default URL of the node.
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.0")]
		[ImplementPropertyType("umbracoUrlName")]
		public string UmbracoUrlName => Page.GetUmbracoUrlName(this);
	}
}
