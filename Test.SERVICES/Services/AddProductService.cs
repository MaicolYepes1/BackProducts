using AutoMapper;
using System;
using System.Threading.Tasks;
using Test.INFRA.Context;
using Test.MODELS.Constants;
using Test.MODELS.Entities;
using Test.MODELS.Models;
using Test.SERVICES.Interfaces;

namespace Test.SERVICES.Services
{
    public class AddProductService : IAddProductService
    {
        #region Dependency
        private readonly DataContext _context;
        private readonly IMapper _map;
        #endregion

        #region Constructor
        public AddProductService(DataContext context, IMapper map)
        {
            _context = context;
            _map = map;
        }
        #endregion

        #region Methods
        public async Task<Response<object>> Add(ProductModel product)
        {
            if (product  == null)
            {
                throw new Exception("Error no hay información para insertar");
            }
            else
            {
                var productMap = _map.Map<Product>(product);
                var res = await _context.Product.AddAsync(productMap);
                await _context.SaveChangesAsync();
                if (res != null)
                {
                    return new Response<object>
                    {
                        Message = "Guardado exitoso",
                        Success = true
                    };
                }
                else
                {
                    return new Response<object>
                    {
                        Message = "Ocurrió un error por favor intente de nuevo.",
                        Success = false
                    };
                }
            }
        }
        #endregion
    }
}
