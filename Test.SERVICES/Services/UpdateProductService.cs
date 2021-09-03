using AutoMapper;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test.INFRA.Context;
using Test.MODELS.Constants;
using Test.MODELS.Entities;
using Test.MODELS.Models;
using Test.SERVICES.Interfaces;

namespace Test.SERVICES.Services
{
    public class UpdateProductService : IUpdateProductService
    {
        #region Dependency
        private readonly DataContext _context;
        private readonly IMapper _map;
        #endregion

        #region Constructor
        public UpdateProductService(DataContext context, IMapper map)
        {
            _context = context;
            _map = map;
        }
        #endregion

        #region Methods
        public async Task<Response<object>> Update(ProductModel product)
        {
            if (product == null)
            {
                throw new Exception("Error, no hay información para actualizar");
            }
            else
            {
                var resp = await _context.Product.Where(s => s.IdProduct == product.IdProduct).FirstOrDefaultAsync();
                if (resp != null)
                {
                    resp.DateEnter = product.DateEnter;
                    resp.DateExit = product.DateExit;
                    resp.Name = product.Name;
                    resp.State = product.State;
                    var res = _context.Product.Update(resp);
                    _context.SaveChanges();
                    return new Response<object>
                    {
                        Message = "Actualizado exitoso",
                        Success = true
                    };
                }
                else
                {
                    return new Response<object>
                    {
                        Message = "Error, no hubo registros para actualizar.",
                        Success = false
                    };
                }
            }
        }
        #endregion
    }
}
