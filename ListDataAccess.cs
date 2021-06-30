using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern2
{
    public class ListDataAccess : IDataAccess
    {
        public static List<Product> Products = new List<Product>()
        {
            new Product (){Name = "Laptop", Price = 799},
            new Product (){Name = "Coffee Maker", Price = 50},
            new Product (){Name = "Blender", Price = 40},
            new Product (){Name = "Headphones", Price = 399},
        };
        public List<Product> LoadData()
        {
           Console.WriteLine($"I am reading data from List Data Access.");
            return Products;
        }

        public void SaveData()
        {
            Console.WriteLine("I am saving data from a List Data Access.");
        }
    }
}
