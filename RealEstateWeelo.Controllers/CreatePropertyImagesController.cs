using Microsoft.AspNetCore.Mvc;
using RealEstateWeelo.DTOs;
using RealEstateWeelo.Presenters;
using RealEstateWeelo.UseCasesPorts;
using System.Threading.Tasks;

namespace RealEstateWeelo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CreatePropertyImagesController
    {
        private readonly ICreatePropertyImageInputPort _inputPort;
        private readonly ICreatePropertyImageOutputPort _outputPort;
        public CreatePropertyImagesController(ICreatePropertyImageInputPort inputPort, ICreatePropertyImageOutputPort outputPort) =>
            (_inputPort, _outputPort) = (inputPort, outputPort);
        [HttpPost]
        public async Task<PropertyImageDTO> CreatePropertyImage(CreatePropertyImageDTO property)
        {
            await _inputPort.Handle(property);
            return ((IPresenter<PropertyImageDTO>)_outputPort).Content;
        }
    }
}
