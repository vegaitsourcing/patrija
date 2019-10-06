using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patrija.Core.ViewModels.Shared
{
    public class BlogCategoryViewModel
    {
        BlogCategoryViewModel(string name)
        {
            Name = name;
        }
        public string Name { get; }
    }
}
