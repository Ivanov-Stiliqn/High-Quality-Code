using System;
using System.Globalization;
using System.Linq;
using System.Threading;

namespace Orders
{
    class MainProgram
    {
        static void Main()
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;

            var dataMapper = new DataMapper();
            var categories = dataMapper.GetAllCategories();
            var products = dataMapper.GetAllProducts();
            var orders = dataMapper.GetAllOrders();


            // Names of the 5 most expensive products
            var mostExpensiveProducts = products
                .OrderByDescending(product => product.UnitPrice)
                .Take(5)
                .Select(product => product.Name);

            Console.WriteLine(string.Join(Environment.NewLine, mostExpensiveProducts));
            Console.WriteLine(new string('-', 10));


            // Number of products in each category
            var productsInCategory = products
                .GroupBy(product => product.CategoryId)
                .Select(group => 
                    new { CategoryName = categories.First(category => category.Id == group.Key).Name,
                    ProductCount = group.Count() })
                .ToList();

            foreach (var item in productsInCategory)
            {
                Console.WriteLine("{0}: {1}", item.CategoryName, item.ProductCount);
            }
            Console.WriteLine(new string('-', 10));


            // The 5 top products (by order quantity)
            var topFiveProducts = orders
                .GroupBy(order => order.ProductId)
                .Select(group => 
                    new { ProductName = products.First(product => product.Id == group.Key).Name,
                    Quantities = group.Sum(order => order.Quantity) })
                .OrderByDescending(q => q.Quantities)
                .Take(5);

            foreach (var item in topFiveProducts)
            {
                Console.WriteLine("{0}: {1}", item.ProductName, item.Quantities);
            }
            Console.WriteLine(new string('-', 10));



            // Finds the most profitable category
            var mostProfitableCategory = orders
                .GroupBy(order => order.ProductId)
                .Select(group => 
                    new { Category = products.First(product => product.Id == group.Key).CategoryId,
                        Price = products.First(product => product.Id == group.Key).UnitPrice,
                        Quantity = group.Sum(order => order.Quantity) })
                .GroupBy(product => product.Category)
                .Select(group => 
                    new { CategoryName = categories.First(category => category.Id == group.Key).Name,
                        TotalQuantity = group.Sum(g => g.Quantity * g.Price) })
                .OrderByDescending(group => group.TotalQuantity)
                .First();

            Console.WriteLine("{0}: {1}", mostProfitableCategory.CategoryName, mostProfitableCategory.TotalQuantity);
        }
    }
}
