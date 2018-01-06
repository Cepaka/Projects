using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace n_recursive
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.Write("Въведете цяло число: ");
            int input = int.Parse(Console.ReadLine());
            long result = Factorial(input);
            Console.WriteLine("Резултата е: {0}", result);
            Console.ReadLine();
        }
        static long Factorial(int input)
        {
            if (input == 0)
                return 1;

            return input * Factorial(input - 1);
        }
    }
}