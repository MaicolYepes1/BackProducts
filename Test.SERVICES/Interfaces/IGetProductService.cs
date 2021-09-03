using System.Threading.Tasks;
using Test.MODELS.Constants;

namespace Test.SERVICES.Interfaces
{
    public interface IGetProductService
    {
        Task<Response<object>> Get();
    }
}
