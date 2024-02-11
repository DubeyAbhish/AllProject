using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_07Jan2024.Methods
{
    class Demo
    {
        static void Main(string[] args)
        {
            //Creating an object/instance of class
            MathEx utility = new MathEx();


            int sum = utility.Add(10, 20);
            Console.WriteLine(sum);
            Console.WriteLine(utility.IsEven(4));

            Console.WriteLine("6 is Prime : " + MathEx.isPrime(6));

            Console.ReadKey();
        }
    }
}
