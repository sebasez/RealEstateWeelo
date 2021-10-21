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
        
        public void CreateProperty(Property property)
        {
            _context.Add(property);
        }

        public async Task<IEnumerable<Property>> GetProperties()
        {
            return await _context.Property.ToListAsync();
        }

        public async Task<Property> GetProperty(int id)
        {
            return await _context.Property.FindAsync(id);
        }

        public void UpdateProperty(int id, Property property)
        {
            var dbProperty = _context.Property.Find(id);
            dbProperty.OwnerId = property.OwnerId;
            dbProperty.Price = property.Price;
            dbProperty.Name = property.Name;
        }
    }
}
