using System.Threading.Tasks;

namespace RealEstateWeelo.UseCasesPorts
{
    public interface IGetPropertyInputPort
    {
        Task<Task> Handle(int id);
    }
}
