using Patrija.Models.Generated;

namespace Patrija.Core.Contexts
{
	public interface ISiteContext
	{
		IPage CurrentPage { get; }
		Home Home { get; }
		ISiteSettings SiteSettings { get; }
	}
}
