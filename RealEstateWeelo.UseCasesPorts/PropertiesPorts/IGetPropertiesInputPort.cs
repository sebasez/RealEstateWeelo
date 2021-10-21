using System.Threading.Tasks;

namespace RealEstateWeelo.UseCasesPorts
{
    public interface IGetPropertiesInputPort
    {
        Task<Task> Handle();
    }
}
