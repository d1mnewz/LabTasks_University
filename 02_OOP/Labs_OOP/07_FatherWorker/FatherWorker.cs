using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_FatherWorker
{
    public class FatherWorker : IWorker, IFather
    {
        private int _age;
        private string _name;
        private string _position;
        private int _salary;
        private int _money;
        private DateTime _birthDate;

        public FatherWorker( string name, string pos, int salary, int money, DateTime bd)
        {
            
            this._name = name;
            this._position = pos;
            this._salary = salary;
            this._money = money;
            this._birthDate = bd;
            DefineAge();
        }
        public void DefineAge()
        {
            this._age = DateTime.Now.Year - this._birthDate.Year;
        }

        public DateTime GetBirthDate()
        {
            return _birthDate;
            
        }

        public string GetName()
        {
            return _name;
        }

        public void ComeBackHome()
        {
            
            Console.WriteLine("Honey, i`m home!");
        }

        public void DrinkBeer()
        {
            Console.WriteLine("Well, apart from drinking there is nothing to do here.");
        }

        public void Eat()
        {
            Console.WriteLine("Yummy!");
        }




        public void GetPayed(int prem)
        {
            Console.WriteLine("I`ve been working hard and that a valuable reward. +{0}$", prem);
            this._money += prem;
        }

        public string GetPosition()
        {
            return this._position;
        }

        public int GetSalary()
        {
            return this._salary;   
        }


        public void HaveAWalkWithSon()
        {
            Console.WriteLine("Son, the time has come: you wasn`t found in cabbage.");
        }

        public void Promote(string position)
        {
            this._position = position;
        }
        
        public void QuitJob()
        {
            Console.WriteLine("Well, job sucks.");
            this._position = "Unemployed";
            this._salary = 0;
        }

        public void Repair(string toRepair)
        {
            Console.WriteLine("Work comes in hands of the real man!");

        }

        public void Sleep()
        {
            Console.WriteLine("Ah, finally got to sleep. It was a good day.");
        }

        public void Work()
        {
            Console.WriteLine("Sometimes it`s worth to work a bit. But only a bit.");
        }

        public void GiveMoneyToWife()
        {
            Console.WriteLine("Why don`t you get a job, honey?");
            this._money = 0;
        }

        public int GetMoney()
        {
            return this._money;
        }
    }
}
