using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Student //создаем класс
    {
        public string name;
        public string id;
        public int year;

        public Student(string name, string id) //в данном моменте создаем конструктор для имени и айди, this - будет хранить адресс
        {
            this.name = name;
            this.id = id;
        }
        public void Print()// данная функция нужна для вывода данных
        {
            Console.WriteLine("Student's name is " + name + ";");
            Console.WriteLine("Student's id is " + id + ";");
        }
        public void Inc()// данная функция нужна для увеличения года обучения студента, а также работает как функция выше для вывода данных
        {
            ++year;
            Console.WriteLine("Year of student's education is increased, now it is: " + year + ";");
        }
    }
    class Program
    {
        static void Function1() // в данном этапе считываем все данные, использую методы, а также увеличиваем год и выводим данные
        {
            string s = Console.ReadLine();
            string[] cheto = s.Split();
            string name = cheto[0];
            string id = cheto[1];
            int year = int.Parse(cheto[2]);
            Student st1 = new Student(name, id)
            {
                year = year
            };
            st1.Print();
            st1.Inc();
        }
        static void Function2() // ну здесь для ленивых, в этом моменте выводим данные, без ввода в плане имени и айди карты, тут лишь надо вывести год обучения
        {
            Student st2 = new Student("Yelaman", "18BD110462")
            {
                year = int.Parse(Console.ReadLine())
            };
            st2.Print();
            st2.Inc();
        }
        static void Main(string[] args)
        {
            Function1();
            Console.ReadKey();
        }
    }
}
