using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HouseAndWorkers.Interfaces;


namespace HouseAndWorkers.HouseParts
{
    class Roof : HousePart
    {
        public override void PrintPart(int left, int right)
        {
            
                Console.SetCursorPosition(left, right);

            Console.WriteLine("/--------------\\");
        }

        public override string ToString()
        {
            return "Roof";
        }
    }
    
}
