using HouseAndWorkers.HouseParts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HouseAndWorkers.Interfaces
{
    interface IWorker
    {
        void Work(HousePart housePart,int left,int top);
    }
}
