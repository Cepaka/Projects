using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Students
{
    class Program
    {
        static void Main(string[] args)
        {
            Student[] students = new Student[100];
            int count = 0;
            int choice;

            do
            {
                Console.WriteLine("\n1. Добавяне на студент");
                Console.WriteLine("2. Извеждане на среден успех");
                Console.WriteLine("3. Запис във файл");
                Console.WriteLine("4. Зареждане от файл");
                Console.WriteLine("5. Най-добър студент");
                Console.WriteLine("0. Изход");
                choice = ReadInt("Въведете команда: ");
                Console.WriteLine();

                switch (choice)
                {
                    case 1:
                        Student st = new Student();
                        st.Name = ReadString("Име: ");
                        st.FacultyNumber = ReadString("Фак.№: ");
                        int marksCount = ReadInt("Брой оценки: ");
                        st.Marks = new decimal[marksCount];
                        for (int i = 0; i < marksCount; ++i)
                            st.Marks[i] = ReadDecimal("Оценка " + (i + 1) + ": ");
                        students[count++] = st;
                        break;
                    case 2:
                        for (int i = 0; i < count; ++i)
                        {
                            decimal avg = 0;
                            foreach (var mark in students[i].Marks)
                                avg += mark;
                            if (students[i].Marks.Length > 0)
                                avg /= students[i].Marks.Length;
                            Console.WriteLine("Фак.№: {0}\tИме: {1}\tСреден успех: {2}", students[i].FacultyNumber, students[i].Name, avg);
                        }
                        break;
                    case 3:
                        string[] lines = new string[count * 3];

                        for (int i = 0; i < count; ++i)
                        {
                            lines[3 * i + 0] = students[i].Name;
                            lines[3 * i + 1] = students[i].FacultyNumber;
                            lines[3 * i + 2] = "";
                            foreach (var mark in students[i].Marks)
                                lines[3 * i + 2] += mark + " ";
                        }
                        File.WriteAllLines("data.txt", lines);
                        Console.WriteLine("Файлът е записан успешно. ");
                        break;
                    case 4:
                        if (!File.Exists("data.txt"))
                        {
                            Console.WriteLine("Файлът не съществува. ");
                            break;
                        }
                        count = 0;
                        string[] fileLines = File.ReadAllLines("data.txt");
                        for (int i = 0; i < fileLines.Length; i += 3)
                        {
                            Student s = new Student();
                            s.Name = fileLines[i];
                            s.FacultyNumber = fileLines[i + 1];
                            string[] markTexts = fileLines[i + 2].Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                            s.Marks = new decimal[markTexts.Length];
                            for (int k = 0; k < s.Marks.Length; ++k)
                            {
                                s.Marks[k] = decimal.Parse(markTexts[k]);
                            }
                            students[count++] = s;
                        }
                        break;

                }
            }
            while (choice != 0);
        }
        static int ReadInt(string prompt)
        {
            int result;
            bool valid;
            do
            {
                Console.Write(prompt);
                valid = int.TryParse(Console.ReadLine(), out result);
                if (!valid)
                    Console.WriteLine("Моля въведете цяло число ");
            }
            while (!valid);
            return result;
        }
        static string ReadString(string prompt)
        {
            Console.Write(prompt);
            return Console.ReadLine();
        }
        static decimal ReadDecimal(string prompt)
        {
            decimal result;
            bool valid;
            do
            {
                Console.Write(prompt);
                valid = decimal.TryParse(Console.ReadLine(), out result);
                if (!valid)
                    Console.WriteLine("Моля въведете число ");
            }
            while (!valid);
            return result;
        }
    }
}
