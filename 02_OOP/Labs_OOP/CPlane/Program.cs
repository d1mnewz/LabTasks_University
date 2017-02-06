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
    class Program
    {
        static void Main(string[] args)
        {
            CPlane cp = new CPlane("Boing-737", 100.00, 300, 0.3);
            cp.GetState();
            cp.AddPassengers(20);
            cp.FlyTo(1000);
            cp.AddFuel(100);
            cp.GetState();
            cp.FlyTo(19);
            cp.GetState();
            cp.OutPassenger(30);
            cp.OutPassenger(10);
            cp.GetState();


            //

            CPlane cp1 = new CPlane("boing 323", 320, 100, 1);
            cp1.GetState();
            CPlane cp2 = new CPlane("Boing 324", 333, 300, 3);
            cp2.GetState();
            if(cp1 < cp2)
                Console.WriteLine($"{cp1.RaceName} < {cp2.RaceName}");
            else Console.WriteLine($"{cp1.RaceName} >= {cp2.RaceName}");
            CPlane res = cp1 + cp2;
            res.GetState();

            res -= cp;
            res.GetState();

        }
    }
}
