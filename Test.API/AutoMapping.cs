using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Test.MODELS.Entities;
using Test.MODELS.Models;

namespace Test.API
{
    public class AutoMapping : Profile
    {
        public AutoMapping()
        {
            CreateMap<ProductModel, Product>();
        }
    }
}
