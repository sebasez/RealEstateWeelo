using RealEstateWeelo.DTOs;
using System.Threading.Tasks;

namespace RealEstateWeelo.UseCasesPorts
{
    public interface IUpdatePropertyInputPort
    {
        Task Handle(UpdatePropertyDTO property);
    }
}
