using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MattiasOvning5
{
    public class Boat : Vehicle
    {
        public Boat(int wheels, string color, string regnum) : base(wheels, color, regnum)
        {
            base.TotalWheels = 0;

            base.Color = color;

            base.RegNum = regnum;
        }
    }
}
