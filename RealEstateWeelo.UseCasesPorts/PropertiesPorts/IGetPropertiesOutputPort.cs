using RealEstateWeelo.DTOs;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace RealEstateWeelo.UseCasesPorts
{
    public interface IGetPropertiesOutputPort
    {
        Task Handle(IEnumerable<PropertyDTO> properties);
    }
}
