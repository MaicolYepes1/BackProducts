using Microsoft.Extensions.DependencyInjection;
using Test.SERVICES.Interfaces;
using Test.SERVICES.Services;

namespace Test.IOC.Dependencies
{
    public class DependencyContainer
    {
        public static void RegisterServices(IServiceCollection services)
        {
            #region Services
            services.AddScoped<IAddProductService, AddProductService>();
            services.AddScoped<IGetProductService, GetProductService>();
            services.AddScoped<IUpdateProductService, UpdateProductService>();
            #endregion
        }
    }
}
