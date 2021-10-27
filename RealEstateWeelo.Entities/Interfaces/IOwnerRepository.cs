using RealEstateWeelo.Entities.POCOs;
using System.Threading.Tasks;

namespace RealEstateWeelo.Entities.Interfaces
{
    public interface IOwnerRepository
    {
        Task CreateOwner(Owner owner);
        Task<Owner> GetOwner(int id);
    }
}
