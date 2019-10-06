using System.Web.Mvc;
using Patrija.Core.ViewModels.Partials.AboutUsPage;
using Patrija.Core.ViewModels.Partials.Blog;
using Patrija.Core.ViewModels.Partials.ContactUs;
using Patrija.Core.ViewModels.Partials.Features;
using Patrija.Core.ViewModels.Partials.Home;
using Patrija.Core.ViewModels.Partials.SupportUs;
using Patrija.Core.ViewModels.Shared;

namespace Patrija.Core.Controllers.Surface.Partials
{
    public class NestedContentController : BaseSurfaceController
    {
        [ChildActionOnly]
        public ActionResult PageIntro(PageIntroViewModel viewModel)
            => PartialView(viewModel);

        [ChildActionOnly]
        public ActionResult HomeIntro(HomeIntroViewModel viewModel)
            => PartialView(viewModel);

        [ChildActionOnly]
        public ActionResult TaggedFeature(TaggedFeatureViewModel viewModel)
            => PartialView(viewModel);

        [ChildActionOnly]
        public ActionResult LinksList(LinksListViewModel viewModel)
            => PartialView(viewModel);

        [ChildActionOnly]
        public ActionResult JoinUs(JoinUsViewModel viewModel)
            => PartialView(viewModel);

        [ChildActionOnly]
        public ActionResult AboutUs(AboutUsViewModel viewModel)
            => PartialView(viewModel);

        [ChildActionOnly]
        public ActionResult ImageWithText(ImageWithTextViewModel viewModel)
            => PartialView(viewModel);

        [ChildActionOnly]
        public ActionResult ArticleContainer(ArticleContainerViewModel viewModel)
            => PartialView(viewModel);

        [ChildActionOnly]
        public ActionResult Block(object viewModel)
            => PartialView(viewModel);

        [ChildActionOnly]
        public ActionResult TestimonialsContainer(TestimonialsContainerViewModel viewModel)
            => PartialView(viewModel);

        [ChildActionOnly]
        public ActionResult FaqContainer(FaqContainerViewModel viewModel)
            => PartialView(viewModel);

        [ChildActionOnly]
        public ActionResult SimpleForm(SimpleFormViewModel viewModel, string formId)
        {
            ViewData["formId"] = formId;
            return PartialView(viewModel);
        }

        [ChildActionOnly]
        public ActionResult Donations(DonationsViewModel viewModel)
            => PartialView(viewModel);

        [ChildActionOnly]
        public ActionResult ContactMap(ContactMapViewModel viewModel)
            => PartialView(viewModel);

        [ChildActionOnly]
        public ActionResult BlogIntro(BlogIntroViewModel viewModel)
            => PartialView(viewModel);
        
        [ChildActionOnly]
        public ActionResult BlogArticleContent(ArticleContentViewModel viewModel)
            => PartialView(viewModel);

        [ChildActionOnly]
        public ActionResult FormWithoutDescription(FormWithoutDescriptionViewModel viewModel, string formId)
        {
            ViewData["formId"] = formId;
            ViewData["containerClass"] = containerClass;
            ViewData["titleClass"] = titleClass;
            return PartialView(viewModel);
        }

        [ChildActionOnly]
        public ActionResult ContactForm(ContactFormViewModel viewModel)
            => PartialView(viewModel);
    }
}