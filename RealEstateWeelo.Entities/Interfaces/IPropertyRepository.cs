using RealEstateWeelo.Entities.POCOs;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace RealEstateWeelo.Entities.Interfaces
{
    public interface IPropertyRepository
    {
        Task CreatePropertyAsync(Property property);
        Task UpdatePropertyAsync(Property property);
        Task<IEnumerable<Property>> GetPropertiesAsync();
        Task<Property> GetPropertyAsync(int id);
    }
}
