using RealEstateWeelo.DTOs;
using System.Threading.Tasks;

namespace RealEstateWeelo.UseCasesPorts
{
    public interface ICreatePropertyImageInputPort
    {
        Task Handle(CreatePropertyImageDTO propertyImage);
    }
}
