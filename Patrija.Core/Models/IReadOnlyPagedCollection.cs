using System.Collections.Generic;

namespace Patrija.Core.Models
{
	public interface IReadOnlyPagedCollection<out T>
	{
		IReadOnlyList<T> Items { get; }
		IPagination Pagination { get; }
	}
}
