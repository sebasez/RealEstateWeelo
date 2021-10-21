using System.Threading.Tasks;

namespace RealEstateWeelo.UseCasesPorts
{
    public interface IGetPropertyImagesInputPort
    {
        Task<Task> Handle(int propertyId);
    }
}
