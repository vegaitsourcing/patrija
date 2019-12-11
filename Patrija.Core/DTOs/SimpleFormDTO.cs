using System;
using System.ComponentModel.DataAnnotations;

namespace Patrija.Core.Dtos
{
    [Serializable]
    public class SimpleFormDto
    {
        [Required]
        public string FullName { get; set; }

        [Required]
        [EmailAddress]
        public string EmailAddress { get; set; }

        [Required]
        public string Comment { get; set; }

        public string PageName { get; set; }


        public string GetCommenterNameOrDefault()
            => string.IsNullOrEmpty(FullName) ? "Anoniman" : FullName;
    }
}
