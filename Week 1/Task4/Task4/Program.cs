using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine()); //переводим массив из string'a массив из integer'a
            for(int i = 1; i <= n; i++) // оба цикла нужны для того чтобы сделать тот самый треугольник из квадратных скобок и со звездочкой внутри
            {
                for(int j = 1; j <= i; j++)
                {
                    Console.Write("[*]"); //с помощью этого выводится элементы по столбичкам, а не по строчно
                }
                Console.WriteLine(); //выводим все на экран

            }
            Console.ReadKey();
        }
    }
}
