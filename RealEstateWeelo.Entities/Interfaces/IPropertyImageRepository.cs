using RealEstateWeelo.Entities.POCOs;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace RealEstateWeelo.Entities.Interfaces
{
    public interface IPropertyImageRepository
    {
        void AddImageProperty(PropertyImage propertyImage);
        Task<IEnumerable<PropertyImage>>GetImageProperties(int propertyId);
    }
}
