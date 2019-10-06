using System;
using System.Linq;
using Patrija.Models.Generated;
using Umbraco.Web;

namespace Patrija.Core.ViewModels.Shared
{
    public class CommentsBlockViewModel
    {
        public CommentViewModel[] Comments { get; }
        
        public string LeaveACommentTitle { get; }
        
        public string LeaveACommentSubtitle { get; }
        
        public string CommenterNameLabel { get; }
        
        public string CommenterEmailLabel { get; }
        
        public string LeaveACommentSubmitText { get; }
        
        public string PreviousCommentsTitle { get; }
        
        public Guid BlogId { get; }
        
        public CommentsBlockViewModel(BlogArticle article)
        {
            var commentBlock = article.Ancestor<Blog>().BlogCommentsBlock;

            LeaveACommentTitle = commentBlock.CommentBlockLeaveAcommentTitle;
            LeaveACommentSubtitle = commentBlock.CommentsBlockLeaveAcommentSubtitle;
            CommenterNameLabel = commentBlock.CommentsBlockCommenterNameLabel;
            CommenterEmailLabel = commentBlock.CommentsBlockCommenterEmail;
            LeaveACommentSubmitText = commentBlock.CommentBlockLeaveAcommentSubmitText;
            PreviousCommentsTitle = commentBlock.CommentsBlockPreviousCommentsTitle;

            BlogId = article.Key;

            Comments = article.Children<BlogComment>().Select(c => new CommentViewModel(c)).ToArray();
        }
    }
}