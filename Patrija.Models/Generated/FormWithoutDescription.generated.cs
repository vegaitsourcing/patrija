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
	/// <summary>Form Without Description</summary>
	[PublishedModel("formWithoutDescription")]
	public partial class FormWithoutDescription : PublishedElementModel
	{
		// helpers
#pragma warning disable 0109 // new is redundant
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.0")]
		public new const string ModelTypeAlias = "formWithoutDescription";
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.0")]
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.0")]
		public new static IPublishedContentType GetModelContentType()
			=> PublishedModelUtility.GetModelContentType(ModelItemType, ModelTypeAlias);
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.0")]
		public static IPublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<FormWithoutDescription, TValue>> selector)
			=> PublishedModelUtility.GetModelPropertyType(GetModelContentType(), selector);
#pragma warning restore 0109

		// ctor
		public FormWithoutDescription(IPublishedElement content)
			: base(content)
		{ }

		// properties

		///<summary>
		/// Submit Button Color
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.0")]
		[ImplementPropertyType("formWithotDescriptionSubmitButtonColor")]
		public string FormWithotDescriptionSubmitButtonColor => this.Value<string>("formWithotDescriptionSubmitButtonColor");

		///<summary>
		/// Comment Field Error Message
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.0")]
		[ImplementPropertyType("formWithoutDescriptionCommentError")]
		public string FormWithoutDescriptionCommentError => this.Value<string>("formWithoutDescriptionCommentError");

		///<summary>
		/// Comment Field Title
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.0")]
		[ImplementPropertyType("formWithoutDescriptionCommentFieldTitle")]
		public string FormWithoutDescriptionCommentFieldTitle => this.Value<string>("formWithoutDescriptionCommentFieldTitle");

		///<summary>
		/// Email Field Error Message
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.0")]
		[ImplementPropertyType("formWithoutDescriptionEmailError")]
		public string FormWithoutDescriptionEmailError => this.Value<string>("formWithoutDescriptionEmailError");

		///<summary>
		/// Email Field Title
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.0")]
		[ImplementPropertyType("formWithoutDescriptionEmailFieldTitle")]
		public string FormWithoutDescriptionEmailFieldTitle => this.Value<string>("formWithoutDescriptionEmailFieldTitle");

		///<summary>
		/// Name Field Error Message
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.0")]
		[ImplementPropertyType("formWithoutDescriptionNameError")]
		public string FormWithoutDescriptionNameError => this.Value<string>("formWithoutDescriptionNameError");

		///<summary>
		/// Name Field Title
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.0")]
		[ImplementPropertyType("formWithoutDescriptionNameFieldTitle")]
		public string FormWithoutDescriptionNameFieldTitle => this.Value<string>("formWithoutDescriptionNameFieldTitle");

		///<summary>
		/// Submit Button Text
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.0")]
		[ImplementPropertyType("formWithoutDescriptionSubmitButtonText")]
		public string FormWithoutDescriptionSubmitButtonText => this.Value<string>("formWithoutDescriptionSubmitButtonText");

		///<summary>
		/// Success Message
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.0")]
		[ImplementPropertyType("formWithoutDescriptionSuccessMessage")]
		public string FormWithoutDescriptionSuccessMessage => this.Value<string>("formWithoutDescriptionSuccessMessage");

		///<summary>
		/// Title
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.0")]
		[ImplementPropertyType("formWithoutDescriptionTitle")]
		public string FormWithoutDescriptionTitle => this.Value<string>("formWithoutDescriptionTitle");
	}
}