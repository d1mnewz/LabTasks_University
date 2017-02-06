using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CPlane
{
//Клас CPlane(Літак). Клас зберігає назву рейсу,
//кількість палива, кількість пасажирів.Конструктор
//має ініціалізувати ці властивості. Методи дозволяють
//модифікувати і читати властивості, забезпечувати рух
//в різні сторони зменшуючи кількість палива, посадку і
//висадку пасажирів, враховуючи фізичні обмеження
//літака і різні позаштатні ситуації (падіння через
//нехватку палива), виводити на екран поточний стан
//об’єкта.
    public class CPlane
    {
        public readonly string RaceName;
        public readonly int PassengersLimit;
        public readonly double FuelLimit;
        public readonly double FuelKmRatio;

        public double CurrentFuel { get { return _currFuel; } }
        public int CurrPassengers { get { return _currPassengers; } }

        private double _currFuel = 0;

        private int _currPassengers = 0;

        public CPlane(string name, double fuel, int passengerLim, double fuelRatio)
        {
            this.FuelLimit = fuel;
            this.RaceName = name;
            this.PassengersLimit = passengerLim;
            this.FuelKmRatio = fuelRatio;
        }

        public void AddFuel(double fuel)
        {
            Console.WriteLine("Adding {0} fuel...", fuel);
            if (fuel > 0 && this.CurrentFuel + fuel <= this.FuelLimit)
                this._currFuel += fuel;
            else Console.WriteLine("Error! Fuel not added.\n");
        }
        private void UseFuel(double fuel)
        {
            Console.WriteLine("Using {0} fuel...", fuel);
            if(fuel > 0)
                this._currFuel -= fuel;
            else Console.WriteLine("Argument fuel < 0\n");
        }

        public void AddPassengers(int pass)
        {
            Console.WriteLine("Seating {0} passengers...", pass);
            if (pass > 0 && this._currPassengers + pass > this.PassengersLimit)
            {
                Console.WriteLine("Error!\nPassengers overflow. No one is seated additionally\n");

            }
            else
                this._currPassengers += pass;

        }
        public void OutPassenger(int pass)
        {
            Console.WriteLine("Seating out {0} passengers...", pass);
            if (this._currPassengers - pass < 0)
            {
                Console.WriteLine("Error!\nYou are trying to seat out more passengers than you have.\n");
            }
            else this._currPassengers -= pass;
        }
        public void FlyTo(int length)
        {
            Console.WriteLine("Preparing for {0}km flight...", length);
            if (this._currFuel - length * FuelKmRatio < 0)
            {
                Console.WriteLine($"Error!\nAvailable {this.CurrentFuel}; Requested {length * FuelKmRatio};\nNot enough fuel\n");
            }
            else
                this.UseFuel(length * FuelKmRatio);
        }
        public void GetState()
        {
            Console.WriteLine("===========================");
            Console.WriteLine($"\t{this.RaceName}\t");
            Console.WriteLine($"Passengers limit - {this.PassengersLimit}");
            Console.WriteLine($"Fuel limit - {this.FuelLimit}");
            Console.WriteLine($"Km/fuel ratio - {this.FuelKmRatio}");
            Console.WriteLine($"Current fuel - {this.CurrentFuel}");
            Console.WriteLine($"Current passengers - {this.CurrPassengers}");
            Console.WriteLine("===========================");
        }

    }
}
