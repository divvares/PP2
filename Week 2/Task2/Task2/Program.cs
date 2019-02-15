using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;

namespace Task2
{
    class Program
    {
        static bool isPrime(int a) //функция для проверки на простоту числа
        {
            if (a == 1) return false;
            for (int i = 2; i < Math.Sqrt(a); i++)
            {
                if (a % i == 0) return false;
            }
            return true;
        }
        static void Main(string[] args)
        {
            StreamReader chitalka = new StreamReader("input.txt"); // открываем поток который считывает input
            string str = chitalka.ReadToEnd(); 
            chitalka.Close(); //закрываем поток для того чтобы файлы не повредились
            string[] str2 = str.Split(); // создаем массив который хранит в себе все элементы отделенные между собой пробелом
            int[] arr = new int[100000]; // задаем массиву размер 
            for(int i = 0; i < str2.Length; i++) //пробегаемся по массиву и присваиваем значение из одного массива в другой массив, а также меняем его тип с string'a на integer
            {
                arr[i] = int.Parse(str2[i]);
            }
            StreamWriter pokazhi = new StreamWriter("output.txt"); // открываем поток для нашего output'a 
            for(int i = 0; i < str.Length; i++) //пробегаемся по массиву и ставим условия на проверку простоту числа и если таковы имеются то выводим их в output
            {
                if (isPrime(arr[i]))
                    pokazhi.Write(arr[i] + " ");
            }
            pokazhi.Close(); //закрываем поток для того чтобы файлы не повредились
            Console.ReadKey();
        }
    }
}
