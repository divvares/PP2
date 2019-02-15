using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine()); //задаем длинну массива
            int[] array = Array.ConvertAll<string, int>(Console.ReadLine().Split(), int.Parse); //переводим массив из string'a в массив из integer'
            int[] lastarray = new int[n * 2]; // умножаем размер массива на 2, так как будут дуплироваться элементы массива и для каждого дуплированного элемента нужно свое место в массиве
            int cnt = -1; // задаем значение -1 для того чтобы облегчить нумерацию элементов в массиве, ведь они увеличиваются изначально на один и только после этого получают значение
            for(int i = 0; i < array.Length; i++) //в данном моменте пробегается по основному массиву и в тоже время заполняет второй массив элементами
            {
                lastarray[++cnt] = array[i]; 
                lastarray[++cnt] = array[i];
            }
            foreach(int finallyArr in lastarray) //показываем все элементы которые мы получили
            {
                    Console.Write(finallyArr + " ");
            }
            Console.ReadKey();
        }
    }
}
