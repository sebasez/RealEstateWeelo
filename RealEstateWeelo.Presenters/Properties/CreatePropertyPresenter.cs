using RealEstateWeelo.DTOs;
using RealEstateWeelo.UseCasesPorts;
using System.Threading.Tasks;

namespace RealEstateWeelo.Presenters
{
    public class CreatePropertyPresenter : ICreatePropertyOutputPort, IPresenter<PropertyDTO>
    {
        public PropertyDTO Content { get; private set; }

        public Task Handle(PropertyDTO property)
        {
            Content = property;
            return Task.CompletedTask;
        }
    }
}
