using RealEstateWeelo.DTOs;
using System.Threading.Tasks;

namespace RealEstateWeelo.UseCasesPorts
{
    public interface ICreatePropertyOutputPort
    {
        Task Handle(PropertyDTO property);
    }
}
