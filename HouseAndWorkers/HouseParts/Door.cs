using HouseAndWorkers.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HouseAndWorkers.HouseParts
{
    class Door : HousePart
    {
        public override void PrintPart(int left, int right)
        {
            Console.SetCursorPosition(left, right);

            Console.WriteLine("    __\n     |- |\n     |__|");
        }

        

        public override string ToString()
        {
            return "Door";
        }
    }
}
