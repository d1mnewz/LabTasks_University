using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_FatherWorker
{
    public interface IWorker : iHuman
    {
        void Work();
        void GetPayed(int prem);
        void QuitJob();
        int GetSalary();
        string GetPosition();
        void Promote(string position);
    }
}
