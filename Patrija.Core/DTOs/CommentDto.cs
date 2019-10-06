using System;
using System.ComponentModel.DataAnnotations;

namespace Patrija.Core.Dtos
{
    public class CommentDto
    {
        [Required]
        public string Commenter { get; set; }
        
        [Required]
        public string CommenterEmail { get; set; }
        
        [Required]
        public string CommentText { get; set; }
        
        public Guid BlogPageId { get; set; }

        public string GetCommenterNameOrDefault()
            => string.IsNullOrEmpty(Commenter) ? "Anoniman" : Commenter;
    }
}