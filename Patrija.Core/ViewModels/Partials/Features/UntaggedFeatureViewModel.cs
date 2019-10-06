using Patrija.Core.Mappers;
using Patrija.Core.ViewModels.Shared;
using Patrija.Models.Generated;

namespace Patrija.Core.ViewModels.Partials.Features
{
    public class UntaggedFeatureViewModel : FeatureViewModel
    {
        public UntaggedFeatureViewModel(IFeature feature)
            :base(feature)
        {
        }
    }
}