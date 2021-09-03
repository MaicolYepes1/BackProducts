using System.Threading.Tasks;
using Test.MODELS.Constants;
using Test.MODELS.Models;

namespace Test.SERVICES.Interfaces
{
    public interface IAddProductService
    {
        Task<Response<object>> Add(ProductModel product);
    }
}
