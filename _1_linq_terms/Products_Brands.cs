using System;
using System.Collections.Generic;

namespace _1_linq_terms
{
    public class Product
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public byte BrandId { get; set; }

        public static List<Product> Products()
        {
            return new List<Product>() {
                new Product(){  ProductId= 1, ProductName="Product 1", BrandId= 1},
                new Product(){  ProductId= 2, ProductName="Product 2", BrandId= 2},
                new Product(){  ProductId= 3, ProductName="Product 3", BrandId= 3},
                new Product(){  ProductId= 4, ProductName="Product 4", BrandId= 1},
                new Product(){  ProductId= 5, ProductName="Product 5", BrandId= 2},
                new Product(){  ProductId= 6, ProductName="Product 6", BrandId= 1}
            };
        }
    }

    public class Brand
    {
        public int Id { get; set; }
        public string Name { get; set; }


        public static List<Brand> Brands()
        {
            return new List<Brand>() {
                new Brand(){  Id= 1, Name="Brand 1"},
                new Brand(){  Id= 2, Name="Brand 2"},
                new Brand(){  Id= 3, Name="Brand 3"}
            };
        }
    }
}
