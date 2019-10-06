using Patrija.Common;
using Patrija.Models.Generated;
using System.Linq;

namespace Patrija.Core.ViewModels.Partials.SupportUs
{
    public class FaqContainerViewModel
    {
        public FaqContainerViewModel(FaqContainer faqContainer)
        {
            Guard.AgainstDefaultValue(faqContainer);
            Guard.AgainstDefaultValue(faqContainer.FaqContainerItems);

            Title = faqContainer.FaqTitle;
            Items = faqContainer.FaqContainerItems.Select(item => new FaqViewModel(item)).ToArray();
        }

        public string Title { get; }
        public FaqViewModel[] Items { get; }
    }
}
