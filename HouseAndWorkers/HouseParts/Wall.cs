using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HouseAndWorkers.Interfaces;
namespace HouseAndWorkers.HouseParts
{
    class Wall : HousePart
    {
        public override void PrintPart(int left,int right)
        {
            for (int i = 0; i < 7; i++)
            {
                Console.SetCursorPosition(left, right);
                Console.Write("|");
                right++;
            }
        }
        public override string ToString()
        {
            return "Wall";
        }
    }
}
