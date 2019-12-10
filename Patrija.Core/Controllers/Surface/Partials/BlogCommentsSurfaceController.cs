using System;
using System.Web.Mvc;
using Patrija.Common.Extensions;
using Patrija.Core.Dtos;
using Patrija.Models.Generated;

namespace Patrija.Core.Controllers.Surface.Partials
{
    public class BlogCommentsSurfaceController : BaseSurfaceController
    {
        public ActionResult AddComment(CommentDto comment)
        {
            var contentService = Services.ContentService;

            var content = contentService.Create(CreateCommentName(comment), contentService.GetById(comment.BlogPageId),
                BlogComment.ModelTypeAlias);
            
            content.SetValue(nameof(BlogComment.BlogCommentCommenter).ToCamelCase(), comment.GetCommenterNameOrDefault());
            content.SetValue(nameof(BlogComment.BlogCommentText).ToCamelCase(), comment.CommentText);

            contentService.SaveAndPublish(content);
            
            return Content("Ok");
        }

        private static string CreateCommentName(CommentDto comment)
            => $"{comment.GetCommenterNameOrDefault()}:{DateTime.UtcNow.ToLongDateString()}";
    }
}