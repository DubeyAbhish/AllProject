using System;
namespace AllProject.Calculator
{
    class Class1
    {
        public static void Main()
        {
            int Res;
            Console.WriteLine("Enter your First Number :");
            int Num = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter your Secound Number :");
            int Num2 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Ope(+,-,*,/,%) :");
            string Ope = Console.ReadLine();

            switch(Ope)
            {
                case "+":
                Res = Num + Num2;
                    Console.WriteLine("Add :" + Res);
                    break;
                case "-":
                    Res = Num - Num2;
                    Console.WriteLine("Div :" + Res);
                    break;
                case "*":
                    Res = Num * Num2;
                    Console.WriteLine("Mul :" + Res);
                    break;
                case "/":
                    Res = Num / Num2;
                    Console.WriteLine("Div:" + Res);
                    break;

            } Console.ReadKey();
        }
    }
}
