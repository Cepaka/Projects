using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwapNumbers
{
    class Program
    {
        static int ReadInt(string prompt)
        {
            int input;
            bool success;
            do
            {
                Console.Write(prompt);
                success = int.TryParse(Console.ReadLine(), out input);
                if (!success)
                {
                    Console.WriteLine("Въведи цяло число");
                }
            }
            while (!success);

            return input;
        }
        static void Swap(ref int a, ref int b)
        {
            a = a + b;
            b = a - b;
            a = a - b;
        }
        static void Main(string[] args)
        {
            int a = ReadInt("a= ");
            int b = ReadInt("b= ");
            Swap(ref a, ref b);
            Console.WriteLine("a= {0} \nb= {1}", a, b);
            Console.ReadLine();
        }
    }
}
