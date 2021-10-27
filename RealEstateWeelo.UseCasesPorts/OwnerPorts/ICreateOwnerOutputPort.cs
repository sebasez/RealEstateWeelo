using RealEstateWeelo.DTOs;
using System.Threading.Tasks;

namespace RealEstateWeelo.UseCasesPorts
{
    public interface ICreateOwnerOutputPort
    {
        Task Handle(OwnerDTO owner);
    }
}
