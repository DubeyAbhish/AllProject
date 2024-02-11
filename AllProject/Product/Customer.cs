using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AllProject.Product
{
    class Customer
    {
        static void Main()
        {
            ProductName A = new ProductName()
            {
                ProID = 1,
                Name = "Colgate",
                Number = "7934834344",
                CustomerName = "Adani",
                Loacation = "Kurla",
                CustomerID = 3

            };

            Console.WriteLine($"ID :{A.ProID }");
            Console.WriteLine($"Name :{A.Name}");
            Console.WriteLine($"Number :{ A.Number}");
            Console.WriteLine($"CustomerName:{A.CustomerName}");
            Console.WriteLine($"Customer Location:{A.Loacation}");
            Console.WriteLine($"CustomerID :{A.CustomerID}");
            Console.ReadKey();

            ProductName A = new ProductName()
            {
                ProID = 2,
                Name = "Oil",
                Number = "7054806969",
                CustomerName = "Ambani",
                Loacation = "Mahalaxmi",
                CustomerID = 2

            };

            Console.WriteLine($"ID :{A.ProID }");
            Console.WriteLine($"Name :{A.Name}");
            Console.WriteLine($"Number :{ A.Number}");
            Console.WriteLine($"CustomerName:{A.CustomerName}");
            Console.WriteLine($"Customer Location:{A.Loacation}");
            Console.WriteLine($"CustomerID :{A.CustomerID}");
            Console.ReadKey();


        }
    }
}
