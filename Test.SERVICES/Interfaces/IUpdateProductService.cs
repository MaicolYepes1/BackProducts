using System.Threading.Tasks;
using Test.MODELS.Constants;
using Test.MODELS.Models;

namespace Test.SERVICES.Interfaces
{
    public interface IUpdateProductService
    {
        Task<Response<object>> Update(ProductModel product);
    }
}
