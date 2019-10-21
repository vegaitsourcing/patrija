using Patrija.Common;
using Patrija.Models.Generated;
using System.Web;

namespace Patrija.Core.ViewModels.Partials.SupportUs
{
    public class FaqViewModel
    {
        public FaqViewModel(FaqItem faqItem)
        {
            Guard.AgainstDefaultValue(faqItem);

            Question = faqItem.FaqItemQuestionText;
            Answer = faqItem.FaqItemAnswerText;
        }

        public string Question { get; }
        public IHtmlString Answer { get; }
    }
}
