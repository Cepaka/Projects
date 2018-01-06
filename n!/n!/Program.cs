using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace n_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.Write("Моля въведете цяло число: ");
            int input = int.Parse(Console.ReadLine());
            int multiply = 1;
            while(input!=0)
            {
                multiply = multiply * input;
                input--;
            }
            Console.WriteLine("Резултата е: {0}", multiply);
            Console.ReadLine();
        }
    
    }
}
