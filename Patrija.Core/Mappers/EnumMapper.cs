using System;
using Patrija.Core.ViewModels.Partials.AboutUsPage;
using Patrija.Core.ViewModels.Partials.Features;

namespace Patrija.Core.Mappers
{
    public static class EnumMapper
    {
        public static ContentPosition MapContentPosition(string contentPosition)
        {
            switch (contentPosition)
            {
                case "Left":
                    return ContentPosition.Left;
                case "Right":
                    return ContentPosition.Right;
                default:
                    throw new ArgumentOutOfRangeException(nameof(contentPosition));
            }
        }

        public static ShapeVariant MapShapeVariant(string shapeVariant)
        {
            switch (shapeVariant)
            {
                case "Second":
                    return ShapeVariant.Second;
                case "Third":
                    return ShapeVariant.Third;
                case "Fourth":
                    return ShapeVariant.Fourth;
                default:
                    return ShapeVariant.First;
            }
        }
    }
}