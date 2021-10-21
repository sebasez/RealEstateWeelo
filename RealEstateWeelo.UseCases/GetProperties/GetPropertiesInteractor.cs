using AutoMapper;
using RealEstateWeelo.DTOs;
using RealEstateWeelo.Entities.Interfaces;
using RealEstateWeelo.UseCasesPorts;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace RealEstateWeelo.UseCases
{
    public class GetPropertiesInteractor : IGetPropertiesInputPort
    {
        private readonly IPropertyRepository _repository;
        private readonly IGetPropertiesOutputPort _outputPort;
        private readonly IMapper _imapper;
        public GetPropertiesInteractor(IPropertyRepository repository, IGetPropertiesOutputPort outputPort, IMapper imapper) =>
            (_repository, _outputPort, _imapper) = (repository, outputPort, imapper);
        public async Task<Task> Handle()
        {
            var propertiesDto = _imapper.Map<IEnumerable<PropertyDTO>>(await _repository.GetProperties());
            await _outputPort.Handle(propertiesDto);
            return Task.CompletedTask;
        }
    }
}
