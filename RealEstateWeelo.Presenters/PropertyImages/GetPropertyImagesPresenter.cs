using RealEstateWeelo.DTOs;
using RealEstateWeelo.UseCasesPorts;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace RealEstateWeelo.Presenters
{
    public class GetPropertyImagesPresenter : IGetPropertyImagesOutputPort, IPresenter<IEnumerable<PropertyImageDTO>>
    {
        public IEnumerable<PropertyImageDTO> Content { get; private set; }

        public Task Handle(IEnumerable<PropertyImageDTO> propertyImages)
        {
            Content = propertyImages;
            return Task.CompletedTask;
        }
    }
}
