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
            { ShapeVariant.First, string.Empty },
            { ShapeVariant.Second, "page-intro__image--secondary" },
            { ShapeVariant.Third, "page-intro__image--tertiary" },
            { ShapeVariant.Fourth, "page-intro__image--quaternary" }
        };
    }

}