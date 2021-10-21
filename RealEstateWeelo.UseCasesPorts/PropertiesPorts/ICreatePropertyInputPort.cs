using RealEstateWeelo.DTOs;
using System.Threading.Tasks;

namespace RealEstateWeelo.UseCasesPorts
{
    public interface ICreatePropertyInputPort
    {
        Task Handle(CreatePropertyDTO property);
    }
}
