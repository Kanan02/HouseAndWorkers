using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HouseAndWorkers.HouseParts;
using HouseAndWorkers.Interfaces;
namespace HouseAndWorkers.TeamFolder
{
    class Worker : IWorker
    {
       
        public void Work(HousePart housePart,int left,int top)
        {
            housePart.PrintPart(left,top);
        }
    }
}
