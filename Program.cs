using System;
using System.Linq;

namespace EFCoreDemo
{
    class Program
    {
        static void Main()
        {
            using (var context = new AppDbContext())
            {
                //Create the database (if it doesn't exist)
                context.Database.EnsureCreated();
                //Add a new product
                var newProduct = new Product {Name = "Yeezy V3", Price = 20.36m};
                context.Products.Add(newProduct);
                context.SaveChanges();
                //Query all products and display them
                var products = context.Products.ToList();
                foreach (var product in products)
                {
                    Console.WriteLine($"Product ID: {product.ProductId}, Name:{product.Name}, Price:${product.Price}");
                }
            }
        }
    }
}
