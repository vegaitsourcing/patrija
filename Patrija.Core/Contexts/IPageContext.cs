using Patrija.Models.Generated;

namespace Patrija.Core.Contexts
{
	public interface IPageContext<out T> : ISiteContext where T : class, IPage
	{
		T Page { get; }
	}
}
