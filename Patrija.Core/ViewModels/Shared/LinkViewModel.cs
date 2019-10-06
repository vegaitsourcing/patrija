using Umbraco.Web.Models;
using Patrija.Models.Generated;

namespace Patrija.Core.ViewModels.Shared
{
	public class LinkViewModel
	{
        public LinkViewModel(string url, string content, bool isActive, string target = null)
        {
            Url = url;
            IsActive = isActive;
            Content = content;
            Target = target;
        }

        public LinkViewModel(string url, string content, string target = null) : this(url, content, false, target)
        { }

        public LinkViewModel(Link link) : this(link.Url, link.Name, link.Target)
		{ }

		public LinkViewModel(IPage node, string target = null) : this(node.Url, node.PageTitle, target)
		{ }

		public string Url { get; }
        public bool IsActive { get; }
		public string Content { get; }
		public string Target { get; }
	}
}
