using _06_Inheritance;
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

    public enum Seasons
    {
        Winter = 0,
        Spring,
        Summer,
        Autumn
    }
    public class Tree : Plant
    {
        public int Age { get; set; }
        public  bool IsFruit { get; }

        public Seasons Bloom;
        public bool isBlooming;
        public Tree(string name, ConsoleColor color, int height, int width, int age, bool fruit, Seasons season) : base(name, color, height, width)
        {
            this.Age = age;
            this.IsFruit = fruit;
            this.Bloom = season;
            this.DefineIfBlooming();
            //this.isBlooming
            
           
        }
        public void DefineIfBlooming()
        {
            DateTime dt = DateTime.Now;
            if ((dt.Month >= 0 && dt.Month <= 2 || dt.Month == 12))
            {
                if (this.Bloom == Seasons.Winter)
                {
                    this.isBlooming = true;
                }
            }
            else if (dt.Month >= 3 && dt.Month <= 5)
            {
                if (this.Bloom == Seasons.Spring)
                    this.isBlooming = true;
            }
            else if (dt.Month >= 6 && dt.Month <= 8)
            {
                if (this.Bloom == Seasons.Summer)
                    this.isBlooming = true;
            }
            else if (dt.Month >= 9 && dt.Month <= 11)
            {
                if (this.Bloom == Seasons.Autumn)
                    this.isBlooming = true;
            }


        }
        public void Print()
        {
            Console.WriteLine("It`s a tree!");
            base.Print();
            Console.WriteLine($"Age - {this.Age}");
            if(IsFruit)
                Console.WriteLine("It`s a fruit tree!");
            else Console.WriteLine("It`s not a fruit tree.");
            if (isBlooming)
            {
                Console.WriteLine("It`s blooming right now!");
            }
            else
                Console.WriteLine("It blooms when {0} comes", this.Bloom);

        }

        public override void CalculateVolume()
        {
            this.Volume = this.Height * this.Width;
        }
    }
}
