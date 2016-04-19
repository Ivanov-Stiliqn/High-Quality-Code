using System.Collections.Generic;
using System.Linq;
using System.IO;
using Orders.Models;

namespace Orders
{
    /// <summary>
    /// Reads data from files and parses the input
    /// </summary>
    public class DataMapper
    {
        private const string CategoriesFileName = "../../Data/categories.txt";
        private const string ProductsFileName =  "../../Data/products.txt";
        private const string OrdersFileName = "../../Data/orders.txt";


        public IEnumerable<Category> GetAllCategories()
        {
            var fileLines = this.ReadFileLines(CategoriesFileName, true);

            var categories = fileLines
                .Select(line => line.Split(','))
                .Select(categoryArgs => new Category
                {
                    Id = int.Parse(categoryArgs[0]),
                    Name = categoryArgs[1],
                    Description = categoryArgs[2]
                });

            return categories;

        }

        public IEnumerable<Product> GetAllProducts()
        {
            var fileLines = this.ReadFileLines(ProductsFileName, true);

            var products = fileLines
                .Select(line => line.Split(','))
                .Select(productArgs => new Product
                {
                    Id = int.Parse(productArgs[0]),
                    Name = productArgs[1],
                    CategoryId = int.Parse(productArgs[2]),
                    UnitPrice = decimal.Parse(productArgs[3]),
                    UnitsInStock = int.Parse(productArgs[4])
                });

            return products;

        }

        public IEnumerable<Order> GetAllOrders()
        {
            var fileLines = this.ReadFileLines(OrdersFileName, true);

            var orders=fileLines
                .Select(line => line.Split(','))
                .Select(orderArgs => new Order
                {
                    Id = int.Parse(orderArgs[0]),
                    ProductId = int.Parse(orderArgs[1]),
                    Quantity = int.Parse(orderArgs[2]),
                    Discount = decimal.Parse(orderArgs[3]),
                });

            return orders;

        }

        private List<string> ReadFileLines(string fileName, bool hasHeader)
        {
            var lines = new List<string>();
            using (var reader = new StreamReader(fileName))
            {
                string currentLine;
                if (hasHeader)
                {
                    reader.ReadLine();
                }

                while ((currentLine = reader.ReadLine()) != null)
                {
                    lines.Add(currentLine);
                }
            }

            return lines;
        }
    }
}
