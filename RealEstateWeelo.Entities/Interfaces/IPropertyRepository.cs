using RealEstateWeelo.Entities.POCOs;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace RealEstateWeelo.Entities.Interfaces
{
    public interface IPropertyRepository
    {
        void CreateProperty(Property property);
        void UpdateProperty(int id, Property property);
        Task<IEnumerable<Property>> GetProperties();
        Task<Property> GetProperty(int id);
    }
}
