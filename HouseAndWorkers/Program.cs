using HouseAndWorkers.HouseParts;
using HouseAndWorkers.TeamFolder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace HouseAndWorkers
{
    class Program
    {
        static void Main(string[] args)
        {
            House house = new House();
            TeamLeader teamLeader = new TeamLeader(house);
            Worker[] workers = new Worker[9]{
            new Worker(),
            new Worker(),
            new Worker(),
            new Worker(),
            new Worker(),
            new Worker(),
            new Worker(),
            new Worker(),
            new Worker()
            }
            ;

            Team team = new Team(teamLeader, workers);

            HousePart[] houseParts = new HousePart[9]
            {
                new Basement(),
                new Door(),
                new Wall(),
                new Wall(),
                new Window(),
                new Window(),
                new Window(),
                new Window(),
                new Roof()
            };
            Console.WriteLine("TeamLeader:");
            Console.WriteLine("We start to build the house!");
            Thread.Sleep(2000);
            
            Console.Clear();
            Console.SetCursorPosition(28, 0);
            Console.WriteLine("TeamLeader: ");

            int k = 1;

            int l = 0, t = 0;
            for (int i = 0; i < 9; i++)
            {
                
                if (i == 0) { l = 2; t = 10; }
                if (i == 1) { l = 2; t = 7; }
                if (i == 2) { l = 2; t = 3; }
                if (i == 3) { l = 16; t = 3; }
                if (i == 4) { l = 5; t = 4; }
                if (i == 5) { l = 10; t = 4; }
                if (i == 6) { l = 5; t = 6; }
                if (i == 7) { l = 10; t = 6; }
                if (i == 8) { l = 2; t = 2; }



                Console.SetCursorPosition(30, k);
                Console.WriteLine("Working...");
                k++;
                Thread.Sleep(2000);

                team.Workers[i].Work(houseParts[i], l, t);
                
                team.Leader.Work(houseParts[i], 30, k);
                Thread.Sleep(2000);
                k++;

                
            }


        }
    }
}
