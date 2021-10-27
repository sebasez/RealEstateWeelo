using Microsoft.EntityFrameworkCore;
using RealEstateWeelo.Entities.Interfaces;
using RealEstateWeelo.Entities.POCOs;
using RealEstateWeelo.Repository.DataContext;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace RealEstateWeelo.Repository.Repositories
{
    public class PropertyRepository : IPropertyRepository
    {
        private readonly RealEstateWeeloContext _context;
        public PropertyRepository(RealEstateWeeloContext context)=>
            _context = context;
        
        public async Task CreatePropertyAsync(Property property)
        {
            await _context.AddAsync(property);
        }

        public async Task<IEnumerable<Property>> GetPropertiesAsync()
        {
            return await _context.Property.ToListAsync();
        }

        public async Task<Property> GetPropertyAsync(int id)
        {
            return await _context.Property.FindAsync(id);
        }

        public async Task UpdatePropertyAsync(Property property)
        {
            var dbProperty = await _context.Property.FindAsync(property.Id);
            if(property.OwnerId.HasValue)
                dbProperty.OwnerId = property.OwnerId;
            dbProperty.Price = property.Price;
            dbProperty.CodeInternal = property.CodeInternal;
            dbProperty.Address = property.Address;
            dbProperty.Year = property.Year;
            dbProperty.Name = property.Name;
        }
    }
}
