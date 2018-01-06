using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matrix
{
    class Program
    {
        static void Main(string[] args)
        {
            int choice;
            decimal[,] matrix = null;
            do
            {
                Console.OutputEncoding = Encoding.UTF8;
                Console.WriteLine("\n1. Въвеждане на матрица");
                Console.WriteLine("2. Сума по главния диагонал");
                Console.WriteLine("3. Най-малък елем. от вторичния диагонал");
                Console.WriteLine("4. Проверка за диагоналната матрица");
                choice = ReadInt("Вашият избор: ");

                switch (choice)
                {
                    case 1:
                        matrix = ReadMatrix();
                        break;
                    case 2:
                        SumMainDiag(matrix);
                        break;
                    case 3:
                        MinAntiDiag(matrix);
                        break;
                    case 4:
                        CheckDiagonal(matrix);
                        break;
                }
            }
            while (choice != 0);
        }
        static void CheckDiagonal(decimal[,] matrix) // Диагонална матрица
        {
            if (matrix == null)
            {
                Console.WriteLine("Моля първо въведете матрица.");
                return;
            }
            int n = matrix.GetLength(0);
            for (int i = 0; i < n; ++i)
            {
                for (int k = 0; k < n; ++k)
                    if (i != k && matrix[i, k] != 0)
                    {
                        Console.WriteLine("Матрицата не е диагонална");
                        return;
                    }
                Console.WriteLine("Матрицата е диагонална");
                break;
            }
        }
        static decimal[,] ReadMatrix()    //Въвеждане на матрица
        {
            int n = ReadInt("n=");
            var m = new decimal[n, n];

            for (int r = 0; r < n; ++r)
            {
                string row = Console.ReadLine();
                string[] cols = row.Split();
                for (int c = 0; c < n; ++c)
                {
                    m[r, c] = decimal.Parse(cols[c]);
                }
            }
            return m;
        }
        static void SumMainDiag(decimal[,] matrix)    // Главен диагонал
        {
            if (matrix == null)
            {
                Console.WriteLine("Моля първо въведете матрица.");
                return;
            }
            int n = matrix.GetLength(0);
            decimal sum = 0;
            for (int i = 0; i < n; ++i)
                sum += matrix[i, i];

            Console.WriteLine("Сумата по главния диагонал: {0}", sum);
        }
        static void MinAntiDiag(decimal[,] matrix)     // Най-малък елемент
        {
            if (matrix == null)
            {
                Console.WriteLine("Моля първо въведете матрица.");
                return;
            }
            int n = matrix.GetLength(0);
            decimal minVal = matrix[0, n - 1];
            for (int i = 0; i < n; ++i)
            {
                if (matrix[i, n - i - 1] < minVal)
                {
                    minVal = matrix[i, n - i - 1];
                }


            }
            Console.WriteLine("Най-малък ел. на вторияни диагонал: {0}", minVal);
        }

        static int ReadInt(string prompt)
        {
            bool isValid;
            int result;
            do
            {
                Console.WriteLine(prompt);
                isValid = int.TryParse(Console.ReadLine(), out result);
                if (!isValid)
                    Console.WriteLine("Моля въведете цяло число.");
            }
            while (!isValid);
            return result;
        }
    }
}
