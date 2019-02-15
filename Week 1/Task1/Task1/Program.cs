using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Program
    {
        static bool isPrime(int a)
        {
            if (a == 1) return false;
            for(int i = 0; i < Math.Sqrt(a); i++)
            {
                if (a % i == 0) return false;
            }
            return true;
        }
        static void Main(string[] args)
        {
            //в данном момент считываем все нужные данные, а также переводим в integer, ведь в С# по дефолту все в string'e
            int n = int.Parse(Console.ReadLine());
            int[] array = new int[n];
            string str1 = Console.ReadLine();
            string[] str2 = str1.Split();
            int[] arr2 = new int[n];
            int cnt = 0;

            // сохраняем все числа массива из string'a в массив из integer
            for (int i = 0; i < n; i++)
            {
                array[i] = int.Parse(str2[i]);
            }
            //тут проходит проверка на простоту числа и если таковые имеются то закидываем в новый массив
            for (int i = 0; i < n; i++)
            {
                if (isPrime(array[i]))
                {
                    arr2[cnt] = array[i];
                    cnt++;
                }
            }
            //выводим на экран количество простых чисел и простые числа в данном массиве
            Console.WriteLine(cnt);
            for (int i = 0; i < cnt; i++)
            {
                Console.Write(arr2[i] + " ");
            }
            Console.ReadKey();
        }   
    }
}
