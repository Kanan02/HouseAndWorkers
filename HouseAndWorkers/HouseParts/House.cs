using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HouseAndWorkers.HouseParts
{
    class House
    {
        public Basement Base { get; set; }
        public Door Door { get; set; }
        public Roof Roof { get; set; }
        public Wall[] Walls { get; set; }
        public Window[] Windows { get; set; }

        public House()
        {
            Walls = new Wall[4] {null,null,null,null };
            Windows = new Window[4] { null, null, null, null };
            Base = null;
            Base = null;
            Base = null;
            Base = null;
        }
        
    }
}
