using System.Threading.Tasks;

namespace RealEstateWeelo.Entities.Interfaces
{
    public interface IUnitOfWork
    {
        Task<int> SaveChanges();
    }
}
