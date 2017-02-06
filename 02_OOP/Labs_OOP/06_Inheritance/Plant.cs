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
    public abstract class Plant
    {
        public ConsoleColor Color { get; set; }
        public string Name { get; set; }
        public int Height { get; set; }
        public int Width { get; set; }
        public int Volume { get; set; }

       
        public  Plant(string name, ConsoleColor color, int height, int width)
        {
            this.Name = name;
            this.Color = color;
            this.Width = width;
            this.Height = height;
            //this.Width = width * height;
            this.CalculateVolume();

        }
        public abstract void CalculateVolume();
        public void Print()
        {
            Console.ForegroundColor = this.Color;
            Console.WriteLine($"\t{this.Name}\t");
            Console.ResetColor();
            Console.WriteLine($"Width - {this.Width}");
            Console.WriteLine($"Height - {this.Height}");
            Console.WriteLine($"Volume - {this.Volume}");
        }
    }
}
