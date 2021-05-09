using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HouseAndWorkers.TeamFolder
{
    class Team
    {
        public TeamLeader Leader { get; set; }
        public Worker[] Workers { get; set; }
        public Team(TeamLeader teamLeader, Worker[] workers)
        {
            Leader = teamLeader;
            Workers = workers;
        }
    }
}
