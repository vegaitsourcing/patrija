using System.Collections.Generic;
using System.Linq;
using Patrija.Core.ViewModels.Partials.AboutUsPage;

namespace Patrija.Web.DisplayHelpers
{
    public static class Dictionaries 
    {
        public static readonly Dictionary<string, string> SupportContentBoxButtonTypeMap = new Dictionary<string, string>()
        {
            {"Mint Green", "btn--mint" },
            {"Blue", string.Empty }
        };
        
        public static readonly Dictionary<ShapeVariant, string> ShapeVariantMap = new Dictionary<ShapeVariant, string>()
        {
            { ShapeVariant.First, "primary" },
            { ShapeVariant.Second, "secondary" },
            { ShapeVariant.Third, "tertiary" },
            { ShapeVariant.Fourth, "quaternary" }
        };
    }

}