using Patrija.Models.Generated;

namespace Patrija.Core.ViewModels.Shared
{
    public class CommentViewModel
    {
        public CommentViewModel(BlogComment comment)
        {
            CommenterName = comment.BlogCommentCommenter;
            CommentText = comment.BlogCommentText;
        }
        
        public string CommenterName { get; }
        
        public string CommentText { get; }
    }
}