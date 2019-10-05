using System;
using Patrija.Core.ViewModels.Shared;
using Patrija.Models.Generated;

namespace Patrija.Core.ViewModels.Partials.Home
{
    public class SupportContentBoxViewModel
    {
        public SupportContentBoxViewModel(SupportContentBox supportContentBox)
        {
            if (supportContentBox == null) throw new ArgumentNullException(nameof(supportContentBox));

            Title = supportContentBox.SupportContentBoxTitle;
            Text = supportContentBox.SupportContentBoxText;
            ButtonColor = supportContentBox.SupportContentBoxButtonColor;
            Link = new LinkViewModel(supportContentBox.SupportContentBoxButtonUrl);
        }

        public string Title { get; }
        public string Text { get;  }
        public string ButtonColor { get; }

        public LinkViewModel Link { get; }
    }
}
