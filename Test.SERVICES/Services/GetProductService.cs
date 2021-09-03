using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;
using Test.INFRA.Context;
using Test.MODELS.Constants;
using Test.SERVICES.Interfaces;

namespace Test.SERVICES.Services
{
    public class GetProductService : IGetProductService
    {
        #region Dependency
        private readonly DataContext _context;
        #endregion

        #region Constructor
        public GetProductService(DataContext context)
        {
            _context = context;
        }
        #endregion

        #region Methods
        public async Task<Response<object>> Get()
        {
            var res = await _context.Product.ToListAsync();
            if (res != null)
            {
                return new Response<object>
                {
                    Message = "Selección exitosa.",
                    Success = true,
                    Result = res
                };
            }
            else
            {
                return new Response<object>
                {
                    Message = "Selección exitosa.",
                    Success = true
                };
            }       
        }
        #endregion
    }
}
