using RealEstateWeelo.Entities.Interfaces;
using RealEstateWeelo.Repository.DataContext;
using System.Threading.Tasks;

namespace RealEstateWeelo.Repository.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly RealEstateWeeloContext _context;
        public UnitOfWork(RealEstateWeeloContext context) =>
            _context = context;
        public Task<int> SaveChanges()
        {
            return _context.SaveChangesAsync();
        }
    }
}
