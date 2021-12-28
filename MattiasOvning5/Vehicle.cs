using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MattiasOvning5
{
    public class Vehicle
    {
        private int totalWheels;
        private string color;
        private string regNum;

        public int TotalWheels { get { return totalWheels; } set { totalWheels = value; } }

        public string Color { get { return color; } set { color = value; } }

        public virtual string RegNum { get { return regNum; } set { regNum = value; } }



        public Vehicle(int wheels, string color, string regnum)
        {
            TotalWheels = wheels;
            Color = color;
            RegNum = regnum;
        }

        public override string ToString() => $"Registration number: {RegNum}, color: {Color}, number of wheels: {TotalWheels}";
    }
}
