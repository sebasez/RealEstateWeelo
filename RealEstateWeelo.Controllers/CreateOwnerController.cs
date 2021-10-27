using Microsoft.AspNetCore.Mvc;
using RealEstateWeelo.DTOs;
using RealEstateWeelo.Presenters;
using RealEstateWeelo.UseCasesPorts;
using System.Threading.Tasks;

namespace RealEstateWeelo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CreateOwnerController
    {
        private readonly ICreateOwnerInputPort _inputPort;
        private readonly ICreateOwnerOutputPort _outputPort;
        public CreateOwnerController(ICreateOwnerInputPort inputPort, ICreateOwnerOutputPort outputPort) =>
            (_inputPort, _outputPort) = (inputPort, outputPort);
        [HttpPost]
        public async Task<OwnerDTO> CreateOwner(CreateOwnerDTO owner)
        {
            await _inputPort.Handle(owner);
            return ((IPresenter<OwnerDTO>)_outputPort).Content;
        }
    }
}
