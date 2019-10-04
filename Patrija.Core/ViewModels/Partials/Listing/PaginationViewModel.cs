using System;
using Patrija.Core.Models;

namespace Patrija.Core.ViewModels.Partials.Listing
{
	public class PaginationViewModel
	{
		public PaginationViewModel(IPagination pagination)
		{
			Pagination = pagination ?? throw new ArgumentNullException(nameof(pagination));
		}

		public IPagination Pagination { get; }
	}
}
