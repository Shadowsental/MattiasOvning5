using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MattiasOvning5
{
    public class Bike : Vehicle
    {
        public Bike(int wheels, string color, string regnum) : base(wheels, color, regnum)
        {
            base.TotalWheels = 2;

            base.Color = color;

            base.RegNum = regnum;
        }
    }
}
