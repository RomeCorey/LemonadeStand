using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Ice
    {
        private double IceCost;

        public Ice()
        {
            IceCost = .09;
        }
        public double GetIceCost()
        {
            return IceCost;
        }
        
    }
}
