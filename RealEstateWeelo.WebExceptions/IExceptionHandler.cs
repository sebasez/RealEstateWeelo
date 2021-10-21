using Microsoft.AspNetCore.Mvc.Filters;
using System.Threading.Tasks;

namespace RealEstateWeelo.WebExceptions
{
    public interface IExceptionHandler
    {
        Task Handle(ExceptionContext context);
    }
}
