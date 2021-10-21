using RealEstateWeelo.DTOs;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace RealEstateWeelo.UseCasesPorts
{
    public interface IGetPropertyImagesOutputPort
    {
        Task Handle(IEnumerable<PropertyImageDTO> propertyImages);
    }
}
