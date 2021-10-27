using RealEstateWeelo.DTOs;
using System.Threading.Tasks;

namespace RealEstateWeelo.UseCasesPorts
{
    public interface IUpdatePropertyOutputPort
    {
        Task Handle(PropertyDTO property);
    }
}
