using Patrija.Models.Generated;
using System;
using System.Collections.Generic;

namespace Patrija.Core.ViewModels.Shared
{
    public class CommentsBlockViewModel
    {
        public CommentsBlockViewModel(CommentsBlock model, List<CommentViewModel> blogComments)
        {
            LeaveACommentTitle = model.CommentBlockLeaveAcommentTitle;
            LeaveACommentSubtitle = model.CommentsBlockLeaveAcommentSubtitle;
            CommenterNameLabel = model.CommentsBlockCommenterNameLabel;
            CommenterEmailLabel = model.CommentsBlockCommenterEmail;
            LeaveACommentSubmitText = model.CommentBlockLeaveAcommentSubmitText;
            PreviousCommentsTitle = model.CommentsBlockPreviousCommentsTitle;

            BlogId = model.Key;

            Comments = blogComments;
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