using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using AutoMapper;
using AutoMapper.QueryableExtensions;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using ProductShop.Data;
using ProductShop.DTOs.Input;
using ProductShop.DTOs.Output;
using ProductShop.Models;

namespace ProductShop
{
    public class StartUp
    {
        private static IMapper mapper;
        public static void Main(string[] args)
        {
            var context = new ProductShopContext();
            /*context.Database.EnsureDeleted();
            context.Database.EnsureCreated();

            string usersJsonString = File.ReadAllText("../../../Datasets/users.json");
            string productsJsonString = File.ReadAllText("../../../Datasets/products.json");
            string categoriesJsonString = File.ReadAllText("../../../Datasets/categories.json");
            string categoryProductsJsonString = File.ReadAllText("../../../Datasets/categories-products.json");

            Console.WriteLine(ImportUsers(context, usersJsonString));
            Console.WriteLine(ImportProducts(context, productsJsonString));
            Console.WriteLine(ImportCategories(context, categoriesJsonString));
            Console.WriteLine(ImportCategoryProducts(context, categoryProductsJsonString));*/

            // Console.WriteLine(GetProductsInRange(context));
           // Console.WriteLine(GetUsersWithProducts(context));

        }

        public static string ImportUsers(ProductShopContext context, string inputJson)
        {
            var users = JsonConvert.DeserializeObject<IEnumerable<UserInputDto>>(inputJson);
            InitializeMapper();

            var mappedUsers = mapper.Map<IEnumerable<User>>(users);

            context.Users.AddRange(mappedUsers);
            context.SaveChanges();

            return $"Successfully imported {mappedUsers.Count()}";
        }

        public static string ImportProducts(ProductShopContext context, string inputJson)
        {
            var products = JsonConvert.DeserializeObject<IEnumerable<ProductInputDto>>(inputJson);
            InitializeMapper();

            var mappedProducts = mapper.Map<IEnumerable<Product>>(products);

            context.Products.AddRange(mappedProducts);
            context.SaveChanges();

            return $"Successfully imported {mappedProducts.Count()}";
        }

        public static string ImportCategories(ProductShopContext context, string inputJson)
        {
            var categories =
                JsonConvert.DeserializeObject<IEnumerable<CategoryInputDto>>(inputJson)
                .Where(x => !string.IsNullOrEmpty(x.Name));

            InitializeMapper();

            var mappedCategories = mapper.Map<IEnumerable<Category>>(categories);
            context.Categories.AddRange(mappedCategories);
            context.SaveChanges();

            return $"Successfully imported {mappedCategories.Count()}";
        }

        public static string ImportCategoryProducts(ProductShopContext context, string inputJson)
        {
            var categoryProducts = JsonConvert.DeserializeObject<IEnumerable<CategoryProductInputDto>>(inputJson);

            InitializeMapper();

            var mappedCategoryProducts = mapper.Map<IEnumerable<CategoryProduct>>(categoryProducts);
            context.CategoryProducts.AddRange(mappedCategoryProducts);
            context.SaveChanges();

            return $"Successfully imported {mappedCategoryProducts.Count()}";
        }

        public static string GetProductsInRange(ProductShopContext context)
        {
            InitializeMapper();

            var products = context
                .Products
                .Where(x => x.Price >= 500 && x.Price <= 1000)
                .OrderBy(x => x.Price)
                .ProjectTo<ProductOutputDto>(mapper.ConfigurationProvider)
                .ToList();


            DefaultContractResolver contractResolver = new DefaultContractResolver
            {
                NamingStrategy = new CamelCaseNamingStrategy()
            };

            var jsonSettings = new JsonSerializerSettings
            {
                Formatting = Formatting.Indented,
                ContractResolver = contractResolver
            };

            string productsAsJson = JsonConvert.SerializeObject(products, jsonSettings);

            return productsAsJson;
        }

