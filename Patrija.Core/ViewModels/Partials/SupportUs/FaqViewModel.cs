using Patrija.Common;
using Patrija.Models.Generated;

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
        public string Answer { get; }
    }
}
