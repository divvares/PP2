using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Program
    {
        public static bool isPrime(int a)//функция для проверки на простоту числа
        {
            if (a == 1 || a == 0) return false;
            for(int i = 2; i <= Math.Sqrt(a); i++)
            {
                if (a % i == 0) return false;
            }
            return true;
        }
        static void Main(string[] args)
        {
            StreamReader read = new StreamReader("input.txt");// открываем поток который считывает input
            string s = read.ReadToEnd();
            read.Close();//закрываем поток для того чтобы файлы не повредились
            string[] s2 = s.Split();// создаем массив который хранит в себе все элементы отделенные между собой пробелом
            int[] array = new int[100000];// задаем массиву размер 
            for (int i = 0; i < s2.Length; i++)//пробегаемся по массиву и присваиваем значение из одного массива в другой массив, а также меняем его тип с string'a на integer
            {
                array[i] = int.Parse(s2[i]);
            }
            StreamWriter write = new StreamWriter("output.txt");// открываем поток для нашего output'a 
            for (int i = 0; i < s.Length; i++) //пробегаемся по массиву и ставим условия на проверку простоту числа и если таковы имеются то выводим их в output
            {
                if (isPrime(array[i]))
                    write.Write(array[i] + " ");
            }
            write.Close();//закрываем поток для того чтобы файлы не повредились
            Console.ReadKey();
        }
    }
}
