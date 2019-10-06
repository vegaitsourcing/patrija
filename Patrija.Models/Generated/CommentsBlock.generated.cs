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
	/// <summary>Comments Block</summary>
	[PublishedModel("commentsBlock")]
	public partial class CommentsBlock : PublishedElementModel
	{
		// helpers
#pragma warning disable 0109 // new is redundant
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.0")]
		public new const string ModelTypeAlias = "commentsBlock";
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.0")]
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.0")]
		public new static IPublishedContentType GetModelContentType()
			=> PublishedModelUtility.GetModelContentType(ModelItemType, ModelTypeAlias);
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.0")]
		public static IPublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<CommentsBlock, TValue>> selector)
			=> PublishedModelUtility.GetModelPropertyType(GetModelContentType(), selector);
#pragma warning restore 0109

		// ctor
		public CommentsBlock(IPublishedElement content)
			: base(content)
		{ }

		// properties

		///<summary>
		/// Leave A Comment Submit Text
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.0")]
		[ImplementPropertyType("commentBlockLeaveACommentSubmitText")]
		public string CommentBlockLeaveAcommentSubmitText => this.Value<string>("commentBlockLeaveACommentSubmitText");

		///<summary>
		/// Leave A Comment Title
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.0")]
		[ImplementPropertyType("commentBlockLeaveACommentTitle")]
		public string CommentBlockLeaveAcommentTitle => this.Value<string>("commentBlockLeaveACommentTitle");

		///<summary>
		/// Commenter Email
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.0")]
		[ImplementPropertyType("commentsBlockCommenterEmail")]
		public string CommentsBlockCommenterEmail => this.Value<string>("commentsBlockCommenterEmail");

		///<summary>
		/// Commenter Name Label
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.0")]
		[ImplementPropertyType("commentsBlockCommenterNameLabel")]
		public string CommentsBlockCommenterNameLabel => this.Value<string>("commentsBlockCommenterNameLabel");

		///<summary>
		/// Leave A Comment Subtitle
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.0")]
		[ImplementPropertyType("commentsBlockLeaveACommentSubtitle")]
		public string CommentsBlockLeaveAcommentSubtitle => this.Value<string>("commentsBlockLeaveACommentSubtitle");

		///<summary>
		/// Previous Comments Title
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.0")]
		[ImplementPropertyType("commentsBlockPreviousCommentsTitle")]
		public string CommentsBlockPreviousCommentsTitle => this.Value<string>("commentsBlockPreviousCommentsTitle");
	}
}
