using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_FatherWorker
{
    public interface IFather : iHuman
    {
        void HaveAWalkWithSon();
        void ComeBackHome();
        void DrinkBeer();
        void Repair(string toRepair);

        void GiveMoneyToWife();
    }
}
