using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RealEstateWeelo.DTOs;
using RealEstateWeelo.UseCasesPorts;

namespace RealEstateWeelo.Presenters
{
    public class GetPropertiesPresenter : IGetPropertiesOutputPort, IPresenter<IEnumerable<PropertyDTO>>
    {
        public IEnumerable<PropertyDTO> Content { get; private set; }

        public Task Handle(IEnumerable<PropertyDTO> properties)
        {
            Content = properties;
            return Task.CompletedTask;
        }
    }
}
