using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FibonacciNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            if (n == 1)
                Console.WriteLine("Fib(1)=0");
            else if (n == 2)
                Console.WriteLine("Fib(2)=1");
            else
            {
                int n2 = 0, n1 = 1;
                int fib = n1 + n2;
                for (int i = 3; i <= n; ++i)
                {
                    fib = n1 + n2;
                    n2 = n1;
                    n1 = fib;
                }
                Console.WriteLine("Fib({0})= {1}", n, fib);
            }
            Console.ReadLine();
        }
    }
}
