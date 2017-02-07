using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_FatherWorker
{
    //ЗАВДАННЯ
    //Спроектувати і реалізувати ієрархію класів, що описують предметну
    //область згідно варіанту, яка реалізується класом 1. Клас 1 в свою чергу
    //утворюється шляхом множинного спадкування класів 2 і 3 кожен з яких в свою
    //чергу успадковує клас 4. Додаткові вимоги:
    //1. Базовий клас містить мінімум один віртуальний метод, один
    //невіртуальний метод і одну динамічно створювану властивість.
    //123
    //2. Забезпечити механізми коректної роботи конструкторів і деструкторів.
    //3. Перевантажити оператор присвоєня з метою його коректної роботи.
    //4. Кожен з класів має містити мінімум одину властивість і 4 методи.
    //5. Написати main() функцію де створити об’єкт класу 1 і
    //продемонструвати різницю між статичним і динамічним
    //поліморфізмом.

    //http://www.c-sharpcorner.com/uploadfile/37db1d/understanding-static-dynamic-polymorphism/
    class Program
    {

        static void Main(string[] args)
        {
            FatherWorker fw = new FatherWorker("Dad", "Engineer", 1000, 500, new DateTime(1980, 10, 23));
            string choice = "";
            while (true)
            {
                Console.Clear();
                Console.WriteLine(nameof(fw.ComeBackHome));
                Console.WriteLine(nameof(fw.DrinkBeer));
                Console.WriteLine(nameof(fw.Eat));
                Console.WriteLine(nameof(fw.GetName));
                Console.WriteLine(nameof(fw.GetBirthDate));
                Console.WriteLine(nameof(fw.GetPayed));
                Console.WriteLine(nameof(fw.GetPosition));
                Console.WriteLine(nameof(fw.GetSalary));
                Console.WriteLine(nameof(fw.GiveMoneyToWife));
                Console.WriteLine(nameof(fw.Promote));
                Console.WriteLine(nameof(fw.HaveAWalkWithSon));
                Console.WriteLine(nameof(fw.QuitJob));
                Console.WriteLine(nameof(fw.Repair));
                Console.WriteLine(nameof(fw.Sleep));
                Console.WriteLine(nameof(fw.Work));
                Console.WriteLine(nameof(fw.GetMoney));

                choice = Console.ReadLine();
                switch (choice)
                {
                    case "ComeBackHome":
                        fw.ComeBackHome();
                        break;
                    case "DrinkBeer":
                        fw.DrinkBeer();
                        break;
                    case "Eat":
                        fw.Eat();
                        break;
                    case "GetBirthDate":
                        Console.WriteLine(fw.GetBirthDate());
                        break;
                    case "GetName":
                        Console.WriteLine(fw.GetName());
                        break;
                    case "GetPayed":
                        fw.GetPayed(new Random().Next(300));
                        break;
                    case "GetPosition":
                        Console.WriteLine(fw.GetPosition());
                        break;
                    case "GetSalary":
                        Console.WriteLine( fw.GetSalary());
                        break;
                    case "GiveMoneyToWife":
                        fw.GiveMoneyToWife();
                        break;
                    case "Promote":
                        fw.Promote("TeamLead");
                        break;
                    case "HaveAWalkWithSon":
                        fw.HaveAWalkWithSon();
                        break;
                    case "QuitJob":
                        fw.QuitJob();
                        break;
                    case "GetMoney":
                        Console.WriteLine(fw.GetMoney());
                        break;
                    case "Repair":
                        fw.Repair("PC");
                        break;
                    case "Sleep":
                        fw.Sleep();
                        break;
                    case "Work":
                        fw.Work();
                        break;
                    default:
                        Console.WriteLine("\n\nInvalid command\n\n");
                        break;
                }
                Console.ReadLine();
            }
        }
    }
}
