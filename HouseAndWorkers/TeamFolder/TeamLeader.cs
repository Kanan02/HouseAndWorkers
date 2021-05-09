using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HouseAndWorkers.Interfaces;
using HouseAndWorkers.HouseParts;
namespace HouseAndWorkers.TeamFolder
{
    class TeamLeader : IWorker
    {
        public House H { get; set; }

        public TeamLeader(House house)
        {
            H = house;
        }
        
        public void Work(HousePart housePart, int left, int top)
        {
            Console.SetCursorPosition(left, top);
            Console.WriteLine($"{housePart} is ready.");
        }

        
    }
}
