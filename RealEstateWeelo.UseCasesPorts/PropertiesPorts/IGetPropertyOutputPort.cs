using RealEstateWeelo.DTOs;
using System.Threading.Tasks;

namespace RealEstateWeelo.UseCasesPorts
{
    public interface IGetPropertyOutputPort
    {
        Task Handle(PropertyDTO property);
    }
}
