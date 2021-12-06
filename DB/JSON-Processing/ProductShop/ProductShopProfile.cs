using AutoMapper;
using ProductShop.DTOs.Input;
using ProductShop.DTOs.Output;
using ProductShop.Models;

namespace ProductShop
{
    public class ProductShopProfile : Profile
    {
        public ProductShopProfile()
        {
            CreateMap<UserInputDto, User>();

            CreateMap<ProductInputDto, Product>();

            CreateMap<CategoryInputDto, Category>();

            CreateMap<CategoryProductInputDto, CategoryProduct>();

            CreateMap<Product, ProductOutputDto>()
                .ForMember(dest => dest.Seller, opt => opt.MapFrom(scr=> $"{scr.Seller.FirstName} {scr.Seller.LastName}"));

        }
    }
}
