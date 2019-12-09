using Patrija.Models.Generated;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Patrija.Core.ViewModels.Shared
{
    public class CommentsBlockViewModel
    {
        public CommentsBlockViewModel(CommentsBlock model)
        {
            LeaveACommentTitle = model.Title;
            LeaveACommentSubtitle = model.Subtitle;

            BlogId = model.Key;

            Comments = model.Comments?.OfType<BlogComment>().Select(c => new CommentViewModel(c)).ToList();
        }

        public List<CommentViewModel> Comments { get; }

        public string LeaveACommentTitle { get; }

        public string LeaveACommentSubtitle { get; }

        public string CommenterNameLabel { get; }

        public string CommenterEmailLabel { get; }

        public string LeaveACommentSubmitText { get; }

        public string PreviousCommentsTitle { get; }

        public Guid BlogId { get; }
    }
}