using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraySwap
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            int[] Myarray = new int[10];
            for (int i = 0; i < Myarray.Length; i++)
            {
                Console.Write("Въведете елемент {0} = ", i);
                Myarray[i] = int.Parse(Console.ReadLine());
            }
            for (int i = 0; i < Myarray.Length / 2; i++)
            {
                int tmp = Myarray[i];
                Myarray[i] = Myarray[Myarray.Length - i - 1];
                Myarray[Myarray.Length - i - 1] = tmp;
            }

            for (int j = 0; j < 10; j++)
            {
                Console.WriteLine("Елемент {0} = {1}", j, Myarray[j]);
            }
            Console.ReadLine();
        }
    }
}
