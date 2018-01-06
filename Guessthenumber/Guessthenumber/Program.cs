using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guessthenumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            var r = new Random();
            int rand = r.Next(1, 101);
            int tries = 1;

            string guessString = Console.ReadLine();
            int guess = int.Parse(guessString);

            while (rand != guess)
            {


                if (rand > guess)
                {
                    Console.WriteLine("Нагоре");
                    tries++;
                }
                else
                {
                    Console.WriteLine("Надолу");
                    tries++;
                }

                guess = int.Parse(Console.ReadLine());
            }

            Console.WriteLine(" Вие познахте от {0}-ия опит!", tries);



            Console.WriteLine("Числото беше {0}", rand);
            Console.ReadLine();
        }
    }
}
