using EF_CFA.Data;
using EF_CFA.Models;

internal class Program
{
    private static void Main(string[] args)
    {
        using (var context = new AppDbContext())
        {
           

            // Add a new product
            var newProduct = new Product { Name = "Choclate", Price = 150.00M };
            context.Products.Add(newProduct);
            context.SaveChanges();
            Console.WriteLine("New Product Added!");

            // Fetch and display all products
            var products = context.Products.ToList();
            Console.WriteLine("Products in Database:");
            foreach (var product in products)
            {
                Console.WriteLine($"{product.Id} - {product.Name} - ${product.Price}");
            }
        }
    }
}