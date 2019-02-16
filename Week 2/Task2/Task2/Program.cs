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
        public static bool isPrime(int a)
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
            StreamReader read = new StreamReader("input.txt");
            string s = read.ReadToEnd();
            read.Close();
            string[] s2 = s.Split();
            int[] array = new int[100000];
            for(int i = 0; i < s2.Length; i++)
            {
                array[i] = int.Parse(s2[i]);
            }
            StreamWriter write = new StreamWriter("output.txt");
            for(int i = 0; i < s.Length; i++)
            {
                if (isPrime(array[i]))
                    write.Write(array[i] + " ");
            }
            write.Close();
            Console.ReadKey();
        }
    }
}
