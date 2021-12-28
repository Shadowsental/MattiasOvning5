using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MattiasOvning5
{
    public class Airplane : Vehicle
    {
        public Airplane(int wheels, string color, string regnum) : base(wheels, color, regnum)
        {
            base.TotalWheels = 3;

            base.Color = color;

            base.RegNum = regnum;
        }

        private int seats;

        public int Seats { get { return seats; } set { seats = value; } }
    }
}
