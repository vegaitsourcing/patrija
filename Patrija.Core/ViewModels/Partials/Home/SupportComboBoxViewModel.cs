using System;
using Patrija.Core.ViewModels.Shared;
using Patrija.Models.Generated;
using Patrija.Core.ViewModels.Partials.Features;

namespace Patrija.Core.ViewModels.Partials.Home
{
    public class SupportContentBoxViewModel
    {
        public SupportContentBoxViewModel(SupportContentBox supportContentBox)
        {
            if (supportContentBox == null) throw new ArgumentNullException(nameof(supportContentBox));

            Title = supportContentBox.SupportContentBoxTitle;
            Text = supportContentBox.SupportContentBoxText;
            ButtonClass = Dictionaries.SupportContentBoxButtonType[supportContentBox.SupportContentBoxButtonColor];
            Link = new LinkViewModel(supportContentBox.SupportContentBoxButtonUrl);
        }

        public string Title { get; }
        public string Text { get;  }
        public string ButtonClass { get; }

        public LinkViewModel Link { get; }
    }
}
