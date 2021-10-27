using RealEstateWeelo.Entities.Interfaces;
using RealEstateWeelo.Entities.POCOs;
using RealEstateWeelo.Repository.DataContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealEstateWeelo.Repository.Repositories
{
    public class OwnerRepository : IOwnerRepository
    {
        private readonly RealEstateWeeloContext _context;
        public OwnerRepository(RealEstateWeeloContext context) =>
            _context = context;
        public async Task CreateOwner(Owner owner)
        {
            await _context.AddAsync(owner);
        }

        public async Task<Owner> GetOwner(int id)
        {
            var owner = await _context.Owner.FindAsync(id);
            return owner;
        }
    }
}
