using RealEstateWeelo.DTOs;
using System.Threading.Tasks;

namespace RealEstateWeelo.UseCasesPorts
{
    public interface ICreatePropertyImageOutputPort
    {
        Task Handle(PropertyImageDTO propertyImage);
    }
}
