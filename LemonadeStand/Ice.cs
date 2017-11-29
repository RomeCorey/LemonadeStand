using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Ice
    {
        private double IceCost = .02;
        private string IceName;

        public double GetIceCost()
        {
            return IceCost;
        }

        public string GetIceName()
        {
            return IceName;
        }

    }
}
