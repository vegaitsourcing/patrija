using Patrija.Core.Mappers;
using Patrija.Core.ViewModels.Shared;
using Patrija.Models.Generated;

namespace Patrija.Core.ViewModels.Partials.Features
{
    public class TextBlockViewModel
    {
        public TextBlockViewModel(TextBlock textBlock)
        {
            Title = textBlock.TextBlockTitle;
            TextLeft = textBlock.TextBlockTextLeft;
            TextRight = textBlock.TextBlockTextRight;
        }
        
        public string Title { get; }
        
        public string TextLeft { get; }
        public string TextRight { get; }
        
    }
}