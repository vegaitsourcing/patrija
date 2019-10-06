using System.Linq;
using Patrija.Core.Contexts;
using Patrija.Models.Generated;
using Patrija.Core.Mappers;

namespace Patrija.Core.ViewModels.Pages
{
    public class ProjectPageViewModel : PageViewModel
    {
        public ProjectPageViewModel(IPageContext<ProjectPage> context) : base(context)
        {
            Blocks = context.Page.ProjectPageBlocks?.Select(block => BlockMapper.MapBlock(block)).ToArray() ?? new object[0];
        }

        public object[] Blocks { get; }
    }
}