        public static string GetSoldProducts(ProductShopContext context)
        {
            var usersWithSoldProducts = context
                .Users
                .Include(x => x.ProductsSold)
                .Where(x => x.ProductsSold.Any(y => y.Buyer != null))
                .OrderBy(u => u.LastName)
                .ThenBy(u => u.FirstName)
                .Select(x => new
                {
                    FirstName = x.FirstName,
                    LastName = x.LastName,
                    SoldProducts = x.ProductsSold
                    .Select(p => new
                    {
                        Name = p.Name,
                        Price = p.Price,
                        BuyerFirstName = p.Buyer.FirstName,
                        BuyerLastName = p.Buyer.LastName
                    })
                    .ToList()
                })
                .ToList();

            DefaultContractResolver contractResolver = new DefaultContractResolver
            {
                NamingStrategy = new CamelCaseNamingStrategy()
            };

            var jsonSettings = new JsonSerializerSettings
            {
                Formatting = Formatting.Indented,
                ContractResolver = contractResolver
            };

            string productsAsJson = JsonConvert.SerializeObject(usersWithSoldProducts, jsonSettings);

            return productsAsJson;
        }

        public static string GetCategoriesByProductsCount(ProductShopContext context)
        {
            var categories = context
                .Categories
                .OrderByDescending(c => c.CategoryProducts.Count)
                .Select(c => new
                {
                    Category = c.Name,
                    ProductsCount = c.CategoryProducts.Count,
                    AveragePrice = $"{(c.CategoryProducts.Sum(p => p.Product.Price) / c.CategoryProducts.Count):f2}",
                    TotalRevenue = $"{c.CategoryProducts.Sum(p => p.Product.Price):f2}"
                })
                .ToList();

            DefaultContractResolver contractResolver = new DefaultContractResolver
            {
                NamingStrategy = new CamelCaseNamingStrategy()
            };

            var jsonSettings = new JsonSerializerSettings
            {
                Formatting = Formatting.Indented,
                ContractResolver = contractResolver
            };

            string categoriesAsJson = JsonConvert.SerializeObject(categories, jsonSettings);

            return categoriesAsJson;
        }

        /*public static string GetUsersWithProducts(ProductShopContext context)
        {
            UserAllDto user = new UserAllDto()
            {
                UserCount = context.Users.Count(u => u.ProductsSold.Count >= 1),
                Users = context
                .Users
                .OrderByDescending(u => u.ProductsSold.Count > 0)
                .Where(u => u.ProductsSold.Count > 0 && u.ProductsSold.Any(ps => ps.Buyer != null))
                .Select(u => new
                {
                    FirstName = u.FirstName,
                    LastName = u.LastName,
                    Age = u.Age,
                    SoldProducts = new ProductSoldDto()
                    {
                        Count = u.ProductsSold.Count,
                        Products = u.ProductsSold
                        .Select(p => new
                        {
                            Name = p.Name,
                            Price = p.Price
                        })
                        .ToArray()
                    }
                }
                .ToArray()
            };




        DefaultContractResolver contractResolver = new DefaultContractResolver
        {
            NamingStrategy = new CamelCaseNamingStrategy()
        };

        var jsonSettings = new JsonSerializerSettings
        {
            Formatting = Formatting.Indented,
            ContractResolver = contractResolver
        };

        string usersWithProductsAsJson = JsonConvert.SerializeObject(usersWithProducts, jsonSettings);

            return usersWithProductsAsJson;
        }*/












    private static void InitializeMapper()
    {
        var mapperConfig = new MapperConfiguration(cfg =>
        {
            cfg.AddProfile<ProductShopProfile>();
        });
        mapper = new Mapper(mapperConfig);
    }
}

    /* MANUAL MAPPING - IEnumerable<User> mappedUsers = users.Select(x=> x.MapToDomainUser).ToList();
     * 
     * public static class UserMappings
    {
        public static User MapToDomainUser(this UserInputDto userDto)
        {
            return new User
            {
                Age = userDto.Age,
                FirstName = userDto.FirstName,
                LastName = userDto.LastName
            };
        }
    }*/

}