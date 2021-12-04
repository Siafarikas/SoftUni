using CarDealer.Data;
using CarDealer.DTO.Input;
using CarDealer.DTO.Output;
using CarDealer.Models;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Xml.Serialization;

namespace CarDealer
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            CarDealerContext dbContext = new CarDealerContext();

            dbContext.Database.EnsureDeleted();
            dbContext.Database.EnsureCreated();

            string supplierXml = File.ReadAllText("Datasets/suppliers.xml");
            string partsXml = File.ReadAllText("Datasets/parts.xml");
            string salesXml = File.ReadAllText("Datasets/sales.xml");
            string carsXml = File.ReadAllText("Datasets/cars.xml");
            string customersXml = File.ReadAllText("Datasets/customers.xml");
            Console.WriteLine(ImportSuppliers(dbContext, supplierXml));
            Console.WriteLine(ImportParts(dbContext, partsXml));
            Console.WriteLine(ImportCars(dbContext, carsXml));
            Console.WriteLine(ImportCustomers(dbContext, customersXml));
            Console.WriteLine(ImportSales(dbContext, salesXml));


            Console.WriteLine(GetSalesWithAppliedDiscount(dbContext));
        }
        private static XmlSerializer GenerateXmlSerializer(string rootName, Type dtoType)
        {
            XmlRootAttribute xmlRoot = new XmlRootAttribute(rootName);
            XmlSerializer xmlSerializer = new XmlSerializer(dtoType, xmlRoot);

            return xmlSerializer;
        }
        public static string ImportSuppliers(CarDealerContext context, string inputXml)
        {
            var xmlSerializer = GenerateXmlSerializer("Suppliers", typeof(InputSupplierDto[]));
            StringReader stringReader = new StringReader(inputXml);
            InputSupplierDto[] dtos = (InputSupplierDto[])xmlSerializer.Deserialize(stringReader);

            ICollection<Supplier> suppliers = new HashSet<Supplier>();
            foreach (var supplierDto in dtos)
            {
                Supplier s = new Supplier()
                {
                    Name = supplierDto.Name,
                    IsImporter = bool.Parse(supplierDto.IsImporter)
                };
                suppliers.Add(s);
            }
            context.Suppliers.AddRange(suppliers);
            context.SaveChanges();

            return $"Successfully imported {suppliers.Count}";
        }

        public static string ImportParts(CarDealerContext context, string inputXml)
        {
            var xmlSerializer = GenerateXmlSerializer("Parts", typeof(InputPartDto[]));
            StringReader stringReader = new StringReader(inputXml);
            InputPartDto[] dtos = (InputPartDto[])xmlSerializer.Deserialize(stringReader);

            ICollection<Part> parts = new HashSet<Part>();
            foreach (var partDto in dtos)
            {
                Supplier supplier = context
                    .Suppliers
                    .Find(partDto.SupplierId);

                if (supplier == null)
                {
                    continue;
                }

                Part p = new Part()
                {
                    Name = partDto.Name,
                    Price = decimal.Parse(partDto.Price),
                    Quantity = partDto.Quantity,
                    Supplier = supplier
                };
                parts.Add(p);
            }

            context.Parts.AddRange(parts);
            context.SaveChanges();
            return $"Successfully imported {parts.Count}";
        }

        public static string ImportCars(CarDealerContext context, string inputXml)
        {
            XmlSerializer xmlSerializer = GenerateXmlSerializer("Cars", typeof(InputCarDto[]));
            StringReader stringReader = new StringReader(inputXml);
            InputCarDto[] dtos = (InputCarDto[])xmlSerializer.Deserialize(stringReader);

            ICollection<Car> cars = new HashSet<Car>();
            //ICollection<PartCar> partCars = new HashSet<PartCar>();
            foreach (var carDto in dtos)
            {
                Car c = new Car
                {
                    Make = carDto.Make,
                    Model = carDto.Model,
                    TravelledDistance = carDto.TraveledDistance,
                };

                ICollection<PartCar> currentCarParts = new HashSet<PartCar>();
                foreach (var partId in carDto.Parts.Select(p => p.Id).Distinct())
                {
                    Part part = context
                        .Parts
                        .Find(partId);

                    if (part == null)
                    {
                        continue;
                    }
                    PartCar partCar = new PartCar()
                    {
                        Car = c,
                        Part = part
                    };
                    currentCarParts.Add(partCar);
                }

                c.PartCars = currentCarParts;
                cars.Add(c);
            }
            context.Cars.AddRange(cars);
            context.SaveChanges();
            return $"Successfully imported {cars.Count}";
        }

        public static string ImportCustomers(CarDealerContext context, string inputXml)
        {
            XmlSerializer xmlSerializer = GenerateXmlSerializer("Customers", typeof(InputCustomerDto[]));
            StringReader stringReader = new StringReader(inputXml);
            InputCustomerDto[] dtos = (InputCustomerDto[])xmlSerializer.Deserialize(stringReader);

            ICollection<Customer> customers = new HashSet<Customer>();
            foreach (var customerDto in dtos)
            {
                Customer c = new Customer()
                {
                    Name = customerDto.Name,
                    BirthDate = DateTime.ParseExact(customerDto.BirthDate, "yyyy-MM-ddTHH:mm:ss", CultureInfo.InvariantCulture),
                    IsYoungDriver = bool.Parse(customerDto.IsYoungDriver)
                };
                customers.Add(c);
            }
            context.Customers.AddRange(customers);
            context.SaveChanges();

            return $"Successfully imported {customers.Count}";
        }

        public static string ImportSales(CarDealerContext context, string inputXml)
        {
            XmlSerializer xmlSerializer = GenerateXmlSerializer("Sales", typeof(InputSaleDto[]));
            StringReader stringReader = new StringReader(inputXml);
            InputSaleDto[] dtos = (InputSaleDto[])xmlSerializer.Deserialize(stringReader);

            ICollection<Sale> sales = new HashSet<Sale>();
            foreach (var saleDto in dtos)
            {
                Car car = context
                    .Cars
                    .Find(saleDto.CarId);

                if (car == null)
                {
                    continue;
                }

                Sale s = new Sale()
                {
                    CarId = saleDto.CarId,
                    CustomerId = saleDto.CustomerId,
                    Discount = decimal.Parse(saleDto.Discount)
                };

                sales.Add(s);
            }
            context.Sales.AddRange(sales);
            context.SaveChanges();

            return $"Successfully imported {sales.Count}";

        }

        public static string GetCarsWithDistance(CarDealerContext context)
        {
            StringBuilder sb = new StringBuilder();
            StringWriter stringWriter = new StringWriter(sb);

            XmlSerializer xmlSerializer = GenerateXmlSerializer("cars", typeof(OutputCarsDto[]));
            XmlSerializerNamespaces namespaces = new XmlSerializerNamespaces();
            namespaces.Add(String.Empty, String.Empty);
            var carDtos = context
                .Cars
                .Where(c => c.TravelledDistance > 2000000)
                .OrderBy(c => c.Make)
                .ThenBy(c => c.Model)
                .Take(10)
                .Select(c => new OutputCarsDto
                {
                    Make = c.Make,
                    Model = c.Model,
                    TravelledDistance = c.TravelledDistance.ToString()
                })
                .ToArray();

            xmlSerializer.Serialize(stringWriter, carDtos, namespaces);

            return sb.ToString().TrimEnd();
        }

        public static string GetCarsFromMakeBmw(CarDealerContext context)
        {
            StringBuilder sb = new StringBuilder();
            StringWriter stringWriter = new StringWriter(sb);

            XmlSerializer xmlSerializer = GenerateXmlSerializer("cars", typeof(OutputCarsBmwDto[]));
            XmlSerializerNamespaces namespaces = new XmlSerializerNamespaces();
            namespaces.Add(String.Empty, String.Empty);

            var carBmwDtos = context
                .Cars
                .Where(c => c.Make == "BMW")
                .OrderBy(c => c.Model)
                .ThenByDescending(c => c.TravelledDistance)
                .Select(c => new OutputCarsBmwDto
                {
                    Id = c.Id.ToString(),
                    Model = c.Model,
                    TravelledDistance = c.TravelledDistance.ToString()
                })
                .ToArray();

            xmlSerializer.Serialize(stringWriter, carBmwDtos, namespaces);

            return sb.ToString().TrimEnd();
        }

        public static string GetLocalSuppliers(CarDealerContext context)
        {
            StringBuilder sb = new StringBuilder();
            StringWriter stringWriter = new StringWriter(sb);

            XmlSerializer xmlSerializer = GenerateXmlSerializer("suppliers", typeof(OutputSupplierWithPartsDto[]));
            XmlSerializerNamespaces namespaces = new XmlSerializerNamespaces();
            namespaces.Add(String.Empty, String.Empty);

            var suppliersDtos = context
                .Suppliers
                .Where(s => s.IsImporter == false)
                .Select(s => new OutputSupplierWithPartsDto
                {
                    Id = s.Id.ToString(),
                    Name = s.Name,
                    PartsCount = s.Parts.Count().ToString()
                })
                .ToArray();

            xmlSerializer.Serialize(stringWriter, suppliersDtos, namespaces);

            return sb.ToString().TrimEnd();
        }

        public static string GetSalesWithAppliedDiscount(CarDealerContext context)
        {
            StringBuilder sb = new StringBuilder();
            StringWriter stringWriter = new StringWriter(sb);

            XmlSerializer xmlSerializer = GenerateXmlSerializer("sales", typeof(OutputSalesWithDiscountDto[]));
            XmlSerializerNamespaces namespaces = new XmlSerializerNamespaces();
            namespaces.Add(String.Empty, String.Empty);

            var salesDtos = context
                .Sales
                .Select(s => new OutputSalesWithDiscountDto
                {
                    Car = new OutputCarSalesDto()
                    {
                        Make = s.Car.Make,
                        Model = s.Car.Model,
                        TravelledDistance = s.Car.TravelledDistance.ToString()
                    },
                    Discount = s.Discount.ToString("f2"),
                    CustomerName = s.Customer.Name,
                    Price = s.Car.PartCars.Sum(pc => pc.Part.Price).ToString("f2"),
                    PriceWithDiscount = (s.Car.PartCars.Sum(pc => pc.Part.Price) - (s.Car.PartCars.Sum(pc => pc.Part.Price) * s.Discount / 100)).ToString("f2")
                })
                .ToArray();

            xmlSerializer.Serialize(stringWriter, salesDtos, namespaces);
            return sb.ToString().TrimEnd();
        }

    }
}