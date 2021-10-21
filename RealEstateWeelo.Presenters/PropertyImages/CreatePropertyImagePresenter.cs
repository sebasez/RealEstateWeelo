using RealEstateWeelo.DTOs;
using RealEstateWeelo.UseCasesPorts;
using System.Threading.Tasks;

namespace RealEstateWeelo.Presenters
{
    public class CreatePropertyImagePresenter : ICreatePropertyImageOutputPort, IPresenter<PropertyImageDTO>
    {
        public PropertyImageDTO Content { get; private set; }

        public Task Handle(PropertyImageDTO propertyImage)
        {
            Content = propertyImage;
            return Task.CompletedTask;
        }
    }
}
