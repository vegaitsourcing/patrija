using Patrija.Common;
using Patrija.Core.Mappers;
using Patrija.Core.ViewModels.Shared;
using Patrija.Models.Generated;

namespace Patrija.Core.ViewModels.Partials.AboutUsPage
{
    public class PageIntroViewModel
    {
        public PageIntroViewModel(PageIntro pageIntro)
        {
            Guard.AgainstDefaultValue(pageIntro, nameof(pageIntro));

            Title = pageIntro.PageIntroTitle;
            Image = new ImageViewModel(pageIntro.PageIntroImage as Image);
            Text = pageIntro.PageIntroText;
            ShapeVariant = EnumMapper.MapShapeVariant(pageIntro.PageIntroShapeVariant);
        }

        public string Title { get; }
        public string Text { get; }
        public ImageViewModel Image { get; }
        public ShapeVariant ShapeVariant { get; }
    }
}