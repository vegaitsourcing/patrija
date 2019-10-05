using System;
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
    }
}