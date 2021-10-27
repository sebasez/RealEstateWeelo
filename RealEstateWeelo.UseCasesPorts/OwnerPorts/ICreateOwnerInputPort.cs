using RealEstateWeelo.DTOs;
using System.Threading.Tasks;

namespace RealEstateWeelo.UseCasesPorts
{
    public interface ICreateOwnerInputPort
    {
        Task Handle(CreateOwnerDTO owner);
    }
}
