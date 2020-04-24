using System;
using Patrija.Core.ViewModels.Partials.AboutUsPage;
using Patrija.Core.ViewModels.Partials.Features;
using Patrija.Core.ViewModels.Partials.News;

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
                    return ContentPosition.Left;
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

        public static DisplayVariant MapDisplayVariant(string displayVariant)
        {
            switch (displayVariant)
            {
                case "Latest Article in Focus":
                    return DisplayVariant.LatestArticleInFocus;
                case "2 x 3":
                    return DisplayVariant.TwoColumnThreeRows;
                case "3 x 2":
                    return DisplayVariant.ThreeColumnTwoRows;
                default:
                    return DisplayVariant.LatestArticleInFocus;
            }
        }
    }
}