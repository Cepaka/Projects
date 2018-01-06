using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hello_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.Write("Въведете вашето име: ");
            string input = Console.ReadLine();
            Console.WriteLine("Здравейте, {0}!", input);
            Console.ReadLine();
        }
    }
}
