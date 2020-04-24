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
            Image = pageIntro.PageIntroImage != null ? new ImageViewModel(pageIntro.PageIntroImage as Image) : default(ImageViewModel);
            Text = pageIntro.PageIntroText;
            Link = pageIntro.Link != null ? new LinkViewModel(pageIntro.Link) : default(LinkViewModel);
            ShapeVariant = EnumMapper.MapShapeVariant(pageIntro.PageIntroShapeVariant);
        }

        public string Title { get; }
        public string Text { get; }
        public ImageViewModel Image { get; }
        public LinkViewModel Link { get; }
        public ShapeVariant ShapeVariant { get; }
    }
}