using ServiceB.Application.Features.Products.Commands.CreateProduct;
using ServiceB.Application.Features.Products.Queries.GetAllProducts;
using AutoMapper;
using ServiceB.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ServiceB.Application.Mappings
{
    public class GeneralProfile : Profile
    {
        public GeneralProfile()
        {
            CreateMap<Product, GetAllProductsViewModel>().ReverseMap();
            CreateMap<CreateProductCommand, Product>();
            CreateMap<GetAllProductsQuery, GetAllProductsParameter>();
        }
    }
}
