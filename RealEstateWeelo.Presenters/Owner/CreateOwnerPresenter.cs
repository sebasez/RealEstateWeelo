using RealEstateWeelo.DTOs;
using RealEstateWeelo.UseCasesPorts;
using System.Threading.Tasks;

namespace RealEstateWeelo.Presenters
{
    public class CreateOwnerPresenter : ICreateOwnerOutputPort, IPresenter<OwnerDTO>
    {
        public OwnerDTO Content { get; private set; }

        public Task Handle(OwnerDTO owner)
        {
            Content = owner;
            return Task.CompletedTask;
        }
    }
}
