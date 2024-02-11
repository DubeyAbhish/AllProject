using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AllProject.tam
{
    class ttt
    {
       protected int a = 10, b = 30, c;
        public void Add()
        {
            c = a + b;
            Console.WriteLine("Addition :" + c);
        }
        public void Sub()
        {
            c = a - b;
            Console.WriteLine("Substration :" + c);
        }
    }


    class B:ttt
    {

        public void Mul()
        {
            c = a * b;
            Console.WriteLine("Mul :" + c);
        }
        public void Div()
        {
            c = a / b;
            Console.WriteLine("Div :" + c);
        }
        static void Main(string[] args)
        {
                  
            B g = new B();
            g.Add(); g.Sub(); g.Mul(); g.Div();

        }
    }
}
 