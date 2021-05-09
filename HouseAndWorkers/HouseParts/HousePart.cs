using HouseAndWorkers.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HouseAndWorkers.HouseParts
{
    abstract class HousePart: IPart
    {
        public abstract void PrintPart(int left, int right);
        

        public abstract override string ToString();
    }
}
