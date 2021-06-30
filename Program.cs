using System;

namespace FactoryPattern2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter the database you would like to access?");
            Console.WriteLine("Type: sql");
            Console.WriteLine("Type: list");
            Console.WriteLine("Type: mongo");

            var input = Console.ReadLine();

            var db =DataAccessFactory.GetDataAccessType(input);

            var products = db.LoadData();
            db.SaveData();

            foreach (var product in products)
            {
                Console.WriteLine($"{product.Name}, {product.Price}");
            }
        }
    }
}
