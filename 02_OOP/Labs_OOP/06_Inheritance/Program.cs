using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_Inheritance
{
//    Створити абстрактний базовий клас і похійдний від нього клас, які
//    реалізують модель предметної області згідно варіанту.Кожен клас має мати
//    мінімум 3 власні елементи даних один з яких створюється динамічно, методи
//    встановлення і читання характеристик елементів-даних класу(Set і Get), та
//    мінімум 2 абстрактні методи обробки даних і мінімум 2 методи обробки даних
//    у похідному класі.Крім цього клас має містити перевантаження оператора
//    присвоєння, конструкторів по замовчуванню і копіювання та віртуальний
//    деструктор. Для розроблених класів реалізувати програму-драйвер, яка
//    демонструє роботу класів.
    class Program
    {
        static void Main(string[] args)
        {
            Tree tr = new Tree("Apple tree", ConsoleColor.Green, 10, 2, 100, true, Seasons.Winter);
            
            Console.WriteLine("Calling base Print"); Console.WriteLine();
            
            (tr as Plant).Print();
            Console.WriteLine();

            Console.WriteLine("Calling child Print"); Console.WriteLine();
            tr.Print();
            Console.WriteLine();

        }
    }
}
