using System.Linq;
using Patrija.Core.Contexts;
using Patrija.Core.ViewModels.Partials.Features;
using Patrija.Models.Generated;

namespace Patrija.Core.ViewModels.Pages
{
    public class PageVariant1ViewModel : PageViewModel
    {
        public PageVariant1ViewModel(IPageContext<PageVariant1> context) : base(context)
        {
            var imageWithText = context.Page.PageVariant1ImageWithText.FirstOrDefault();
            ImageWithText = imageWithText != null ? new ImageWithTextViewModel(imageWithText) : null;

            var textBlock = context.Page.TextBlock.FirstOrDefault();
            TextBlockViewModel = textBlock != null ? new TextBlockViewModel(textBlock) : null;
        }

        public ImageWithTextViewModel ImageWithText { get; }
        public TextBlockViewModel TextBlockViewModel { get; }
    }
}