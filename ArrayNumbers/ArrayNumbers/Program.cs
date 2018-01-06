using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Въведете цяло число м/у 1 и 100");
            int a = int.Parse(Console.ReadLine());
            int d = 0;
            var r = new Random();
            int[] myArray = new int[100];
            for (int i = 0; i < myArray.Length; i++)
            {
                myArray[i] = r.Next(1, 101);
                if (a == myArray[i])
                {
                    d++;
                    Console.WriteLine("Намерено на позиция {0}", i + 1);
                }
            }
            Console.WriteLine("Вашето число се среща {0} път/и", d);
            Console.ReadLine();
        }
    }
}
