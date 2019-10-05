using System.Linq;
using Patrija.Core.Contexts;
using Patrija.Core.ViewModels.Partials.Home;
using Patrija.Models.Generated;

namespace Patrija.Core.ViewModels.Pages
{
	public class HomeViewModel : PageViewModel
	{
		public HomeViewModel(IPageContext<Home> context) : base(context)
		{
		    var homeIntro = context.Home.HomeIntro.FirstOrDefault();
            HomeIntro = homeIntro != null ? new HomeIntroViewModel(homeIntro) : null; 
        }

        public HomeIntroViewModel HomeIntro { get; }
	}
}
