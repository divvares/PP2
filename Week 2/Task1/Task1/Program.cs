using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Program
    {
        public static bool IsPalin(string str, int i) //рекурсивная функция для проверки палиндром или нет
        {
            if (str[i] != str[str.Length - 1 - i])
                return false;
            if (i == str.Length / 2)
                return true;
            return IsPalin(str, i + 1);
        }
        static void Main(string[] args)
        {

            StreamReader chitalka = new StreamReader("input.txt");
            string s = chitalka.ReadToEnd(); // сделано для того чтобы прочитать input.txt файл с нужным нам input

            if (IsPalin(s, 0)) // обращаемся к функции для проверки на палиндром
                Console.WriteLine("Yes");
            else
                Console.WriteLine("No");
            chitalka.Close();
            Console.ReadKey();
        }
    }
}
