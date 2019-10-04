using Patrija.Models.DocumentTypes;

namespace Patrija.Core.Contexts
{
	public interface ISeoContext<out T> : ISiteContext where T : class, ISeo
	{
		T Seo { get; }
	}
}
